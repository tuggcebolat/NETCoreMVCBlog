using Microsoft.AspNetCore.Mvc;
using NETCoreMVCBlog.Models;

namespace NETCoreMVCBlog.Controllers
{
    public class KullaniciController :Controller
    {
        Kullanici k1 = new Kullanici() { Name = "Tuğçe", Lastname = "Bolat", Age =  26};
        Kullanici k2 = new Kullanici() { Name = "Attila", Lastname = "Bolat", Age =  26};
        Kullanici k3 = new Kullanici() { Name = "Ata", Lastname = "Bolat", Age =  26}; 

    }
}
