﻿using Microsoft.AspNetCore.Mvc;
using Plugins.SmaEnergymeter.Services;

namespace Plugins.SmaEnergymeter.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CurrentPowerController : ControllerBase
    {
        private readonly CurrentPowerService _currentPowerService;

        public CurrentPowerController(CurrentPowerService currentPowerService)
        {
            _currentPowerService = currentPowerService;
        }

        [Obsolete]
        [HttpGet]
        public int GetCurrentPower(int lastXSeconds = 0)
        {
            return _currentPowerService.GetCurrentPower();
        }

        [Route("[action]")]
        [HttpGet]
        public int GetPower()
        {
            return _currentPowerService.GetCurrentPower();
        }
    }
}
