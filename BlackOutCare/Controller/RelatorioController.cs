using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackOutCare.Repository;
using BlackOutCare.Model;

namespace BlackOutCare.Controller
{
    public static class RelatorioController
    {
        public static void GerarRelatorio()
        {
            Console.Clear();
            Console.WriteLine("=== Relatório de Status do Sistema ===\n");

            // Exibe incidentes registrados
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(">> Incidentes Registrados:");
            Console.ResetColor();

            if (BancoSimulado.Incidentes.Count == 0)
            {
                Console.WriteLine("Nenhum incidente registrado.");
            }
            else
            {
                foreach (Incidente i in BancoSimulado.Incidentes)
                {
                    Console.WriteLine($"[{i.Data:dd/MM/yyyy}] Setor: {i.Setor} | Descrição: {i.Descricao}");
                }
            }

            Console.WriteLine("\n");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(">> Alertas Emitidos:");
            Console.ResetColor();

            if (BancoSimulado.Alertas.Count == 0)
            {
                Console.WriteLine("Nenhum alerta emitido.");
            }
            else
            {
                foreach (Alerta a in BancoSimulado.Alertas)
                {
                    Console.WriteLine($"[{a.Data:dd/MM/yyyy HH:mm}] Setor: {a.Setor} | Alerta: {a.Mensagem}");
                }
            }

            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }

        public static void ExibirHistorico()
        {
            Console.Clear();
            Console.WriteLine("=== Histórico de Eventos ===\n");

            if (BancoSimulado.Incidentes.Count == 0 && BancoSimulado.Alertas.Count == 0)
            {
                Console.WriteLine("Nenhum evento registrado até o momento.");
            }
            else
            {
                if (BancoSimulado.Incidentes.Count > 0)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine(">> Incidentes:");
                    Console.ResetColor();

                    foreach (var i in BancoSimulado.Incidentes)
                    {
                        Console.WriteLine($"[{i.Data:dd/MM/yyyy}] Setor: {i.Setor} | {i.Descricao}");
                    }

                    Console.WriteLine();
                }

                if (BancoSimulado.Alertas.Count > 0)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine(">> Alertas:");
                    Console.ResetColor();

                    foreach (var a in BancoSimulado.Alertas)
                    {
                        Console.WriteLine($"[{a.Data:dd/MM/yyyy HH:mm}] Setor: {a.Setor} | {a.Mensagem}");
                    }

                    Console.WriteLine();
                }
            }

            Console.WriteLine("Pressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }
    }

   
}