using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using CongDongCSKH.Models;
using System.Configuration;

namespace CongDongCSKH
{
    internal class EFDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Manage> Manages { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<MessageNT> MessagesNTs { get; set; }
        public DbSet<Reaction> Reactions { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<BanAction> BanActions { get; set; }
        public DbSet<ChatbotMessage> ChatbotMessages { get; set; }
        public DbSet<UserGroup> UserGroups { get; set; }

        public void ConfigureServices(IServiceCollection services)
        
            => services.AddDbContext<EFDbContext>();
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            =>optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
        
    }
}
