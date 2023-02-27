using Business.Classes;
using DataLayer.Context;
using DataLayer.InterfaceRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Repository
{
    public class MedlemRepository : Repository<Medlem>, IMedlemRepository
    {
        public BokningDbContext BokningDbContext { get; }
        public MedlemRepository(BokningDbContext bokningDbContext) : base(bokningDbContext)
        {
            BokningDbContext = bokningDbContext;
        }
    }
}
