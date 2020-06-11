using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var client = new ServiceASMX.ProductosSoapClient();
            var productos = client.ObtenerTodos();

            return View(productos);
        }

        public ActionResult ListaDesdeWebApi()
        {
            List<ProductoDTO> productosDesdeWebApi = GetProductos();
            return View(productosDesdeWebApi);
        }

        public ActionResult ListaDesdeWebApiPorJavascript()
        {
            return View();
        }

        private List<ProductoDTO> GetProductos()
        {
            var url = $"https://localhost:44306/api/productos";
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Accept = "application/json";

            using (WebResponse response = request.GetResponse())
            {
                using (Stream strReader = response.GetResponseStream())
                {
                    if (strReader == null) return new List<ProductoDTO>();
                    using (StreamReader objReader = new StreamReader(strReader))
                    {
                        string responseBody = objReader.ReadToEnd();
                        var result = JsonConvert.DeserializeObject<List<ProductoDTO>>(responseBody);
                        return result;
                    }
                }
            }
        }
    }
}