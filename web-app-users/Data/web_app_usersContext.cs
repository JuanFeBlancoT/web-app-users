#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using web_app_users.Models;

namespace web_app_users.Data
{
    public class web_app_usersContext : DbContext
    {
        public web_app_usersContext (DbContextOptions<web_app_usersContext> options)
            : base(options)
        {
        }

        public DbSet<web_app_users.Models.Class> Class { get; set; }
    }
}
