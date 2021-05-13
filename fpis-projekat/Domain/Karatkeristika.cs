using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fpis_projekat.Domain
{
    
    public class Karatkeristika
    {
        public int KarakteristikaId { get; set; }
        public int ProizvodId { get; set; }
        public Proizvod Proizvod { get; set; }
        public double Vrednost { get; set; }
        public string NazivKarakteristike { get; set; }

    }
}
