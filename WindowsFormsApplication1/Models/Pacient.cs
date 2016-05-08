using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Models
{
    public class Pacient
    {
        public int Id { get; set; }
        public string CNP { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public int? Varsta { get; set; }
        public string Observatii { get; set; }

        public virtual ICollection<Rezultat> Rezultate { get; set; }
    }
    

    
}
