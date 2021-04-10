using ExpedienteLojas.Dominio.Enum;
using System.Collections.Generic;
using System.Linq;

namespace ExpedienteLojas.Dominio.Classes
{
    public class ExpedienteLoja
    {
        public ExpedienteLoja()
        {
            Expediente = new List<Expediente>();
        }

        public Loja Loja { get; set; }

        public IList<Expediente> Expediente { get; set; }

        public bool Expediente24hs { get { return !Expediente.Any(); } }
    }
}