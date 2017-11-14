using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebPixCoreUI.Models;
using WebPixRenderingEngine.Helpers;

namespace WebPixRenderingEngine.Controllers
{
    public class PageController : Controller
    {
        // GET: Page
        private int IDCliente = PixRender.IDCliente;

        // GET: Page
        public ActionResult Index(int id)
        {
            int idUsuario = 0;

            if (PixRender.UsuarioLogado.IdUsuario == 0)
                idUsuario = 999;
            else
                idUsuario = PixRender.UsuarioLogado.IdUsuario;

            ViewBag.urlCliente = PixRender.defaultSiteUrl;
            ViewBag.NomeCliente = PixRender.Cliente.Nome;


            var keyUrlIn = ConfigurationManager.AppSettings["UrlAPI"].ToString();
            var urlAPIIn = keyUrlIn + "Seguranca/Principal/buscarpaginas/" + IDCliente + "/" + idUsuario;
            var client = new WebClient { Encoding = System.Text.Encoding.UTF8 };
            var result = client.DownloadString(string.Format(urlAPIIn));
            var jss = new System.Web.Script.Serialization.JavaScriptSerializer();
            PageViewModel[] Pagina = jss.Deserialize<PageViewModel[]>(result);

            var modelo = Pagina.Where(x => x.ID == id).FirstOrDefault();

            ViewBag.Title = modelo.Titulo;

            return View(modelo);
        }
        public ContentResult GetCss()
        {

            int idUsuario = 0;

            if (PixRender.UsuarioLogado.IdUsuario == 0)
                idUsuario = 999;
            else
                idUsuario = PixRender.UsuarioLogado.IdUsuario;

            var keyUrlIn = ConfigurationManager.AppSettings["UrlAPI"].ToString();
            var urlAPIIn = keyUrlIn + "Seguranca/Principal/buscarEstilo/" + IDCliente + "/" + idUsuario;
            var client = new WebClient { Encoding = System.Text.Encoding.UTF8 };
            var result = client.DownloadString(string.Format(urlAPIIn));
            var jss = new System.Web.Script.Serialization.JavaScriptSerializer();
            EstiloViewModel[] Estilos = jss.Deserialize<EstiloViewModel[]>(result);

            var resultado = Estilos.Where(x => x.idCliente == IDCliente).FirstOrDefault();
            string cssBody = "";

            if (resultado != null)
                cssBody = resultado.Conteudo;

            return Content(cssBody, "text/css");
        }
    }
}