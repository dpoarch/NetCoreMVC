using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.netCoreMVCCRUD.Models
{
    public class Employee
    {
        [Key]

        public int Id { get; set; }
        [Column(TypeName = "nvarchar(250")]
        [Required(ErrorMessage ="This field is required")]

        [DisplayName("FULL NAME")]
        public string name { get; set; }
        [Column(TypeName =  "varchar(10")]

        [DisplayName("EMP. CODE")]
        public string code { get; set; }
        [Column(TypeName =  "varchar(100")]

        [DisplayName("POSITION")]
        public string position { get; set; }
        [Column(TypeName = "varchar(100")]

        [DisplayName("OFFICE LOCATION")]
        public string location { get; set; }

    }
}
