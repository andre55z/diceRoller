using System;
using static System.Random;

namespace DiceRoller
{
    class Dice
    {
        string diceColor = "Black";
        int diceSides;
        public void Talking(){
            Console.WriteLine("Hello! Welcome to the Dice Roller!\nHow many sides does your dice have?");
            diceSides = Convert.ToInt32(Console.ReadLine());
            Rolling();

        }
        public void Rolling()
        {
            Console.WriteLine(@"OK, lets roll? (Press ENTER)");
            Console.ReadLine();
            Random random= new Random();
            diceSides = random.Next(1,diceSides + 1);
            Console.WriteLine($@"The number is {diceSides}");
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Dice dice = new Dice();
            dice.Talking();
        }  
    }
}
