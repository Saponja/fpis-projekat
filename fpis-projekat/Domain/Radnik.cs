using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fpis_projekat.Domain
{
    public class Radnik
    {
        public int RadnikId { get; set; }
        public string ImePrezime { get; set; }
        public string Email { get; set; }
        public List<Porudzbenica> Porudzbenice { get; set; }
        public List<Otpremnica> Otpremnice { get; set; }
        public List<Cenovnik> Cenovnici { get; set; }


    }
}
