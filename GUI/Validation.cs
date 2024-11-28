namespace GUI
{
    internal class Validation
    {

        internal int AskForInteger()
        {
            string input = Console.ReadLine();

            if (!int.TryParse(input, out int result))
            {
                Console.WriteLine("Felaktigt val, välj en siffra"); 

            }
            return result;  
        }
        internal double AskForDouble()
        {
            string input = Console.ReadLine();

            if (!double.TryParse(input, out double result))
            {
                Console.WriteLine("Felaktigt val, välj en siffra");

            }
            return result;
        }
    }
}