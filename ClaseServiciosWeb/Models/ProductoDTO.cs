using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClaseServiciosWeb.Models
{
    public class ProductoDTO
    {
        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
    }
}