using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public class ProductoServicio : IServicio<Producto>
    {
        ProductoRepository productoRepository;

        public ProductoServicio(PracticaEFEntities ctx)
        {
            productoRepository = new ProductoRepository(ctx);
        }

        public void Crear(Producto entity)
        {
            productoRepository.Crear(entity);
        }

        public void Eliminar(int id)
        {
            productoRepository.Eliminar(id);
        }

        public Producto ObtenerPorId(int id)
        {
            return productoRepository.ObtenerPorId(id);
        }

        public List<Producto> ObtenerTodos()
        {
            return productoRepository.ObtenerTodos();
        }
    }
}
