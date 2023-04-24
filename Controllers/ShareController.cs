using Microsoft.AspNetCore.Mvc;
using Shareasy.Models;
using Shareasy.Services.Interfaces;
using System.Text.Json;

namespace Shareasy.Controllers
{
    [ApiController]
    [Route("api/share")]
    public class ShareController : ControllerBase
    {
        private readonly ILogger<ShareController> _logger;
        private readonly IShareService _shareService;

        public ShareController(ILogger<ShareController> logger, IShareService shareService)
        {
            _logger = logger;
            _shareService = shareService;
        }

        [HttpGet("new", Name = "New")]
        public IActionResult New()
        {
            Share share = _shareService.CreateNewInstance();
            return Ok(JsonSerializer.Serialize(share));
        }

        [HttpGet("{code:regex([[A-Z0-9]]):length(5)}", Name = "View")]
        public string View(string code)
        {
            return "Você está na página do hash: " + code;
        }
    }
}