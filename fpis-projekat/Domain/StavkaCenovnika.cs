using Microsoft.EntityFrameworkCore;

namespace fpis_projekat.Domain
{
    
    public class StavkaCenovnika
    {
        public int StavkaCenovnikaId { get; set; }
        public int CenovnikId { get; set; }
        public Cenovnik Cenovnik { get; set; }
        public double CenaSaPDV { get; set; }
        public double CenaBezPDV { get; set; }
        public int ProizvodId { get; set; }
        public Proizvod Proizvod { get; set; }
    }
}