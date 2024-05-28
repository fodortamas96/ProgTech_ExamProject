using ExamProject.Notes;
using ExamProject.Users;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamProject.Database
{
    internal class NotesContext : DbContext
    {
        public DbSet<Note> Notes { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=notes.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User { UserId = 1, Username = "Testuser1", Password = "testPw1", Email = "test1@test.com" },
                new User { UserId = 1, Username = "Testuser2", Password = "testPw2", Email = "test2@test.com" });

            modelBuilder.Entity<Note>().HasData(
                new Note
                {
                    NoteId = 1,
                    Title = "test title 1",
                    Context = "test context 1",
                    Importance = Importance.Normal,
                    CreationDate = DateTime.Now,
                    ModificationDate = DateTime.Now,
                    OwnerId = 1
                },
                new Note
                {
                    NoteId = 2,
                    Title = "test title 2",
                    Context = "test context 2",
                    Importance = Importance.High,
                    CreationDate = DateTime.Now,
                    OwnerId = 2
                }
                );
        }
    }
}
