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
    [Route("api/cities")]
    public class CityController : ControllerBase
    {
        private readonly ICityService _cityService;


        public CityController(ICityService cityService)
        {
            _cityService = cityService;
        }

        

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var result = await _cityService.FetchCityListAsync(id);
            return Ok(result);
        }
    }
}
