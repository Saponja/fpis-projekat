using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fpis_projekat.Domain
{
    public class Otpremnica
    {
        public int OtpremnicaId { get; set; }
        public DateTime Datum { get; set; }
        public int RadnikId { get; set; }
        public Radnik Radnik { get; set; }
        public List<StavkaOtpremnice> StavkeOtpremnice { get; set; }

    }
}
