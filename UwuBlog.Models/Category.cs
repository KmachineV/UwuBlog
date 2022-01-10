using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace UwuBlog.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Este Campo es Requerido")]
        [Display(Name="Nombre Categoria")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Este Campo es Requerido")]
        [Display(Name = "Orden de Visualizacion")]
        public int Order { get; set; }

    }
}
