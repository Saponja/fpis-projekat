using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fpis_projekat.Domain
{
    public class StavkaReklamacije
    {
        public int StavkaReklamacijeId { get; set; }
        public int ReklamacijaId { get; set; }
        public Reklamacija Reklamacija { get; set; }
        public string Opis { get; set; }
        public int ProizvodId { get; set; }
        public Proizvod Proizvod { get; set; }

    }
}
