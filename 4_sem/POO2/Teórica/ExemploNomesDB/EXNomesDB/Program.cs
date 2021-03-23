using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using EXNomesDB.BLL;

namespace EXNomesDB
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorNomes gerenciador = new GerenciadorNomes();
            int op;
            do
            {
                Console.WriteLine("****MENU****");
                Console.WriteLine("1-Adicionar Nome");
                Console.WriteLine("2-Listar Nomes");
                Console.WriteLine("0-Sair");
                Console.WriteLine("opcao: ");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 0:
                        break;
                    case 1:
                        Console.Write("Nome: ");
                        string nome = Console.ReadLine();
                        bool ok = gerenciador.Inserir(nome);
                        if (ok)
                        {
                            Console.WriteLine("Nome Adicionado com sucesso!");
                        }
                        break;
                    case 2:
                        List<string> nomes = gerenciador.Listar();
                        if(nomes != null)
                        {
                            if(nomes.Count > 0)
                            {
                                Console.WriteLine("===Lista de Nomes===");
                                foreach(string n in nomes) 
                                {
                                    Console.WriteLine(n);
                                }
                            }
                            else
                            {
                                Console.WriteLine("Lista Vazia");
                            }
                        }
                        break;
                    default:
                        Console.WriteLine("Opção invalida");
                        break;
                }

            } while (op != 0);
        }
    }
}
