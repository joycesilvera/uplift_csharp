using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Uplift.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Uplift.DataAccess.Data.Repository.IRepository
{
    public interface ICategoryRepository :IRepository<Category>
    {
       
        IEnumerable<SelectListItem> GetCategoryListForDropDown();

        void Update(Category category);

        
    }
}
