using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackOutCare.Model;
using BlackOutCare.Repository;

namespace BlackOutCare.Controller
{
    public static class IncidenteController
    {
        public static void RegistrarIncidente()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("=== Registro de Incidente ===");

                Console.Write("Informe o setor afetado: ");
                string setor = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(setor))
                    throw new Exception("O setor não pode estar vazio.");

                Console.Write("Informe a data do incidente (dd/MM/yyyy): ");
                string dataTexto = Console.ReadLine();
                if (!DateTime.TryParseExact(dataTexto, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime data))
                    throw new Exception("Data inválida. Use o formato dd/MM/yyyy.");

                Console.Write("Descreva o incidente: ");
                string descricao = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(descricao))
                    throw new Exception("A descrição não pode estar vazia.");

                Incidente novo = new Incidente(setor, data, descricao);
                BancoSimulado.Incidentes.Add(novo);


                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nIncidente registrado com sucesso!");
                Console.ResetColor();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\nErro: {ex.Message}");
                Console.ResetColor();
            }

            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }
    }
}
