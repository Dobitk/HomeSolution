using HomeProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeProject.Domain
{
    public class TasksDBContext : DbContext
    {
        public TasksDBContext(DbContextOptions<TasksDBContext> contextOptions) : base(contextOptions) { }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<WorkHistory> WorkHistories { get; set; }
        public DbSet<Family> Families { get; set; }

 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           base.OnModelCreating(modelBuilder);
           modelBuilder.Entity<Employee>().HasData(
                new Employee { Id = 1, DepartmentName = "Директор", FirstName = "Иван", LastName = "Иванов", 
                               DateBirth = new DateTime(1996, 2, 2), Phone = "111-11-11"});


            modelBuilder.Entity<Family>().HasData(
                 new Family { Id = 1, Description = "Жена - Иванова Марина", Yearbirth = "1975", EmployeeId = 1},
                 new Family { Id = 2, Description = "Сын - Иванов Сергей", Yearbirth = "1999", EmployeeId = 1 }
                 );


            modelBuilder.Entity<WorkHistory>().HasData(
                new WorkHistory { Id = 1, WorkName = "СШ №1 Учитель информатики", StartDate = new DateTime(2005, 05, 06), EndDate = new DateTime(2006, 01, 02), EmployeeId = 1 },
                new WorkHistory { Id = 2, WorkName = "СШ №2 Завуч", StartDate = new DateTime(2006, 04, 06), EndDate = new DateTime(2015, 08, 02), EmployeeId = 1 }
                );

           modelBuilder.Entity<Employee>().HasData(
                new Employee { Id = 2, DepartmentName = "Заместитель директора", FirstName = "Сергей", LastName = "Петров", 
                               DateBirth = new DateTime(1986, 3, 25), Phone = "111-11-11"});


            modelBuilder.Entity<Family>().HasData(
                 new Family { Id = 3, Description = "Жена - Петрова Ирина", Yearbirth = "1986", EmployeeId = 2},
                 new Family { Id = 4, Description = "Дочь - Метрова Таня", Yearbirth = "1995", EmployeeId = 2 }
                 );


            modelBuilder.Entity<WorkHistory>().HasData(
                new WorkHistory { Id = 3, WorkName = "СШ №15 Учитель физики", StartDate = new DateTime(2005, 05, 06), EndDate = new DateTime(2006, 01, 02), EmployeeId = 2 },
                new WorkHistory { Id = 4, WorkName = "СШ №100 Директор", StartDate = new DateTime(2006, 04, 06), EndDate = new DateTime(2015, 08, 02), EmployeeId = 2 }
                );



        }
    }
}
