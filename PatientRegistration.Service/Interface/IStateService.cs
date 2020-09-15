using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using PatientRegistration.Model;


namespace PatientRegistration.Service.Interfaces
{
    public interface IStateService
    {
        Task<IEnumerable<StateDataModel>> FetchStateListAsync();

    }
}