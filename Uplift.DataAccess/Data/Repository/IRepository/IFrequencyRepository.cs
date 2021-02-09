using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using Uplift.Models;

namespace Uplift.DataAccess.Data.Repository.IRepository
{
    public interface IFrequencyRepository : IRepository<Frequency>
    {

        IEnumerable<SelectListItem> GetFrequencyListForDropDown();

        void Update(Frequency frequency);
    }
}