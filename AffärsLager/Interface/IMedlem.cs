using System;
using System.Collections.Generic;
using System.Text;
using Business.Classes;

namespace Business.Interface
{
    public interface IMedlem
    {
        int MedlemsId { get; set; }
        string Namn { get; set; }
        string TelefonNr { get; set; }
        string Epost { get; set; }
        //List<Bokning> Bokad { get; set; }
    }
}
