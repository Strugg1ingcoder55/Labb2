using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Labb2;

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
            Console.WriteLine("1. Logga in");
            Console.WriteLine("2. Avsluta programmet");

            Console.WriteLine("Välj något av ovanstående alternativ: 1 eller 2");

            int input = Validation.AskForInteger();

            if (input == 1)
            {
                LoggaIn(); 
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
        private static void LoggaIn()
        {
            foreach(Användare Användare in Database.användares)
            {
                Console.WriteLine(Användare.AnvändarID + " " + Användare.Namn);
            }
            Console.WriteLine("");
            Console.WriteLine("Välj användare eller tryck på någon siffra som inte är 1-3 för att komma tillbaka!");
            

            int input = Validation.AskForInteger();

            if (input >= 2)
            {
                
            }
            else if (input == 3)
            {
                
            }
            else
            {
                FelVal();
                Meny();
            }
            Console.ReadLine();

        }
    }
}

