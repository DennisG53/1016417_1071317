using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EDDProyectoPreliminarHD.Models
{
    public class CuentaUsuario
    {
        [Key]

        public int UserID { get; set; }

        //[Required(ErrorMessage = "Nombre requerido")]
        public string Nombre { get; set; }

        //[Required(ErrorMessage = "Apellido requerido")]
        public string Apellido { get; set; }

        //[Required(ErrorMessage = "Edad requerida")]
        public int Edad { get; set; }

        //[Required(ErrorMessage = "Nombre de usuario requerido")]
        public string Username { get; set; }

        //[Required(ErrorMessage = "Contraseña requerida")]
        //[DataType(DataType.Password)]
        public string Password { get; set; }

        //[Compare("Password", ErrorMessage = "Confirme su contraseña")]
        //[DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}