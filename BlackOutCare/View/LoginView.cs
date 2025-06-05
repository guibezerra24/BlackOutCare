using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackOutCare.Controller;

namespace BlackOutCare.View
{
    public static class LoginView
    {
        public static void TelaLogin()
        {
            bool logado = false;

            while (!logado)
            {
                Console.Clear();
                Console.WriteLine("=====================================");
                Console.WriteLine("        SISTEMA BLACKOUTCARE         ");
                Console.WriteLine("=====================================\n");

                Console.Write("Usuário: ");
                string nome = Console.ReadLine();

                Console.Write("Senha: ");
                string senha = Console.ReadLine();

                logado = LoginController.ValidarLogin(nome, senha);

                if (!logado)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\nPressione qualquer tecla para tentar novamente...");
                    Console.ResetColor();
                    Console.ReadKey();
                }
            }

            
            MenuView.ExibirMenu(); 
        }
    }
}