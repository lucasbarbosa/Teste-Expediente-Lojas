using ExpedienteLojas.Api.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace ExpedienteLojas.Api.Controllers
{
    [ApiController]
    public abstract class MainApiController : ControllerBase
    {
        private readonly IList<string> _errors;

        public MainApiController()
        {
            _errors = new List<string>();
        }

        protected ActionResult CustomResponse(object result = null)
        {
            if (!ValidOperation())
            {
                return BadRequest(new ResponseViewModel
                {
                    success = false,
                    errors = GetErrors()
                });
            }

            return Ok(new ResponseViewModel
            {
                success = true,
                data = result
            });
        }

        protected bool ValidOperation()
        {
            return !_errors.Any();
        }

        protected void AddError(string error)
        {
            _errors.Add(error);
        }

        protected IList<string> GetErrors()
        {
            return _errors;
        }
    }
}