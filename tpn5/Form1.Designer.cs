
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.btnCalcularCCI = new System.Windows.Forms.Button();
            this.btnCalcularPVoMG = new System.Windows.Forms.Button();
            this.dwvGrilla = new System.Windows.Forms.DataGridView();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.textCodigo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPV = new System.Windows.Forms.TextBox();
            this.txtMG = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCCI = new System.Windows.Forms.TextBox();
            this.txtPI = new System.Windows.Forms.TextBox();
            this.txtCSI = new System.Windows.Forms.TextBox();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.txtExistencia = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dwvGrilla)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingresar Codigo";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(136, 26);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 23);
            this.txtCodigo.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(171, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Costo con IVA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Costo Sin Iva";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Porcentaje De IVA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 353);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Margen De Ganancia";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 15);
            this.label8.TabIndex = 18;
            this.label8.Text = "Existencia";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 141);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 15);
            this.label9.TabIndex = 20;
            this.label9.Text = "Estado";
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.Location = new System.Drawing.Point(259, 26);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(114, 23);
            this.btnBuscarProducto.TabIndex = 22;
            this.btnBuscarProducto.Text = "Buscar Producto";
            this.btnBuscarProducto.UseVisualStyleBackColor = true;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // btnCalcularCCI
            // 
            this.btnCalcularCCI.Location = new System.Drawing.Point(10, 261);
            this.btnCalcularCCI.Name = "btnCalcularCCI";
            this.btnCalcularCCI.Size = new System.Drawing.Size(148, 23);
            this.btnCalcularCCI.TabIndex = 23;
            this.btnCalcularCCI.Text = "Calcular el costo con Iva";
            this.btnCalcularCCI.UseVisualStyleBackColor = true;
            this.btnCalcularCCI.Click += new System.EventHandler(this.btnCalcularCCI_Click);
            // 
            // btnCalcularPVoMG
            // 
            this.btnCalcularPVoMG.Location = new System.Drawing.Point(19, 309);
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
            this.dwvGrilla.Location = new System.Drawing.Point(10, 60);
            this.dwvGrilla.Name = "dwvGrilla";
            this.dwvGrilla.RowTemplate.Height = 25;
            this.dwvGrilla.Size = new System.Drawing.Size(443, 349);
            this.dwvGrilla.TabIndex = 25;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(93, 410);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 27;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Descripcion";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnNuevo);
            this.panel1.Controls.Add(this.btnEditar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtCodigo);
            this.panel1.Controls.Add(this.btnBuscarProducto);
            this.panel1.Controls.Add(this.dwvGrilla);
            this.panel1.Location = new System.Drawing.Point(8, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(594, 455);
            this.panel1.TabIndex = 29;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(483, 60);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 27;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(483, 109);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 26;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click_1);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnCancelar);
            this.panel2.Controls.Add(this.textCodigo);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txtPV);
            this.panel2.Controls.Add(this.txtMG);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.btnGuardar);
            this.panel2.Controls.Add(this.txtCCI);
            this.panel2.Controls.Add(this.txtPI);
            this.panel2.Controls.Add(this.txtCSI);
            this.panel2.Controls.Add(this.cbEstado);
            this.panel2.Controls.Add(this.txtExistencia);
            this.panel2.Controls.Add(this.btnCalcularCCI);
            this.panel2.Controls.Add(this.txtDescripcion);
            this.panel2.Controls.Add(this.btnCalcularPVoMG);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(632, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(381, 455);
            this.panel2.TabIndex = 30;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(196, 409);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 31;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // textCodigo
            // 
            this.textCodigo.Location = new System.Drawing.Point(123, 8);
            this.textCodigo.Name = "textCodigo";
            this.textCodigo.Size = new System.Drawing.Size(121, 23);
            this.textCodigo.TabIndex = 30;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 15);
            this.label10.TabIndex = 29;
            this.label10.Text = "Codigo";
            // 
            // txtPV
            // 
            this.txtPV.Location = new System.Drawing.Point(196, 380);
            this.txtPV.Name = "txtPV";
            this.txtPV.Size = new System.Drawing.Size(138, 23);
            this.txtPV.TabIndex = 28;
            // 
            // txtMG
            // 
            this.txtMG.Location = new System.Drawing.Point(19, 381);
            this.txtMG.Name = "txtMG";
            this.txtMG.Size = new System.Drawing.Size(149, 23);
            this.txtMG.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(196, 352);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 15);
            this.label7.TabIndex = 26;
            this.label7.Text = "Precio Final de Venta";
            // 
            // txtCCI
            // 
            this.txtCCI.Location = new System.Drawing.Point(258, 261);
            this.txtCCI.Name = "txtCCI";
            this.txtCCI.Size = new System.Drawing.Size(114, 23);
            this.txtCCI.TabIndex = 25;
            // 
            // txtPI
            // 
            this.txtPI.Location = new System.Drawing.Point(123, 218);
            this.txtPI.Name = "txtPI";
            this.txtPI.Size = new System.Drawing.Size(175, 23);
            this.txtPI.TabIndex = 23;
            // 
            // txtCSI
            // 
            this.txtCSI.Location = new System.Drawing.Point(123, 178);
            this.txtCSI.Name = "txtCSI";
            this.txtCSI.Size = new System.Drawing.Size(175, 23);
            this.txtCSI.TabIndex = 22;
            // 
            // cbEstado
            // 
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Location = new System.Drawing.Point(123, 133);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(121, 23);
            this.cbEstado.TabIndex = 21;
            // 
            // txtExistencia
            // 
            this.txtExistencia.Location = new System.Drawing.Point(123, 92);
            this.txtExistencia.Name = "txtExistencia";
            this.txtExistencia.Size = new System.Drawing.Size(158, 23);
            this.txtExistencia.TabIndex = 19;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(123, 50);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(175, 23);
            this.txtDescripcion.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 513);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Carga y Actualizacion de Producto";
            ((System.ComponentModel.ISupportInitialize)(this.dwvGrilla)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.Button btnCalcularCCI;
        private System.Windows.Forms.Button btnCalcularPVoMG;
        private System.Windows.Forms.DataGridView dwvGrilla;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtCCI;
        private System.Windows.Forms.TextBox txtPI;
        private System.Windows.Forms.TextBox txtCSI;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.TextBox txtExistencia;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox txtPV;
        private System.Windows.Forms.TextBox txtMG;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textCodigo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnCancelar;
    }
}

