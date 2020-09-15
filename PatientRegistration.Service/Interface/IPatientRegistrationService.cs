using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using PatientRegistration.Model;


namespace PatientRegistration.Service.Interfaces
{
    public interface IPatientRegistrationService
    {
        Task<bool> RegisterPatientDataAsync(PatientDataModel patient);

        Task<IEnumerable<PatientDataModel>> FetchPatientListAsync();
    }
}