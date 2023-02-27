using System;
using System.Collections.Generic;
using System.Text;
using Business.Interface;
using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace Business.Classes
{
    public class Bok : IBok
    {
        [Key]
        public int Id { get; set; }
        public string Titel { get; set; }
        public int ISBN { get; set; }
        public bool ÄrTillgänglig { get; set; }

        public void Tillgänglig()
        {
            ÄrTillgänglig = true;
        }
        public void Bokad()
        {
            ÄrTillgänglig = false;
        }
    }
}
