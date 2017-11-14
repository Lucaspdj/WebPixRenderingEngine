using System.Web.Mvc;
using WebPixCoreUI.Models;
using WebPixRenderingEngine.Helpers;

namespace WebPixRenderingEngine.Controllers
{
    public class LoginController : Controller
    {
        public ActionResult Login()
        {
            ViewBag.urlCliente = PixRender.defaultSiteUrl;
            ViewBag.NomeCliente = PixRender.Cliente.Nome;
            return View();
        }

        // POST: Login/Create
        [HttpPost]
        public ActionResult Login(LoginViewModel collection)
        {
            try
            {
                if (PixRender.Login(collection))
                {
                    Response.Redirect(PixRender.defaultSiteUrl);
                    return View();
                }
                else
                {
                    ViewBag.TemporariaMensagem = "Usuario ou senha invalida";
                    return View();
                }
            }
            catch
            {
                ViewBag.TemporariaMensagem = "Usuario ou senha invalida";
                return View();
            }
        }
    }
}