using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fpis_projekat.Domain
{
    public class PrevoznoSredstvo
    {
        public int PrevoznoSredstvoId { get; set; }
        public string NazivSredstva { get; set; }
        public List<StavkaPorudzbenice> StavkePorudzbenice { get; set; }
    }
}
