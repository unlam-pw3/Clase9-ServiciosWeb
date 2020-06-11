using ClaseServiciosWeb.Models;
using DAL;
using Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace ClaseServiciosWeb
{
    /// <summary>
    /// Summary description for Productos
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    //[System.Web.Script.Services.ScriptService]
    public class Productos : System.Web.Services.WebService
    {
        ProductoServicio productoServicio;
        public Productos()
        {
            PracticaEFEntities ctx = new PracticaEFEntities();
            productoServicio = new ProductoServicio(ctx);
        }

        [WebMethod]
        public List<ProductoDTO> ObtenerTodos()
        {
            List<Producto> productosEF = productoServicio.ObtenerTodos();

            //lista resultado a devolver
            return ProductoDTO.MapearListaEF(productosEF);
        }

        [WebMethod]
        public ProductoDTO ObtenerPorId(int id)
        {
            Producto productoEF = productoServicio.ObtenerPorId(id);

            //lista resultado a devolver
            return new ProductoDTO(productoEF);
        }

        [WebMethod]
        public string Crear(ProductoDTO prod)
        {
            productoServicio.Crear(prod.MapearEF());
            return $"Producto {prod.Nombre} agregado exitosamente";
        }

        [WebMethod]
        public string Modificar(ProductoDTO prod)
        {
            productoServicio.Modificar(prod.MapearEF());
            return $"Producto ID: {prod.IdProducto} - {prod.Nombre} modificado exitosamente";
        }

        [WebMethod]
        public string Eliminar(ProductoDTO prod)
        {
            productoServicio.Eliminar(prod.IdProducto);
            return $"Producto ID: {prod.IdProducto} eliminado exitosamente";
        }
    }
}
