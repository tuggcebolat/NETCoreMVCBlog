using Microsoft.AspNetCore.Mvc;
using NETCoreMVCBlog.Models;

namespace NETCoreMVCBlog.Controllers
{
    public class KullaniciController : Controller
    {
        public IActionResult Index()
        {
            Kullanici kullanici1 = new Kullanici() { FirstName = "Tuğçe", LastName = "Bolat", Age = 26 };
            Kullanici kullanici2 = new Kullanici() { FirstName = "Attila", LastName = "Bolat", Age = 26 };
            Kullanici kullanici3 = new Kullanici() { FirstName = "Ata", LastName = "Bolat", Age = 26 };

            //List<Kullanici> kullanicilar = new List<Kullanici>() {  kullanici1, kullanici2, kullanici3 };
            //return View(kullanicilar);
            return View();
        }

        

        


    }
}
