using System.ComponentModel.DataAnnotations;

//Модель должностей
namespace HomeProject.Models
{
    public class Department
    {
        public int Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; }

  


    }
}
