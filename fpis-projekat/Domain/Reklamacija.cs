using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fpis_projekat.Domain
{
    public class Reklamacija
    {
        public int ReklamacijaId { get; set; }
        public DateTime Datum { get; set; }
        public List<StavkaReklamacije> StavkeReklamacije { get; set; }
    }
}
