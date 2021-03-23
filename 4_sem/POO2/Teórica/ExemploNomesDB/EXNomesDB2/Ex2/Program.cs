using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex2.BLL;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorNomes gerenciador = new GerenciadorNomes();
            int op;
            do
            {
                // apresenta o menu e le uma opcao
                Console.WriteLine("1 - Adicionar Nome");
                Console.WriteLine("2 - Listar Nomes");
                Console.WriteLine("0 - Sair");
                Console.Write("Opcao: ");
                op = int.Parse(Console.ReadLine());
                // executa a operaçao de acordo com o opcao informada
                switch (op)
                {
                    case 0:
                        break;
                    case 1:
                        // le um nome
                        Console.Write("Nome: ");
                        string nome = Console.ReadLine();
                        bool ok = gerenciador.Inserir(nome);
                        if (ok)
                        {
                            Console.WriteLine("Nome Adicionado com Sucesso!");
                        }
                        break;
                    case 2:
                        List<string> nomes = gerenciador.Listar();
                        if (nomes != null)
                        {
                            if (nomes.Count > 0)
                            {
                                Console.WriteLine("=== Lista de Nomes ===");
                                foreach (string n in nomes)
                                {
                                    Console.WriteLine(n);
                                }
                            }
                            else
                            {
                                Console.WriteLine("Lista Vazia!");
                            }
                        }
                        break;
                    default:
                        Console.WriteLine("Opcao Invalida");
                        break;

                }

            } while (op != 0);
        }
    }
}
