using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackOutCare.Model;
using BlackOutCare.Repository;

namespace BlackOutCare.Controller
{
    public static class AlertaController
    {
        public static void GerarAlerta()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("=== Geração de Alerta ===");

                Console.Write("Informe o setor onde deseja emitir o alerta: ");
                string setor = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(setor))
                    throw new Exception("O nome do setor não pode estar vazio.");

                Setor setorEncontrado = BancoSimulado.Setores.Find(s => s.Nome.Equals(setor, StringComparison.OrdinalIgnoreCase));
                if (setorEncontrado == null)
                    throw new Exception("Setor não encontrado no sistema.");

                Console.Write("Digite a mensagem de alerta: ");
                string mensagem = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(mensagem))
                    throw new Exception("A mensagem de alerta não pode estar vazia.");

                Alerta novoAlerta = new Alerta(setorEncontrado.Nome, mensagem, DateTime.Now);
                BancoSimulado.Alertas.Add(novoAlerta);

                setorEncontrado.Status = "ALERTA";

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n⚠️ Alerta gerado com sucesso para o setor " + setorEncontrado.Nome + "!");
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
