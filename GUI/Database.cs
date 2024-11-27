using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Labb2;

namespace GUI
{
     class Database
    {
        internal List<Användare> användares = new List<Användare>();
        internal List<Fordon> fordons = new List<Fordon>();
        internal List<Stationer> station = new List<Stationer>();
        internal List<Hyrning> hyrning = new List<Hyrning>();

        internal void Seed()
        {
            #region Användare1
            Användare användare1 = new Användare();
            användare1.AnvändarID = 1;
            användare1.Namn = "Oscar Norén";
            användare1.Email = "oscar.noren02@gmail.com";
            användare1.Betalningsmetod = "Swish";
            användare1.Hyreshistorik = 2;
            användare1.IsAdmin = false;


            #endregion

            #region Användare 2
            Användare användare2 = new Användare();
            användare2.AnvändarID = 2;
            användare2.Namn = "Jans Svensson";
            användare2.Email = "Jans.svensson99@gmail.com";
            användare2.Betalningsmetod = "BankID";
            användare2.Hyreshistorik = 5;
            användare2.IsAdmin = false;

            #endregion

            #region Användare 3
            Användare användare3 = new Användare();
            användare3.AnvändarID = 3;
            användare3.Namn = "S2106104";
            användare3.Email = "S2106104@gmail.com";
            användare3.Betalningsmetod = "Swish";
            användare3.Hyreshistorik = 10;
            användare3.IsAdmin = true;

            #endregion


            #region Fordon1
            Fordon fordon1 = new Fordon();
            fordon1.FordonsID = 1;
            fordon1.FordonsTyp = "Elscooter";
            fordon1.BatteriStatus = "Hög";
            fordon1.FordonsStatus = true;
            #endregion

            #region Fordon2
            Fordon fordon2 = new Fordon();
            fordon2.FordonsID = 2;
            fordon2.FordonsTyp = "Elscooter";
            fordon2.BatteriStatus = "Medel";
            fordon2.FordonsStatus = true;
            #endregion

            #region Fordon3
            Fordon fordon3 = new Fordon();
            fordon3.FordonsID = 3;
            fordon3.FordonsTyp = "Elscooter";
            fordon3.BatteriStatus = "Låg";
            fordon3.FordonsStatus = true;
            #endregion

            #region Fordon4
            Fordon fordon4 = new Fordon();
            fordon4.FordonsID = 4;
            fordon4.FordonsTyp = "Elscooter";
            fordon4.BatteriStatus = "Urladdad";
            fordon4.FordonsStatus = false;
            #endregion

            #region Fordon5
            Fordon fordon5 = new Fordon();
            fordon5.FordonsID = 5;
            fordon5.FordonsTyp = "Elsparkcykel";
            fordon5.BatteriStatus = "Hög";
            fordon5.FordonsStatus = true;
            #endregion

            #region Fordon6
            Fordon fordon6 = new Fordon();
            fordon6.FordonsID = 6;
            fordon6.FordonsTyp = "Elsparkcykel";
            fordon6.BatteriStatus = "Medel";
            fordon6.FordonsStatus = true;
            #endregion

            #region Fordon7
            Fordon fordon7 = new Fordon();
            fordon7.FordonsID = 7;
            fordon7.FordonsTyp = "Elsparkcykel";
            fordon7.BatteriStatus = "Låg";
            fordon7.FordonsStatus = true;
            #endregion

            #region Fordon8
            Fordon fordon8 = new Fordon();
            fordon8.FordonsID = 8;
            fordon8.FordonsTyp = "Elsparkcykel";
            fordon8.BatteriStatus = "Urladdad";
            fordon8.FordonsStatus = false;
            #endregion

            #region Station1
            Stationer station1 = new Stationer();
            station1.Plats = "Borås";
            station1.Storlek = "Mellan";
            station1.AntalFordon = 3;


            #endregion

            #region Station2
            Stationer station2 = new Stationer();
            station2.Plats = "Göteborg";
            station2.Storlek = "Stor";
            station2.AntalFordon = 5;
            #endregion


        }
    }
}
