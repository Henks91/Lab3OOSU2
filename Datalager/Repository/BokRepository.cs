using Business.Classes;
using DataLayer.InterfaceRepository;
using System;
using System.Collections.Generic;
using System.Text;
using DataLayer.Context;

namespace DataLayer.Repository
{
    public class BokRepository : Repository<Bok>, IBokRepository
    {
        public BokningDbContext BokningDbContext { get; }
        public BokRepository(BokningDbContext bokningDbContext) : base(bokningDbContext)
        {
            BokningDbContext = bokningDbContext;
        }

        
    }
}
