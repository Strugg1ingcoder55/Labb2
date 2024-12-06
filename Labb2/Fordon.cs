using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2
{
    public class Fordon
    {
        public int FordonsID { get; set; }
        public string FordonsTyp { get; set; }
        public string BatteriStatus { get; set; }
        public bool FordonsStatus { get; set; }

        public Användare Användare;
        public Stationer Stationer;

       
    }
}
