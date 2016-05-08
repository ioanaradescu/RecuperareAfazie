using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Models
{
    public class Rezultat
    {
        public int RezultatId { get; set; }

        public int PacientId { get; set; }  //FK
        public virtual Pacient Pacient { get; set; }

        public int TestId { get; set; }    //FK
        public virtual Test Test { get; set; }

        public int? RaspunsuriCorecte { get; set; }
        public int? RaspunsuriGresite { get; set; }

       
        public string TimpRezolvare { get; set; }

        public DateTime DataRezolvare { get; set; }

        public virtual ICollection<Raspuns> Raspunsuri { get; set; }

    }
}
