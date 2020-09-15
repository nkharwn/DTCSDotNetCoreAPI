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
using PatientRegistration.Model;

namespace PatientRegistration.Api.Controllers
{
    [Route("api/Patients")]
    public class PatientRegistrationController : ControllerBase
    {
        private readonly IPatientRegistrationService _patientRegistrationService;


        public PatientRegistrationController(IPatientRegistrationService patientRegistrationService)
        {
            _patientRegistrationService = patientRegistrationService;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] PatientDataModel value)
        {
            var result = await _patientRegistrationService.RegisterPatientDataAsync(value);
            if (result)
                return Ok();
            else
                return UnprocessableEntity();
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _patientRegistrationService.FetchPatientListAsync();
            return Ok(result);
        }
    }
}
