using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Uplift.DataAccess.Data.Repository.IRepository;

namespace Uplift.DataAccess.Data.Repository
{
    public class UnitOfWork : IUnitOfWork
    {

        public ICategoryRepository Category { get; private set; }
        public IFrequencyRepository Frequency { get; private set; }

        private readonly ApplicationDbContext _db;

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Category = new CategoryRepository(_db);
            Frequency = new FrequencyRepository(_db);
        }

        void IDisposable.Dispose()
        {
            _db.Dispose();
        }

        void IUnitOfWork.Save()
        {
            _db.SaveChanges();
        }
    }
}
