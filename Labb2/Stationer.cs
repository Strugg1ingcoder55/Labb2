using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Stationer
    {
        public string Plats;
        public string Storlek;
        public int AntalFordon;

        //public int AnvändbaraFordon;
        //Gör användbara fordon till en metod istället

        public List<Fordon> Fordon = new List<Fordon>();

        
        //public List<Användare> Användare;
        //En funktion som ser skillnaden mellan AntalFordon och AnvändbaraFordon för att se vilka fordon
        //som är otillgängliga
    }
}
