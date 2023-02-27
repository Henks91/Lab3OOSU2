using Business.Classes;
using DataLayer.Context;
using DataLayer.InterfaceRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Repository
{
    public class FakturaRepository : Repository<Faktura>, IFakturaRepository
    {
        public BokningDbContext BokningDbContext { get; }
        public FakturaRepository(BokningDbContext bokningDbContext) : base(bokningDbContext)
        {
            BokningDbContext = bokningDbContext;
        }
    }
}
