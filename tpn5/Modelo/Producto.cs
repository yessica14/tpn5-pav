using System;
using System.Collections.Generic;
using System.Text;

namespace TPN5.Modelo
{
    public class Producto
    {
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public int Existencia { get; set; }
        public Double CostoSinIva { get; set; }
        public Double PorcentajeDeIVA { get; set; }

        public Double CostoConIVA { get; set; }

        public Double margenDeGanancia;

        public Double precioFinalDeVenta { get; set; }
        public Double CalcularCostoConIva()
        {
            return CostoSinIva + CostoSinIva * (PorcentajeDeIVA / 100);
        }
        
        public EstadoProducto estadoProducto { get; set; }

        public Double CalcularMargenDeGanancia()
        {
            return margenDeGanancia = ((precioFinalDeVenta - CostoConIVA) / CostoConIVA)*100;
        }

        public Double CalcularPrecioFinalDeVenta()
        {
            return precioFinalDeVenta = CostoConIVA + CostoConIVA * (margenDeGanancia/100);
        }
    }
}
