using ExpedienteLojas.Negocio.Enum;
using System.Collections.Generic;
using System.Linq;

namespace ExpedienteLojas.Negocio.Classes
{
    public class ExpedienteLoja
    {
        #region Construtores

        public ExpedienteLoja()
        {
            Expediente = new List<Expediente>();
        }

        #endregion

        #region Atributos

        public Loja Loja { get; set; }

        public IList<Expediente> Expediente { get; set; }

        public bool Expediente24hs { get { return !Expediente.Any(); } }

        #endregion
    }
}