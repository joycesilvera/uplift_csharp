using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;
using Uplift.Models;

namespace Uplift.DataAccess.Data.Repository
{
    public class ServiceRepository
    {
        private readonly ApplicationDbContext _db;

        public ServiceRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public IEnumerable<SelectListItem> GetServiceListForDropDown()
        {
            return _db.Frequency.Select(i => new SelectListItem()
            {
                Text = i.Name,
                Value = i.Id.ToString()
            });
        }

        public void Update(Service service)
        {
            var objFromDb = _db.Service.FirstOrDefault(s => s.Id == service.Id);

            objFromDb.Name = service.Name;
            objFromDb.LongDesc = service.LongDesc;
            objFromDb.Price = service.Price;
            objFromDb.ImageUrl = service.ImageUrl;
            objFromDb.FrequencyId = service.FrequencyId;
            objFromDb.CategoryId = service.CategoryId;

            _db.SaveChanges();

        }
    }
}
