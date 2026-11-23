using Microsoft.AspNetCore.Mvc;

namespace AkilliCVAnalizSistemi.Controllers
{
    public class CVController : Controller
    {
        // SAYFA AÇILIR
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        // FORM GÖNDERİLİR
        [HttpPost]
        public IActionResult Index(string cvText)
        {
            int puan = 0;

            try
            {
                string isIlani = "c sharp sql html css javascript asp net";

                if (!string.IsNullOrWhiteSpace(cvText))
                {
                    var cvWords = cvText.ToLower().Split(' ');
                    var ilanWords = isIlani.Split(' ');

                    foreach (var word in cvWords)
                    {
                        if (ilanWords.Contains(word))
                        {
                            puan += 10;
                        }
                    }
                }

                ViewBag.Puan = puan;
                ViewBag.Message = "CV başarıyla analiz edildi!";
            }
            catch
            {
                ViewBag.Puan = 0;
                ViewBag.Message = "Hata oluştu ama sistem çalışıyor.";
            }

            return View();
        }
    }
}