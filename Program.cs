namespace NumbersGame
{

    internal class Program
    {
       static void Main(string[] args)
        {
            Random random = new Random();  //slumpmässigt nummer
            int hiddenNumber = random.Next(1, 20); // hemligt nummer är mellan 1-20
            int attempts = 5;  // man har 5 försök på sig

            Console.WriteLine($"Välkommen! Jag tänker på ett nummer. Kan du gissa vilket? Du får fem försök.");

            bool isCorrectGuess = false; //boolean visar om det är sant eller falskt.

            while (true)
            {
                if (attempts != 0)  
                {
                    if (int.TryParse(Console.ReadLine(), out int guess))
                    {
                        attempts--;

                        if (guess == hiddenNumber)  //  == visar ifall gissning är lika med hemliga numret
                        {
                            isCorrectGuess = true; // om svaret är rätt så avbryts loopen
                            break;
                        }
                        else if (guess > hiddenNumber) // > visar att gissningen är större än hemliga numret 
                        {
                            Console.WriteLine("Tyvärr, du gissade för högt!");
                        }
                        else if (guess < hiddenNumber)  // < visar att gissningen är mindre än hemliga numret 
                        {
                            Console.WriteLine("Tyvärr, du gissade för lågt!");
                        }
                    }
                }
                else
                {
                    break;  
                }
            }

            if (isCorrectGuess) //bryter loopen om metoden returnerar korrekt text eller fem försök är använda.
            {
                Console.WriteLine("Wohooo! Du klarade det!");
            }
            else
            {
                Console.WriteLine("Tyvärr, du lyckades inte gissa talet på fem försök!");
            }
        }
    }
}
