using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2
{
    public class Användare
    {
        //registrera sig
        //logga in
        public int AnvändarID;
        public string Namn;
        public string Email;
        public int TelefonNr;
        public string Betalningsmetod;
        public int Hyreshistorik;
        public bool IsAdmin;

        public Fordon Fordon;
        public Hyrning Hyrning;

      

    }
}
