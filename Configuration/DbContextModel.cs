using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using UserRegistrationForm.Models;

namespace UserRegistrationForm.Configuration
{
    public class DbContextModel : DbContext
    {

        public DbContextModel()
        {

        }

        public DbContextModel(DbContextOptions<DbContextModel> options) : base(options)
        {
        }
        public DbSet<UserRegistration> Users { get; set; }
    }
}
