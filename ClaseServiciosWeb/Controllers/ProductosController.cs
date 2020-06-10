using ClaseServiciosWeb.Models;
using DAL;
using Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ClaseServiciosWeb.Controllers
{
    public class ProductosController : ApiController
    {
        public List<ProductoDTO> Get()
        {
            PracticaEFEntities ctx = new PracticaEFEntities();
            ProductoServicio productoServicio = new ProductoServicio(ctx);

            List<Producto> productosEF = productoServicio.ObtenerTodos();

            //lista resultado a devolver
            return ProductoDTO.MapearListaEF(productosEF);
        }

        public string Post(ProductoDTO prod)
        {
            return $"Producto {prod.Nombre} agregado exitosamente";
        }
    }
}
