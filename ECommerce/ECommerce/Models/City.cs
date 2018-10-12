using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ECommerce.Models
{
    public class City
    {
        [Key]
        public int CityId { get; set; }

        [Display(Name = "Ciudad")]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [MaxLength(50, ErrorMessage = "El campo {0} no debe ser mayor a {1} carácteres")]
        public string Name { get; set; }

        [Display(Name = "Departamento")]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public int DepartmentId { get; set; }

        public virtual Department Department { get; set; }
    }
}