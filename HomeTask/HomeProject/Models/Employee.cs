using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HomeProject.Models
{
    //Модель сотрудников
    public class Employee
    {
        
        public int Id { get; set; }
        [StringLength(100)]
        [Required]
        public string DepartmentName { get; set; }
        [StringLength(100)]
        [Required(ErrorMessage = "Поле <Имя> должно быть заполнено")]//
        // [Display(Name = "Поле <Имя> должно быть заполнено")]
        public string FirstName { get; set; }
        [StringLength(100)]
        [Required(ErrorMessage = "Поле <Фамилия> должно быть заполнено")]//
        //[Display(Name = "Поле <Фамилия> должно быть заполнено")]
        public string LastName { get; set; }
        [StringLength(20)]
        public string Phone { get; set; }

        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? DateBirth { get; set; }



        public IEnumerable<Family> Family { get; set; } 

        public IEnumerable<WorkHistory> WorkHistory { get; set; }



    }
}
