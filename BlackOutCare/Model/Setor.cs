using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackOutCare.Model
{
    public class Setor
    {
        public string Nome { get; set; }
        public string Status { get; set; }

        public Setor(string nome, string status)
        {
            Nome = nome;
            Status = status;
        }
    }
}
