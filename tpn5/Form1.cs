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
            Solucion.CreacionDeProductos();
            dwvGrilla.DataSource = Solucion.ObtenerProductos();
            AgregarEstadoDelProducto();
        }

        private void EnlazarControles(Producto producto)
        {
            txtDescripcion.Text = producto.Descripcion;
            txtExistencia.Text = producto.Existencia.ToString();
            cbEstado.SelectedIndex = 0;
            cbEstado.Enabled = false;

            //BindingSource bsProducto = new BindingSource();
            //txtDescripcion.DataBindings.Add("text", bsProducto, producto.Descripcion);
            ////txtDescripcion.DataBindings.Add("text", bsProducto, producto.Existencia.ToString());
            //txtDescripcion.DataBindings.Add("text", bsProducto, producto.CSI.ToString());
            //txtDescripcion.DataBindings.Add("text", bsProducto, producto.PI.ToString());
            //txtDescripcion.DataBindings.Add("text", bsProducto, producto.estadoProducto.ToString());
            ////bsProducto.DataSource = producto;
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            var codigoLectura = txtCodigo.Text;
            var producto = Solucion.BuscarProducto(int.Parse(codigoLectura));
            if (producto == null)
            {
                var resultado = MessageBox.Show("El producto no existe. Desea crear un nuevo producto?", "Mensaje de Existencia", MessageBoxButtons.YesNo);
                if (DialogResult.Yes == resultado)
                {
                    MessageBox.Show("continuar con la carga del producto");
                }
                else
                {
                    MessageBox.Show("Ingresa un nuevo codigo de producto");
                    txtCodigo.Text = "";
                }
                return;
            }
            EnlazarControles(producto);
            btnCalcularPVoMG.Enabled = false;
        }

        private void btnCalcularCCI_Click(object sender, EventArgs e)
        {
            var producto = Solucion.BuscarProducto(int.Parse(txtCodigo.Text));
            producto.CostoSinIva = float.Parse(txtCSI.Text);
            producto.PorcentajeDeIVA = float.Parse(txtPI.Text);
            var resultadoCCI = producto.CalcularCostoConIva();
            txtCCI.Text = resultadoCCI.ToString();
            btnCalcularPVoMG.Enabled = true;
        }

        private void btnCalcularPVoMG_Click(object sender, EventArgs e)
        {
            var producto = Solucion.BuscarProducto(int.Parse(txtCodigo.Text));
            producto.CostoSinIva = float.Parse(txtCSI.Text);
            producto.PorcentajeDeIVA = float.Parse(txtPI.Text);
            
            
            var cci = txtCCI.Text;
            float resultado = 0;
            if (txtPF.Text == "")
            {
                producto.margenDeGanancia = float.Parse(txtMG.Text);
                resultado = producto.CalcularPrecioFinalDeVenta();
                txtPF.Text = resultado.ToString();
            }
            else
            {
                producto.precioFinalDeVenta = float.Parse(txtPF.Text);
                resultado = 35;
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
            var producto = Solucion.BuscarProducto(int.Parse(txtCodigo.Text));

            producto.Codigo = int.Parse(txtCodigo.Text);
            producto.Descripcion = txtDescripcion.Text;
            producto.Existencia = int.Parse(txtExistencia.Text);
            producto.CostoSinIva = float.Parse(txtCCI.Text);
            producto.PorcentajeDeIVA = float.Parse(txtPI.Text);
            producto.estadoProducto = (EstadoProducto)cbEstado.SelectedIndex;
            producto.precioFinalDeVenta = float.Parse(txtPF.Text);

            //Solucion.AgregarProducto(producto);

            dwvGrilla.DataSource = null;
            dwvGrilla.DataSource = Solucion.ObtenerProductos();

            txtCodigo.Text = "";
            txtDescripcion.Text = "";
            txtExistencia.Text = "";
            txtCSI.Text = "";
            txtPI.Text = "";
            txtCCI.Text = "";
            txtMG.Text = "";
            txtPF.Text = "";
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //cbEstado.Enabled = true;
            //if(MensajeDeValidacion())
            //{
            //    GuardarEditarProducto();
            //}
            //else
                

        }

        public void GuardarEditarProducto()
        {
            var producto = Solucion.BuscarProducto(int.Parse(txtCodigo.Text));

            producto.Codigo = int.Parse(txtCodigo.Text);
            producto.Descripcion = txtDescripcion.Text;
            producto.Existencia = int.Parse(txtExistencia.Text);
            producto.CostoSinIva = float.Parse(txtCCI.Text);
            producto.PorcentajeDeIVA = float.Parse(txtPI.Text);
            producto.estadoProducto = (EstadoProducto)cbEstado.SelectedIndex;
            producto.precioFinalDeVenta = float.Parse(txtPF.Text);

            dwvGrilla.DataSource = null;
            dwvGrilla.DataSource = Solucion.ObtenerProductos();
        }
        public bool MensajeDeValidacion()
        {
            bool pasoValidacion = true;
            if (txtCodigo.Text == null && txtDescripcion.Text == null && txtExistencia.Text == null
                && txtCCI.Text == null && txtPI.Text == null && txtMG.Text == null && txtPF.Text == null)
            {
                MessageBox.Show("Debe completar todos los campos para la edicion");
                pasoValidacion = false;
            }
            return pasoValidacion;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }
    }
        
}
