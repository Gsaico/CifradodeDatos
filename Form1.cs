using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace TransEncripHash
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.TabPage tabPage4;
		private System.Windows.Forms.Button btnTransformar;
		private System.Windows.Forms.Button btnSimDesEncriptar;
		private System.Windows.Forms.TextBox txtSimADesEncriptado;
		private System.Windows.Forms.TextBox txtSimAEncriptado;
		private System.Windows.Forms.TextBox txtSimAEncriptar;
		private System.Windows.Forms.Button btnSimEncriptar;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtSimKey;
		private System.Windows.Forms.TextBox txtAsimLlavePublica;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnAsimDesEncriptar;
		private System.Windows.Forms.TextBox txtAsimDesEncriptado;
		private System.Windows.Forms.TextBox txtAsimEncriptado;
		private System.Windows.Forms.TextBox txtAsimAEncriptar;
		private System.Windows.Forms.Button btnAsimEncriptar;
		private System.Windows.Forms.Button btnAsimGenerar;

		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		private System.Windows.Forms.TextBox txtCantidad;
		private System.Windows.Forms.TextBox txtHashEncriptar1;
		private System.Windows.Forms.Button btnHashEncriptar1;
		private System.Windows.Forms.TextBox txtHashEncriptado1;
		private System.Windows.Forms.TextBox txtSalt;
		private System.Windows.Forms.CheckBox chkContraseña;
		private System.Windows.Forms.Label lblSalt;
		private System.Windows.Forms.Label lblIteraciones;
		private System.Windows.Forms.Button btnHashKey;
		private System.Windows.Forms.Button btnHashValidar;
		private System.Windows.Forms.Button btnCargar;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.PictureBox picOrig;
		private System.Windows.Forms.PictureBox picXOR;
		private System.Windows.Forms.PictureBox picDesp;
		private System.Windows.Forms.Label lblXOR;
		private System.Windows.Forms.Label lblDesp;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.CheckBox chkSimetrica;
		private System.Windows.Forms.Label label6;

		private miRSA _objKey = null;
		private System.Windows.Forms.TextBox txtHashEncriptado2;
		private byte[] _objHashKey = null;

		public Form1()
		{
			InitializeComponent();
			_objKey = new miRSA();
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				if (components != null)
				{
					components.Dispose();
				}
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
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.label1 = new System.Windows.Forms.Label();
			this.lblDesp = new System.Windows.Forms.Label();
			this.lblXOR = new System.Windows.Forms.Label();
			this.picDesp = new System.Windows.Forms.PictureBox();
			this.picXOR = new System.Windows.Forms.PictureBox();
			this.btnCargar = new System.Windows.Forms.Button();
			this.picOrig = new System.Windows.Forms.PictureBox();
			this.btnTransformar = new System.Windows.Forms.Button();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.label6 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.txtSimKey = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.btnSimDesEncriptar = new System.Windows.Forms.Button();
			this.txtSimADesEncriptado = new System.Windows.Forms.TextBox();
			this.txtSimAEncriptado = new System.Windows.Forms.TextBox();
			this.txtSimAEncriptar = new System.Windows.Forms.TextBox();
			this.btnSimEncriptar = new System.Windows.Forms.Button();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.chkSimetrica = new System.Windows.Forms.CheckBox();
			this.btnAsimGenerar = new System.Windows.Forms.Button();
			this.txtAsimLlavePublica = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.btnAsimDesEncriptar = new System.Windows.Forms.Button();
			this.txtAsimDesEncriptado = new System.Windows.Forms.TextBox();
			this.txtAsimEncriptado = new System.Windows.Forms.TextBox();
			this.txtAsimAEncriptar = new System.Windows.Forms.TextBox();
			this.btnAsimEncriptar = new System.Windows.Forms.Button();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.btnHashValidar = new System.Windows.Forms.Button();
			this.btnHashKey = new System.Windows.Forms.Button();
			this.chkContraseña = new System.Windows.Forms.CheckBox();
			this.txtSalt = new System.Windows.Forms.TextBox();
			this.lblSalt = new System.Windows.Forms.Label();
			this.txtHashEncriptado1 = new System.Windows.Forms.TextBox();
			this.txtCantidad = new System.Windows.Forms.TextBox();
			this.lblIteraciones = new System.Windows.Forms.Label();
			this.txtHashEncriptar1 = new System.Windows.Forms.TextBox();
			this.btnHashEncriptar1 = new System.Windows.Forms.Button();
			this.txtHashEncriptado2 = new System.Windows.Forms.TextBox();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.tabPage4.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Controls.Add(this.tabPage4);
			this.tabControl1.Location = new System.Drawing.Point(16, 22);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(446, 328);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Controls.Add(this.lblDesp);
			this.tabPage1.Controls.Add(this.lblXOR);
			this.tabPage1.Controls.Add(this.picDesp);
			this.tabPage1.Controls.Add(this.picXOR);
			this.tabPage1.Controls.Add(this.btnCargar);
			this.tabPage1.Controls.Add(this.picOrig);
			this.tabPage1.Controls.Add(this.btnTransformar);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Size = new System.Drawing.Size(438, 302);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Transformación";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(58, 124);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(90, 23);
			this.label1.TabIndex = 18;
			this.label1.Text = "Imagen Original";
			this.label1.Visible = false;
			// 
			// lblDesp
			// 
			this.lblDesp.Location = new System.Drawing.Point(254, 264);
			this.lblDesp.Name = "lblDesp";
			this.lblDesp.Size = new System.Drawing.Size(120, 23);
			this.lblDesp.TabIndex = 17;
			this.lblDesp.Text = "Transformación Desp";
			this.lblDesp.Visible = false;
			// 
			// lblXOR
			// 
			this.lblXOR.Location = new System.Drawing.Point(40, 266);
			this.lblXOR.Name = "lblXOR";
			this.lblXOR.Size = new System.Drawing.Size(116, 23);
			this.lblXOR.TabIndex = 16;
			this.lblXOR.Text = "Trasnformación XOR";
			this.lblXOR.Visible = false;
			// 
			// picDesp
			// 
			this.picDesp.Location = new System.Drawing.Point(236, 160);
			this.picDesp.Name = "picDesp";
			this.picDesp.Size = new System.Drawing.Size(160, 100);
			this.picDesp.TabIndex = 15;
			this.picDesp.TabStop = false;
			// 
			// picXOR
			// 
			this.picXOR.Location = new System.Drawing.Point(26, 162);
			this.picXOR.Name = "picXOR";
			this.picXOR.Size = new System.Drawing.Size(160, 100);
			this.picXOR.TabIndex = 14;
			this.picXOR.TabStop = false;
			// 
			// btnCargar
			// 
			this.btnCargar.Location = new System.Drawing.Point(266, 18);
			this.btnCargar.Name = "btnCargar";
			this.btnCargar.Size = new System.Drawing.Size(108, 24);
			this.btnCargar.TabIndex = 13;
			this.btnCargar.Text = "Cargar";
			this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
			// 
			// picOrig
			// 
			this.picOrig.Location = new System.Drawing.Point(26, 20);
			this.picOrig.Name = "picOrig";
			this.picOrig.Size = new System.Drawing.Size(160, 100);
			this.picOrig.TabIndex = 12;
			this.picOrig.TabStop = false;
			// 
			// btnTransformar
			// 
			this.btnTransformar.Location = new System.Drawing.Point(266, 48);
			this.btnTransformar.Name = "btnTransformar";
			this.btnTransformar.Size = new System.Drawing.Size(108, 24);
			this.btnTransformar.TabIndex = 6;
			this.btnTransformar.Text = "Transformar";
			this.btnTransformar.Click += new System.EventHandler(this.btnTransformar_Click);
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.label6);
			this.tabPage2.Controls.Add(this.label3);
			this.tabPage2.Controls.Add(this.label2);
			this.tabPage2.Controls.Add(this.pictureBox4);
			this.tabPage2.Controls.Add(this.pictureBox3);
			this.tabPage2.Controls.Add(this.pictureBox2);
			this.tabPage2.Controls.Add(this.txtSimKey);
			this.tabPage2.Controls.Add(this.label4);
			this.tabPage2.Controls.Add(this.btnSimDesEncriptar);
			this.tabPage2.Controls.Add(this.txtSimADesEncriptado);
			this.tabPage2.Controls.Add(this.txtSimAEncriptado);
			this.tabPage2.Controls.Add(this.txtSimAEncriptar);
			this.tabPage2.Controls.Add(this.btnSimEncriptar);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Size = new System.Drawing.Size(438, 302);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Simétrica";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(308, 276);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(70, 23);
			this.label6.TabIndex = 27;
			this.label6.Text = "Modo CBC";
			this.label6.Visible = false;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(178, 276);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(72, 23);
			this.label3.TabIndex = 26;
			this.label3.Text = "Modo EBC";
			this.label3.Visible = false;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(32, 274);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(90, 23);
			this.label2.TabIndex = 25;
			this.label2.Text = "Imagen Original";
			this.label2.Visible = false;
			// 
			// pictureBox4
			// 
			this.pictureBox4.Location = new System.Drawing.Point(280, 172);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(124, 100);
			this.pictureBox4.TabIndex = 24;
			this.pictureBox4.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Location = new System.Drawing.Point(148, 172);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(124, 100);
			this.pictureBox3.TabIndex = 23;
			this.pictureBox3.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Location = new System.Drawing.Point(16, 172);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(124, 100);
			this.pictureBox2.TabIndex = 22;
			this.pictureBox2.TabStop = false;
			// 
			// txtSimKey
			// 
			this.txtSimKey.Location = new System.Drawing.Point(138, 6);
			this.txtSimKey.Name = "txtSimKey";
			this.txtSimKey.Size = new System.Drawing.Size(228, 20);
			this.txtSimKey.TabIndex = 21;
			this.txtSimKey.Text = "";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(10, 8);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(111, 16);
			this.label4.TabIndex = 19;
			this.label4.Text = "Llave de encriptación";
			// 
			// btnSimDesEncriptar
			// 
			this.btnSimDesEncriptar.Location = new System.Drawing.Point(350, 118);
			this.btnSimDesEncriptar.Name = "btnSimDesEncriptar";
			this.btnSimDesEncriptar.Size = new System.Drawing.Size(80, 24);
			this.btnSimDesEncriptar.TabIndex = 17;
			this.btnSimDesEncriptar.Text = "DesEncriptar";
			this.btnSimDesEncriptar.Click += new System.EventHandler(this.btnSimDesEncriptar_Click);
			// 
			// txtSimADesEncriptado
			// 
			this.txtSimADesEncriptado.Location = new System.Drawing.Point(10, 118);
			this.txtSimADesEncriptado.Multiline = true;
			this.txtSimADesEncriptado.Name = "txtSimADesEncriptado";
			this.txtSimADesEncriptado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtSimADesEncriptado.Size = new System.Drawing.Size(336, 50);
			this.txtSimADesEncriptado.TabIndex = 16;
			this.txtSimADesEncriptado.Text = "TEXTO DESENCRIPTADO";
			// 
			// txtSimAEncriptado
			// 
			this.txtSimAEncriptado.Location = new System.Drawing.Point(10, 82);
			this.txtSimAEncriptado.Multiline = true;
			this.txtSimAEncriptado.Name = "txtSimAEncriptado";
			this.txtSimAEncriptado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtSimAEncriptado.Size = new System.Drawing.Size(336, 32);
			this.txtSimAEncriptado.TabIndex = 15;
			this.txtSimAEncriptado.Text = "TEXTO ENCRIPTADO";
			// 
			// txtSimAEncriptar
			// 
			this.txtSimAEncriptar.Location = new System.Drawing.Point(10, 28);
			this.txtSimAEncriptar.Multiline = true;
			this.txtSimAEncriptar.Name = "txtSimAEncriptar";
			this.txtSimAEncriptar.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtSimAEncriptar.Size = new System.Drawing.Size(336, 50);
			this.txtSimAEncriptar.TabIndex = 13;
			this.txtSimAEncriptar.Text = "TEXTO A ENCRIPTAR";
			// 
			// btnSimEncriptar
			// 
			this.btnSimEncriptar.Location = new System.Drawing.Point(350, 50);
			this.btnSimEncriptar.Name = "btnSimEncriptar";
			this.btnSimEncriptar.Size = new System.Drawing.Size(80, 24);
			this.btnSimEncriptar.TabIndex = 12;
			this.btnSimEncriptar.Text = "Encriptar";
			this.btnSimEncriptar.Click += new System.EventHandler(this.btnSimEncriptar_Click);
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.chkSimetrica);
			this.tabPage3.Controls.Add(this.btnAsimGenerar);
			this.tabPage3.Controls.Add(this.txtAsimLlavePublica);
			this.tabPage3.Controls.Add(this.label5);
			this.tabPage3.Controls.Add(this.btnAsimDesEncriptar);
			this.tabPage3.Controls.Add(this.txtAsimDesEncriptado);
			this.tabPage3.Controls.Add(this.txtAsimEncriptado);
			this.tabPage3.Controls.Add(this.txtAsimAEncriptar);
			this.tabPage3.Controls.Add(this.btnAsimEncriptar);
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Size = new System.Drawing.Size(438, 302);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Asimétrica";
			// 
			// chkSimetrica
			// 
			this.chkSimetrica.Location = new System.Drawing.Point(204, 0);
			this.chkSimetrica.Name = "chkSimetrica";
			this.chkSimetrica.Size = new System.Drawing.Size(132, 24);
			this.chkSimetrica.TabIndex = 32;
			this.chkSimetrica.Text = "Utilizar Simétrico";
			// 
			// btnAsimGenerar
			// 
			this.btnAsimGenerar.Location = new System.Drawing.Point(348, 28);
			this.btnAsimGenerar.Name = "btnAsimGenerar";
			this.btnAsimGenerar.Size = new System.Drawing.Size(80, 38);
			this.btnAsimGenerar.TabIndex = 31;
			this.btnAsimGenerar.Text = "Generar Llaves";
			this.btnAsimGenerar.Click += new System.EventHandler(this.btnAsimGenerar_Click);
			// 
			// txtAsimLlavePublica
			// 
			this.txtAsimLlavePublica.Location = new System.Drawing.Point(9, 28);
			this.txtAsimLlavePublica.Multiline = true;
			this.txtAsimLlavePublica.Name = "txtAsimLlavePublica";
			this.txtAsimLlavePublica.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtAsimLlavePublica.Size = new System.Drawing.Size(335, 36);
			this.txtAsimLlavePublica.TabIndex = 29;
			this.txtAsimLlavePublica.Text = "LLAVE GENARADA";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(8, 8);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(94, 16);
			this.label5.TabIndex = 27;
			this.label5.Text = "Llaves generadas";
			// 
			// btnAsimDesEncriptar
			// 
			this.btnAsimDesEncriptar.Location = new System.Drawing.Point(350, 144);
			this.btnAsimDesEncriptar.Name = "btnAsimDesEncriptar";
			this.btnAsimDesEncriptar.Size = new System.Drawing.Size(80, 24);
			this.btnAsimDesEncriptar.TabIndex = 26;
			this.btnAsimDesEncriptar.Text = "DesEncriptar";
			this.btnAsimDesEncriptar.Click += new System.EventHandler(this.btnAsimDesEncriptar_Click);
			// 
			// txtAsimDesEncriptado
			// 
			this.txtAsimDesEncriptado.Location = new System.Drawing.Point(8, 210);
			this.txtAsimDesEncriptado.Multiline = true;
			this.txtAsimDesEncriptado.Name = "txtAsimDesEncriptado";
			this.txtAsimDesEncriptado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtAsimDesEncriptado.Size = new System.Drawing.Size(336, 66);
			this.txtAsimDesEncriptado.TabIndex = 25;
			this.txtAsimDesEncriptado.Text = "TEXTO DESENCRIPTADO CON LA LLAVE PRIVADA";
			// 
			// txtAsimEncriptado
			// 
			this.txtAsimEncriptado.Location = new System.Drawing.Point(8, 140);
			this.txtAsimEncriptado.Multiline = true;
			this.txtAsimEncriptado.Name = "txtAsimEncriptado";
			this.txtAsimEncriptado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtAsimEncriptado.Size = new System.Drawing.Size(336, 66);
			this.txtAsimEncriptado.TabIndex = 24;
			this.txtAsimEncriptado.Text = "TEXTO ENCRIPTADO CON LA LLAVE PÚBLICA";
			// 
			// txtAsimAEncriptar
			// 
			this.txtAsimAEncriptar.Location = new System.Drawing.Point(8, 70);
			this.txtAsimAEncriptar.Multiline = true;
			this.txtAsimAEncriptar.Name = "txtAsimAEncriptar";
			this.txtAsimAEncriptar.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtAsimAEncriptar.Size = new System.Drawing.Size(336, 66);
			this.txtAsimAEncriptar.TabIndex = 23;
			this.txtAsimAEncriptar.Text = "TEXTO A ENCRIPTAR";
			// 
			// btnAsimEncriptar
			// 
			this.btnAsimEncriptar.Location = new System.Drawing.Point(348, 74);
			this.btnAsimEncriptar.Name = "btnAsimEncriptar";
			this.btnAsimEncriptar.Size = new System.Drawing.Size(80, 24);
			this.btnAsimEncriptar.TabIndex = 22;
			this.btnAsimEncriptar.Text = "Encriptar";
			this.btnAsimEncriptar.Click += new System.EventHandler(this.btnAsimEncriptar_Click);
			// 
			// tabPage4
			// 
			this.tabPage4.Controls.Add(this.txtHashEncriptado2);
			this.tabPage4.Controls.Add(this.btnHashValidar);
			this.tabPage4.Controls.Add(this.btnHashKey);
			this.tabPage4.Controls.Add(this.chkContraseña);
			this.tabPage4.Controls.Add(this.txtSalt);
			this.tabPage4.Controls.Add(this.lblSalt);
			this.tabPage4.Controls.Add(this.txtHashEncriptado1);
			this.tabPage4.Controls.Add(this.txtCantidad);
			this.tabPage4.Controls.Add(this.lblIteraciones);
			this.tabPage4.Controls.Add(this.txtHashEncriptar1);
			this.tabPage4.Controls.Add(this.btnHashEncriptar1);
			this.tabPage4.Location = new System.Drawing.Point(4, 22);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Size = new System.Drawing.Size(438, 302);
			this.tabPage4.TabIndex = 3;
			this.tabPage4.Text = "Hash";
			// 
			// btnHashValidar
			// 
			this.btnHashValidar.Location = new System.Drawing.Point(348, 144);
			this.btnHashValidar.Name = "btnHashValidar";
			this.btnHashValidar.Size = new System.Drawing.Size(80, 23);
			this.btnHashValidar.TabIndex = 31;
			this.btnHashValidar.Text = "Validar Hash";
			this.btnHashValidar.Visible = false;
			this.btnHashValidar.Click += new System.EventHandler(this.btnHashValidar_Click);
			// 
			// btnHashKey
			// 
			this.btnHashKey.Location = new System.Drawing.Point(346, 40);
			this.btnHashKey.Name = "btnHashKey";
			this.btnHashKey.Size = new System.Drawing.Size(80, 23);
			this.btnHashKey.TabIndex = 30;
			this.btnHashKey.Text = "Generar Key";
			this.btnHashKey.Visible = false;
			this.btnHashKey.Click += new System.EventHandler(this.btnHashKey_Click);
			// 
			// chkContraseña
			// 
			this.chkContraseña.Checked = true;
			this.chkContraseña.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkContraseña.Location = new System.Drawing.Point(332, 4);
			this.chkContraseña.Name = "chkContraseña";
			this.chkContraseña.TabIndex = 29;
			this.chkContraseña.Text = "Contraseña";
			this.chkContraseña.CheckedChanged += new System.EventHandler(this.chkContraseña_CheckedChanged);
			// 
			// txtSalt
			// 
			this.txtSalt.Location = new System.Drawing.Point(222, 4);
			this.txtSalt.Name = "txtSalt";
			this.txtSalt.Size = new System.Drawing.Size(104, 20);
			this.txtSalt.TabIndex = 28;
			this.txtSalt.Text = "";
			// 
			// lblSalt
			// 
			this.lblSalt.AutoSize = true;
			this.lblSalt.Location = new System.Drawing.Point(192, 8);
			this.lblSalt.Name = "lblSalt";
			this.lblSalt.Size = new System.Drawing.Size(24, 16);
			this.lblSalt.TabIndex = 27;
			this.lblSalt.Text = "Salt";
			// 
			// txtHashEncriptado1
			// 
			this.txtHashEncriptado1.Location = new System.Drawing.Point(4, 102);
			this.txtHashEncriptado1.Multiline = true;
			this.txtHashEncriptado1.Name = "txtHashEncriptado1";
			this.txtHashEncriptado1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtHashEncriptado1.Size = new System.Drawing.Size(336, 66);
			this.txtHashEncriptado1.TabIndex = 26;
			this.txtHashEncriptado1.Text = "TEXTO ENCRIPTADO MANUALMENTE";
			// 
			// txtCantidad
			// 
			this.txtCantidad.Location = new System.Drawing.Point(134, 4);
			this.txtCantidad.Name = "txtCantidad";
			this.txtCantidad.Size = new System.Drawing.Size(36, 20);
			this.txtCantidad.TabIndex = 25;
			this.txtCantidad.Text = "";
			// 
			// lblIteraciones
			// 
			this.lblIteraciones.AutoSize = true;
			this.lblIteraciones.Location = new System.Drawing.Point(6, 6);
			this.lblIteraciones.Name = "lblIteraciones";
			this.lblIteraciones.Size = new System.Drawing.Size(123, 16);
			this.lblIteraciones.TabIndex = 24;
			this.lblIteraciones.Text = "Cantidad de iteraciones";
			// 
			// txtHashEncriptar1
			// 
			this.txtHashEncriptar1.Location = new System.Drawing.Point(4, 30);
			this.txtHashEncriptar1.Multiline = true;
			this.txtHashEncriptar1.Name = "txtHashEncriptar1";
			this.txtHashEncriptar1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtHashEncriptar1.Size = new System.Drawing.Size(336, 66);
			this.txtHashEncriptar1.TabIndex = 23;
			this.txtHashEncriptar1.Text = "TEXTO A ENCRIPTAR";
			// 
			// btnHashEncriptar1
			// 
			this.btnHashEncriptar1.Location = new System.Drawing.Point(346, 74);
			this.btnHashEncriptar1.Name = "btnHashEncriptar1";
			this.btnHashEncriptar1.Size = new System.Drawing.Size(80, 24);
			this.btnHashEncriptar1.TabIndex = 22;
			this.btnHashEncriptar1.Text = "Encriptar";
			this.btnHashEncriptar1.Click += new System.EventHandler(this.btnHashEncriptar1_Click);
			// 
			// txtHashEncriptado2
			// 
			this.txtHashEncriptado2.Location = new System.Drawing.Point(4, 172);
			this.txtHashEncriptado2.Multiline = true;
			this.txtHashEncriptado2.Name = "txtHashEncriptado2";
			this.txtHashEncriptado2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtHashEncriptado2.Size = new System.Drawing.Size(336, 66);
			this.txtHashEncriptado2.TabIndex = 32;
			this.txtHashEncriptado2.Text = "TEXTO ENCRIPTADO CON PASSWORDDERIVEBYTES";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(474, 365);
			this.Controls.Add(this.tabControl1);
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.Text = "Transformaciones, Encriptaciones y Hash";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.tabPage3.ResumeLayout(false);
			this.tabPage4.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		private static void Main()
		{
			Application.Run(new Form1());
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
		}

		#region Tratamiento de imagenes

		private byte[] CargarImagen(string strArchivo)
		{
			FileStream fs = new FileStream(strArchivo, FileMode.Open);
			byte[] bitmapBytes = new byte[36054];
			fs.Read(bitmapBytes, 0, bitmapBytes.Length);
			fs.Close();

			return bitmapBytes;
		}

		private void GrabarImagen(string strArchivo, byte[] bitmapBytes)
		{
			FileStream fs = new FileStream(strArchivo, FileMode.OpenOrCreate);
			fs.Write(bitmapBytes, 0, bitmapBytes.Length);
			fs.Flush();
			fs.Close();
		}
		
		private void LiberarImagenesTrans()
		{
			if (this.picOrig.Image != null) this.picOrig.Image.Dispose();
			if (this.picDesp.Image != null) this.picDesp.Image.Dispose();
			if (this.picXOR.Image != null) this.picXOR.Image.Dispose();
		}

		private void LiberarImagenesSimm()
		{
			if (this.pictureBox2.Image != null) this.pictureBox2.Image.Dispose();
			if (this.pictureBox3.Image != null) this.pictureBox3.Image.Dispose();
			if (this.pictureBox4.Image != null) this.pictureBox4.Image.Dispose();
		}

		#endregion

		#region Transformaciones

		private void btnCargar_Click(object sender, System.EventArgs e)
		{
			if (this.picOrig.Image != null) this.picOrig.Image.Dispose();
			this.picOrig.Image = (Bitmap)Bitmap.FromFile(@"..\..\ImagenDemo.bmp");

		}

		private void btnTransformar_Click(object sender, System.EventArgs e)
		{
			LiberarImagenesTrans();
			byte[] bitmapBytes1 = CargarImagen(@"..\..\ImagenDemoCarga.bmp");
			
			bitmapBytes1 = TransEncripHash.TransformacionXOR.Codificar(bitmapBytes1);

			GrabarImagen(@"..\..\ImagenDemo2a.bmp", bitmapBytes1);
			
			Bitmap b1 = (Bitmap)Bitmap.FromFile(@"..\..\ImagenDemo2a.bmp");
			this.picXOR.Image = b1;

			byte[] bitmapBytes2 = CargarImagen(@"..\..\ImagenDemoCarga.bmp");

			bitmapBytes2 = TransEncripHash.TransformacionDesp.Codificar(bitmapBytes2);

			GrabarImagen(@"..\..\ImagenDemo2b.bmp", bitmapBytes2);

			Bitmap b2 = (Bitmap)Bitmap.FromFile(@"..\..\ImagenDemo2b.bmp");
			this.picDesp.Image = b2;

			this.picOrig.Image = (Bitmap)Bitmap.FromFile(@"..\..\ImagenDemo.bmp");
			this.lblDesp.Visible= this.lblXOR.Visible = true;
		}

		#endregion

		#region Algoritmos Simétricos

		private void btnSimEncriptar_Click(object sender, System.EventArgs e)
		{
			LiberarImagenesSimm();
			byte[] bitmapBytes = null;
			byte[] _bytTemp=null;

			_bytTemp = TransEncripHash.MiRijndael.Encriptar(this.txtSimAEncriptar.Text, this.txtSimKey.Text);

			this.txtSimAEncriptado.Text = Convert.ToBase64String(_bytTemp);

			bitmapBytes = CargarImagen(@"..\..\ImagenDemoCarga.bmp");
			bitmapBytes = TransEncripHash.MiRijndael.EncriptarDeImagen(bitmapBytes, this.txtSimKey.Text, CipherMode.ECB);
			GrabarImagen(@"..\..\ImagenDemo3.bmp", bitmapBytes);
			Bitmap b3 = (Bitmap)Bitmap.FromFile(@"..\..\ImagenDemo3.bmp");
			this.pictureBox3.Image = b3;


			bitmapBytes = CargarImagen(@"..\..\ImagenDemoCarga.bmp");
			bitmapBytes = TransEncripHash.MiRijndael.EncriptarDeImagen(bitmapBytes, this.txtSimKey.Text, CipherMode.CBC);
			GrabarImagen(@"..\..\ImagenDemo4.bmp", bitmapBytes);
			Bitmap b4 = (Bitmap)Bitmap.FromFile(@"..\..\ImagenDemo4.bmp");
			this.pictureBox4.Image = b4;

			Bitmap b2 = (Bitmap)Bitmap.FromFile(@"..\..\ImagenDemo.bmp");
			this.pictureBox2.Image = b2;

			this.label2.Visible=true;
			this.label3.Visible=true;
			this.label6.Visible=true;

		}

		private void btnSimDesEncriptar_Click(object sender, System.EventArgs e)
		{
			byte[] _bytTemp=Convert.FromBase64String(this.txtSimAEncriptado.Text);
			this.txtSimADesEncriptado.Text = TransEncripHash.MiRijndael.Desencriptar(_bytTemp, this.txtSimKey.Text);
		}
		
		#endregion

		#region Algoritmos Asimétricos

		private void btnAsimEncriptar_Click(object sender, System.EventArgs e)
		{
			byte[] _bytEncriptado = null;

			//Creamos una instancia del encritador publico
			RSACryptoServiceProvider _objEncriptadorPublico = new RSACryptoServiceProvider();
			//Le asignamos la llave genarada
			_objEncriptadorPublico.FromXmlString(this.txtAsimLlavePublica.Text);

			if (this.chkSimetrica.Checked)
			{
				//Se declara la memoria para almacenar la llave utilizada por nuestro Rijndael personalizado
				byte[] _bytKey = (Rijndael.Create()).Key;

				//Se encripta el texto y se obtiene la llave que se utilizó para la encriptación
				byte[] _bytEncriptadoSimetrico = TransEncripHash.MiRijndael.Encriptar(this.txtAsimAEncriptar.Text, _bytKey);

				//Se encripta la llave con el algoritmo RSA
				byte[] _bytEncriptadoLlave = _objEncriptadorPublico.Encrypt(_bytKey, false);

				//Se copia en un arreglo la llave encriptada y el encriptado de Rijndael
				_bytEncriptado = new byte[_bytEncriptadoLlave.Length + _bytEncriptadoSimetrico.Length];
				_bytEncriptadoLlave.CopyTo(_bytEncriptado,0);
				_bytEncriptadoSimetrico.CopyTo(_bytEncriptado, _bytEncriptadoLlave.Length);
			}
			else
			{
				_bytEncriptado = _objEncriptadorPublico.Encrypt(System.Text.Encoding.UTF8.GetBytes(this.txtAsimAEncriptar.Text), false);
			}
			this.txtAsimEncriptado.Text = Convert.ToBase64String(_bytEncriptado);
		}

		private void btnAsimDesEncriptar_Click(object sender, System.EventArgs e)
		{
			this.txtAsimDesEncriptado.Text = this._objKey.DesEncriptar(Convert.FromBase64String(this.txtAsimEncriptado.Text), this.chkSimetrica.Checked);
		}

		private void btnAsimGenerar_Click(object sender, System.EventArgs e)
		{
			this.txtAsimLlavePublica.Text = this._objKey.ObtenerLlavePublica();
		}

		#endregion

		#region Hash

		private void btnHashEncriptar1_Click(object sender, System.EventArgs e)
		{
			if (chkContraseña.Checked)
			{
				this.txtHashEncriptado1.Text = Convert.ToBase64String(TransEncripHash.HashContraseñas.Encriptar(this.txtHashEncriptar1.Text, this.txtSalt.Text, Convert.ToInt32(this.txtCantidad.Text)));

				PasswordDeriveBytes _objPdb = new PasswordDeriveBytes(this.txtHashEncriptar1.Text, System.Text.Encoding.UTF8.GetBytes(this.txtSalt.Text), "SHA256", Convert.ToInt32(this.txtCantidad.Text));
				this.txtHashEncriptado2.Text = Convert.ToBase64String(_objPdb.GetBytes(32));

			}
			else
			{
				this.txtHashEncriptado1.Text = Convert.ToBase64String(TransEncripHash.HashValidacion.Encriptar(this.txtHashEncriptar1.Text, this._objHashKey));
			}

		}

		private void chkContraseña_CheckedChanged(object sender, System.EventArgs e)
		{
			bool _blnContraseña = chkContraseña.Checked;
			if (_blnContraseña)
				lblSalt.Text = "Salt";
			else
				lblSalt.Text = "Key ";
			this.txtSalt.Visible = _blnContraseña;
			this.lblIteraciones.Visible = _blnContraseña;
			this.txtCantidad.Visible = _blnContraseña;
			this.btnHashKey.Visible = !_blnContraseña;
			this.btnHashValidar.Visible = !_blnContraseña;
			this.txtHashEncriptado2.Visible = _blnContraseña;
		}

		private void btnHashKey_Click(object sender, System.EventArgs e)
		{
			this._objHashKey = (new System.Security.Cryptography.DESCryptoServiceProvider()).Key;
			this.lblSalt.Text = "Key : " + Convert.ToBase64String(this._objHashKey);
		}

		private void btnHashValidar_Click(object sender, System.EventArgs e)
		{
			byte[] _objhashFinal = TransEncripHash.HashValidacion.Encriptar(this.txtHashEncriptar1.Text, this._objHashKey);
			byte[] _objHashInicial = Convert.FromBase64String(this.txtHashEncriptado1.Text);

			if (TransEncripHash.HashValidacion.CompareByteArray(_objHashInicial, _objhashFinal))
				System.Windows.Forms.MessageBox.Show("Son iguales", "Validacion de hash", MessageBoxButtons.OK, MessageBoxIcon.Information);
			else
				System.Windows.Forms.MessageBox.Show("Son Diferentes", "Validacion de hash", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		#endregion

	}
}