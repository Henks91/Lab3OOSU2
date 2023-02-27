using Business.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace Business.Classes
{
    public class Expidit : IExpidit
    {
        [Key]
        public int AnstId { get; set; }
        public string Namn { get; set; }
        public string Lösenord { get; set; }
        public string Roll { get; set; }
       
        public bool Lösenordskontroll(string försök)
        {
            return Lösenord == försök;
        }

        public string HämtaLösenord()
        {
            string returLösen = Lösenord;
            return returLösen;
        }
    }
}
