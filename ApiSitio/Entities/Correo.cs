using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiSitio.Entities
{
    public class Correo
    {
        [Key]
        public int ID { get; set; }
        public string Asunto { get; set; }
        public string Cuerpo { get; set; }
        public int ID_User { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy/dd/MM}", ApplyFormatInEditMode = true)]
        public DateTime? Fecha { get; set; }
    }
}
