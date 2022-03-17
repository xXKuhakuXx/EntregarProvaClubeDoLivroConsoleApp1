using System;

namespace ProvaClubeDoLivroConsoleApp1
{
    internal class Program
    {
        public static string opcao;

        //Contadores 
        public static int contadorAmiguinhosAdicionados = 0;

        //Arrays 
        public static Friend[] amiguinho = new Friend[100];



        static void Main(string[] args)
        {
            //Variaveis 
            MainMenu menu = new MainMenu();
            SubMenu menu2 = new SubMenu();
            Friend chamarFunçoesDoFriend = new Friend();

            #region Menu Principal 

            while (true)
            {

                menu.MenuPrincipal();
                opcao = Console.ReadLine();
                #region controle de erro 
                if (opcao != "1" && opcao != "2" && opcao != "3" && opcao != "s")
                {
                    while (true)
                    {
                        Console.Write("Digite uma opçao valida: ");
                        opcao = Console.ReadLine();

                        if (opcao == "1" || opcao == "2" || opcao == "3" || opcao == "s")
                        {
                            Console.Clear();
                            break;
                        }
                    }
                }
                #endregion

                if (opcao == "s")
                    break;

                if (opcao == "1")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Seja bem vindo ao setor Amiguinhos");
                    Console.ResetColor();

                    menu2.MenuSecundario();

                    if (menu2.opcao == "1")
                    {

                        AdicionarInformaçoesNoArray();
                    }
                    else if (menu2.opcao == "2")
                    {

                        MostrarAmiguinhosAdicionados();
                    }
                    else if (menu2.opcao == "3")
                    {
                        MostrarAmiguinhosAdicionados();
                        EditarAmiguinho();
                    }
                    else if (menu2.opcao == "4")
                    {
                        MostrarAmiguinhosAdicionados();
                        ExcluirAmiguinho();
                    }

                }
                else if (opcao == "2")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Seja bem vindo ao setor das Caixas !");
                    Console.ResetColor();

                    menu2.MenuSecundario();



                }

            }

            #endregion
            #region Adicionar Amiguinho
            static void AdicionarInformaçoesNoArray()
            {
                Friend friend = new Friend();

                int Id = 1;

                Console.Write("Digite o nome do Amiguinho: ");
                friend.nome = Console.ReadLine();

                Console.Write("Digite o nome do Responsavel do Amiguinho: ");
                friend.nomeResponsavel = Console.ReadLine();

                Console.Write("Digite o Numero do Amiguinho: ");
                friend.telefone = Console.ReadLine();

                Console.Write("Digite o endereço do Amiguinho: ");
                friend.endereço = Console.ReadLine();
                friend.idAmiguinho = Id;

                contadorAmiguinhosAdicionados++;
                Id++;

                for (int i = 0; i < amiguinho.Length; i++)
                {
                    if (amiguinho[i] == null)
                    {
                        amiguinho[i] = friend;
                        break;
                    }
                }
            }

            #endregion

            #region Mostrar Amiguinho
            static void MostrarAmiguinhosAdicionados()
            {
                Friend friend = new Friend();
                friend.idAmiguinho = 0;

                if (amiguinho[0].idAmiguinho != friend.idAmiguinho)
                {
                    while (true)
                    {
                        for (int i = 0; i < contadorAmiguinhosAdicionados; i++)
                        { 
                            if (amiguinho[i].idAmiguinho != friend.idAmiguinho)
                            {
                                Console.WriteLine("ID: " + amiguinho[i].idAmiguinho);
                                Console.WriteLine("Nome: " + amiguinho[i].nome);
                                Console.WriteLine("Nome do Responsavel: " + amiguinho[i].nomeResponsavel);
                                Console.WriteLine("Telefone: " + amiguinho[i].telefone);
                                Console.WriteLine("Endereçoo: " + amiguinho[i].endereço);
                            }
                            break;
                        }
                        break;
                    }
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("nenhum amiguinho cadastrado!");
                    Console.ResetColor();
                }
            }
            #endregion

            #region Editar Amiguinho 
            static void EditarAmiguinho()
            {
                Console.Write("Digite a ID do amiguinho que deseja Editar: ");
                int idDoAmiguinhoASerEditado = Convert.ToInt32(Console.ReadLine());
                Friend friend = new Friend();

                for (int i = 0; i < amiguinho.Length; i++)
                {
                    if (amiguinho[i].idAmiguinho == idDoAmiguinhoASerEditado)
                    {
                        Console.Write("Digite o nome do Amiguinho: ");
                        friend.nome = Console.ReadLine();

                        Console.Write("Digite o nome do Responsavel do Amiguinho: ");
                        friend.nomeResponsavel = Console.ReadLine();

                        Console.Write("Digite o Numero do Amiguinho: ");
                        friend.telefone = Console.ReadLine();

                        Console.Write("Digite o endereço do Amiguinho: ");
                        friend.endereço = Console.ReadLine();

                        amiguinho[i] = friend;

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Amiguinho editado com sucesso! ");
                        Console.ResetColor();

                        break;
                    }
                }
            }
            #endregion

            #region Excluir Amiguinho 
            static void ExcluirAmiguinho()
            {
                Friend igualarAZero = new Friend();
                igualarAZero.idAmiguinho = 0;

                if (amiguinho[0].idAmiguinho != igualarAZero.idAmiguinho)
                {
                    Console.WriteLine("Digite a Id do Amiguingo que deseja excluir: ");
                    int alunoQueVaiSerExcluido = Convert.ToInt32(Console.ReadLine());

                    Friend friend = new Friend();

                    friend.nome = null;
                    friend.nomeResponsavel = null;
                    friend.telefone = null;
                    friend.endereço = null;
                    friend.idAmiguinho = 0;

                    for (int i = 0; i < amiguinho.Length; i++)
                    {
                        if (amiguinho[i].idAmiguinho == alunoQueVaiSerExcluido)
                        {
                            amiguinho[i] = friend;
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Amiguinho editado com sucesso! ");
                            Console.ResetColor();
                            break;
                        }
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("nenhum amiguinho cadastrado!");
                    Console.ResetColor();
                }
            }
            #endregion
        }
    }
}
