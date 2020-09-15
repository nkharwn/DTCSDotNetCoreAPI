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
    public class CityServiceTest
    {
        private readonly ICityService _service;
        public CityServiceTest()
    {
        _service = new CityService();
    }
       

        [Fact]
        public async Task Fetch_WhenCalled_ReturnCityData()
        {
            var result = await _service.FetchCityListAsync(1);
            // Assert
            Assert.True(result.Count()>0);
            

        }

        
    }
}
