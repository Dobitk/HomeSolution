using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


//Модел работы в прошлом
namespace HomeProject.Models
{
    public class WorkHistory
    {
        public int Id { get; set; }
        [StringLength(150)]
        [Required(ErrorMessage = "Поле <Работа> должно быть заполнено")]
        public string WorkName { get; set; }
        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = true)]
        public DateTime StartDate { get; set; }

       [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = true)]
        public DateTime EndDate { get; set; }

        public int EmployeeId { get; set; }

        public Employee Employee { get; set; }

    }
}
