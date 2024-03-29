//
// nome do programa: EX_3_1.cs
//
// programadores: nome dos alunos
// Mateus Fernando          484555
// Vinicius Ponciano        482955
// Yitzhak Stone            478493
// data: 30/04/2015
// descricao:
// recebe um inteiro N e o programa calcula e exibe na tela o fatorial de N,
// o N-esimo termo da sequencia de fibonacci e a soma desses resultados.
// 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EX_3_1
{
    class Program
    {

        static int result_fibo;
        static int result_fat;

        static void Main(string[] args)
        {

            try
            {

                Console.WriteLine("{0}\t\t{1}", "484555", "Mateus Fernando");
                Console.WriteLine("{0}\t\t{1}", "482955", "Vinicius Ponciano");
                Console.WriteLine("{0}\t\t{1}", "478493", "Yitzhak Stone");

                Console.WriteLine();

                int n1;

                if (args.Length != 1 ||
                    (!(int.TryParse(args[0], out n1))))
                {
                    Console.WriteLine("Parametros Inválidos");
                    return;
                }


                Thread t1 = new Thread(() => calculaFatorial(n1));
                Thread t2 = new Thread(() => calculaFibonacci(n1));

                t1.Start();
                t2.Start();
                //t1.Join();
                //t2.Join();

                while(t1.IsAlive || t2.IsAlive){}

                int soma = result_fat + result_fibo;

                Console.WriteLine("Soma dos resultados: {0}", soma);

                Console.WriteLine();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }

        }

        static void calculaFatorial(int n)
        {
            result_fat = fatorial(n);
            Console.WriteLine("Fatorial de {0} = {1}", n, result_fat);
        }

        static void calculaFibonacci(int n)
        {

            result_fibo = fibonacci(n);
            Console.WriteLine("Fibonacci N:{0} = {1}", n, result_fibo);
            
        }

        static int fatorial(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return n * fatorial(n - 1);
            }
        }

        static int fibonacci(int n)
        {
            int a = 0;
            int b = 1;

            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }

    }
}
