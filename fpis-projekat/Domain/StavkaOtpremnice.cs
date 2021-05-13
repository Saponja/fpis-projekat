using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fpis_projekat.Domain
{
    
    public class StavkaOtpremnice
    {
        public int StavkaOtpremniceId { get; set; }
        public int OtpremnicaId { get; set; }
        public Otpremnica Otpremnica { get; set; }
        public string Opis { get; set; }
        public int ProizvodId { get; set; }
        public Proizvod Proizvod { get; set; }
        public int PorudzbenicaId { get; set; }
        public Porudzbenica Porudzbenica { get; set; }
    }
}
