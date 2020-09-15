using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Xunit;
using PatientRegistration.Service.Services;
using PatientRegistration.Service.Interfaces;
using PatientRegistration.Model;
namespace patientRegistration.Service.Tests
{
    public class PatientRegistrationServiceTest
    {
        private readonly IPatientRegistrationService _service;
        public PatientRegistrationServiceTest()
    {
        _service = new PatientRegistrationService();
    }
       

        [Fact]
        public async Task Fetch_WhenCalled_ReturnPatientData()
        {
            var result = await _service.FetchPatientListAsync();
            // Assert
            Assert.True(result.Count()>0);
            

        }

        [Fact]
        public async Task Register_WhenCalled_ReturnTrueValue()
        {
          var patientDetail=  new PatientDataModel
            {
                Name = "Allen",
                SurName = "Jose",
                CityId = 1,
                DOB = DateTime.Now,
                Gender ="M"
            };
            var result = await _service.RegisterPatientDataAsync(patientDetail);
            
            Assert.True(result);

        }
    }
}
