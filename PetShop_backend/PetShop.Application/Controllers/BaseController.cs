using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PetShop_backend.PetShop.Bussiness.CoreServices.Interfaces;
using PetShop_backend.PetShop.Bussiness.Exceptions;
using PetShop_backend.PetShop.Data.ApplicationModels;

namespace PetShop_backend.PetShop.Application.Controllers
{ 
    [ApiController, Route("[controller]")]
    public class BaseController<T> : ControllerBase where T : class
    {
        private readonly ILogger<T> _logger;
        private readonly ILoggerService _loggerService;

        public BaseController(ILogger<T> logger, ILoggerService loggerService)
        {
            _logger = logger;
            _loggerService = loggerService;
        }

        protected BadRequestObjectResult ValidationErrorsBadRequest(CustomValidationException validationException)
        {
            BaseResponse<Dictionary<string, string>> responseErrors;
            BaseResponse<string> responseMessage;
            BaseResponse<List<Dictionary<string, string>>> responseErrorsList;
            if (validationException.IsStringError)
            {
                responseMessage = BaseResponse<string>
                        .Builder()
                        .SetMessage(validationException.Message)
                        .SetData("")
                    ;
                return BadRequest(responseMessage);
            }

            if (validationException.ErrorsList == null || validationException.ErrorsList.Count == 0)
            {
                responseErrors = BaseResponse<Dictionary<string, string>>.Builder()
                        .SetMessage("Informe os dados corretamente.")
                        .SetData(validationException.Errors)
                    ;
                return BadRequest(responseErrors);
            }

            responseErrorsList = BaseResponse<List<Dictionary<string, string>>>.Builder()
                    .SetMessage("Informe os dados corretamente.")
                    .SetData(validationException.ErrorsList)
                ;
            return BadRequest(responseErrorsList);
        }

        protected async Task<ObjectResult> UntreatedException(Exception exception)
        {
            await _loggerService.LogErrorServicesBackground(exception);
            Console.WriteLine(exception.Message);
            BaseResponse<string> response;
            response = BaseResponse<string>.Builder()
                    .SetMessage(
                        "Ocorreu um erro durante o processamento da sua solicitação. Tente novamente dentro de alguns minutos. Se o problema persistir, contate o administrador do sistema."
                    )
                    .SetData("")
                ;
            return StatusCode(500, response);
        }

        protected async Task<ObjectResult> NotFoundResponse(RecordNotFoundExceptions exception)
        {
            await _loggerService.LogErrorServicesBackground(exception);
            Console.WriteLine(exception.Message);
            BaseResponse<string> response;
            response = BaseResponse<string>.Builder()
                    .SetMessage(
                        "Nenhum registro foi encontrado."
                    )
                    .SetData("")
                ;
            return StatusCode(404, response);
        }
        protected BadRequestObjectResult ValidationErrorsWithDataBadRequest<TG>(ValidationExceptionWithData<TG> exception)
        {
            BaseResponse<TG> response;
            response = BaseResponse<TG>.Builder()
                .SetMessage(exception.Message)
                .SetData(exception.GetData())
            ;
            return BadRequest(response);
        }
    }
}