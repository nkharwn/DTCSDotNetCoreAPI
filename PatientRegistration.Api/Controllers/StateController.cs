using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using Microsoft.AspNetCore.Cors;
using PatientRegistration.Service.Interfaces ;

namespace PatientRegistration.Api.Controllers
{
    [Route("api/states")]
    public class StateController : ControllerBase
    {
        private readonly IStateService _stateService;


        public StateController(IStateService stateService)
        {
            _stateService = stateService;
        }

        

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _stateService.FetchStateListAsync();
            return Ok(result);
        }
    }
}
