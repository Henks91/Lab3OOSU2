using Business.Classes;
using DataLayer.InterfaceRepository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DataLayer.Context;

namespace DataLayer.Repository
{
    public class BokningRepository : Repository<Bokning>, IBokningRepository
    {
        public BokningDbContext BokningDbContext { get; }
        public BokningRepository(BokningDbContext bokningDbContext) :base(bokningDbContext)
        {
            BokningDbContext = bokningDbContext;
        }
        public bool Upphämtad()
        {
            return true;
        }

        
    }
}
