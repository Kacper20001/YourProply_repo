using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YourProply.Entities;

namespace YourProply.Presenters
{
    public class TenantMenuPresenter
    {
        private readonly TenantMenu _view;
        private readonly YourProplyDbContext _context;
        private readonly User _loggedInUser;

        public TenantMenuPresenter(TenantMenu view, YourProplyDbContext context, User loggedInUser)
        {
            _view = view;
            _context = context;
            _loggedInUser = loggedInUser;
        }
    }
}
