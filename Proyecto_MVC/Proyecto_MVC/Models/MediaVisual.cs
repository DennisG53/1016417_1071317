using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Proyecto_MVC.Models
{
    public class MediaVisual
    {
        [Key]
        public int UserID { get; set; }

        [Required(ErrorMessage = "Debe ingresar el tipo de media.")]
        public string Tipo { get; set; }

        [Required(ErrorMessage = "Debe ingresar el nombre de la media.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Debe ingresar el año de lanzamiento.")]
        public int AnioLanzamiento { get; set; }

        [Required(ErrorMessage = "Debe ingresar el genero de la media.")]
        public string Genero { get; set; }
    }
}