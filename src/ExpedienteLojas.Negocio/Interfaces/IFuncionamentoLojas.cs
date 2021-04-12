using ExpedienteLojas.Negocio.Classes;
using ExpedienteLojas.Negocio.Enum;
using System;

namespace ExpedienteLojas.Negocio.Interfaces
{
    public interface IFuncionamentoLojas
    {
        ExpedienteLoja ObterHorariosAtendimento(Loja loja);

        bool EstaAberta(Loja loja, DateTime data);
    }
}