using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fpis_projekat.Domain
{
    public class Drzava
    {
        public int DrzavaId { get; set; }
        public string NazivDrzave { get; set; }
        public List<Grad> Gradovi { get; set; }
        //public List<Kupac> Kupci { get; set; }
        public List<Cenovnik> Cenovnici { get; set; }


    }
}
