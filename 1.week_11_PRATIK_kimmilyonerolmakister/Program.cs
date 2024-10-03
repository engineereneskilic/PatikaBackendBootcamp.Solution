using System;

namespace _1.week_11_PRATIK_kimmilyonerolmakister
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Soruları ve cevapları tanımlama
            // Soru 1
            string soru1 = "Kızınca tüküren hayvan hangisidir?";
            string cevap1A = "a) Lama"; // Seçenek A
            string cevap1B = "b) Deve"; // Seçenek B
            string dogruCevap1 = "a"; // Doğru cevap (A seçeneği)

            // Soru 2
            string soru2 = "Dünya'ya en yakın gezegen hangisidir?";
            string cevap2A = "a) Venüs"; // Seçenek A
            string cevap2B = "b) Mars"; // Seçenek B
            string dogruCevap2 = "a"; // Doğru cevap (A seçeneği)

            // Soru 3
            string soru3 = "5 * 2 + 8 / 2 - 2 işleminin sonucu kaçtır?";
            string cevap3A = "a) 7"; // Seçenek A
            string cevap3B = "b) 12"; // Seçenek B
            string dogruCevap3 = "b"; // Doğru cevap (B seçeneği)

            // Doğru cevap sayısını tutmak için bir değişken oluşturuyoruz
            int dogruSayisi = 0;

            // Soru 1'i soruyoruz
            Console.WriteLine($"Soru 1: {soru1}"); // Soruyu yazdır
            Console.WriteLine(cevap1A); // Seçenek A'yı yazdır
            Console.WriteLine(cevap1B); // Seçenek B'yi yazdır
            Console.Write("Cevabınızı girin (A veya B): "); // Kullanıcıdan cevap bekliyoruz
            string cevap1 = Console.ReadLine().Trim().ToLower(); // Kullanıcının cevabını al ve küçük harfe çevir

            // Kullanıcının cevabını kontrol et
            if (cevap1 == dogruCevap1) // Cevap doğruysa
            {
                Console.WriteLine("Doğru cevap!"); // Kullanıcıya doğru cevap olduğunu bildir
                dogruSayisi++; // Doğru cevap sayısını artır
            }
            else // Cevap yanlışsa
            {
                Console.WriteLine("Yanlış cevap!"); // Kullanıcıya yanlış cevap olduğunu bildir
            }

            // Soru 2'yi soruyoruz
            Console.WriteLine($"Soru 2: {soru2}"); // Soruyu yazdır
            Console.WriteLine(cevap2A); // Seçenek A'yı yazdır
            Console.WriteLine(cevap2B); // Seçenek B'yi yazdır
            Console.Write("Cevabınızı girin (A veya B): "); // Kullanıcıdan cevap bekliyoruz
            string cevap2 = Console.ReadLine().Trim().ToLower(); // Kullanıcının cevabını al ve küçük harfe çevir

            // Kullanıcının cevabını kontrol et
            if (cevap2 == dogruCevap2) // Cevap doğruysa
            {
                Console.WriteLine("Doğru cevap!"); // Kullanıcıya doğru cevap olduğunu bildir
                dogruSayisi++; // Doğru cevap sayısını artır
            }
            else // Cevap yanlışsa
            {
                Console.WriteLine("Yanlış cevap!"); // Kullanıcıya yanlış cevap olduğunu bildir
            }

            // Kullanıcıya 3. soru sorulmaz, sonuç kontrolü yapıyoruz
            // Doğru cevap sayısına göre büyük ödül kazanıp kazanmadığını kontrol ediyoruz
            if (dogruSayisi >= 2) // Eğer kullanıcının doğru cevap sayısı 2 veya daha fazla ise
            {
                Console.WriteLine("Tebrikler! 1 Milyon TL'lik büyük ödülü kazandınız!"); // Kullanıcıya ödül kazandığını bildir
            }
            else // Kullanıcının doğru cevap sayısı 2'den az ise
            {
                Console.WriteLine("Üzgünüm, büyük ödülü kazanamadınız."); // Kullanıcıya ödülü kazanamadığını bildir
            }

            // Programın bitişi
            Console.WriteLine("Çıkmak için bir tuşa basın..."); // Kullanıcıya çıkmak için bir tuşa basmasını söyle
            Console.ReadKey(); // Kullanıcının bir tuşa basmasını bekle
        }
    }
    }
}
