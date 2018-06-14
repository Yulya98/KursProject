
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace English2._0
{
    public class CodeFirst : DbContext
    {
        public DbSet<Words> Words { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<UsersWords> UsersWords { get; set; }
        public DbSet<Play> Play { get; set; }
        public CodeFirst()
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UsersWords>()
                .HasKey(t => new { t.UserId, t.WordId });

            modelBuilder.Entity<UsersWords>()
                .HasOne(pt => pt.User)
                .WithMany(p => p.UsersWord)
                .HasForeignKey(pt => pt.UserId);

            modelBuilder.Entity<UsersWords>()
                .HasOne(pt => pt.Word)
                .WithMany(t => t.UsersWord)
                .HasForeignKey(pt => pt.WordId);

            modelBuilder.Entity<Play>()
                .HasKey(t => new { t.FirstId, t.SecondId });

            modelBuilder.Entity<Play>()
                .HasOne(pt => pt.User1)
                .WithMany(p => p.Play1)
                .HasForeignKey(pt => pt.FirstId);

            modelBuilder.Entity<Play>()
                .HasOne(pt => pt.User2)
                .WithMany(t => t.Play2)
                .HasForeignKey(pt => pt.SecondId);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=KursProj;Trusted_Connection=True;multipleactiveresultsets=True");
            base.OnConfiguring(builder);
        }

    }
}