﻿using DAL;
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

        public Nullable<int> IdMarca { get; set; }
        public MarcaDTO Marca { get; set; }

        public ProductoDTO()
        {
            
        }

        public ProductoDTO(Producto productoEntidad, bool mapearMarca = true)
        {
            this.IdProducto = productoEntidad.IdProducto;
            this.Nombre = productoEntidad.Nombre;
            this.Precio = productoEntidad.Precio;
            if (mapearMarca && productoEntidad.Marca != null)
            {
                this.Marca = new MarcaDTO(productoEntidad.Marca);
            }
        }

        public Producto MapearEF()
        {
            Producto p = new Producto();
            p.IdProducto = this.IdProducto;
            p.Nombre = this.Nombre;
            p.Precio = this.Precio;
            if (this.Marca != null)
            {
                p.Marca = this.Marca.MapearEF();
            }

            return p;
        }

        public static List<Producto> MapearListaDTO(List<ProductoDTO> productosDTO)
        {
            List<Producto> productosEF = new List<Producto>();

            foreach (var prodDTO in productosDTO)
            {
                productosEF.Add(prodDTO.MapearEF());
            }

            return productosEF;
        }

        public static List<ProductoDTO> MapearListaEF(List<Producto> productosEF, bool mapearMarca = true)
        {
            List<ProductoDTO> productosDTO = new List<ProductoDTO>();

            foreach (var prodEF in productosEF)
            {
                productosDTO.Add(new ProductoDTO(prodEF, mapearMarca));
            }

            return productosDTO;
        }
    }
}