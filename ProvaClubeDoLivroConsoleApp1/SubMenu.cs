using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaClubeDoLivroConsoleApp1
{
    public class SubMenu
    {
        public string opcao;

        public void MenuSecundario()
        {
            Console.WriteLine("Digite 1 para registrar");
            Console.WriteLine("Digite 2 para visualizar");
            Console.WriteLine("Digite 3 para editar");
            Console.WriteLine("Digite 4 para excluir");

            Console.WriteLine("opcao: ");
            opcao = Console.ReadLine();

            Console.Clear();

        }
    }
}
