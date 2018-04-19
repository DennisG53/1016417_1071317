using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Proyecto_MVC.Models
{
    public class CuentaUsuario
    {
        [Required(ErrorMessage = "Por favor, ingrese su nombre.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Por favor, ingrese su apellido.")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "Por favor, seleccione un nombre de usuario.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Por favor, ingrese su edad.")]
        public int Edad { get; set; }

        [Required(ErrorMessage = "Por favor, seleccione una contraseña.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Verifique su contraseña.")]
        public string ConfirmarPassword { get; set; }
    }
}