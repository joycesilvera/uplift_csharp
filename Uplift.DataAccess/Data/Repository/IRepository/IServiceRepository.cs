using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using Uplift.Models;

namespace Uplift.DataAccess.Data.Repository.IRepository
{
    public interface IServiceRepository : IRepository<Service>
    {

        IEnumerable<SelectListItem> GetServiceListForDropDown();

        void Update(Service service);
    }
}