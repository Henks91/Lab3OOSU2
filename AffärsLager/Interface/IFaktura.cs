using System;
using System.Collections.Generic;
using System.Text;
using Business.Classes;

namespace Business.Interface
{
    public interface IFaktura
    {
        Bokning Bokning { get; set; }

        Expidit Expidit { get; set; }
        DateTime FaktiskÅterTid { get; set; }
        int TotalPris { get; set; }
        int DagsKostnad { get; set; }
    }
}
