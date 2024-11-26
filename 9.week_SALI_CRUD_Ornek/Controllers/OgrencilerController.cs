using _9.week_SALI_CRUD_Ornek.Models;
using Microsoft.AspNetCore.Mvc;

namespace _9.week_SALI_CRUD_Ornek.Controllers
{
    public class OgrencilerController : Controller
    {



        public OgrencilerController()
        {

        }

        public IActionResult Index()
        {
            var ogrenciler = Veri.Ogrencis;



            return View(ogrenciler);
        }



        public IActionResult Yeni()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Yeni(YeniOgrenciViewModel yeniOgrenciVM)
        {

            if(ModelState.IsValid)
            {
                Ogrenci yeni = new Ogrenci()
                {
                    Id =  Veri.Ogrencis.Max(o => o.Id) + 1,
                    Ad = yeniOgrenciVM.Ad,
                    DogumYili = yeniOgrenciVM.DogumYili,
                    Takim = yeniOgrenciVM.Takim
                };
                Veri.Ogrencis.Add(yeni);

                return RedirectToAction("Index");
            }

            // VERİLERİN GEÇERLİLİĞİNİ KONTROL ET


            // VERİLER GEÇERLİ İSE ÖĞRENCİYİ KAYDET VE ÖĞRENCİ LİSTESİNE YÖNLEN

            // VERİLER GEÇERLİ AYNI SAYFAYI TEKRAR GÖSTER
            return View();
        }


    }
}
