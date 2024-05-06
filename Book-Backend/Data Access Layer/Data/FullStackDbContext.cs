using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Data_Access_Layer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.Data
{
    public class FullStackDbContext : DbContext
    {
        public FullStackDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<UserModel> User { get; set; }  

        public DbSet<BookModel> Book { get; set; }

    }
    
}
