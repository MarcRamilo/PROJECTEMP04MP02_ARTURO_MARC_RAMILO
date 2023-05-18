using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECTEMP02_MARCRAMILO.model
{
    public class Campionats
    {//encapsular per mantenir dades privades i tenir geters i setters public més segur
        private int year;
        private String city;
        private String country;
        private List<DJ> Disjockey = new List<DJ>();    

        public int Year { get { return year; } set { year = value; } }
        //public int Year { get => year; set => year=value; }
        public String City { get { return city; } set { city = value; } }
        //public int City { get => city; set => year=city; }
        public String Country { get { return country; } set { country = value; } }
        //public int Country { get => country; set => year=country; }

        public void addDj(DJ dj)
        {
            Disjockey.Add(dj);
        }
      

    }
}
