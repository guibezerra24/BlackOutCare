using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackOutCare.Repository;
using BlackOutCare.Model;

namespace BlackOutCare.Controller
{
    public static class LoginController
    {
        public static bool ValidarLogin(string nomeDigitado, string senhaDigitada)
        {
            try
            {
                // Procura o usuário na lista simulada
                Usuario usuarioEncontrado = BancoSimulado.Usuarios.FirstOrDefault(u => u.Nome == nomeDigitado && u.Senha == senhaDigitada);

                if (usuarioEncontrado != null)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Login realizado com sucesso!");
                    Console.ResetColor();
                    return true;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Usuário ou senha incorretos.");
                    Console.ResetColor();
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Erro ao tentar logar: {ex.Message}");
                Console.ResetColor();
                return false;
            }
        }
    }
}