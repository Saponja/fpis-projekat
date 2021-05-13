using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fpis_projekat.Domain
{
    public class Proizvod
    {
        public int ProizvodId { get; set; }
        public string NazivModela { get; set; }

        public List<Karatkeristika> Karatkeristike { get; set; }
        public List<StavkaPorudzbenice> StavkePorudzbenice { get; set; }
        public List<StavkaOtpremnice> StavkeOtpremnice { get; set; }
        public List<StavkaCenovnika> StavkeCenovnika { get; set; }
        public List<StavkaReklamacije> StavkeReklamacije { get; set; }


    }
}
