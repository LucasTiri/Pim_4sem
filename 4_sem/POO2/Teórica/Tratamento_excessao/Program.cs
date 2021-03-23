using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tratamento_excessao
{
    class Program
    {
        static void Main(string[] args)
        {/*
            int n = 10;
            int d = 0;
            try//caso der erro não é executado
            {
                int divisao = n / d;
                Console.WriteLine("{0}", divisao);

            }
            catch (ArithmeticException)//executado se haver esse erro
            {
                Console.WriteLine("ERRO: Divisão por 0");
            }
            Console.WriteLine("Instrução depois do try catch");
         */
            try
            {
                Console.WriteLine("Numerador: ");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine("Denominador: ");
                int d = int.Parse(Console.ReadLine());
                int divisao = n / d;
                Console.WriteLine("Resultado {0}", divisao);
            }
            catch(FormatException e){
                Console.WriteLine("ERRO na formatação: {0}", e.Message);
            }b
            catch (DivideByZeroException e)
            {
                Console.WriteLine("ERRO na divisão: {0}", e.Message);
            }
            finally
            {
                Console.WriteLine("Fim do programa");
            }
        }
    }
}
