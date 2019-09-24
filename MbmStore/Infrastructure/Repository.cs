using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MbmStore.Models;

namespace MbmStore.Infrastructure
{
    public static class Repository
    {
        public static List<Product> Products = new List<Product>();
        public static List<Invoice> Invoices = new List<Invoice>();

        static Repository()
        {
            Book book1 = new Book(4, "George R. R. Martin", "Fire and Blood", 9.99m, 1997, "123456", "book01.jpg");
            book1.Category = "Book";
            Book book2 = new Book(5, "George R. R. Martin", "The Mystery Knight", 19.99m, 1998, "654321", "book02.jpg");
            book2.Category = "Book";
            Book book3 = new Book(6, "George R. R. Martin", "A Feast for Crows", 29.99m, 1999, "321654", "book03.jpg");
            book3.Category = "Book";

            MusicCD cd1 = new MusicCD(7, "Metallica", "Load", 50.60m, 1996, "cd01.jpg");
            cd1.Category = "Music";
            Track track1 = new Track("Ain't my bitch", "Metallica", new TimeSpan(0, 5, 04));
            Track track2 = new Track("2 X 4", "Metallica", new TimeSpan(0, 5, 28));
            Track track3 = new Track("The house Jack built", "Metallica", new TimeSpan(0, 6, 39));
            Track track4 = new Track("Until it sleeps", "Metallica", new TimeSpan(0, 4, 28));
            Track track5 = new Track("King Nothing", "Metallica", new TimeSpan(0, 5, 30));
            Track track6 = new Track("Hero of the day", "Metallica", new TimeSpan(0, 4, 22));
            Track track7 = new Track("Bleeding me", "Metallica", new TimeSpan(0, 8, 18));

            MusicCD cd2 = new MusicCD(8, "Megadeth", "Countdown to Extinction", 55.60m, 1965, "cd02.jpg");
            cd2.Category = "Music";
            Track track8 = new Track("Skin o'My Teeth", "Megadeth", new TimeSpan(0, 3, 14));
            Track track9 = new Track("Symphony of Destruction", "Megadeth", new TimeSpan(0, 4, 02));
            Track track10 = new Track("Architecture of Aggression", "Megadeth", new TimeSpan(0, 3, 34));
            Track track11 = new Track("Foreclosure of a dream", "Megadeth", new TimeSpan(0, 4, 17));
            Track track12 = new Track("Sweating bullets", "Megadeth", new TimeSpan(0, 5, 03));
            Track track13 = new Track("This was my life", "Megadeth", new TimeSpan(0, 3, 42));
            Track track14 = new Track("Countdown to Extinction", "Megadeth", new TimeSpan(0, 4, 16));

            MusicCD cd3 = new MusicCD(9, "W.A.S.P.", "The Headless Children", 59.60m, 1970, "cd03.jpg");
            cd3.Category = "Music";
            Track track15 = new Track("The Heretic", "W.A.S.P.", new TimeSpan(0, 7, 16));
            Track track16 = new Track("The real me", "W.A.S.P.", new TimeSpan(0, 3, 21));
            Track track17 = new Track("The headless children", "W.A.S.P.", new TimeSpan(0, 5, 47));
            Track track18 = new Track("Thunderhead", "W.A.S.P.", new TimeSpan(0, 6, 45));
            Track track19 = new Track("Mean Man", "W.A.S.P.", new TimeSpan(0, 4, 50));
            Track track20 = new Track("The Neutron Bomber", "W.A.S.P.", new TimeSpan(0, 4, 04));
            Track track21 = new Track("Mephisto Waltz", "W.A.S.P.", new TimeSpan(0, 1, 26));

            Movie movie1 = new Movie(10, "Jungle Book", 160.50m, "junglebook.jpg", "Jon Favreau");
            movie1.Category = "Movie";
            Movie movie2 = new Movie(11, "Gladiator", 120.60m, "gladiator.jpg", "Ryan Coogler");
            movie2.Category = "Movie";
            Movie movie3 = new Movie(12, "Forrest Gump", 180.50m, "forrest-gump.jpg", "James Gunn");
            movie3.Category = "Movie";

            cd1.AddTrack(track1);
            cd1.AddTrack(track2);
            cd1.AddTrack(track3);
            cd1.AddTrack(track4);
            cd1.AddTrack(track5);
            cd1.AddTrack(track6);
            cd1.AddTrack(track7);

            cd2.AddTrack(track8);
            cd2.AddTrack(track9);
            cd2.AddTrack(track10);
            cd2.AddTrack(track11);
            cd2.AddTrack(track12);
            cd2.AddTrack(track13);
            cd2.AddTrack(track14);

            cd3.AddTrack(track15);
            cd3.AddTrack(track16);
            cd3.AddTrack(track17);
            cd3.AddTrack(track18);
            cd3.AddTrack(track19);
            cd3.AddTrack(track20);
            cd3.AddTrack(track21);

            Products.Add(movie1);
            Products.Add(movie2);
            Products.Add(movie3);

            Products.Add(book1);
            Products.Add(book2);
            Products.Add(book3);

            Products.Add(cd1);
            Products.Add(cd2);
            Products.Add(cd3);

            Customer cust1 = new Customer("Marina", "Doholici", "Grofhojparken", "8260", "Viby J", Convert.ToDateTime("1996.08.20"));
            Customer cust2 = new Customer("Menalas", "Smith", "Neptunvej", "8270", "Hojbjerg", Convert.ToDateTime("1996.02.05"));

            Invoice invoice1 = new Invoice(1, new DateTime(2018, 09, 18), cust1);
            Invoice invoice2 = new Invoice(2, new DateTime(2018, 09, 19), cust2);

            invoice1.AddOrderItem(book1, 1);
            invoice1.AddOrderItem(book2, 2);

            invoice2.AddOrderItem(movie1, 1);
            invoice2.AddOrderItem(movie2, 2);

           
            Invoices.Add(invoice1);
            Invoices.Add(invoice2);
        }
    }
}
