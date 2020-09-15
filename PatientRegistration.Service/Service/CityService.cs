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
    public class CityService : ICityService
    {
        
        public Task<IEnumerable<CityDataModel>> FetchCityListAsync(int stateId)
        {
            return Task.Run(() => iMedOneDB.DBContext.GetData<Tblcity>().Where(data=>data.StateId==stateId).Select(data => new CityDataModel
            {
                Id = data.Id,
                Name = data.Name
            }));
        }

       
    }
}

