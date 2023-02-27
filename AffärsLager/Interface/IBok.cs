using Business.Classes;
using System;
using System.Collections.Generic;
using System.Text;


namespace Business.Interface
{
    public interface IBok 
    {
        int Id { get; set; }
        string Titel { get; set; }
        int ISBN { get; set; }
        bool ÄrTillgänglig { get; set; }

    }
}
