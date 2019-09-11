using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho
{
    class Program
    {
        static List<Menu> menus;
        static void Main(string[] args)
        {
            Console.Clear();
                        
            Boolean continua = true;

            List<Menu> listaMenu = new List<Menu>();

            do
            {

                Console.WriteLine("-----Menu de cadastro-----");
                Console.WriteLine(" 1 - Incluir");
                Console.WriteLine(" 2 - Alterar");
                Console.WriteLine(" 3 - Excluir");
                Console.WriteLine(" 4 - Listar");
                Console.WriteLine(" 5 - Pesquisar");
                Console.WriteLine(" 00 - Sair ");
                Console.WriteLine("Digite sua opção:");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Menu pessoa = new Menu();

                        Console.WriteLine("Cadastro de pessoa");
                        Console.Write("Nome: ");
                        string nome = Console.ReadLine();
                        Console.Write("Senha: ");
                        int senha = Convert.ToInt32(Console.ReadLine());
                        Console.Write("id: ");
                        int id = Convert.ToInt32(Console.ReadLine());

                        listaMenu = new List<Menu>();
                        break;


                    case "2":
                        Console.WriteLine("Alterar");
                        Console.WriteLine("Idique o registro a ser alterado (Nome): ");
                        string alterarNome = (Console.ReadLine());
                        Menu alterar = menus.Find(x => x.Nome == alterarNome);
                        if(alterarNome != null)
                        {
                            alterar.Id = int.Parse( Console.ReadLine());
                            alterar.Senha = int.Parse ( Console.ReadLine());
                            alterar.Nome = Console.ReadLine();

                        }
                        else
                        {
                            Console.WriteLine("Registro não encontrado");
                        }


                        break;
                    case "3":
                        Console.WriteLine("Excluir");
                        Console.WriteLine("Indique o registro a ser excluido (Nome): ");
                        int excluirNome = int.Parse(Console.ReadLine());
                        if(excluirNome  <= listaMenu.Count)
                        {
                            listaMenu.RemoveAt(excluirNome);
                        }
                        else
                        {
                            Console.WriteLine("item não existe na lista");
                        }


                        break;
                    case "4":
                        Console.WriteLine("Listar");
                        Console.WriteLine("Id - Senha. - Nome - Id");
                        listaMenu = new List<Menu>();
                        for(int i = 0; i< listaMenu.Count; i++)
                        {
                              foreach (Menu p in menus )
                               {
                                Console.WriteLine(p.Nome + " " + p.Id);
                               }
                        }

                        break;
                    case "5":
                        Console.WriteLine("Pesquisar");
                        Console.WriteLine("Inserir o Nome do registro que deseja pesquisar ");
                        string src = Console.ReadLine();
                        Menu pesq = listaMenu.Find(x => x.Nome == src);
                        if(pesq != null)
                        {
                            Console.WriteLine("Id: { pesq.Senha}");
                            Console.WriteLine("Id: { pesq.Nome}");
                            Console.WriteLine("Id: { pesq.Id}");
                        }

                        break;
                    case "00":
                        Console.WriteLine("Sair");
                        continua = false;
                        break;

                    default:
                        Console.WriteLine("opcão nao existe.");
                        break;

                }
            }

            while (continua);
            
        }
    }
}
