using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fpis_projekat.Domain
{
    public class Porudzbenica
    {
        public int PorudzbenicaId { get; set; }
        public DateTime Datum { get; set; }
        public string Napomena { get; set; }
        public int RadnikId { get; set; }
        public Radnik Radnik { get; set; }
        public int PIBKupuje { get; set; }
        public Kupac Kupuje { get; set; }
        public int PIBPrima { get; set; }
        public Kupac Prima { get; set; }
        public int PIBPlaca { get; set; }
        public Kupac Placa { get; set; }
        public List<StavkaPorudzbenice> StavkePorudzbenice { get; set; }
        public List<StavkaOtpremnice> StavkeOtpremnice { get; set; }

    }
}
