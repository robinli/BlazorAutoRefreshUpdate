using Microsoft.AspNetCore.Mvc;

namespace BlazorPwa.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GetVersionController : ControllerBase
    {
        IConfiguration _configuration;

        public GetVersionController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        /*TODO Blazor Web Assembly PWA Auto Refresh Update Tip 01: API*/
        /// <summary>
        /// https://localhost:7207/GetVersion
        /// </summary>
        /// <returns></returns>
        public async Task<string> Get()
        {
            await Task.Delay(0);
            return _configuration["AppVersion"];
        }
    }
}
