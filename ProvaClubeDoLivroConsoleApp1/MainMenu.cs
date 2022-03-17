using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaClubeDoLivroConsoleApp1
{
    public class MainMenu
    {
        public void MenuPrincipal()
        {
            Console.WriteLine("Digite o numero da funçao que deseja desenvolver:");
            Console.WriteLine("-------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("<<<<<Opçoes>>>>>");
            Console.ResetColor();
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("1- Amiguinhos;");
            Console.WriteLine("2- Caixas;");
            Console.WriteLine("3- Revistinhas;");
            Console.WriteLine("4- Emprestimos;");
            Console.WriteLine("Ou digite s para sair.");
        }
    }
}
