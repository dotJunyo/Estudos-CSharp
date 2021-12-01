using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int optMenu = 9;

            while (optMenu != 0)
            {
                Console.Clear();

                Console.WriteLine("O que deseja fazer?");
                Console.WriteLine("1 - Soma");
                Console.WriteLine("2 - Subtracao");
                Console.WriteLine("3 - Divisao");
                Console.WriteLine("4 - Multiplicacao");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("");

                optMenu = int.Parse(Console.ReadLine());

                switch (optMenu)
                {
                    case 1:
                        Soma();
                        break;
                    case 2:
                        Subtracao();
                        break;
                    case 3:
                        Divisao();
                        break;
                    case 4:
                        Multiplicacao();
                        break;
                }
            }
        }

        static void Soma()
        {
            Console.Clear();

            Console.WriteLine("Digite o primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("\nDigite o segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 + v2;

            Console.WriteLine($"\nO resultado de {v1}+{v2} é: {resultado}\n");
            Console.ReadKey();
        }
        static void Subtracao()
        {
            Console.Clear();

            Console.WriteLine("Digite o primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("\nDigite o segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 - v2;

            Console.WriteLine($"\nO resultado de {v1}-{v2} é: {resultado}\n");
            Console.ReadKey();
        }
        static void Divisao()
        {
            Console.Clear();

            Console.WriteLine("Digite o primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("\nDigite o segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 / v2;

            Console.WriteLine($"\nO resultado de {v1}/{v2} é: {resultado}\n");
            Console.ReadKey();
        }
        static void Multiplicacao()
        {
            Console.Clear();

            Console.WriteLine("Digite o primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("\nDigite o segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 * v2;

            Console.WriteLine($"\nO resultado de {v1}*{v2} é: {resultado}\n");
            Console.ReadKey();
        }
    }
}
