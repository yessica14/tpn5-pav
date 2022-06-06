using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPN5.Modelo;
using TPN5.Repositorio;

namespace TPN5
{
    public partial class Form1 : Form
    {
        private static List<Object> _listProductos = new List<Object>();
        public Form1()
        {
            InitializeComponent();
            Repositorio.Repositorio.CreacionDeProductos();
            dwvGrilla.DataSource = Repositorio.Repositorio.ObtenerProductos();
            AgregarEstadoDelProducto();
            panel2.Enabled = false;
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            var codigoLectura = txtCodigo.Text;
            var producto = Repositorio.Repositorio.BuscarProducto(int.Parse(codigoLectura));
           
            if (producto == null)
            {
                
                var resultado = MessageBox.Show("El producto no existe. Desea crear un nuevo producto?", "Mensaje de Existencia", MessageBoxButtons.YesNo);
                if (DialogResult.Yes == resultado)
                {
                    MessageBox.Show("continuar con la carga del producto");
                    textCodigo.Text = txtCodigo.Text;
                    cbEstado.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Ingresa un nuevo codigo de producto");
                    textCodigo.Text = "";
                    cbEstado.Enabled = false;
                }
                panel2.Enabled = true;
                return;
            }
            else
            {
                var listProducto = new List<Producto>();
                listProducto.Add(producto);

                dwvGrilla.DataSource = null;
                dwvGrilla.DataSource = listProducto;

            }

            btnCalcularPVoMG.Enabled = false;
        }

        private void btnCalcularCCI_Click(object sender, EventArgs e)
        {
            var producto = Repositorio.Repositorio.BuscarProducto(int.Parse(textCodigo.Text));
            Double resultadoCCI = 0;

            if (producto == null)
            {
                var producto_new = new Producto();
                producto_new.Codigo = int.Parse(textCodigo.Text);
                producto_new.Descripcion = txtDescripcion.Text;
                producto_new.estadoProducto = (EstadoProducto)cbEstado.SelectedItem;
                producto_new.Existencia = int.Parse(txtExistencia.Text);
                producto_new.CostoSinIva = Double.Parse(txtCSI.Text);
                producto_new.PorcentajeDeIVA = Double.Parse(txtPI.Text);
                resultadoCCI = producto_new.CalcularCostoConIva();
                Repositorio.Repositorio.AgregarProducto(producto_new);
            }
            else
            {
                producto.CostoSinIva = Double.Parse(txtCSI.Text);
                producto.PorcentajeDeIVA = Double.Parse(txtPI.Text);
                resultadoCCI = producto.CalcularCostoConIva();
            }
            txtCCI.Text = resultadoCCI.ToString();
            btnCalcularPVoMG.Enabled = true;
        }

        private void btnCalcularPVoMG_Click(object sender, EventArgs e)
        {
            var producto = Repositorio.Repositorio.BuscarProducto(int.Parse(textCodigo.Text));
            producto.CostoSinIva = Double.Parse(txtCSI.Text);
            producto.PorcentajeDeIVA = Double.Parse(txtPI.Text);

            producto.CostoConIVA = Double.Parse(txtCCI.Text);

            double resultado = 0;
            if (txtPV.Text == "")
            {
                producto.margenDeGanancia = Double.Parse(txtMG.Text);
                resultado = producto.CalcularPrecioFinalDeVenta();
                txtPV.Text = resultado.ToString();
            }
            else
            {
                producto.precioFinalDeVenta = Double.Parse(txtPV.Text);
                resultado = producto.CalcularMargenDeGanancia();
                txtMG.Text = resultado.ToString();
            }
        }

        private void AgregarEstadoDelProducto()
        {
            cbEstado.Items.Add(EstadoProducto.Activo);
            cbEstado.Items.Add(EstadoProducto.Inactivo);
            cbEstado.Items.Add(EstadoProducto.Eliminado);
            cbEstado.Text = cbEstado.Text;
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            var producto = Repositorio.Repositorio.BuscarProducto(int.Parse(textCodigo.Text));

            if (textCodigo.Text == "" || txtDescripcion.Text == "" || txtExistencia.Text == ""
               && txtCCI.Text == "" || txtPI.Text == "" || txtMG.Text == "" || txtPV.Text == "")
            {
                MessageBox.Show("Debe completar todos los campos para la edicion");
            }
            else
            {
                producto.Codigo = int.Parse(textCodigo.Text);
                producto.Descripcion = txtDescripcion.Text;
                producto.Existencia = int.Parse(txtExistencia.Text);
                producto.CostoSinIva = Double.Parse(txtCCI.Text);
                producto.PorcentajeDeIVA = Double.Parse(txtPI.Text);
                producto.estadoProducto = (EstadoProducto)cbEstado.SelectedIndex;
                producto.precioFinalDeVenta = Double.Parse(txtPV.Text);

                dwvGrilla.DataSource = null;
                dwvGrilla.DataSource = Repositorio.Repositorio.ObtenerProductos();

                MessageBox.Show("se guardo con exito");
            }
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            panel2.Enabled = true;
            cbEstado.Enabled = true;
            var producto = Repositorio.Repositorio.BuscarProducto(int.Parse(txtCodigo.Text));

            textCodigo.Text = producto.Codigo.ToString();
            txtDescripcion.Text = producto.Descripcion.ToString();
            txtExistencia.Text = producto.Existencia.ToString();
            cbEstado.SelectedIndex = producto.estadoProducto.GetHashCode();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            panel2.Enabled = true;
            textCodigo.Text = "";
            cbEstado.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            textCodigo.Text = "";
            txtDescripcion.Text = "";
            txtExistencia.Text = "";
            txtCSI.Text = "";
            txtPI.Text = "";
            txtCCI.Text = "";
            txtMG.Text = "";
            txtPV.Text = "";
            panel2.Enabled = false;
        }
    }
        
}
