using Business.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Interface
{
    public interface IBokning
    {
        int BokningId { get; set; }

        Expidit Expidit { get; set; }
        Medlem Medlem { get; set; }
        IList<Bok> BokadeBöcker { get; set; }
        DateTime StartLån { get; set; }  // Det datum som skrivs in när man först planerar att boka boken ifrån i menyval 1
        DateTime FaktisktStartLån { get; set; } //När boken faktiskt blev upphämtad av medlem, tex om upphämtning sker någon dag efter önskat startdatum på bokningen som angavs under menyval 1.
        DateTime ÅterTid { get; set; } //När boken ska vara tillbaka lämnad, 14 dagar efter startdatum för bokningen
        bool UppHämtad { get; set; }
    }
}
