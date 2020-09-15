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
    public class StateService : IStateService
    {
        
        public Task<IEnumerable<StateDataModel>> FetchStateListAsync()
        {
            var stateList=iMedOneDB.DBContext.GetData<Tblstate>().Select(data => new StateDataModel
            {
                Id = data.Id,
                Name = data.Name
            });
            return Task.Run(() => stateList);
        }

       
    }
}

