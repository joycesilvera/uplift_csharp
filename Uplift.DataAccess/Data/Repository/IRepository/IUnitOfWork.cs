using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;


namespace Uplift.DataAccess.Data.Repository.IRepository
{
    //all transactions, access to all repos, safe method to push all changes to database
    public interface IUnitOfWork : IDisposable
    {

        //whenever you add a new repository, you have to add it here
        ICategoryRepository Category { get; }
        IFrequencyRepository Frequency { get; }
        void Save();

        //check
    }
}
