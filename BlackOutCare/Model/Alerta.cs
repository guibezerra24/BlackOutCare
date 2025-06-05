using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BlackOutCare.Model
{
    public class Alerta
    {
        public string Setor { get; set; }
        public string Mensagem { get; set; }
        public DateTime Data { get; set; }

        public Alerta(string setor, string mensagem, DateTime data)
        {
            Setor = setor;
            Mensagem = mensagem;
            Data = data;
        }
    }
}
