﻿using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using YourProply.Entities;
using YourProply.Services;
using YourProply.Views;

namespace YourProply.Presenters
{
    public class UsersPresenter
    {
        private readonly IUsersView _view;
        private readonly YourProplyDbContext _context;
        private readonly User _loggedInUser;
        private List<Tenant> _allUsers;
        private readonly OpenAIService _openAIService;

        public UsersPresenter(IUsersView view, YourProplyDbContext context, User loggedInUser, OpenAIService openAIService)
        {
            _view = view;
            _openAIService = openAIService;
            _context = context;
            _loggedInUser = loggedInUser;
            _view.AddUserClick += OnAddUserClick;
            _view.EditUserClick += OnEditUserClick;
            _view.DeleteUserClick += OnDeleteUserClick;
            _view.FilterUsers += OnFilterUsers;
            _view.BackToMenuClick += OnBackToMenuClick;
            LoadUsers();
        }

        /// <summary>
        /// Ładuje listę wszystkich najemców należących do zalogowanego wynajmującego.
        /// </summary>
        private void LoadUsers()
        {
            _allUsers = _context.Users
                .OfType<Tenant>()
                .Include(u => u.Address)
                .Where(u => u.LandlordId == _loggedInUser.UserId)
                .ToList();

            _view.SetUsers(_allUsers);
        }

        /// <summary>
        /// Metoda obsługująca dodawanie nowego najemcy.
        /// </summary>
        private void OnAddUserClick(object sender, EventArgs e)
        {
            var addTenantView = new AddTenantView(_context.Properties.Where(p => p.UserId == _loggedInUser.UserId).ToList());
            var addTenantPresenter = new AddTenantPresenter(addTenantView, _context, _loggedInUser);
            addTenantView.FormClosed += (s, args) => LoadUsers();
            addTenantView.ShowDialog();
        }

        /// <summary>
        /// Metoda obsługująca edytowanie wybranego najemcy.
        /// </summary>
        private void OnEditUserClick(object sender, EventArgs e)
        {
            var selectedUser = _view.GetSelectedUser();
            if (selectedUser != null)
            {
                var editUserView = new AddTenantView(_context.Properties.Where(p => p.UserId == _loggedInUser.UserId).ToList(), selectedUser as Tenant);
                var editUserPresenter = new AddTenantPresenter(editUserView, _context, _loggedInUser);
                editUserView.FormClosed += (s, args) => LoadUsers();
                editUserView.ShowDialog();
            }
            else
            {
                _view.ShowMessage("Wybierz użytkownika, którego chcesz edytować.");
            }
        }

        /// <summary>
        /// Metoda obsługująca usuwanie wybranego najemcy.
        /// </summary>
        private void OnDeleteUserClick(object sender, EventArgs e)
        {
            var selectedUser = _view.GetSelectedUser();
            if (selectedUser != null)
            {
                _context.Users.Remove(selectedUser);
                _context.SaveChanges();
                LoadUsers();
            }
            else
            {
                _view.ShowMessage("Wybierz użytkownika, którego chcesz usunąć.");
            }
        }

        /// <summary>
        /// Metoda obsługująca filtrowanie listy najemców.
        /// </summary>
        private void OnFilterUsers(object sender, string filterText)
        {
            if (string.IsNullOrWhiteSpace(filterText))
            {
                _view.SetUsers(_allUsers);
            }
            else
            {
                var filteredUsers = _allUsers
                    .Where(u => !string.IsNullOrEmpty(u.UserName) && u.UserName.Contains(filterText, StringComparison.OrdinalIgnoreCase))
                    .ToList();

                _view.SetUsers(filteredUsers);
            }
        }

        /// <summary>
        /// Metoda obsługująca powrót do menu.
        /// </summary>
        private void OnBackToMenuClick(object sender, EventArgs e)
        {
            var landlordMenu = new LandlordMenu(_loggedInUser);
            var landlordMenuPresenter = new LandlordMenuPresenter(landlordMenu, _context, _loggedInUser, _openAIService);
            _view.Hide();
            landlordMenu.FormClosed += (s, args) => _view.Show();
            landlordMenu.Show();
        }
    }
}
