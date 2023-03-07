using System;
using System.Collections.Generic;
using System.Linq;
using Business.Classes;
using Business.Interface;
using DataLayer;
using DataLayer.Context;
using Microsoft.EntityFrameworkCore;

namespace BusinessLayer
{
    public class Kontroller
    {
        public Kontroller() { }

        public UnitOfWork UnitOfWork
        {
            get => default;
            set
            {
            }
        }

        public DataLayer.InterfaceRepository.Repository<object> Repository
        {
            get => default;
            set
            {
            }
        }
        #region LaddaData
        /// <LaddaData-kommentar>
        /// Denna metod används för att reseta och skapa en databas i kontrollern för att inte resetta och skapa databasen i GUI.
        /// </LaddaData-kommentar>
        public void LaddaData()
        {
            BokningDbContext DbContext = new BokningDbContext();
            //DbContext.Reset();
            DbContext.Database.EnsureCreated();
        }
        #endregion
        #region Inloggning
        /// <summary>
        /// Här kontrolleras användarens input i login mot den populerade data som finns i databasen.
        /// Expidit matchas mot AnstId och Lösenord i en FirstOrDefault-metod i databasen och returneras till GUI.
        /// </summary>
        /// <param name="anstNr"></param>
        /// <param name="lösenord"></param>
        /// <returns></returns>
        public Expidit Inloggning(int anstNr, string lösenord)
        {
            using (UnitOfWork unit = new UnitOfWork())
            {
                Expidit expidit = unit.Expidit.FirstOrDefault(e => e.AnstId == anstNr && e.Lösenord == lösenord);
                return expidit;
            }
        }
        #endregion
        #region HämtaTillgängligaBöcker
        /// <HämtaTillgängligaBöcker-kommentar>
        /// Här hämtas tillgängliga böcker för bokning som matchas på property "ÄrTillgänglig == true" och returneras i en IList<> till GUI.
        /// </HämtaTillgängligaBöcker-kommentar>
        /// <returns></returns>
        public IList<Bok> HämtaTillgängligaBöcker()
        {
            using (UnitOfWork unit = new UnitOfWork())
            {
                return unit.Bok.Find(z => z.ÄrTillgänglig == true).ToList();
            }
        }

        public IList<Bok> HämtaAllaBöcker()
        {
            using (UnitOfWork unit = new UnitOfWork())
            {
                return unit.Bok.GetAll().Where(z=> z.ÄrTillgänglig == true).ToList();
            }
        }
        #endregion
        #region SkapaBokning
        /// <SkapaBokning-kommentar>
        /// I denna metod skapas en bokning och för varje bok i bokningen så sätts ÄrTillgänglig till false. 
        /// Bokningen och böckerna uppdateras i databasen. 
        /// Bokningen placeras i en List<> som returneras till GUI.
        /// </SkapaBokning-kommentar>
        /// <param name="medlem"></param>
        /// <param name="exp"></param>
        /// <param name="startlån"></param>
        /// <param name="bokadeBöcker"></param>
        /// <returns></returns>
        public Bokning SkapaBokning(Medlem medlem, Expidit exp, DateTime startlån, IList<Bok> bokadeBöcker)
        {

            using (UnitOfWork unit = new UnitOfWork())
            {
                List<Bokning> bokningList = new List<Bokning>();
                Bokning bokning = new Bokning()
                {
                    BokningId = default,
                    Expidit = exp,
                    Medlem = medlem,
                    BokadeBöcker = bokadeBöcker,
                    StartLån = startlån,
                    FaktisktStartLån = default(DateTime),
                    ÅterTid = default(DateTime),
                    UppHämtad = false
                };
               
                foreach (Bok bok in bokadeBöcker)
                {
                    bok.ÄrTillgänglig = false;
                    unit.Bok.Update(bok);
                    unit.Complete();

                }
                bokningList.Add(bokning);
                unit.Bokning.Update(bokning);
                unit.Complete();
                return bokning;
            }
        }
        #endregion
        #region HämtaUtBokning
        /// <HämtaUtBokning-Kommentar>
        /// Här uppdateras bool värden och DateTime för bokningen som skapades.
        /// Bokningen "hämtas ut", uppdateras och sparas till databasen.
        /// </HämtaUtBokning-Kommentar>
        /// <param name="bokning"></param>
        public void HämtaUtBokning(Bokning bokning)
        {
            using (UnitOfWork unit = new UnitOfWork())
            {
                bokning.UppHämtad = true;
                bokning.Återlämnad = false;
                bokning.FaktisktStartLån = DateTime.Now; //Eftersom att det sätts som DateTime.Now här så är det ett mer verklighetsbaserat exempel av en applikation. 
                bokning.ÅterTid = DateTime.Now.AddDays(14); //Därav kommer priset alltid att bli 0kr vid simulering. 
                unit.Bokning.Update(bokning); //Sätt bokning.FaktisktStartLån = bokning.StartLån; och bokning.ÅterTid = bokning.FaktisktStartLån.AddDays(14); för att kunna få ut prisvid tidigare valt datum.
                unit.Complete();
            }
        }
        #endregion
        #region HittaMedlem
        /// <HittaMedlem-Kommentar>
        /// Här hämtas ett objekt av en medlem från databasen och returneras till GUI.
        /// Medlemen matchas med medlemsId i en FirstOrDefault-metod.
        /// </HittaMedlem-Kommentar>
        /// <param name="medlemId"></param>
        /// <returns></returns>
        
        //public Medlem Hittamedlem(int medlemId)
        //{
        //    using (UnitOfWork unit = new UnitOfWork())
        //    {
        //        Medlem medlem = unit.Medlem.FirstOrDefault(e => e.MedlemsId == medlemId);

        //        return medlem;
        //    }
        //}                  **Orginalet**
     
        public IList<Medlem> Hittamedlem()
        {
            using (UnitOfWork unit = new UnitOfWork())
            {
                return unit.Medlem.GetAll().ToList();
            }
        }
       
        #endregion
        #region SkapaFaktura
        /// <SkapaFaktura-kommentar>
        /// Här hämtas en bokning från databasen.
        /// Bokningen matchas med antingen bokningsId eller medlemsId i en FirstOrDefault-metod.
        /// Om bokningen inte redan är återlämnad så startas skapande av ett nytt objekt av faktura.
        /// För varje bok i bokningens bokadeBöcker uppdateras ÄrTillgänglig till true i databasen.
        /// Objektet av faktura läggs till i databasen.
        /// Objektet av faktura placeras i en List<> som returneras till GUI för visning.
        /// </SkapaFaktura-kommentar>
        /// <param name="expidit"></param>
        /// <param name="bNr"></param>
        /// <returns></returns>
        public List<Faktura> SkapaFaktura(Expidit expidit, int bNr)
        {
            using (UnitOfWork unit = new UnitOfWork())
            {
                Bokning bokning2 = unit.Bokning.FirstOrDefault(b => b.BokningId == bNr || b.Medlem.MedlemsId == bNr); 
                
                if (bokning2.Återlämnad == false)
                {
                    int antalBöcker = bokning2.BokadeBöcker.Count();
                    List<Faktura> fakturaList = new List<Faktura>();
                    int uträkningPris = ((int)(DateTime.Now - bokning2.ÅterTid).TotalDays) * (10 * antalBöcker);
                    if (uträkningPris < 0)
                    {
                        uträkningPris = 0;
                    }
                    Faktura faktura = new Faktura()
                    {
                        Bokning = bokning2,
                        Expidit = expidit,
                        FaktiskÅterTid = DateTime.Now,
                        TotalPris = uträkningPris

                    };
                    foreach (Bok bok in bokning2.BokadeBöcker)
                    {
                        bok.ÄrTillgänglig = true;
                        unit.Bok.Update(bok);
                        unit.Complete();
                    }
                    bokning2.Återlämnad = true;
                    unit.Faktura.Update(faktura);
                    unit.Complete();
                    fakturaList.Add(faktura);
                    return fakturaList;
                }
                else
                {
                    return null;
                }
            }
        }

        public Expidit HämtaExpidit(int expNr)
        {
            using (UnitOfWork unit = new UnitOfWork())
            {
                Expidit expidit = unit.Expidit.FirstOrDefault(e => e.AnstId == expNr);

                return expidit;
            }
        }
        #endregion
        #region HämtaBokning
        /// <HämtaBokning-kommentar>
        /// Här hämtas en bokning från databasen som returneras till GUI.
        /// Bokningen matchas med antingen bokningsId eller medlemsId i en FirstOrDefault-metod.
        /// </HämtaBokning-kommentar>
        /// <param name="EttNr"></param>
        /// <returns></returns>
        //public IList<Bokning> HämtaBokning(int EttNr)
        //{
        //    using (UnitOfWork unit = new UnitOfWork())
        //    {
        //        List<Bokning> bokning = new List<Bokning>();
                
        //        Bokning b = unit.Bokning.FirstOrDefault(b => b.BokningId == EttNr 
        //        || b.Medlem.MedlemsId == EttNr);

        //        bokning.Add(b);


        //        return bokning;
        //    }
        //}     **Orginalet**

        public Bokning HämtaBokning(int bId)
        {
            using (UnitOfWork unit = new UnitOfWork())
            {
                return unit.Bokning.FirstOrDefault(z => z.BokningId == bId);
            }
        }
        #endregion
        #region HämtaBokningensBöcker
        /// <HämtaBokningensBöcker-kommentar>
        /// Här skapas en temporär List<Bok>.
        /// Bokning matchas med antingen bokningsId eller medlemsId i en FirstOrDefault-metod i databasen.
        /// Varje bok i bokningens bokadeBöcker läggs till i den temporära List<Bok> som returneras till GUI.
        /// </HämtaBokningensBöcker-kommentar>
        /// <param name="bNr"></param>
        /// <returns></returns>
        //public List<Bok> HämtaBokningensBöcker(int bNr)
        //{
        //    List<Bok> bikbok = new List<Bok>();
        //    using (UnitOfWork unit = new UnitOfWork())
        //    {
        //        Bokning bokning2 = unit.Bokning.FirstOrDefault(b => b.BokningId == bNr || b.Medlem.MedlemsId == bNr);

        //        foreach (Bok b in bokning2.BokadeBöcker)
        //        {
        //            bikbok.Add(b);
        //        }
        //        return bikbok;
        //    }
        //}       **Orginalet**

        public IList<Bok> HämtaBokningensBöcker(int EttNr)
        {
            List<Bok> bikbok = new List<Bok>();
            using (UnitOfWork unit = new UnitOfWork())
            {
                Bokning bokning2 = unit.Bokning.FirstOrDefault(b => b.BokningId == EttNr || b.Medlem.MedlemsId == EttNr);

                foreach (Bok b in bokning2.BokadeBöcker)
                {
                    bikbok.Add(b);
                }
                return bikbok;
            }
        }
        #endregion
    }
}