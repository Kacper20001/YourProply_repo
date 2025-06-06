﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YourProply.Entities;

namespace YourProply.Entities
{
    public class Tenant : User
    {
        public Tenant() { }

        public Tenant(int userId, string userName, string firstName, string lastName, string email, string password, int idNumber, Address address, Property property, DateTime dateOfBirth, int landlordId)
            : base(userId, userName, firstName, lastName, email, password, idNumber, address, dateOfBirth)
        {
            Property = property;
            UserType = UserType.Tenant;
            LandlordId = landlordId;
        }

        public Property Property { get; set; }
        public int LandlordId { get; set; }
        public Landlord Landlord { get; set; }
    }
}
