using iMedOneDB.Models;
using PatientRegistration.Model;
using PatientRegistration.Service.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace  PatientRegistration.Service.Services
{
    public class PatientRegistrationService : IPatientRegistrationService
    {
        public Task<bool> RegisterPatientDataAsync(PatientDataModel patient)
        {
            var checkPatientExist = iMedOneDB.DBContext.GetData<TBLPATIENT>().Any(data=> data.Name == patient.Name && data.SurName == patient.SurName && data.DOB == patient.DOB && data.Gender == patient.Gender);

            if (checkPatientExist)
            {
                return Task.Run(() => false);
            }
                IEnumerable<TBLPATIENT> patientData = new List<TBLPATIENT>() {
                new TBLPATIENT{
                Name = patient.Name,
                SurName = patient.SurName,
                CityId = patient.CityId,
                DOB = patient.DOB,
                Gender = patient.Gender
                }
            };
                iMedOneDB.DBContext.SaveAll<TBLPATIENT>(patientData);
                return Task.Run(() => true );
        }

        public Task<IEnumerable<PatientDataModel>> FetchPatientListAsync()
        {
            return Task.Run(() => iMedOneDB.DBContext.GetData<TBLPATIENT>().Select(data => new PatientDataModel
            {
                Name = data.Name,
                SurName = data.SurName,
                CityId = data.CityId,
                DOB = data.DOB,
                Gender = data.Gender
            }));
        }
    }
}

