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
    public class StateServiceTest
    {
        private readonly IStateService _service;
        public StateServiceTest()
    {
        _service = new StateService();
    }
       

        [Fact]
        public async Task Fetch_WhenCalled_ReturnStateData()
        {
            var result = await _service.FetchStateListAsync();
            // Assert
            Assert.True(result.Count()>0);
            

        }

        
    }
}
