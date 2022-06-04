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
        public float CostoSinIva { get; set; }
        public float PorcentajeDeIVA { get; set; }

        public float margenDeGanancia;

        public float precioFinalDeVenta { get; set; }
        public float CalcularCostoConIva()
        {
            return CostoSinIva + CostoSinIva * PorcentajeDeIVA;
        }
        
        public EstadoProducto estadoProducto { get; set; }

        public float CalcularMargenDeGanancia()
        {
            return margenDeGanancia = (CalcularPrecioFinalDeVenta() - CalcularCostoConIva()) / CalcularCostoConIva();
        }

        public float CalcularPrecioFinalDeVenta()
        {
            return precioFinalDeVenta = CalcularCostoConIva() + CalcularCostoConIva() * margenDeGanancia;
        }

        //public static float? calcularPrecioDeVentaOMargenDeGanancia(string cci, string? mg, string? pf)
        //{
        //    float costoconIVA = float.Parse(cci);
        //    MargenDeGanancia = float.TryParse(mg, out _) ? float.Parse(mg) : (float?)null;
        //    PrecioFinalDeVenta = float.TryParse(pf, out _) ? float.Parse(pf) : (float?)null;
        //    float ?resultado = PrecioFinalDeVenta == null ? costoconIVA + costoconIVA * MargenDeGanancia : (precioFinalDeVenta - costoconIVA) / costoconIVA;
        //    return resultado;
        //}
    }
}
