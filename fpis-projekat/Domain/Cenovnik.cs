using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fpis_projekat.Domain
{
    public class Cenovnik
    {
        public int CenovnikId { get; set; }
        public DateTime Datum { get; set; }
        public int DrzavaId { get; set; }
        public Drzava Drzava { get; set; }
        public int RadnikId { get; set; }
        public Radnik Radnik { get; set; }
        public List<StavkaCenovnika> StavkeCenovnika { get; set; }
    }
}
