using System.Collections.Generic;

namespace ExpedienteLojas.Api.ViewModels
{
    public class ResponseViewModel
    {
        #region Construtores

        public ResponseViewModel()
        {
            errors = new List<string>();
        }

        #endregion

        #region Atributos

        public bool success { get; set; }

        public object data { get; set; }

        public IList<string> errors { get; set; }

        #endregion
    }
}