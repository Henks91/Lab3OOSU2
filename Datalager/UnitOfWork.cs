using System;
using DataLayer.Context;
using DataLayer.InterfaceRepository;
using DataLayer.Repository;

namespace DataLayer
{
    public class UnitOfWork : IUnitOfWork
    {
        private bool isDisposed = false;
        private readonly bool disposeContext = false;
        protected BokningDbContext _dbContext { get; }

        private IBokRepository bok = null;
        public IBokRepository Bok => bok ??= new BokRepository(_dbContext);

        private IBokningRepository bokning = null;
        public IBokningRepository Bokning => bokning ??= new BokningRepository(_dbContext);

        private IExpiditRepository expidit = null;
        public IExpiditRepository Expidit => expidit ??= new ExpiditRepository(_dbContext);

        private IFakturaRepository faktura = null;
        public IFakturaRepository Faktura => faktura ??= new FakturaRepository(_dbContext);

        private IMedlemRepository medlem = null;
        public IMedlemRepository Medlem => medlem ??= new MedlemRepository(_dbContext);

        public UnitOfWork() : this(new BokningDbContext())
        {
            disposeContext = true;
        }
        public UnitOfWork(BokningDbContext bokningDbContext) 
        {
            _dbContext = bokningDbContext;
        }
        public int Complete()
        {
            return _dbContext.SaveChanges();
        }
        public void Dispose()
        {
            Dispose(true);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (isDisposed)
            {
                return;
            }
            if (disposing)
            {
                if (disposeContext)
                {
                    _dbContext.Dispose();
                }
            }
            isDisposed = true;
        }
        ~UnitOfWork()
        {
            Dispose(false);
        }
    }
}
