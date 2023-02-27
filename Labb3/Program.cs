using DataLayer;
using DataLayer.Context;
using System;
using DataLayer.Seed;
using Business.Classes;
using Microsoft.EntityFrameworkCore;
using GUI;
using System.Windows.Forms;

namespace TestLabb2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
            
            BokningSeed.Populate(bokningDbContext);
            BokningSeed.Populate(bokningDbContext);


        }
    }
}
