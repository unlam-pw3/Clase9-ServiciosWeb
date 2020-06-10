using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClaseServiciosWeb.Models
{
    public class MarcaDTO
    {
        public int IdMarca { get; set; }

        public string Nombre { get; set; }

        public List<ProductoDTO> Producto { get; set; }

        public MarcaDTO()
        {

        }
        public MarcaDTO(Marca marcaEF)
        {
            this.IdMarca = marcaEF.IdMarca;
            this.Nombre = marcaEF.Nombre;
        }
        public Marca MapearEF()
        {
            Marca m = new Marca();
            m.IdMarca = this.IdMarca;
            m.Nombre = this.Nombre;
            //m.Producto = this.Producto;

            return m;
        }
    }
}