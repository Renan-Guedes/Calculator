using System;

namespace Calculator
{
    class Program
    {
        enum Opcao { Soma = 1, Subtracao, Multiplicacao, Divisao, Potencia, Raiz, Sair }

        static void Main(string[] args)
        {
            Menu();
        }

        #region Funções

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Bem vindo ao Projeto Calculator!");
            Console.WriteLine();
            Console.WriteLine("Digite apenas o número da opção que deseja:");
            Console.WriteLine();
            Console.WriteLine("1 -> Soma");
            Console.WriteLine("2 -> Subtração");
            Console.WriteLine("3 -> Multiplicação");
            Console.WriteLine("4 -> Divisão");
            Console.WriteLine("5 -> Potência");
            Console.WriteLine("6 -> Raiz");
            Console.WriteLine("7 -> Fechar o programa!");

            Opcao opcao = (Opcao)short.Parse(Console.ReadLine());

            switch (opcao)
            {
                case Opcao.Soma:
                    Soma();
                    break;

                case Opcao.Subtracao:
                    Subtracao();
                    break;

                case Opcao.Multiplicacao:
                    Multiplicacao();
                    break;

                case Opcao.Divisao:
                    Divisao();
                    break;

                case Opcao.Potencia:
                    Potencia();
                    break;

                case Opcao.Raiz:
                    Raiz();
                    break;

                case Opcao.Sair:
                    Console.WriteLine("Programa finalizado!");
                    System.Environment.Exit(0);
                    break;

                default:
                    Menu();
                    break;
            }
        }

        public static void Soma()
        {
            Console.Clear();

            Console.WriteLine("---> Soma de dois números! <---");
            Console.WriteLine("-------------------------------------");

            Console.Write("Digite o primeiro número: ");
            float n1 = float.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            float n2 = float.Parse(Console.ReadLine());

            Console.WriteLine();
            float resultado = n1 + n2;

            Console.WriteLine($"A soma de {n1} + {n2} é igual a {resultado}");
            Console.WriteLine();
            Console.WriteLine("Aperte Enter para voltar ao menu");

            Console.ReadKey();
            Menu();
        }

        public static void Subtracao()
        {
            Console.Clear();

            Console.WriteLine("---> Substração de dois números! <---");
            Console.WriteLine("-------------------------------------");

            Console.Write("Digite o primeiro número: ");
            float n1 = float.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            float n2 = float.Parse(Console.ReadLine());

            float resultado = n1 - n2;

            Console.WriteLine($"A diferença de {n1} - {n2} é igual a {resultado}");
            Console.WriteLine();
            Console.WriteLine("Aperte Enter para voltar ao menu");

            Console.ReadKey();
            Menu();
        }

        public static void Multiplicacao()
        {
            Console.Clear();

            Console.WriteLine("---> Multiplicação de dois números! <---");
            Console.WriteLine("-------------------------------------");

            Console.Write("Digite o primeiro número: ");
            float n1 = float.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            float n2 = float.Parse(Console.ReadLine());

            float resultado = n1 * n2;

            Console.WriteLine($"A multiplicação de {n1} x {n2} é igual a {resultado}");
            Console.WriteLine();
            Console.WriteLine("Aperte Enter para voltar ao menu");

            Console.ReadKey();
            Menu();
        }

        public static void Divisao()
        {
            Console.Clear();

            Console.Write("---> Divisão de dois números! <---");
            Console.WriteLine("-------------------------------------");

            Console.Write("Digite o primeiro número: ");
            float n1 = float.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            float n2 = float.Parse(Console.ReadLine());

            float resultado = n1 / n2;

            Console.WriteLine($"A divisão de {n1} por {n2} é igual a {resultado}");
            Console.WriteLine();
            Console.WriteLine("Aperte Enter para voltar ao menu");

            Console.ReadKey();
            Menu();
        }

        public static void Potencia()
        {
            Console.Clear();

            Console.Write("---> Potência de um número! <---");
            Console.WriteLine("-------------------------------------");

            Console.Write("Digite a base: ");
            float baseNum = float.Parse(Console.ReadLine());

            Console.Write("Digite o expoente: ");
            float expoente = float.Parse(Console.ReadLine());

            float resultado = (float)Math.Pow(baseNum, expoente);

            Console.WriteLine($"A base {baseNum} elevada à potência {expoente} é igual a {resultado}");
            Console.WriteLine();
            Console.WriteLine("Aperte Enter para voltar ao menu");

            Console.ReadKey();
            Menu();
        }

        public static void Raiz()
        {
            Console.Clear();

            Console.Write("---> Raiz de um número! <---");
            Console.WriteLine("-------------------------------------");

            Console.Write("Digite um número: ");
            float numero = float.Parse(Console.ReadLine());

            float resultado = (float)Math.Sqrt(numero);

            Console.WriteLine($"A raiz de {numero} é igual a {resultado}");
            Console.WriteLine();
            Console.WriteLine("Aperte Enter para voltar ao menu");

            Console.ReadKey();
            Menu();
        }

        #endregion
    }
}