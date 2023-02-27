using Business.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Business.Classes
{
    public class Faktura : IFaktura
    {
        [Key]
        public int FakturaId { get; set; }

        public virtual Bokning Bokning{ get; set; } = null!;

        public virtual Expidit Expidit { get; set; } = null!;
        public DateTime FaktiskÅterTid { get; set; }
        public int TotalPris { get; set; }
        public int DagsKostnad { get; set; }
        
    }
}
