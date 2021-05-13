using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fpis_projekat.Domain
{
    
    public class StavkaPorudzbenice
    {
        public int StavkaPorudzbeniceId { get; set; }
        public int PorudzbenicaId { get; set; }
        public Porudzbenica Porudzbenica { get; set; }
        public double Kolicina { get; set; }
        public DateTime DatumIsporuke { get; set; }
        public int ProizvodId { get; set; }
        public Proizvod Proizvod { get; set; }
        public List<PrevoznoSredstvo> PrevoznaSredstva { get; set; }
    }
}
