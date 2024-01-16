using System;

namespace  Calculator
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

            Console.WriteLine("O que você deseja fazer?");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Substração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Potenciação");
            Console.WriteLine("6 - Raíz quadrada");
            Console.WriteLine("7 - Sair");

            Console.WriteLine("=================");
            Console.WriteLine("Selecione uma opção: ");
           
            short res = short.Parse(Console.ReadLine());


            switch(res)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: Potenciacao();break;
                case 6: raizQuadrada();break;
                case 7: System.Environment.Exit(0); break;
                default: Menu(); break;

            }
        }

        static void Soma()
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            float valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor");
            float valor2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = valor1 + valor2;
            Console.WriteLine($"O resultado da soma é {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void Subtracao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro Valor:");
            float valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor:");
            float valor2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = valor1 - valor2;
            Console.WriteLine($"O resultado da subtração é {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void Divisao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor:");
            float valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor:");
            float valor2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = valor1 / valor2;
            Console.WriteLine($"O resultado da divisão é {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void Multiplicacao(){
            Console.Clear();

            Console.WriteLine("Primeiro valor:");
            float valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor:");
            float valor2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = valor1 * valor2;
            Console.WriteLine($"O resultado da multiplicação é {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void Potenciacao(){
            Console.Clear();

            Console.WriteLine("Valor da base:");
            float valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Valor do expoente:");
            float valor2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");
            double resultado = Math.Pow(valor1, valor2);
            Console.WriteLine($"O resultado da potência de {valor1} por {valor2} é {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void raizQuadrada(){
            Console.Clear();

            Console.WriteLine("Valor do número:");
            float valor1 = float.Parse(Console.ReadLine());


            Console.WriteLine("");
            double resultado = Math.Sqrt(valor1);
            Console.WriteLine($"A raíz de {valor1} é {resultado}");
            Console.ReadKey();
            Menu();
        }
    }
}