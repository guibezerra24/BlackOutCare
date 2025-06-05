using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackOutCare.Repository;
using BlackOutCare.Model;


namespace BlackOutCare.Controller
{
    public static class SetorController
    {
        public static void MonitorarSetores()
        {
            Console.Clear();
            Console.WriteLine("=== Monitoramento de Setores ===\n");

            if (BancoSimulado.Setores.Count == 0)
            {
                Console.WriteLine("Nenhum setor cadastrado no sistema.");
            }
            else
            {
                Console.WriteLine("{0,-25} {1}", "Setor", "Status");
                Console.WriteLine(new string('-', 40));

                foreach (Setor setor in BancoSimulado.Setores)
                {
                    if (setor.Status.Equals("ALERTA", StringComparison.OrdinalIgnoreCase))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }

                    Console.WriteLine("{0,-25} {1}", setor.Nome, setor.Status);
                    Console.ResetColor();
                }
            }

            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }
    }
}