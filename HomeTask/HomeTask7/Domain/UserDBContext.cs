using System.Configuration;
using HomeTask7.Services;
using HomeTask7.UserModels;
using Microsoft.EntityFrameworkCore;


namespace HomeTask7.Domain
{
    class UserDBContext: DbContext
    {
        public DbSet<BookAuthor> BookAuthors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

           //  optionsBuilder.UseSqlServer("Server=USERHOME\\SQL;DataBase=BaseBook;Trusted_Connection=true");
            optionsBuilder.UseSqlServer(Connect.StringConnect());
        }

    }
}
