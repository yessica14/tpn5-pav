
namespace TPN5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtCSI = new System.Windows.Forms.TextBox();
            this.txtPI = new System.Windows.Forms.TextBox();
            this.txtCCI = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMG = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPF = new System.Windows.Forms.TextBox();
            this.txtExistencia = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.btnCalcularCCI = new System.Windows.Forms.Button();
            this.btnCalcularPVoMG = new System.Windows.Forms.Button();
            this.dwvGrilla = new System.Windows.Forms.DataGridView();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.btGuardar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dwvGrilla)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingresar Codigo";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(155, 24);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 23);
            this.txtCodigo.TabIndex = 2;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(155, 69);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(238, 23);
            this.txtDescripcion.TabIndex = 4;
            // 
            // txtCSI
            // 
            this.txtCSI.Location = new System.Drawing.Point(155, 113);
            this.txtCSI.Name = "txtCSI";
            this.txtCSI.Size = new System.Drawing.Size(238, 23);
            this.txtCSI.TabIndex = 5;
            // 
            // txtPI
            // 
            this.txtPI.Location = new System.Drawing.Point(155, 161);
            this.txtPI.Name = "txtPI";
            this.txtPI.Size = new System.Drawing.Size(238, 23);
            this.txtPI.TabIndex = 6;
            // 
            // txtCCI
            // 
            this.txtCCI.Location = new System.Drawing.Point(155, 271);
            this.txtCCI.Name = "txtCCI";
            this.txtCCI.Size = new System.Drawing.Size(238, 23);
            this.txtCCI.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Descripcion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Costo con IVA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Costo Sin Iva";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Porcentaje De IVA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 322);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Margen De Ganancia";
            // 
            // txtMG
            // 
            this.txtMG.Location = new System.Drawing.Point(155, 314);
            this.txtMG.Name = "txtMG";
            this.txtMG.Size = new System.Drawing.Size(238, 23);
            this.txtMG.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 367);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Precio Final de venta";
            // 
            // txtPF
            // 
            this.txtPF.Location = new System.Drawing.Point(155, 359);
            this.txtPF.Name = "txtPF";
            this.txtPF.Size = new System.Drawing.Size(238, 23);
            this.txtPF.TabIndex = 16;
            // 
            // txtExistencia
            // 
            this.txtExistencia.Location = new System.Drawing.Point(522, 113);
            this.txtExistencia.Name = "txtExistencia";
            this.txtExistencia.Size = new System.Drawing.Size(238, 23);
            this.txtExistencia.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(431, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 15);
            this.label8.TabIndex = 18;
            this.label8.Text = "Existencia";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(448, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 15);
            this.label9.TabIndex = 20;
            this.label9.Text = "Estado";
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.Location = new System.Drawing.Point(279, 24);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(114, 23);
            this.btnBuscarProducto.TabIndex = 22;
            this.btnBuscarProducto.Text = "Buscar Producto";
            this.btnBuscarProducto.UseVisualStyleBackColor = true;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // btnCalcularCCI
            // 
            this.btnCalcularCCI.Location = new System.Drawing.Point(11, 216);
            this.btnCalcularCCI.Name = "btnCalcularCCI";
            this.btnCalcularCCI.Size = new System.Drawing.Size(148, 23);
            this.btnCalcularCCI.TabIndex = 23;
            this.btnCalcularCCI.Text = "Calcular el costo con Iva";
            this.btnCalcularCCI.UseVisualStyleBackColor = true;
            this.btnCalcularCCI.Click += new System.EventHandler(this.btnCalcularCCI_Click);
            // 
            // btnCalcularPVoMG
            // 
            this.btnCalcularPVoMG.Location = new System.Drawing.Point(13, 422);
            this.btnCalcularPVoMG.Name = "btnCalcularPVoMG";
            this.btnCalcularPVoMG.Size = new System.Drawing.Size(111, 23);
            this.btnCalcularPVoMG.TabIndex = 24;
            this.btnCalcularPVoMG.Text = "Calcular PV O MG";
            this.btnCalcularPVoMG.UseVisualStyleBackColor = true;
            this.btnCalcularPVoMG.Click += new System.EventHandler(this.btnCalcularPVoMG_Click);
            // 
            // dwvGrilla
            // 
            this.dwvGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dwvGrilla.Location = new System.Drawing.Point(448, 199);
            this.dwvGrilla.Name = "dwvGrilla";
            this.dwvGrilla.RowTemplate.Height = 25;
            this.dwvGrilla.Size = new System.Drawing.Size(443, 183);
            this.dwvGrilla.TabIndex = 25;
            // 
            // cbEstado
            // 
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Location = new System.Drawing.Point(522, 60);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(121, 23);
            this.cbEstado.TabIndex = 26;
            // 
            // btGuardar
            // 
            this.btGuardar.Location = new System.Drawing.Point(169, 421);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(75, 23);
            this.btGuardar.TabIndex = 27;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.UseVisualStyleBackColor = true;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(279, 422);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 28;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Location = new System.Drawing.Point(448, 401);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(443, 100);
            this.panel1.TabIndex = 29;
            this.panel1.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(162, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(192, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(127, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 15);
            this.label10.TabIndex = 0;
            this.label10.Text = "label10";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 513);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btGuardar);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.dwvGrilla);
            this.Controls.Add(this.btnCalcularPVoMG);
            this.Controls.Add(this.btnCalcularCCI);
            this.Controls.Add(this.btnBuscarProducto);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtExistencia);
            this.Controls.Add(this.txtPF);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMG);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCCI);
            this.Controls.Add(this.txtPI);
            this.Controls.Add(this.txtCSI);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Carga y Actualizacion de Producto";
            ((System.ComponentModel.ISupportInitialize)(this.dwvGrilla)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtCSI;
        private System.Windows.Forms.TextBox txtPI;
        private System.Windows.Forms.TextBox txtCCI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMG;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPF;
        private System.Windows.Forms.TextBox txtExistencia;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.Button btnCalcularCCI;
        private System.Windows.Forms.Button btnCalcularPVoMG;
        private System.Windows.Forms.DataGridView dwvGrilla;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
    }
}

