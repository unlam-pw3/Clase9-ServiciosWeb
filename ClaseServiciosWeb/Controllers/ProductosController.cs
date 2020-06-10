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
        ProductoServicio productoServicio;
        public ProductosController()
        {
            PracticaEFEntities ctx = new PracticaEFEntities();
            productoServicio = new ProductoServicio(ctx);
        }
        public List<ProductoDTO> Get()
        {
            List<Producto> productosEF = productoServicio.ObtenerTodos();

            //lista resultado a devolver
            return ProductoDTO.MapearListaEF(productosEF);
        }

        [HttpGet]
        public ProductoDTO Get(int id)
        {
            Producto productoEF = productoServicio.ObtenerPorId(id);

            //lista resultado a devolver
            return new ProductoDTO(productoEF);
        }

        public string Post(ProductoDTO prod)
        {
            productoServicio.Crear(prod.MapearEF());
            return $"Producto {prod.Nombre} agregado exitosamente";
        }

        public string Put(ProductoDTO prod)
        {
            productoServicio.Modificar(prod.MapearEF());
            return $"Producto ID: {prod.IdProducto} - {prod.Nombre} modificado exitosamente";
        }

        public string Delete(ProductoDTO prod)
        {
            productoServicio.Eliminar(prod.IdProducto);
            return $"Producto ID: {prod.IdProducto} eliminado exitosamente";
        }
    }
}
