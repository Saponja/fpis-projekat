using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace fpis_projekat.Domain
{
    
    public class Grad
    {
        public int GradId { get; set; }
        public int DrzavaId { get; set; }
        public Drzava Drzava { get; set; }
        public string NazivGrada { get; set; }
        public List<Kupac> Kupci { get; set; }


    }
}
