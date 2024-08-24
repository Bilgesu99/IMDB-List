using System;
using System.Collections.Generic;
using IMDB_List; // `Films` sınıfını içe aktar

namespace IMDBList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Films> filmList = new List<Films>(); // Film nesnelerini saklayacağımız liste.

            // Kullanıcıdan film bilgilerini almak için döngü
            while (true)
            {
                Console.Write("Film ismini giriniz: ");
                string name = Console.ReadLine();

                Console.Write("IMDB puanı giriniz: ");
                double imdbPuan = Convert.ToDouble((Console.ReadLine));
               

                Films newFilm = new Films(name, imdbPuan);
                filmList.Add(newFilm);

                Console.Write("Yeni bir film eklemek istiyor musunuz? (Evet/Hayır): ");
                string cevap = Console.ReadLine().Trim().ToLower();
                if (cevap != "evet")
                {
                    break;
                }
            }

            // Uygulamanın sonunda sonuçları listeleyelim
            Console.WriteLine("\nTüm Filmler:");
            foreach (var film in filmList)
            {
                Console.WriteLine($"Film: {film.Name}, IMDB Puanı: {film.ImdbPuan}");
            }

            Console.WriteLine("\nIMDB Puanı 4 ile 9 arasında olan Filmler:");
            foreach (var film in filmList)
            {
                if (film.ImdbPuan >= 4 && film.ImdbPuan <= 9)
                {
                    Console.WriteLine($"Film: {film.Name}, IMDB Puanı: {film.ImdbPuan}");
                }
            }

            Console.WriteLine("\nİsmi 'A' ile başlayan Filmler ve IMDB Puanları:");
            foreach (var film in filmList)
            {
                if (film.Name.StartsWith("A", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Film: {film.Name}, IMDB Puanı: {film.ImdbPuan}");
                }
            }
        }
    }
}