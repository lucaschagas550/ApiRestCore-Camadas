using ApiRestCore.Business.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ApiRestCore.Controllers.V2
{

    [ApiVersion("2.0")]
    [Route("api/v{version:apiVersion}/teste")]
    public class TesteController : MainController
    {
        private readonly ILogger _logger;

        public TesteController(INotificador notificador, IUser appUser) : base(notificador, appUser)
        {
        }

        [HttpGet]
        public string Valor()
        {

            return "Sou a V2";
        }
    }
}
