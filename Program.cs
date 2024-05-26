using System.Reflection.Metadata;

namespace BasicCalculator
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            MeuMenu();
        }

        static void MeuMenu()
        {


            Console.WriteLine("CALCULADORA BASICA - 4 OPERAÇÕES >>> \nEscolha a operação: \n1 - Adição \n2 - Subtração \n3 - Divisão \n4 - Multiplicação \n5 - SAIR ");
            int res1 = int.Parse(Console.ReadLine());
            switch (res1)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: Environment.Exit(0); break; // Encerra progrma
                default: MeuMenu(); break;

            }

        }

        static void Soma()
        {
            Console.Clear();
            Console.WriteLine(">>>ADIÇÃO: \nDigite valor 1: ");
            float valor1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite valor 2: ");
            float valor2 = float.Parse(Console.ReadLine());
            Console.WriteLine($"Resultado da Adição:  {valor1 + valor2}");
            Console.ReadKey();
            MeuMenu();
        }
        static void Subtracao()
        {
            Console.Clear();
            Console.WriteLine(">>>SUBTRAÇÃO: \nDigite valor 1: ");
            float valor1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite valor 2: ");
            float valor2 = float.Parse(Console.ReadLine());
            Console.WriteLine($"Resultado da Subtração:  {valor1 - valor2}");
            Console.ReadKey();
            MeuMenu();

        }
        static void Divisao()
        {
            Console.Clear();
            Console.WriteLine(">>>DIVISÃO: \nDigite valor 1: ");
            float valor1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite valor 2: ");
            float valor2 = float.Parse(Console.ReadLine());
            Console.WriteLine($"Resultado da Divisão:  {valor1 / valor2}");
            Console.ReadKey();
            MeuMenu();
        }
        static void Multiplicacao()
        {
            Console.Clear();
            Console.WriteLine(">>>MULTIPLICAÇÃO: \nDigite valor 1: ");
            float valor1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite valor 2: ");
            float valor2 = float.Parse(Console.ReadLine());
            Console.WriteLine($"Resultado da Multiplicação:  {valor1 * valor2}");
            Console.ReadKey();
            MeuMenu();


        }
    }
}
