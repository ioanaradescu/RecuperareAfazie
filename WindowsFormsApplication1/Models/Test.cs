using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Models
{
    public class Test
    {
        public int TestId {get; set;}
        public string Nume { get; set; }
        public int Nivel { get; set; }
        

        public virtual ICollection<Intrebare> Intrebari { get; set; }
        public virtual ICollection<Rezultat> Rezultate { get; set; }
    }
}
