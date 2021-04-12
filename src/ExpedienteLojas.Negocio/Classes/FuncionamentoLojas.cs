using ExpedienteLojas.Negocio.Enum;
using ExpedienteLojas.Negocio.Interfaces;
using System;

namespace ExpedienteLojas.Negocio.Classes
{
    public class FuncionamentoLojas : IFuncionamentoLojas
    {
        #region Atributos

        private readonly IFuncionamentoLojasRepositorio _funcionamentoLojasRepositorio;

        #endregion

        #region Construtores

        public FuncionamentoLojas(IFuncionamentoLojasRepositorio funcionamentoLojasRepositorio)
        {
            _funcionamentoLojasRepositorio = funcionamentoLojasRepositorio;
        }

        #endregion

        #region Métodos Públicos

        public ExpedienteLoja ObterHorariosAtendimento(Loja loja)
        {
            return _funcionamentoLojasRepositorio.ObterHorariosAtendimento(loja);
        }

        public bool EstaAberta(Loja loja, DateTime data)
        {
            return _funcionamentoLojasRepositorio.EstaAberta(loja, data);
        }

        #endregion
    }
}