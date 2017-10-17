using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WestPi.Remote.Helpers;
using WestPi.Remote.Models;

namespace WestPi.Remote.Controllers
{
    [Route("api/[controller]")]
    public class VolumeController : Controller
    {
        private readonly ICommandService _commandService;

        public VolumeController(ICommandService commandService)
        {
            _commandService = commandService;
        }

        [HttpGet]
        [ProducesResponseType(typeof(VolumeStatus), 200)]
        public async Task<IActionResult> GetVolumeAsync()
        {
            return Json(await _commandService.GetVolumeAsync());
        }

        [HttpPut("{percent}")]
        [ProducesResponseType(typeof(VolumeStatus), 200)]
        public async Task<IActionResult> RaiseVolumeAsync(int percent)
        {
            return Json(await _commandService.SetVolumeAsync(percent));
        }
    }
}
