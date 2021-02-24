using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiSitio.Entities
{
    public class Report_Offer
    {
        public int Id { get; set; }
        public int Offer_Jobid { get; set; }
        public string Email { get; set; }
        public string Motivo { get; set; }
    }
}
