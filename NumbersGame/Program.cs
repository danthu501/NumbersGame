using System;

namespace NumbersGame
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ch = true;
            while (ch == true)
            {
                Console.WriteLine("Välkommen! Jag tänker på ett nummmer mellan 1 och 20. Kan du gissa vilket? Du får fem försök.");
                Random Randomderare = new Random();
                int number = Randomderare.Next(1, 21);
                //Test

                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Vilket tal vill du gissa på?");

                    int GuessNumber = Int32.Parse(Console.ReadLine());

                    //Checks if the variable "GeussNumber" is higer or lower than the varible "number".
                    CheckGuess(GuessNumber, number);


                    if (GuessNumber == number)
                    {
                        Console.WriteLine("Woho! Du gjorde det!");
                        Console.Write("Vill du spela igen? JA/NEJ: ");
                        string answer = Console.ReadLine();
                        if (answer.ToLower() == "ja")
                        {
                            Console.Clear();
                            break;
                        }
                        else
                        {
                            ch = false;
                            break;
                        }
                    }
                    if (i == 4)
                    {
                        Console.WriteLine("Tyvärr du har gissat fem gånger.");
                        Console.Write("Vill du spela igen? JA/NEJ: ");
                        string answer = Console.ReadLine();
                        if (answer.ToLower() == "ja")
                        {
                            Console.Clear();
                            break;
                        }
                        else
                        {
                            ch = false;
                            break;
                        }

                    }

                }


            }
            static void CheckGuess(int GuessNumber, int number)
            {
                if (GuessNumber < number)
                {
                    Console.WriteLine("Tyvärr du gissade för lågt");
                }
                if (GuessNumber > number)
                {
                    Console.WriteLine("Tyvärr du gissade för högt");
                }

            }
        }
    }
}
