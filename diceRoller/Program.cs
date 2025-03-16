using System;
using System.Diagnostics.CodeAnalysis;
using static System.Random;

namespace DiceRoller
{
    class Verify
    {
        public int Verfy(string diceSides)
        {
            if (int.TryParse(diceSides, out int dS))
            {
                if (dS >0)
                    return dS;
                else
                {
                    Console.WriteLine("Invalid input, try again!");
                    return 0;
                }
            }
            else
            {
                Console.WriteLine("Invalid input, try again!");
                return 0;
            }
        }
    }
    class Dice
    {
        
        string diceColor = "Black";
        public void Talking(){
            int vrf = 0;
            Console.WriteLine("Hello! Welcome to the Dice Roller!\nHow many sides does your dice have?");
            string diceSides = Console.ReadLine();
            Verify verify = new Verify();
            while(vrf == 0){
                vrf = verify.Verfy(diceSides);
                if (vrf == 0){
                    diceSides = Console.ReadLine();
                }
            }
            Rolling(vrf);

        }
        public int Rolling(int dS2r)
        {
            Console.WriteLine(@"OK, lets roll? (Press any tecle)");
            Console.ReadLine();
            Random random= new Random();
            int diceSides = random.Next(1, dS2r+ 1);
            Console.WriteLine($@"The number is {diceSides}");
            return 0;
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            bool ver = true;
            while(ver==true){
                int verf = 1;
                Dice dice = new Dice();
                dice.Talking();
                Console.WriteLine("Roll again?\n1 = Yes\t||\tAnotherNumber = No");
                string answer = Console.ReadLine();
                while(verf == 1)
                    if (int.TryParse(answer, out int ans))
                    {
                        verf=0;
                        if (ans == 1)
                        {
                            ver = true;
                        }
                        else
                        {
                            ver = false;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input, try again!");
                        verf = 1;
                        answer = Console.ReadLine();
                    }

            }  
        }
    }
}
