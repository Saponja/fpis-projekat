using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fpis_projekat.Domain
{
    public class Kupac
    {
        public int KupacId { get; set; }
        public string NazivKupca { get; set; }
        public string UlicaBroj { get; set; }
        public int DrzavaId { get; set; }
        public Drzava Drzava { get; set; }
        public int GradId { get; set; }
        public Grad Grad { get; set; }
        public List<Porudzbenica> Kupovanja { get; set; }
        public List<Porudzbenica> Placanja { get; set; }
        public List<Porudzbenica> Primanja { get; set; }

    }
}
