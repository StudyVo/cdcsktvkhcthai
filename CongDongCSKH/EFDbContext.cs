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
        public DbSet<ChatSession> ChatSessions { get; set; }
        public DbSet<UserGroup> UserGroups { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<EFDbContext>();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Thiết lập liên kết 1-nhiều giữa ChatSession và ChatbotMessage
            modelBuilder.Entity<ChatbotMessage>()
                .HasOne(m => m.ChatSession)
                .WithMany(s => s.Messages)
                .HasForeignKey(m => m.ChatSessionId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}