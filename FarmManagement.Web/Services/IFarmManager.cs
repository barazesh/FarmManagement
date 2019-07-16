using FarmManagement.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FarmManagement.Web.Services
{
    public interface IFarmManager
    {
        IEnumerable<ContactorStatusViewModel> GetCurrentStatus();
        bool UpdateContactorStates(IEnumerable<ContactorStatusViewModel> model);
    }
}
