using System;

class Calculadora
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\n--- Calculadora Dona Mariana ---");
            Console.WriteLine("1. Adição");
            Console.WriteLine("2. Subtração");
            Console.WriteLine("3. Multiplicação");
            Console.WriteLine("4. Divisão");
            Console.WriteLine("0. Sair");
            Console.Write("Escolha uma operação: ");

            if (!int.TryParse(Console.ReadLine(), out int opcao) || opcao < 0 || opcao > 4)
            {
                Console.WriteLine("Opção inválida. Tente novamente.");
                continue;
            }

            if (opcao == 0)
            {
                Console.WriteLine("Encerrando a calculadora. Até logo!");
                break;
            }

            Console.Write("Digite o primeiro número: ");
            if (!decimal.TryParse(Console.ReadLine(), out decimal num1))
            {
                Console.WriteLine("Número inválido. Tente novamente.");
                continue;
            }

            Console.Write("Digite o segundo número: ");
            if (!decimal.TryParse(Console.ReadLine(), out decimal num2))
            {
                Console.WriteLine("Número inválido. Tente novamente.");
                continue;
            }

            switch (opcao)
            {
                case 1:
                    Console.WriteLine($"Resultado: {num1} + {num2} = {num1 + num2:F2}");
                    break;
                case 2:
                    Console.WriteLine($"Resultado: {num1} - {num2} = {num1 - num2:F2}");
                    break;
                case 3:
                    Console.WriteLine($"Resultado: {num1} x {num2} = {num1 * num2:F2}");
                    break;
                case 4:
                    if (num2 == 0)
                    {
                        Console.WriteLine("Erro: divisão por zero não é permitida.");
                    }
                    else
                    {
                        Console.WriteLine($"Resultado: {num1} ÷ {num2} = {num1 / num2:F2}");
                    }
                    break;
            }
        }
    }
}
