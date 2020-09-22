using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DotNetCoreCRUDMVC.Models
{
    public class NewEmpClass
    {
        [Key]
        public int Empid { get; set; }

        [Required(ErrorMessage ="Enter emp Name")]
        [Display(Name ="Employe Name")]
        public String Empname { get; set; }

        [Required(ErrorMessage = "Enter Email")]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public String Email { get; set; }

        [Required(ErrorMessage = "Enter emp Age")]
        [Display(Name = "Age")]
        [Range(20,50)]
        public int Age { get; set; }

        [Required(ErrorMessage = "Enter emp Salary")]
        [Display(Name = "Salary")]
        public int Salary { get; set; }
    }
}
