using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FarmManagement.Web.Models;

namespace FarmManagement.Web.Services
{
    public class FarmManager : IFarmManager
    {
        public IEnumerable<ContactorStatusViewModel> GetCurrentStatus()
        {
            List<ContactorStatusViewModel> status = new List<ContactorStatusViewModel>();
            ContactorStatusViewModel c1 = new ContactorStatusViewModel
            {
                name = "c1",
                status = true
            };

            status.Add(c1);
            return status;
        }

        public bool UpdateContactorStates(IEnumerable<ContactorStatusViewModel> model)
        {
            return true;
        }
    }
}
