using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiSitio.Entities
{
    public class Usuario1
    {
        [Key]
        public int ID { get; set; }
        public string Nombre { get; set; }

        public string Apellido { get; set; }
        public string Contraseña { get; set; }
        public string Email { get; set; }
        public string Rol { get; set; }
        public int Telefono { get; set; }
        public string URL { get; set; }
        public string Email_emp { get; set; }
        public string Username { get; set; }
    }
}
