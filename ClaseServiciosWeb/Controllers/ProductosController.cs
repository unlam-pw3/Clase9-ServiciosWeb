using ClaseServiciosWeb.Models;
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
            List<ProductoDTO> productos = new List<ProductoDTO>();
            productos.Add(new ProductoDTO() { IdProducto = 1, Nombre = "Pelota", Precio = 5000 });
            productos.Add(new ProductoDTO() { IdProducto = 2, Nombre = "Camiseta", Precio = 7000 });
            productos.Add(new ProductoDTO() { IdProducto = 3, Nombre = "Botines", Precio = 4000 });
            return productos;
        }

        public string Post(ProductoDTO prod)
        {
            return $"Producto {prod.Nombre} agregado exitosamente";
        }
    }
}
