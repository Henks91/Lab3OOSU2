using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Business.Interface;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Business.Classes
{
    public class Medlem : IMedlem
    {
        [Key]
        public int MedlemsId { get; set; }
        public string Namn { get; set; }
        public string TelefonNr { get; set; }
        public string Epost { get; set; }
    }
}
