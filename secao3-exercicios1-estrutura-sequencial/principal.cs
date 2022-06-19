﻿using System.Globalization;

namespace secao_3_exercicios1_estrutura_sequencial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int option;
            int MenuIndice;
            const int ValueSaida = 99;
            List<string> MenuOptions = new() { "exercicio01", "exercicio02", "exercicio03", "exercicio04", "exercicio05", "sair" };

            do
            {
                Console.Clear();
                Console.Beep();
                Console.WriteLine("Escolha:");
                MenuIndice = 0;
                foreach (string MenuOption in MenuOptions)
                {
                    Console.WriteLine($"{++MenuIndice} - {MenuOption}");
                    if (MenuIndice == MenuOptions.Count - 1)
                    {
                        MenuIndice = 98;   //controls to use 99 to the last option
                    }
                }
                try
                {
                    option = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    option = 0;
                }
                switch (option)
                {
                    case 1:
                        exercicio01();
                        break;
                    case 2:
                        exercicio02();
                        break;
                    case 3:
                        exercicio03();
                        break;
                    case 4:
                        exercicio04();
                        break;
                    case 5:
                        exercicio05();
                        break;
                    case ValueSaida:
                        Environment.Exit(0);
                        break;
                    default:
                        option = 0;
                        break;
                }
                if (option != 0 && option != ValueSaida)
                {
                    Console.ReadKey(); // wait, user reading outputs
                }
            } while (option != ValueSaida);
        }
        static void exercicio01()
        {
            int valor1;
            int valor2;

            Console.WriteLine("Digite o primeiro valor inteiro: ");
            valor1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor inteiro: ");
            valor2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"SOMA = {valor1 + valor2}");
        }
        static void exercicio02()
        {
            double raio;
            double area;

            Console.WriteLine("Digite o valor do Raio:");
            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            area = Math.PI * Math.Pow(raio, 2);
            Console.WriteLine($"A={area.ToString("F4", CultureInfo.InvariantCulture)}");
        }
        static void exercicio03()
        {
            int A, B, C, D, DIFERENCA;

            Console.WriteLine("Digite o valor de A:");
            A = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de B:");
            B = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de C:");
            C = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de D:");
            D = int.Parse(Console.ReadLine());

            DIFERENCA = (A * B - C * D);

            Console.WriteLine($"DIFERENCA = {DIFERENCA}");
        }
        static void exercicio04()
        {
            int NumerodoFuncionario;
            int HorasTrabalhadas;
            double ValorPorHora;
            double Salario;

            Console.WriteLine("Digite o número do funcionário");
            NumerodoFuncionario = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número de horas trabalhadas");
            HorasTrabalhadas = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor da hora");
            ValorPorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Salario = HorasTrabalhadas * ValorPorHora;
            Console.WriteLine($"NUMBER = {NumerodoFuncionario}\nSALARY = U$ {Salario.ToString("F2", CultureInfo.InvariantCulture)}");
        }
        static void exercicio05()
        {
            string[] PecasLinha;
            int cod1, cod2, qtde1, qtde2;
            double preco1, preco2, TotalPagar;

            Console.WriteLine("Digite [Código Peça][Nr de Peças] [Vr Unitário] <enter>");
            PecasLinha = Console.ReadLine().Split(' ');
            cod1 = int.Parse(PecasLinha[0]);
            qtde1 = int.Parse(PecasLinha[1]);
            preco1 = double.Parse(PecasLinha[2],CultureInfo.InvariantCulture);

            Console.WriteLine("Digite [Código Peça][Nr de Peças] [Vr Unitário] <enter>");
            PecasLinha = Console.ReadLine().Split(' ');
            cod2 = int.Parse(PecasLinha[0]);
            qtde2 = int.Parse(PecasLinha[1]);
            preco2 = double.Parse(PecasLinha[2],CultureInfo.InvariantCulture);

            TotalPagar = (qtde1 * preco1) + (qtde2 * preco2);

            Console.WriteLine($"VALOR A PAGAR: R$ {TotalPagar.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}