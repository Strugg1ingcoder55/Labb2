using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Labb2;
using static System.Collections.Specialized.BitVector32;

namespace GUI
{
    class Program
    {
        private static InMemoryDatabase Database = new InMemoryDatabase();
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
            Console.WriteLine("1. Visa användare");
            Console.WriteLine("2. Avsluta programmet");

            Console.WriteLine("Välj något av ovanstående alternativ: 1 eller 2");

            int input = Validation.AskForInteger();

            if (input == 1)
            
                VisaAnvändare(); 
            
            else if (input == 2)
            
                AvslutaMeny(); 
            
            else
            
                FelVal();
                Meny();
            
        }
        public static void AvslutaMeny()
        {
            Environment.Exit(0); //Programmet stängs ner när man trycker 2
        }
        public static void FelVal()
        {
            Console.WriteLine("Det alternativet finns inte, välj 1 eller 2"); //
        }
        
        
        
        public static void VisaAnvändare()
        {
            foreach(Användare Användare in Database.användares)
            {
                /*Visa användare*/

                Console.WriteLine(Användare.AnvändarID); //Visar alla AnvändarID:n när man trycker 1


            }
            Console.WriteLine("");
            Console.WriteLine("Tryck 1 för kund 1");
            Console.WriteLine("Tryck 2 för kund 2");
            Console.WriteLine("Tryck 3 för Admin");
            Console.WriteLine("Tryck på någon siffra som inte är 1-3 för att komma tillbaka!");


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

        private static void AdminUI()
        {
            throw new NotImplementedException();
        }

        private static void AnvändarUI() //Vad som händer efter man har tryckt 1.Användare
        {
            foreach (Stationer stationer in Database.station)
            {
                Console.WriteLine("Välj vilken stad du vill hyra ifrån! ");
                Console.WriteLine(stationer.Plats);
            }

                 Console.WriteLine("");
            { 
                Console.Clear();


            int input = Validation.AskForInteger();
            if (input == 1)
            {
                Console.WriteLine("Du är i Borås"); //Steg 1 


                    foreach (Stationer Station in Database.station)
                    {
                        foreach (Fordon fordon in Database.fordons)

                        {
                            Console.WriteLine("I Borås finns det följande fordon att välja mellan: ");

                            Console.WriteLine("1. Elscooter");
                            Console.WriteLine("7. Elsparkcykel");

                            

                            int inputt = Validation.AskForInteger();



                            if (Fordon.FordonsStatus == true && Fordon.BatteriStatus == "Hög" && Station.Plats == "Borås")
                            {
                                VisaTillgängligaScootrar();
                            }

                            else if (input == 7 && Fordons.FordonsStatus == true && Fordon.BatteriStatus == "Hög" && Station.Plats == "Borås" && Fordon.FordonsTyp == "Elscooter")
                            {
                                VisaTillgängligaSparkcyklar();
                            }
                            else
                            {
                                FelVal();
                                Meny();
                            }
                            Console.ReadLine();
                        }
                    }
private static void VisaTillgängligaScootrar()
        {
            Console.WriteLine(Fordon.FordonsID);
        }
    }
private static void VisaTillgängligaSparkcyklar()
        {
            throw new NotImplementedException();
        }
    }




                        
        


       
        
    


