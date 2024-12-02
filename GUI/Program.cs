﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Labb2;
using Logiclayer;
//Logiclayer kopplas inte, 

namespace GUI
{

    class Program
    {
        InMemoryDatabase InMemoryDatabase = new InMemoryDatabase();
        private static Validation Validation = new Validation();
        static void Main(string[] args)
        {
            Database.Seed();
            Meny();
        }

        public static void Meny()
        {
            Console.Clear();
            Console.WriteLine("Välj vad du vill göra");
            Console.WriteLine("1. Välj användare");
            Console.WriteLine("2. Avsluta programmet");

            Console.WriteLine("Välj något av ovanstående alternativ: 1 eller 2");

            int input = Validation.AskForInteger();

            if (input == 1)
            {
                VäljAnvändare();

            }
            else if (input == 2)
            {
                AvslutaMeny();
            }
            else
            {
                FelVal();
                Meny();
            }
        }
        private static void AvslutaMeny()
        {
            Environment.Exit(500);
        }
        private static void FelVal()
        {
            Console.WriteLine("Det alternativet finns inte, välj 1-2");
        }
        private static void VäljAnvändare()
        {
            foreach (Användare Användare in Database.användares)
            {
                Console.WriteLine(Användare.AnvändarID + " " + Användare.Namn);
            }
            Console.WriteLine("");
            Console.WriteLine("Välj användare eller tryck på någon siffra som inte är 1-3 för att komma tillbaka!");


            int input = Validation.AskForInteger();

            if (input == 1 || input == 2)
            {
                AnvändarUI();
            }
            else if (input == 3)
            {
                AdminUI();
            }
            else
            {
                FelVal();
                Meny();
            }
            Console.ReadLine();

        }
        private static void AnvändarUI()
        {
            Console.Clear();

            foreach (Stationer Station in Database.station)
            {
                Console.WriteLine("Stationern finns i " + Station.Plats + " och har storleken " + Station.Storlek + " " + "med antalet " + Station.AntalFordon + " fordon");
            }
            Console.WriteLine("Välj stad! ");
            Console.WriteLine("1. Borås");
            Console.WriteLine("2. Göteborg");

            int input = Validation.AskForInteger();
            if (input == 1)
            {
                Console.WriteLine("Du är i Borås");
                foreach (Stationer Station in Database.station)
                {
                    foreach (Fordon Fordon in Station.Fordon)
                    {
                        if (Fordon.FordonsStatus == true && Station.Plats == "Borås")
                        {
                            Console.WriteLine("ID: " + Fordon.FordonsID + " Typ: " + Fordon.FordonsTyp + " Batteri Nivå:" + Fordon.BatteriStatus);
                            Console.WriteLine("Skriv id:et till fordonet du vill hyra!");
                            Console.WriteLine("1. Elscooter");
                            Console.WriteLine("7. Elsparkcykel");
                            int inputt = Validation.AskForInteger();
                            if (inputt == 1)
                            {
                                foreach (Användare Användare in Database.användares)
                                {
                                    foreach (Hyrning Hyrning in Database.hyrning)
                                    {
                                        if (Användare.Betalningsmetod == "Swish")
                                        {
                                            Console.WriteLine("Du har valt " + Fordon.FordonsID + "  " + Fordon.FordonsTyp + " och du betalar med " + Användare.Betalningsmetod + " och den har hyrtiden " + Hyrning.Hyrtid + " per minut och kostar " + Hyrning.Hyrkostnad + " kr.");
                                            Console.WriteLine("Tack för ditt köp!");
                                            Environment.Exit(1000);
                                        }
                                        //Den kommer aldrig hit andå när vi använder våran användare 2 som har betalningsmetod = kontanter
                                        else if (Användare.Betalningsmetod == "Kontanter")
                                        {
                                            Console.WriteLine("Tyvärr men vi acceptar inte " + Användare.Betalningsmetod + " byt till en annan betalningsmetod nästa gång!");
                                            Environment.Exit(1000);

                                        }
                                    }
                                }
                            }
                            else if (inputt == 7)
                            {
                                Console.WriteLine("");
                                foreach (Användare Användare in Database.användares)
                                {
                                    foreach (Hyrning Hyrning in Database.hyrning)
                                    {
                                        if (Användare.Betalningsmetod == "Swish")
                                        {
                                            Console.WriteLine("Du har valt " + Fordon.FordonsID + "  " + Fordon.FordonsTyp + " och du betalar med " + Användare.Betalningsmetod + " och den har hyrtiden " + Hyrning.Hyrtid + " per minut och kostar " + Hyrning.Hyrkostnad + " kr.");
                                            Console.WriteLine("Tack för ditt köp!");
                                            Environment.Exit(10000);
                                        }
                                        else if (Användare.Betalningsmetod == "Kontanter")
                                        {
                                            Console.WriteLine("Tyvärr men vi acceptar inte " + Användare.Betalningsmetod + " byt till en annan betalningsmetod nästa gång!");
                                            Environment.Exit(1000);

                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }


            else if (input == 2)
            {
                Console.WriteLine("Du är i Göteborg");
                foreach (Stationer Station in Database.station)
                {
                    foreach (Fordon Fordon in Station.Fordon)
                    {
                        if (Fordon.FordonsStatus == true && Station.Plats == "Göteborg")
                        {
                            //Fordonet visar bara 1 id; varför??
                            Console.WriteLine("ID: " + Fordon.FordonsID + " Typ: " + Fordon.FordonsTyp + " Batteri Nivå:" + Fordon.BatteriStatus);
                            Console.WriteLine("Skriv id:et till fordonet du vill hyra!");
                            Console.WriteLine("2. Elscooter");
                            Console.WriteLine("3. Elscooter");
                            Console.WriteLine("5. Elsparkcykel");
                            Console.WriteLine("6. Elsparkcykel");
                            int inputt = Validation.AskForInteger();
                            if (inputt == 2)
                            {
                                foreach (Användare Användare in Database.användares)
                                {
                                    foreach (Hyrning Hyrning in Database.hyrning)
                                    {
                                        if (Användare.Betalningsmetod == "Swish")
                                        {
                                            Console.WriteLine("Du har valt " + Fordon.FordonsID + "  " + Fordon.FordonsTyp + " och du betalar med " + Användare.Betalningsmetod + " och den har hyrtiden " + Hyrning.Hyrtid + " per minut och kostar " + Hyrning.Hyrkostnad + " kr.");
                                            Console.WriteLine("Tack för ditt köp!");
                                            Environment.Exit(1000);
                                        }
                                        //Den kommer aldrig hit andå när vi använder våran användare 2 som har betalningsmetod = kontanter
                                        else if (Användare.Betalningsmetod == "Kontanter")
                                        {
                                            Console.WriteLine("Tyvärr men vi acceptar inte " + Användare.Betalningsmetod + " byt till en annan betalningsmetod nästa gång!");
                                            Environment.Exit(1000);

                                        }
                                    }
                                }
                            }
                            else if (inputt == 3)
                            {
                                Console.WriteLine("");
                                foreach (Användare Användare in Database.användares)
                                {
                                    foreach (Hyrning Hyrning in Database.hyrning)
                                    {
                                        if (Användare.Betalningsmetod == "Swish")
                                        {
                                            Console.WriteLine("Du har valt " + Fordon.FordonsID + "  " + Fordon.FordonsTyp + " och du betalar med " + Användare.Betalningsmetod + " och den har hyrtiden " + Hyrning.Hyrtid + " per minut och kostar " + Hyrning.Hyrkostnad + " kr.");
                                            Console.WriteLine("Tack för ditt köp!");
                                            Environment.Exit(10000);
                                        }
                                        else if (Användare.Betalningsmetod == "Kontanter")
                                        {
                                            Console.WriteLine("Tyvärr men vi acceptar inte " + Användare.Betalningsmetod + " byt till en annan betalningsmetod nästa gång!");
                                            Environment.Exit(1000);

                                        }
                                    }
                                }
                            }

                            else if (inputt == 5)
                            {
                                Console.WriteLine("");
                                foreach (Användare Användare in Database.användares)
                                {
                                    foreach (Hyrning Hyrning in Database.hyrning)
                                    {
                                        if (Användare.Betalningsmetod == "Swish")
                                        {
                                            Console.WriteLine("Du har valt " + Fordon.FordonsID + "  " + Fordon.FordonsTyp + " och du betalar med " + Användare.Betalningsmetod + " och den har hyrtiden " + Hyrning.Hyrtid + " per minut och kostar " + Hyrning.Hyrkostnad + " kr.");
                                            Console.WriteLine("Tack för ditt köp!");
                                            Environment.Exit(10000);
                                        }
                                        else if (Användare.Betalningsmetod == "Kontanter")
                                        {
                                            Console.WriteLine("Tyvärr men vi acceptar inte " + Användare.Betalningsmetod + " byt till en annan betalningsmetod nästa gång!");
                                            Environment.Exit(1000);

                                        }
                                    }
                                }
                            }
                            else if (inputt == 6)
                            {
                                Console.WriteLine("");
                                foreach (Användare Användare in Database.användares)
                                {
                                    foreach (Hyrning Hyrning in Database.hyrning)
                                    {
                                        if (Användare.Betalningsmetod == "Swish")
                                        {
                                            Console.WriteLine("Du har valt " + Fordon.FordonsID + "  " + Fordon.FordonsTyp + " och du betalar med " + Användare.Betalningsmetod + " och den har hyrtiden " + Hyrning.Hyrtid + " per minut och kostar " + Hyrning.Hyrkostnad + " kr.");
                                            Console.WriteLine("Tack för ditt köp!");
                                            Environment.Exit(10000);
                                        }
                                        else if (Användare.Betalningsmetod == "Kontanter")
                                        {
                                            Console.WriteLine("Tyvärr men vi acceptar inte " + Användare.Betalningsmetod + " byt till en annan betalningsmetod nästa gång!");
                                            Environment.Exit(1000);

                                        }
                                    }
                                }
                            }
                        }
                    }

                }
            }
            else
            {
                FelVal();
                AnvändarUI();
            }
            Console.ReadLine();

        }
        private static void AdminUI()
        {
            Console.Clear();
            Console.WriteLine("Välkommen Admin! Vad vill du göra?");
            Console.WriteLine("1. Visa fordons lista");
            Console.WriteLine("2. Ta bort trasigt fordon");
            Console.WriteLine("Välj mellan 1 och 2");
            Console.WriteLine("");
            int input = Validation.AskForInteger();

            if (input == 1)
            {
                Console.WriteLine("Du har valt 1) visa fordons lista!");
                foreach (Stationer Station in Database.station)
                {
                    foreach (Fordon Fordon in Station.Fordon)
                    {
                        Console.WriteLine("ID: " + Fordon.FordonsID + " Typ: " + Fordon.FordonsTyp + " Batteri Nivå:" + Fordon.BatteriStatus + " Tillgänglighet " + Fordon.FordonsStatus);
                    }
                }
            }
            else if (input == 2)
            {
                Console.WriteLine("Ska vara helt ärlig har ingen aning på hur man lägger till det här just nu, tror det är bättre om vi fokuserar på winforms och arbetar på det här på onsdag");
            }
            else
            {
                FelVal();
                Meny();
            }
        }
    }
}