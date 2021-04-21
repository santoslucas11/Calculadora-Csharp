using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu(){
            Console.Clear();

            Console.WriteLine("Calculadora - Escolha um número para realizar uma operação");
            Console.WriteLine("1 - Somar");
            Console.WriteLine("2 - Subtrair");
            Console.WriteLine("3 - Dividir");
            Console.WriteLine("4 - Multiplicar");
            Console.WriteLine("");
            Console.WriteLine("0 - Sair");    


            Console.WriteLine("----------------");
            Console.WriteLine("Opção selecionada: ");

            short opcao = short.Parse(Console.ReadLine());

            switch(opcao){
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 0: System.Environment.Exit(0); break;
                default: Menu(); break;
            }
        }

        static void Soma (){
            Console.Clear();

            Console.WriteLine("Primeiro Valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float result = v1 + v2;
            Console.WriteLine($"Resultado soma: {result}");
            Console.ReadKey();
            Menu();
        }

        static void Subtracao(){
            Console.Clear();

            Console.WriteLine("Insira o primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Insira o segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float result = v1 - v2;
            Console.WriteLine($"Resultado: {result}");
            Console.ReadKey();
            Menu();
        }
    
        static void Divisao(){
            Console.Clear();

            Console.WriteLine("Insira o primeiro valor: ");
            float v1 =  float.Parse(Console.ReadLine());

            Console.WriteLine("Insira o segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float result = v1 / v2;
            Console.WriteLine($"Resultado divisão {result}");
            Console.ReadKey();
            Menu();
        }

        static void Multiplicacao(){
            Console.Clear();

            Console.WriteLine("Insira o primeiro valor: ");
            float v1 =  float.Parse(Console.ReadLine());

            Console.WriteLine("Insira o segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float result = v1 * v2;
            Console.WriteLine($"Resultado divisão {result}");
            Console.ReadKey();
            Menu();
        }
    }
}
