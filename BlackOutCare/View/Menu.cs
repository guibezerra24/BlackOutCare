using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackOutCare.Controller;

namespace BlackOutCare.View
{
    public static class MenuView
    {
        public static void ExibirMenu()
        {
            bool continuar = true;

            while (continuar)
            {
                Console.Clear();
                Console.WriteLine("=====================================");
                Console.WriteLine("          BLACKOUTCARE - MENU        ");
                Console.WriteLine("=====================================\n");

                Console.WriteLine("1 - Registrar Incidente");
                Console.WriteLine("2 - Gerar Alerta");
                Console.WriteLine("3 - Monitorar Setores");
                Console.WriteLine("4 - Gerar Relatório de Status");
                Console.WriteLine("5 - Ver Histórico de Eventos");
                Console.WriteLine("0 - Sair");

                Console.Write("\nEscolha uma opção: ");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        IncidenteController.RegistrarIncidente();
                        break;
                    case "2":
                        AlertaController.GerarAlerta();
                        break;
                    case "3":
                        SetorController.MonitorarSetores();
                        break;
                    case "4":
                        RelatorioController.GerarRelatorio();
                        break;
                    case "5":
                        RelatorioController.ExibirHistorico();
                        break;
                    case "0":
                        continuar = false;
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Opção inválida. Pressione uma tecla para continuar...");
                        Console.ResetColor();
                        Console.ReadKey();
                        break;
                }
            }

            Console.WriteLine("\nEncerrando o sistema... Obrigado por utilizar o BlackOutCare!");
        }
    }
}