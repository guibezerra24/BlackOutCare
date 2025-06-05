using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BlackOutCare.Model;
using System.Threading.Tasks;

namespace BlackOutCare.Repository
{
    public static class BancoSimulado
    {
        public static List<Usuario> Usuarios = new List<Usuario>()
        {
            new Usuario("admin", "123"),
            new Usuario("enfermeiro", "456")
        };

        public static List<Setor> Setores = new List<Setor>()
        {
            new Setor("UTI", "Normal"),
            new Setor("Emergência", "Normal"),
            new Setor("Centro Cirúrgico", "Normal"),
            new Setor("Farmácia", "Normal"),
            new Setor("Raio-X", "Normal")
        };

        public static List<Incidente> Incidentes = new List<Incidente>();
        public static List<Alerta> Alertas = new List<Alerta>();
    }
}