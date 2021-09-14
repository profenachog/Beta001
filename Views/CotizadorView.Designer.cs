
namespace Cotizador.Views
{
    partial class CotizadorView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label8 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnCotizar = new System.Windows.Forms.Button();
            this.lblTienda = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblVendedor = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdoPremium = new System.Windows.Forms.RadioButton();
            this.rdoStandard = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkChupin = new System.Windows.Forms.CheckBox();
            this.rdoPantalon = new System.Windows.Forms.RadioButton();
            this.chkMao = new System.Windows.Forms.CheckBox();
            this.chkMangaCorta = new System.Windows.Forms.CheckBox();
            this.rdoCamisa = new System.Windows.Forms.RadioButton();
            this.btnHistorial = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(507, 574);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 19);
            this.label8.TabIndex = 19;
            this.label8.Text = "$";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(555, 574);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(18, 19);
            this.lblTotal.TabIndex = 18;
            this.lblTotal.Text = "0";
            // 
            // btnCotizar
            // 
            this.btnCotizar.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnCotizar.Location = new System.Drawing.Point(201, 551);
            this.btnCotizar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCotizar.Name = "btnCotizar";
            this.btnCotizar.Size = new System.Drawing.Size(163, 65);
            this.btnCotizar.TabIndex = 17;
            this.btnCotizar.Text = "COTIZAR";
            this.btnCotizar.UseVisualStyleBackColor = false;
            this.btnCotizar.Click += new System.EventHandler(this.btnCotizar_Click);
            // 
            // lblTienda
            // 
            this.lblTienda.AutoSize = true;
            this.lblTienda.Location = new System.Drawing.Point(26, 18);
            this.lblTienda.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblTienda.Name = "lblTienda";
            this.lblTienda.Size = new System.Drawing.Size(66, 19);
            this.lblTienda.TabIndex = 16;
            this.lblTienda.Text = "TIENDA";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(782, 18);
            this.lblDireccion.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(154, 19);
            this.lblDireccion.TabIndex = 15;
            this.lblDireccion.Text = "DIRECCION TIENDA";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(26, 75);
            this.lblId.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(26, 19);
            this.lblId.TabIndex = 14;
            this.lblId.Text = "ID";
            // 
            // lblVendedor
            // 
            this.lblVendedor.AutoSize = true;
            this.lblVendedor.Location = new System.Drawing.Point(447, 75);
            this.lblVendedor.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(93, 19);
            this.lblVendedor.TabIndex = 13;
            this.lblVendedor.Text = "VENDEDOR";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtCantidad);
            this.groupBox3.Controls.Add(this.txtPrecio);
            this.groupBox3.Location = new System.Drawing.Point(589, 353);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(8);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(8);
            this.groupBox3.Size = new System.Drawing.Size(384, 167);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "PRECIO UNITARIO Y CANTIDAD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "CANTIDAD";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 77);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "$";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(300, 69);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(8);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(47, 27);
            this.txtCantidad.TabIndex = 1;
            this.txtCantidad.Text = "1";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(50, 71);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(8);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(127, 27);
            this.txtPrecio.TabIndex = 0;
            this.txtPrecio.Text = "100";
           
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdoPremium);
            this.groupBox2.Controls.Add(this.rdoStandard);
            this.groupBox2.Location = new System.Drawing.Point(26, 353);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(8);
            this.groupBox2.Size = new System.Drawing.Size(514, 167);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CALIDAD DE PRENDA";
            // 
            // rdoPremium
            // 
            this.rdoPremium.AutoSize = true;
            this.rdoPremium.Location = new System.Drawing.Point(238, 77);
            this.rdoPremium.Margin = new System.Windows.Forms.Padding(8);
            this.rdoPremium.Name = "rdoPremium";
            this.rdoPremium.Size = new System.Drawing.Size(100, 23);
            this.rdoPremium.TabIndex = 1;
            this.rdoPremium.TabStop = true;
            this.rdoPremium.Text = "PREMIUM";
            this.rdoPremium.UseVisualStyleBackColor = true;
            // 
            // rdoStandard
            // 
            this.rdoStandard.AutoSize = true;
            this.rdoStandard.Checked = true;
            this.rdoStandard.Location = new System.Drawing.Point(44, 77);
            this.rdoStandard.Margin = new System.Windows.Forms.Padding(8);
            this.rdoStandard.Name = "rdoStandard";
            this.rdoStandard.Size = new System.Drawing.Size(113, 23);
            this.rdoStandard.TabIndex = 0;
            this.rdoStandard.TabStop = true;
            this.rdoStandard.Text = "STANDARD";
            this.rdoStandard.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkChupin);
            this.groupBox1.Controls.Add(this.rdoPantalon);
            this.groupBox1.Controls.Add(this.chkMao);
            this.groupBox1.Controls.Add(this.chkMangaCorta);
            this.groupBox1.Controls.Add(this.rdoCamisa);
            this.groupBox1.Location = new System.Drawing.Point(30, 146);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(8);
            this.groupBox1.Size = new System.Drawing.Size(943, 181);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PRENDA";
            // 
            // chkChupin
            // 
            this.chkChupin.AutoSize = true;
            this.chkChupin.Location = new System.Drawing.Point(421, 117);
            this.chkChupin.Margin = new System.Windows.Forms.Padding(8);
            this.chkChupin.Name = "chkChupin";
            this.chkChupin.Size = new System.Drawing.Size(87, 23);
            this.chkChupin.TabIndex = 4;
            this.chkChupin.Text = "CHUPIN";
            this.chkChupin.UseVisualStyleBackColor = true;
            // 
            // rdoPantalon
            // 
            this.rdoPantalon.AutoSize = true;
            this.rdoPantalon.Location = new System.Drawing.Point(40, 114);
            this.rdoPantalon.Margin = new System.Windows.Forms.Padding(8);
            this.rdoPantalon.Name = "rdoPantalon";
            this.rdoPantalon.Size = new System.Drawing.Size(111, 23);
            this.rdoPantalon.TabIndex = 3;
            this.rdoPantalon.TabStop = true;
            this.rdoPantalon.Text = "PANTALÓN";
            this.rdoPantalon.UseVisualStyleBackColor = true;
            // 
            // chkMao
            // 
            this.chkMao.AutoSize = true;
            this.chkMao.Location = new System.Drawing.Point(769, 53);
            this.chkMao.Margin = new System.Windows.Forms.Padding(8);
            this.chkMao.Name = "chkMao";
            this.chkMao.Size = new System.Drawing.Size(127, 23);
            this.chkMao.TabIndex = 2;
            this.chkMao.Text = "CUELLO MAO";
            this.chkMao.UseVisualStyleBackColor = true;
            // 
            // chkMangaCorta
            // 
            this.chkMangaCorta.AutoSize = true;
            this.chkMangaCorta.Location = new System.Drawing.Point(421, 53);
            this.chkMangaCorta.Margin = new System.Windows.Forms.Padding(8);
            this.chkMangaCorta.Name = "chkMangaCorta";
            this.chkMangaCorta.Size = new System.Drawing.Size(144, 23);
            this.chkMangaCorta.TabIndex = 1;
            this.chkMangaCorta.Text = "MANGA CORTA";
            this.chkMangaCorta.UseVisualStyleBackColor = true;
            // 
            // rdoCamisa
            // 
            this.rdoCamisa.AutoSize = true;
            this.rdoCamisa.Checked = true;
            this.rdoCamisa.Location = new System.Drawing.Point(40, 53);
            this.rdoCamisa.Margin = new System.Windows.Forms.Padding(8);
            this.rdoCamisa.Name = "rdoCamisa";
            this.rdoCamisa.Size = new System.Drawing.Size(88, 23);
            this.rdoCamisa.TabIndex = 0;
            this.rdoCamisa.TabStop = true;
            this.rdoCamisa.Text = "CAMISA";
            this.rdoCamisa.UseVisualStyleBackColor = true;
            // 
            // btnHistorial
            // 
            this.btnHistorial.Location = new System.Drawing.Point(786, 73);
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Size = new System.Drawing.Size(150, 23);
            this.btnHistorial.TabIndex = 20;
            this.btnHistorial.Text = "VER HISTORIAL";
            this.btnHistorial.UseVisualStyleBackColor = true;
            this.btnHistorial.Click += new System.EventHandler(this.btnHistorial_Click);
            // 
            // CotizadorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 671);
            this.Controls.Add(this.btnHistorial);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnCotizar);
            this.Controls.Add(this.lblTienda);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblVendedor);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CotizadorView";
            this.Text = "COTIZADOR EXPRESS";
            this.Load += new System.EventHandler(this.CotizadorView_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdoPremium;
        private System.Windows.Forms.RadioButton rdoStandard;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkChupin;
        private System.Windows.Forms.RadioButton rdoPantalon;
        private System.Windows.Forms.CheckBox chkMao;
        private System.Windows.Forms.CheckBox chkMangaCorta;
        public System.Windows.Forms.Label lblTienda;
        public System.Windows.Forms.Label lblDireccion;
        public System.Windows.Forms.Label lblId;
        public System.Windows.Forms.Label lblVendedor;
        public System.Windows.Forms.Button btnCotizar;
        private System.Windows.Forms.RadioButton rdoCamisa;
        private System.Windows.Forms.Button btnHistorial;
    }
}