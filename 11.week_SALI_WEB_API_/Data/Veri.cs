namespace _11.week_SALI_WEB_API_.Data
{
    public class Veri
    {
        public static List<Kisi> Kisiler()
        {
            return new List<Kisi>()
            {
                new Kisi() { Id = 1, Ad = "Hadise"},
                new Kisi() { Id = 2, Ad = "Murat Boz"},
                new Kisi() { Id = 3, Ad = "Şebnem Ferah"},
                new Kisi() { Id = 4, Ad = "Cengiz Kurtoğlu"},
                new Kisi() { Id = 5, Ad = "Murat Dalkılıç"}
            };
        }
    }
}
