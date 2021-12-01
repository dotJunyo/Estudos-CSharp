using System;
using System.Threading;

namespace StopwatchApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("---------------");
            Console.WriteLine("---Stopwatch---");
            Console.WriteLine("---------------");
            Console.WriteLine("M => Minutos | S => Segundos");
            Console.WriteLine("\nQuanto tempo deseja contar?\n");

            string data = Console.ReadLine().ToLower();
            char type = char.Parse(data.Substring(data.Length - 1, 1));
            int time = int.Parse(data.Substring(0, data.Length - 1));
            int multiplier = 1;

            if (type == 'm')
            {
                multiplier = 60;
            }

            if (time == 0)
            {
                System.Environment.Exit(0);
            }

            Start(time * multiplier);
        }

        static void Start(int time)
        {
            int currentTime = 0;

            while (currentTime < time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("Timer finalizado!");
            Thread.Sleep(2500);
            Menu();
        }
    }
}