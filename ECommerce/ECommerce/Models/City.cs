using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        [Index("City_Name_DepartmentId_Index", IsUnique = true, Order =1)]
        public string Name { get; set; }

        [Display(Name = "Departamento")]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Range(1, double.MaxValue, ErrorMessage ="Debe seleccionar un {0}")]
        [Index("City_Name_DepartmentId_Index", IsUnique = true, Order = 2)]
        public int DepartmentId { get; set; }

        public virtual Department Department { get; set; }

        public virtual ICollection<Company> Companies { get; set; }
    }
}