using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_31_State_Managament_Session.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Session["sepetim"] = "Bu sessiondan gelen sepetin verisidir.";
            return View();
        }

        public ActionResult SessionOku()
        {
            // Session Okuma
            string veri = (string)Session["sepetim"];
            return View();
        }
    }
}
/* Session(Durum): Server Side State Managament nesnesidir.
   Session sunucuda ve her kullanıcı için ayrı ayrı oluşan nesnedir.
   Örneğin 1000 kullanıcı var ise kullanıcı adeti kadar session sunucuda tutulur.
   Session web sayfaları arasında gezinirken bilgi tutabilmek ve durum yönetebilmek için kullanılır. Örnek: E-Ticaret sitelerindeki sepet mantığı.
   Session default olarak yaşam süresi 20 dakikadır.
*/