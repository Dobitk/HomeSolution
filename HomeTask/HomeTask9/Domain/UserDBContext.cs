using HomeTask9.Services;
using HomeTask9.UserModels;
using Microsoft.EntityFrameworkCore;


namespace HomeTask9.Domain
{
    class UserDBContext: DbContext
    {
        public DbSet<Character> Characters { get; set; }
        public DbSet<Story> Stories { get; set; }
        public DbSet<Author> Authors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

             optionsBuilder.UseSqlServer("Server=USERHOME\\SQL;DataBase=CSharpAdvanced;Trusted_Connection=true");
            //optionsBuilder.UseSqlServer(Connect.StringConnect());
        }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            

            modelBuilder.Entity<Author>().HasData(
                new Author { Id = 1, Name = "Hans Christian Andersen" },
                new Author { Id = 2, Name = "Comic" },
                new Author { Id = 3, Name = "Novel" },
                new Author { Id = 4, Name = "Bobby Lynn Maslen" });


            modelBuilder.Entity<Author>().HasIndex(x => new { x.Name, x.NameState });

            modelBuilder.Entity<Story>().HasData(
                new Story { Id = 1, Name = "Fairytail of the lost needle", Description = "" },
                new Story { Id = 2, Name = "Clone Wars", Description = "" },
                new Story { Id = 3, Name = "Cool story, Bob", Description = "" });


            modelBuilder.Entity<Character>().HasData(
                new Character() { Id = 1, FirstName = "Finn", LastName = "Mertens", Age = 14, StoryId = 1, AuthorId = 1 },
                new Character() { Id = 2, FirstName = "Philip", LastName = "Fry", Age = 2700, StoryId = 1, AuthorId = 4 },
                new Character() { Id = 3, FirstName = "Anakin", LastName = "Skywalker", Age = 29, StoryId = 2, AuthorId = 3 },
                new Character() { Id = 4, FirstName = "Varian", LastName = "Wrynn", Age = 4, StoryId = 3, AuthorId = 2 });



        }

    }
}
