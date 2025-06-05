using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackOutCare.Model
{
    public class Incidente
    {
        public string Setor { get; set; }
        public DateTime Data { get; set; }
        public string Descricao { get; set; }

        public Incidente(string setor, DateTime data, string descricao)
        {
            Setor = setor;
            Data = data;
            Descricao = descricao;
        }
    }
}
