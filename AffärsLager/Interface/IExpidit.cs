using Business.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Interface
{
    public interface IExpidit
    {
        int AnstId { get; set; }
        string Namn { get; set; }
        string Lösenord { get; set; }
        string Roll { get; set; }
        //List<Bokning> Bokningar { get; set; }
    }
}
