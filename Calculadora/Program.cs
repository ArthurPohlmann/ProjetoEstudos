using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            string CalcularNovamente = "S";
            while (CalcularNovamente == "S")
            {
                Console.WriteLine("**************CALCULADORA*********************");
                Console.WriteLine("");
                Console.WriteLine("Informe qual operação deseja realizar: ");
                Console.WriteLine("1. Somar ");
                Console.WriteLine("2. Subtrair ");
                Console.WriteLine("3. Multiplicar ");
                Console.WriteLine("4. Dividir ");
                string opcao = Console.ReadLine();

                double numero1 = 0;
                double numero2 = 0;

                if (opcao == "1" || opcao == "2" || opcao == "3" || opcao == "4")
                {
                    Console.Write("Digite o primeiro número ");
                    numero1 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Digite o segundo número ");
                    numero2 = Convert.ToDouble(Console.ReadLine());
                }

                Console.WriteLine("A opção escolhida foi {0} e os números digitados foram {1} e {2} ", opcao, numero1, numero2);

                switch (opcao)
                {
                    case "1":
                        double somar = numero1 + numero2;
                        Console.WriteLine("{0} + {1} = {2}", numero1, numero2, somar);
                        break;
                    case "2":
                        double subtrair = numero1 - numero2;
                        Console.WriteLine("{0} - {1} = {2}", numero1, numero2, subtrair);
                        break;
                    case "3":
                        double multiplicar = numero1 * numero2;
                        Console.WriteLine("{0} * {1} = {2}", numero1, numero2, multiplicar);
                        break;
                    case "4":
                        if (numero2 != 0)
                        {
                            double dividir = numero1 / numero2;
                            Console.WriteLine("{0} / {1} = {2}", numero1, numero2, dividir);
                        }
                        else
                        {
                            Console.WriteLine("O número não pode ser dividido por 0! ");
                        }
                        break;
                    default:
                        Console.WriteLine("Opção inválida! ");
                        break;
                }

                Console.WriteLine("Deseja calcular mais uma vez ? (S/N)");
                CalcularNovamente = Console.ReadLine();
                Console.Clear();
            }
        }
    }

            
}
