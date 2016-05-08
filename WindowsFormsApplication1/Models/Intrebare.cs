using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Models
{
    public class Intrebare
    {
        public int Id { get; set; }

        public int TestId { get; set; }
        public virtual Test Test { get; set; }

        public string TextIntrebare { get; set; }
        public string ImagineIntrebare { get; set; }
        public string Raspuns1 { get; set; }
        public string Raspuns2 { get; set; }
        public string Raspuns3 { get; set; }
        public string Raspuns4 { get; set; }
    }
}
