using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCWALOROEDD.Models
{
    public class CuentaUsuario
    {
        //Los mensajes de error se usarán para poder verificar errores y pedir los datos respectivos.

        [Required(ErrorMessage = "Por favor, indique su nombre.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Por favor, indique su apellido.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Por favor, indique su edad.")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Por favor, seleccione un nombre de usuario.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Por favor, seleccione su contraseña.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Verifique que su contraseña esté correcta.")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}