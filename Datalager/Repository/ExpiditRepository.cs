using Business.Classes;
using DataLayer.Context;
using DataLayer.InterfaceRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Repository
{
    public class ExpiditRepository : Repository<Expidit>, IExpiditRepository
    {
        public BokningDbContext BokningDbContext { get; }
        public ExpiditRepository(BokningDbContext bokningDbContext) : base(bokningDbContext)
        {
            BokningDbContext = bokningDbContext;
        }
    }
}
