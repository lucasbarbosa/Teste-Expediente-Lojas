using ExpedienteLojas.Api.Controllers;
using ExpedienteLojas.Negocio.Classes;
using ExpedienteLojas.Negocio.Enum;
using ExpedienteLojas.Negocio.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ExpedienteLojas.Api.V1.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class ExpedienteLojasController : MainApiController
    {
        private readonly IFuncionamentoLojas _funcionamentoLojas;
        
        public ExpedienteLojasController(IFuncionamentoLojas funcionamentoLojas)
        {
            _funcionamentoLojas = funcionamentoLojas;
        }

        [HttpGet("GetExpediente")]
        public ActionResult<ExpedienteLoja> GetExpediente(Loja loja)
        {
            try
            {
                var expediente = _funcionamentoLojas.ObterHorariosAtendimento(loja);

                return CustomResponse(expediente);
            }
            catch (Exception ex)
            {
                AddError(ex.Message);

                return CustomResponse();
            }
        }

        [HttpGet("GetLojaAberta")]
        public ActionResult<bool> GetLojaAberta(Loja loja, DateTime data)
        {
            try
            {
                var estaAberta = _funcionamentoLojas.EstaAberta(loja, data);

                return CustomResponse(estaAberta);
            }
            catch (Exception ex)
            {
                AddError(ex.Message);

                return CustomResponse();
            }
        }
    }
}