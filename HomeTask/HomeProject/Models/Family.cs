using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualBasic.CompilerServices;

namespace HomeProject.Models
{
    public class Family
    {
        public int Id { get; set; }
        [StringLength(150)]
        [Required(ErrorMessage = "Поле <Семья> должно быть заполнено")]
        public string Description { get; set; }
        [StringLength(4)]
        //[DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:yyyy}", ApplyFormatInEditMode = true)]
        [RegularExpression("([1-9][0-9]*)", ErrorMessage = "Разрешены только цифры")]
        public string Yearbirth { get; set; }

        public int EmployeeId { get; set; }

        public Employee Employee { get; set; }

    }
}
