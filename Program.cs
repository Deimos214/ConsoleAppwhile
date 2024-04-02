using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            double contsal = 0;
            double salario;


            Console.WriteLine("Deseja iniciar? S/N");
            string func = Console.ReadLine().ToLower();
            int cont = 0;
            while (func == "s")
            {
                Console.WriteLine("Qual a forma de contratação?(Assalariado(A), Comissionado(C), Horista(H))");
                string forma = Console.ReadLine().ToLower();
                switch (forma)
                {
                    case "a":
                        Console.WriteLine("informe o salário: ");
                        double sal = double.Parse(Console.ReadLine());
                        Console.WriteLine("informe o desconto: ");
                        double desc = double.Parse(Console.ReadLine());
                        salario = (sal - desc);
                        Console.WriteLine("O salário é " + salario);
                        contsal += salario;
                        cont++;
                        break;
                    case "c":
                        Console.WriteLine("informe a quantidade de produtos: ");
                        double produto = double.Parse(Console.ReadLine());
                        Console.WriteLine("informe o valor da comissão: ");
                        double comiss = double.Parse(Console.ReadLine());
                        salario = (produto * comiss);
                        Console.WriteLine("O salário é " + salario);
                        contsal += salario;
                        cont++;
                        break;
                    case "h":
                        Console.WriteLine("informe o valor da hora: ");
                        double valorh = double.Parse(Console.ReadLine());
                        Console.WriteLine("informe a quantidade de horas trabalhadas: ");
                        double qtdhora = double.Parse(Console.ReadLine());
                        salario = (valorh * qtdhora);
                        Console.WriteLine("O salário é " + salario);
                        contsal += salario;
                        cont++;
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;



                }

                Console.WriteLine("Deseja iniciar? S/N");
                func = Console.ReadLine().ToLower();


            }
            Console.WriteLine("Total folha de pagamento: " + contsal.ToString("C"));
            Console.WriteLine("Número de funcionários: " + cont);
            Console.WriteLine("Media salarial:" + (contsal / cont).ToString("C"));

            Console.ReadKey();
        }
    }
}

