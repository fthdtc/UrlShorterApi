using Microsoft.AspNetCore.Mvc;
using UrlShorterApi.Entity.Model;
using UrlShorterApi.Service.Service;

namespace UrlShorterApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UrlController : ControllerBase
    {
        private readonly ILogger<UrlController> _logger;
        private readonly IUrlShorterService _urlShorterService;

        public UrlController(ILogger<UrlController> logger, IUrlShorterService urlShorterService)
        {
            _logger = logger;
            _urlShorterService = urlShorterService;
        }

        [HttpPost("Short")]
        public async Task<ActionResult> Short(ShortModel model)
        {
            return Ok(await _urlShorterService.ShortUrlAsync(model));
        }

        [HttpPost("Redirect")]
        public async Task<ActionResult> Redirect(RedirectModel model)
        {
            return Ok(await _urlShorterService.RedirectUrlAsync(model));
        }

        [HttpPost("Custom")]
        public async Task<ActionResult> Custom(CustomModel model)
        {
            return Ok(await _urlShorterService.CustomUrlAsync(model));
        }
    }
}
