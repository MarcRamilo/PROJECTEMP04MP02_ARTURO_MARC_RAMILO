using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECTEMP02_MARCRAMILO.model
{
    public class Producte
    {
        public int id {get; set;}
        public String Name { get; set; }
        public int preu { get; set; }
        public String descripcio { get; set; }

        private List<Colors> colors = new List<Colors>();

        private List<Talles> talles = new List<Talles>();


    }
}
