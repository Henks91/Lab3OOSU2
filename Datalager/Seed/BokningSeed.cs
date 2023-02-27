using Microsoft.EntityFrameworkCore;
using Business.Classes;
using System;

namespace DataLayer.Seed
{
    public static class BokningSeed
    {
        public static void Populate(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Expidit>().HasData(
                new Expidit() { AnstId = 1, Namn = "Magnus", Lösenord = "a", Roll = "Biblotikare"},               
                new Expidit() { AnstId = 2, Namn = "Gustaf", Lösenord = "b", Roll = "Biblotikare" },              
                new Expidit() { AnstId = 3, Namn = "Josefin", Lösenord = "c", Roll = "Biblotikare" }
                );

            modelBuilder.Entity<Bok>().HasData(
                new Bok() { Id = 1, ISBN = 1281894, Titel = "Allt är ditt", ÄrTillgänglig = true},
                new Bok() { Id = 2, ISBN = 183943, Titel = "Bröd och Mjölk", ÄrTillgänglig = true },
                new Bok() { Id = 3, ISBN = 3435342, Titel = "Under Magnoliaträden", ÄrTillgänglig = true },
                new Bok() { Id = 4, ISBN = 442312, Titel = "Den andre", ÄrTillgänglig = true },
                new Bok() { Id = 5, ISBN = 342345, Titel = "Icebreaker", ÄrTillgänglig = true },
                new Bok() { Id = 6, ISBN = 656431, Titel = "Harry Potter", ÄrTillgänglig = true },
                new Bok() { Id = 7, ISBN = 333124, Titel = "Det slutar med oss", ÄrTillgänglig = true },
                new Bok() { Id = 8, ISBN = 978554, Titel = "Löpa Varg", ÄrTillgänglig = true },
                new Bok() { Id = 9, ISBN = 1023451, Titel = "Blodmåne", ÄrTillgänglig = true }
                );

            modelBuilder.Entity<Medlem>().HasData(
                new Medlem() {MedlemsId = 10, Namn = "Lukas Blomström", TelefonNr = "073-4235322", Epost = "Lukas.blomström@hotmail.com" },
                new Medlem() {MedlemsId = 11, Namn = "Jack Stenman", TelefonNr = "073-13371337", Epost = "jacksten@gmail.com" },
                new Medlem() {MedlemsId = 12, Namn = "Linn Aschberg", TelefonNr = "073-73317331", Epost = "linn-aschberg@live.se" }
                );                  
        }
    }
}
