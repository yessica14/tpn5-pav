using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TPN5.Modelo;

namespace TPN5.Repositorio
{
    public class Solucion
    {
        private static List<Producto> _productos = new List<Producto>();
        public static void CreacionDeProductos()
        {
            _productos.Add(new Producto
            {
                Codigo = 1,
                Descripcion = "Azucar",
                Existencia = 0,
                estadoProducto = EstadoProducto.Activo,
            });

            _productos.Add(new Producto
            {
                Codigo = 2,
                Descripcion = "yerba",
                Existencia = 2,
                estadoProducto = EstadoProducto.Activo,
            });

            _productos.Add(new Producto
            {
                Codigo = 3,
                Descripcion = "cafe",
                Existencia = 3,
                estadoProducto = EstadoProducto.Activo,
            });

        }
        public static List<Producto> ObtenerProductos()
        {
            return _productos.ToList();
        }

        public static Producto BuscarProducto(int codigo)
        {
            var producto = _productos.Where(p => p.Codigo == codigo && p.Existencia > 0).FirstOrDefault();
            return producto;
        }
        public static void AgregarProducto(Producto producto)
        {
            _productos.Add(producto);
        }
            

            
    }
}
