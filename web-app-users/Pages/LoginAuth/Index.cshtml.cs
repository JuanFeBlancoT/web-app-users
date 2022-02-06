#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using web_app_users.Data;
using web_app_users.Models;

namespace web_app_users.Pages.LoginAuth
{
    public class IndexModel : PageModel
    {
        private readonly web_app_users.Data.web_app_usersContext _context;

        public IndexModel(web_app_users.Data.web_app_usersContext context)
        {
            _context = context;
        }

        public IList<Class> Class { get;set; }

        public async Task OnGetAsync()
        {
            Class = await _context.Class.ToListAsync();
        }
    }
}
