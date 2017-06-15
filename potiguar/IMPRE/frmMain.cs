using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Bematech;
using Bematech.Texto;
using Bematech.CodigosDeBarras;
using Bematech.Comunicacao;
using Bematech.MiniImpressoras;


namespace TestMiniPrinter
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class frmPrincipal : System.Windows.Forms.Form
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cboPortaComunicacao;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cboImpressora;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.GroupBox grbImpressaoTexto;
		private System.Windows.Forms.GroupBox grbAlinhamento;
		internal System.Windows.Forms.RadioButton rbtAlignCentro;
		internal System.Windows.Forms.RadioButton rbtAlignEsquerda;
		internal System.Windows.Forms.RadioButton rbtAlignDireita;
		internal System.Windows.Forms.RadioButton rbtAlignNenhum;
		private System.Windows.Forms.GroupBox grbFormatoFonte;
		internal System.Windows.Forms.CheckBox chkExpandido;
		internal System.Windows.Forms.CheckBox chkItalico;
		internal System.Windows.Forms.CheckBox chkSublinhado;
		internal System.Windows.Forms.CheckBox chkNegrito;
		private System.Windows.Forms.GroupBox grbTamanhoFonte;
		internal System.Windows.Forms.RadioButton rbtNormal;
		internal System.Windows.Forms.RadioButton rbtElite;
		internal System.Windows.Forms.RadioButton rbtCondensado;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtTexto;
		private System.Windows.Forms.Button btnImprimir;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Button btnImprimirCaracterGrafico;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.CheckBox checkBox81;
		private System.Windows.Forms.CheckBox checkBox80;
		private System.Windows.Forms.CheckBox checkBox79;
		private System.Windows.Forms.CheckBox checkBox78;
		private System.Windows.Forms.CheckBox checkBox77;
		private System.Windows.Forms.CheckBox checkBox76;
		private System.Windows.Forms.CheckBox checkBox75;
		private System.Windows.Forms.CheckBox checkBox74;
		private System.Windows.Forms.CheckBox checkBox73;
		private System.Windows.Forms.CheckBox checkBox72;
		private System.Windows.Forms.CheckBox checkBox71;
		private System.Windows.Forms.CheckBox checkBox70;
		private System.Windows.Forms.CheckBox checkBox69;
		private System.Windows.Forms.CheckBox checkBox68;
		private System.Windows.Forms.CheckBox checkBox67;
		private System.Windows.Forms.CheckBox checkBox66;
		private System.Windows.Forms.CheckBox checkBox54;
		private System.Windows.Forms.CheckBox checkBox53;
		private System.Windows.Forms.CheckBox checkBox52;
		private System.Windows.Forms.CheckBox checkBox51;
		private System.Windows.Forms.CheckBox checkBox50;
		private System.Windows.Forms.CheckBox checkBox49;
		private System.Windows.Forms.CheckBox checkBox48;
		private System.Windows.Forms.CheckBox checkBox47;
		private System.Windows.Forms.CheckBox checkBox46;
		private System.Windows.Forms.CheckBox checkBox45;
		private System.Windows.Forms.CheckBox checkBox44;
		private System.Windows.Forms.CheckBox checkBox43;
		private System.Windows.Forms.CheckBox checkBox42;
		private System.Windows.Forms.CheckBox checkBox41;
		private System.Windows.Forms.CheckBox checkBox40;
		private System.Windows.Forms.CheckBox checkBox39;
		private System.Windows.Forms.CheckBox checkBox38;
		private System.Windows.Forms.CheckBox checkBox37;
		private System.Windows.Forms.CheckBox checkBox63;
		private System.Windows.Forms.CheckBox checkBox62;
		private System.Windows.Forms.CheckBox checkBox61;
		private System.Windows.Forms.CheckBox checkBox60;
		private System.Windows.Forms.CheckBox checkBox59;
		private System.Windows.Forms.CheckBox checkBox58;
		private System.Windows.Forms.CheckBox checkBox57;
		private System.Windows.Forms.CheckBox checkBox56;
		private System.Windows.Forms.CheckBox checkBox55;
		private System.Windows.Forms.CheckBox checkBox65;
		private System.Windows.Forms.CheckBox checkBox64;
		private System.Windows.Forms.CheckBox checkBox36;
		private System.Windows.Forms.CheckBox checkBox35;
		private System.Windows.Forms.CheckBox checkBox34;
		private System.Windows.Forms.CheckBox checkBox33;
		private System.Windows.Forms.CheckBox checkBox32;
		private System.Windows.Forms.CheckBox checkBox31;
		private System.Windows.Forms.CheckBox checkBox30;
		private System.Windows.Forms.CheckBox checkBox18;
		private System.Windows.Forms.CheckBox checkBox17;
		private System.Windows.Forms.CheckBox checkBox16;
		private System.Windows.Forms.CheckBox checkBox15;
		private System.Windows.Forms.CheckBox checkBox14;
		private System.Windows.Forms.CheckBox checkBox13;
		private System.Windows.Forms.CheckBox checkBox12;
		private System.Windows.Forms.CheckBox checkBox11;
		private System.Windows.Forms.CheckBox checkBox10;
		private System.Windows.Forms.CheckBox checkBox9;
		private System.Windows.Forms.CheckBox checkBox8;
		private System.Windows.Forms.CheckBox checkBox7;
		private System.Windows.Forms.CheckBox checkBox6;
		private System.Windows.Forms.CheckBox checkBox5;
		private System.Windows.Forms.CheckBox checkBox4;
		private System.Windows.Forms.CheckBox checkBox3;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.CheckBox checkBox27;
		private System.Windows.Forms.CheckBox checkBox26;
		private System.Windows.Forms.CheckBox checkBox25;
		private System.Windows.Forms.CheckBox checkBox24;
		private System.Windows.Forms.CheckBox checkBox23;
		private System.Windows.Forms.CheckBox checkBox22;
		private System.Windows.Forms.CheckBox checkBox21;
		private System.Windows.Forms.CheckBox checkBox20;
		private System.Windows.Forms.CheckBox checkBox19;
		private System.Windows.Forms.CheckBox checkBox29;
		private System.Windows.Forms.CheckBox checkBox28;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button btnAutenticar;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtTextoAutenticacao;
		private System.Windows.Forms.Button btnAbrirGaveta;
		private System.Windows.Forms.Button btnCorteTotalPapel;
		private System.Windows.Forms.Button btnCorteParcialPapel;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rbtGaveta;
		private System.Windows.Forms.RadioButton rbtImpressora;
		private System.Windows.Forms.TextBox txtStatus;
		private System.Windows.Forms.Button btnLerStatus;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.Button btnImprimirCodigoBarras;
		private System.Windows.Forms.ComboBox cboCodigoBarras;
		private System.Windows.Forms.GroupBox groupBox7;
		private System.Windows.Forms.GroupBox grbFonte;
		private System.Windows.Forms.GroupBox grbPosicaoLengenda;
		private System.Windows.Forms.GroupBox groupBox6;
		private System.Windows.Forms.RadioButton rbtFina;
		private System.Windows.Forms.RadioButton rbtMedia;
		private System.Windows.Forms.RadioButton rbtGrossa;
		private System.Windows.Forms.RadioButton rbtFonteNormal;
		private System.Windows.Forms.RadioButton rbtFonteCondensada;
		private System.Windows.Forms.RadioButton rbtCaracteresAcimaCodigo;
		private System.Windows.Forms.RadioButton rbtCaracteresAbaixoCodigo;
		private System.Windows.Forms.RadioButton rbtCaracteresAcimaAbaixoCodigo;
		private System.Windows.Forms.RadioButton rbtNaoImprimeCaracteres;
		private System.Windows.Forms.TextBox txtCodigoBarras;
		private System.Windows.Forms.Button btnImprimirCaracteresAcentuados;
		private System.Windows.Forms.Button btnSair;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.GroupBox groupBox8;
		private System.Windows.Forms.Button btnAbrirImagem;
		private System.Windows.Forms.PictureBox pctImage;
		private System.Windows.Forms.TextBox txtPathImagem;
		private System.Windows.Forms.Button btnImprimirBitmap;
		private System.Windows.Forms.Button btnAplicar;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.TextBox txtGraus;
		private System.Windows.Forms.CheckBox chkAjustarImagemPapel;
		private System.Windows.Forms.GroupBox grbOrientacaoPapel;
		private System.Windows.Forms.RadioButton rbtPaisagem;
		private System.Windows.Forms.RadioButton rbtRetrato;
		private System.Windows.Forms.GroupBox grbDithering;
		
		private ImpressoraNaoFiscal miniPrinter = new ImpressoraNaoFiscal(ModeloImpressoraNaoFiscal.MP2000TH,"COM1");
		private System.Windows.Forms.ComboBox cboDithering;
		private System.Windows.Forms.GroupBox grbRotacao;
		private System.Windows.Forms.GroupBox grbQualidadeImpressao;
		private System.Windows.Forms.ComboBox cboQualidadeImpressao;
		private ImpressaoBitmap bitmap = null;

		public frmPrincipal()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmPrincipal));
			this.cboPortaComunicacao = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.cboImpressora = new System.Windows.Forms.ComboBox();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.grbImpressaoTexto = new System.Windows.Forms.GroupBox();
			this.btnImprimirCaracteresAcentuados = new System.Windows.Forms.Button();
			this.grbAlinhamento = new System.Windows.Forms.GroupBox();
			this.rbtAlignCentro = new System.Windows.Forms.RadioButton();
			this.rbtAlignEsquerda = new System.Windows.Forms.RadioButton();
			this.rbtAlignDireita = new System.Windows.Forms.RadioButton();
			this.rbtAlignNenhum = new System.Windows.Forms.RadioButton();
			this.grbFormatoFonte = new System.Windows.Forms.GroupBox();
			this.chkExpandido = new System.Windows.Forms.CheckBox();
			this.chkItalico = new System.Windows.Forms.CheckBox();
			this.chkSublinhado = new System.Windows.Forms.CheckBox();
			this.chkNegrito = new System.Windows.Forms.CheckBox();
			this.grbTamanhoFonte = new System.Windows.Forms.GroupBox();
			this.rbtNormal = new System.Windows.Forms.RadioButton();
			this.rbtElite = new System.Windows.Forms.RadioButton();
			this.rbtCondensado = new System.Windows.Forms.RadioButton();
			this.label2 = new System.Windows.Forms.Label();
			this.txtTexto = new System.Windows.Forms.TextBox();
			this.btnImprimir = new System.Windows.Forms.Button();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.btnImprimirCaracterGrafico = new System.Windows.Forms.Button();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.checkBox81 = new System.Windows.Forms.CheckBox();
			this.checkBox80 = new System.Windows.Forms.CheckBox();
			this.checkBox79 = new System.Windows.Forms.CheckBox();
			this.checkBox78 = new System.Windows.Forms.CheckBox();
			this.checkBox77 = new System.Windows.Forms.CheckBox();
			this.checkBox76 = new System.Windows.Forms.CheckBox();
			this.checkBox75 = new System.Windows.Forms.CheckBox();
			this.checkBox74 = new System.Windows.Forms.CheckBox();
			this.checkBox73 = new System.Windows.Forms.CheckBox();
			this.checkBox72 = new System.Windows.Forms.CheckBox();
			this.checkBox71 = new System.Windows.Forms.CheckBox();
			this.checkBox70 = new System.Windows.Forms.CheckBox();
			this.checkBox69 = new System.Windows.Forms.CheckBox();
			this.checkBox68 = new System.Windows.Forms.CheckBox();
			this.checkBox67 = new System.Windows.Forms.CheckBox();
			this.checkBox66 = new System.Windows.Forms.CheckBox();
			this.checkBox54 = new System.Windows.Forms.CheckBox();
			this.checkBox53 = new System.Windows.Forms.CheckBox();
			this.checkBox52 = new System.Windows.Forms.CheckBox();
			this.checkBox51 = new System.Windows.Forms.CheckBox();
			this.checkBox50 = new System.Windows.Forms.CheckBox();
			this.checkBox49 = new System.Windows.Forms.CheckBox();
			this.checkBox48 = new System.Windows.Forms.CheckBox();
			this.checkBox47 = new System.Windows.Forms.CheckBox();
			this.checkBox46 = new System.Windows.Forms.CheckBox();
			this.checkBox45 = new System.Windows.Forms.CheckBox();
			this.checkBox44 = new System.Windows.Forms.CheckBox();
			this.checkBox43 = new System.Windows.Forms.CheckBox();
			this.checkBox42 = new System.Windows.Forms.CheckBox();
			this.checkBox41 = new System.Windows.Forms.CheckBox();
			this.checkBox40 = new System.Windows.Forms.CheckBox();
			this.checkBox39 = new System.Windows.Forms.CheckBox();
			this.checkBox38 = new System.Windows.Forms.CheckBox();
			this.checkBox37 = new System.Windows.Forms.CheckBox();
			this.checkBox63 = new System.Windows.Forms.CheckBox();
			this.checkBox62 = new System.Windows.Forms.CheckBox();
			this.checkBox61 = new System.Windows.Forms.CheckBox();
			this.checkBox60 = new System.Windows.Forms.CheckBox();
			this.checkBox59 = new System.Windows.Forms.CheckBox();
			this.checkBox58 = new System.Windows.Forms.CheckBox();
			this.checkBox57 = new System.Windows.Forms.CheckBox();
			this.checkBox56 = new System.Windows.Forms.CheckBox();
			this.checkBox55 = new System.Windows.Forms.CheckBox();
			this.checkBox65 = new System.Windows.Forms.CheckBox();
			this.checkBox64 = new System.Windows.Forms.CheckBox();
			this.checkBox36 = new System.Windows.Forms.CheckBox();
			this.checkBox35 = new System.Windows.Forms.CheckBox();
			this.checkBox34 = new System.Windows.Forms.CheckBox();
			this.checkBox33 = new System.Windows.Forms.CheckBox();
			this.checkBox32 = new System.Windows.Forms.CheckBox();
			this.checkBox31 = new System.Windows.Forms.CheckBox();
			this.checkBox30 = new System.Windows.Forms.CheckBox();
			this.checkBox18 = new System.Windows.Forms.CheckBox();
			this.checkBox17 = new System.Windows.Forms.CheckBox();
			this.checkBox16 = new System.Windows.Forms.CheckBox();
			this.checkBox15 = new System.Windows.Forms.CheckBox();
			this.checkBox14 = new System.Windows.Forms.CheckBox();
			this.checkBox13 = new System.Windows.Forms.CheckBox();
			this.checkBox12 = new System.Windows.Forms.CheckBox();
			this.checkBox11 = new System.Windows.Forms.CheckBox();
			this.checkBox10 = new System.Windows.Forms.CheckBox();
			this.checkBox9 = new System.Windows.Forms.CheckBox();
			this.checkBox8 = new System.Windows.Forms.CheckBox();
			this.checkBox7 = new System.Windows.Forms.CheckBox();
			this.checkBox6 = new System.Windows.Forms.CheckBox();
			this.checkBox5 = new System.Windows.Forms.CheckBox();
			this.checkBox4 = new System.Windows.Forms.CheckBox();
			this.checkBox3 = new System.Windows.Forms.CheckBox();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.checkBox27 = new System.Windows.Forms.CheckBox();
			this.checkBox26 = new System.Windows.Forms.CheckBox();
			this.checkBox25 = new System.Windows.Forms.CheckBox();
			this.checkBox24 = new System.Windows.Forms.CheckBox();
			this.checkBox23 = new System.Windows.Forms.CheckBox();
			this.checkBox22 = new System.Windows.Forms.CheckBox();
			this.checkBox21 = new System.Windows.Forms.CheckBox();
			this.checkBox20 = new System.Windows.Forms.CheckBox();
			this.checkBox19 = new System.Windows.Forms.CheckBox();
			this.checkBox29 = new System.Windows.Forms.CheckBox();
			this.checkBox28 = new System.Windows.Forms.CheckBox();
			this.label14 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btnAutenticar = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.txtTextoAutenticacao = new System.Windows.Forms.TextBox();
			this.btnAbrirGaveta = new System.Windows.Forms.Button();
			this.btnCorteTotalPapel = new System.Windows.Forms.Button();
			this.btnCorteParcialPapel = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rbtGaveta = new System.Windows.Forms.RadioButton();
			this.rbtImpressora = new System.Windows.Forms.RadioButton();
			this.txtStatus = new System.Windows.Forms.TextBox();
			this.btnLerStatus = new System.Windows.Forms.Button();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.groupBox6 = new System.Windows.Forms.GroupBox();
			this.txtCodigoBarras = new System.Windows.Forms.TextBox();
			this.grbPosicaoLengenda = new System.Windows.Forms.GroupBox();
			this.rbtNaoImprimeCaracteres = new System.Windows.Forms.RadioButton();
			this.rbtCaracteresAcimaAbaixoCodigo = new System.Windows.Forms.RadioButton();
			this.rbtCaracteresAbaixoCodigo = new System.Windows.Forms.RadioButton();
			this.rbtCaracteresAcimaCodigo = new System.Windows.Forms.RadioButton();
			this.groupBox7 = new System.Windows.Forms.GroupBox();
			this.rbtGrossa = new System.Windows.Forms.RadioButton();
			this.rbtMedia = new System.Windows.Forms.RadioButton();
			this.rbtFina = new System.Windows.Forms.RadioButton();
			this.grbFonte = new System.Windows.Forms.GroupBox();
			this.rbtFonteCondensada = new System.Windows.Forms.RadioButton();
			this.rbtFonteNormal = new System.Windows.Forms.RadioButton();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.cboCodigoBarras = new System.Windows.Forms.ComboBox();
			this.btnImprimirCodigoBarras = new System.Windows.Forms.Button();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.grbQualidadeImpressao = new System.Windows.Forms.GroupBox();
			this.cboQualidadeImpressao = new System.Windows.Forms.ComboBox();
			this.grbRotacao = new System.Windows.Forms.GroupBox();
			this.btnAplicar = new System.Windows.Forms.Button();
			this.label15 = new System.Windows.Forms.Label();
			this.txtGraus = new System.Windows.Forms.TextBox();
			this.chkAjustarImagemPapel = new System.Windows.Forms.CheckBox();
			this.grbOrientacaoPapel = new System.Windows.Forms.GroupBox();
			this.rbtPaisagem = new System.Windows.Forms.RadioButton();
			this.rbtRetrato = new System.Windows.Forms.RadioButton();
			this.groupBox8 = new System.Windows.Forms.GroupBox();
			this.txtPathImagem = new System.Windows.Forms.TextBox();
			this.btnImprimirBitmap = new System.Windows.Forms.Button();
			this.btnAbrirImagem = new System.Windows.Forms.Button();
			this.pctImage = new System.Windows.Forms.PictureBox();
			this.grbDithering = new System.Windows.Forms.GroupBox();
			this.cboDithering = new System.Windows.Forms.ComboBox();
			this.btnSair = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.grbImpressaoTexto.SuspendLayout();
			this.grbAlinhamento.SuspendLayout();
			this.grbFormatoFonte.SuspendLayout();
			this.grbTamanhoFonte.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.groupBox6.SuspendLayout();
			this.grbPosicaoLengenda.SuspendLayout();
			this.groupBox7.SuspendLayout();
			this.grbFonte.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.grbQualidadeImpressao.SuspendLayout();
			this.grbRotacao.SuspendLayout();
			this.grbOrientacaoPapel.SuspendLayout();
			this.groupBox8.SuspendLayout();
			this.grbDithering.SuspendLayout();
			this.SuspendLayout();
			// 
			// cboPortaComunicacao
			// 
			this.cboPortaComunicacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboPortaComunicacao.Items.AddRange(new object[] {
																	 "COM1",
																	 "COM2",
																	 "COM3",
																	 "COM4",
																	 "COM5",
																	 "COM6",
																	 "LPT1",
																	 "LPT2",
																	 "USB"});
			this.cboPortaComunicacao.Location = new System.Drawing.Point(144, 8);
			this.cboPortaComunicacao.Name = "cboPortaComunicacao";
			this.cboPortaComunicacao.Size = new System.Drawing.Size(80, 21);
			this.cboPortaComunicacao.TabIndex = 2;
			this.cboPortaComunicacao.SelectedIndexChanged += new System.EventHandler(this.cboPortaComunicacao_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(120, 23);
			this.label1.TabIndex = 3;
			this.label1.Text = "Porta de comunicaÁ„o:";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(240, 13);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(64, 23);
			this.label3.TabIndex = 6;
			this.label3.Text = "Impressora:";
			// 
			// cboImpressora
			// 
			this.cboImpressora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboImpressora.Items.AddRange(new object[] {
															   "MP20 CI",
															   "MP20 MI",
															   "MP20 TH",
															   "MP2000 CI",
															   "MP2000 TH",
															   "MP2100 TH"});
			this.cboImpressora.Location = new System.Drawing.Point(304, 8);
			this.cboImpressora.Name = "cboImpressora";
			this.cboImpressora.Size = new System.Drawing.Size(112, 21);
			this.cboImpressora.TabIndex = 5;
			this.cboImpressora.SelectedIndexChanged += new System.EventHandler(this.cboImpressora_SelectedIndexChanged);
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Location = new System.Drawing.Point(8, 40);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(662, 456);
			this.tabControl1.TabIndex = 7;
			this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.grbImpressaoTexto);
			this.tabPage1.Controls.Add(this.groupBox3);
			this.tabPage1.Controls.Add(this.groupBox2);
			this.tabPage1.Controls.Add(this.btnAbrirGaveta);
			this.tabPage1.Controls.Add(this.btnCorteTotalPapel);
			this.tabPage1.Controls.Add(this.btnCorteParcialPapel);
			this.tabPage1.Controls.Add(this.groupBox1);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Size = new System.Drawing.Size(654, 430);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Geral";
			// 
			// grbImpressaoTexto
			// 
			this.grbImpressaoTexto.Controls.Add(this.btnImprimirCaracteresAcentuados);
			this.grbImpressaoTexto.Controls.Add(this.grbAlinhamento);
			this.grbImpressaoTexto.Controls.Add(this.grbFormatoFonte);
			this.grbImpressaoTexto.Controls.Add(this.grbTamanhoFonte);
			this.grbImpressaoTexto.Controls.Add(this.label2);
			this.grbImpressaoTexto.Controls.Add(this.txtTexto);
			this.grbImpressaoTexto.Controls.Add(this.btnImprimir);
			this.grbImpressaoTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.grbImpressaoTexto.Location = new System.Drawing.Point(32, 8);
			this.grbImpressaoTexto.Name = "grbImpressaoTexto";
			this.grbImpressaoTexto.Size = new System.Drawing.Size(376, 256);
			this.grbImpressaoTexto.TabIndex = 24;
			this.grbImpressaoTexto.TabStop = false;
			this.grbImpressaoTexto.Text = "Impress„o de Texto";
			// 
			// btnImprimirCaracteresAcentuados
			// 
			this.btnImprimirCaracteresAcentuados.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnImprimirCaracteresAcentuados.Location = new System.Drawing.Point(136, 224);
			this.btnImprimirCaracteresAcentuados.Name = "btnImprimirCaracteresAcentuados";
			this.btnImprimirCaracteresAcentuados.Size = new System.Drawing.Size(232, 24);
			this.btnImprimirCaracteresAcentuados.TabIndex = 17;
			this.btnImprimirCaracteresAcentuados.Text = "Imprimir Caracteres Acentuados";
			this.btnImprimirCaracteresAcentuados.Click += new System.EventHandler(this.btnImprimirCaracteresAcentuados_Click);
			// 
			// grbAlinhamento
			// 
			this.grbAlinhamento.Controls.Add(this.rbtAlignCentro);
			this.grbAlinhamento.Controls.Add(this.rbtAlignEsquerda);
			this.grbAlinhamento.Controls.Add(this.rbtAlignDireita);
			this.grbAlinhamento.Controls.Add(this.rbtAlignNenhum);
			this.grbAlinhamento.Location = new System.Drawing.Point(264, 88);
			this.grbAlinhamento.Name = "grbAlinhamento";
			this.grbAlinhamento.Size = new System.Drawing.Size(104, 110);
			this.grbAlinhamento.TabIndex = 16;
			this.grbAlinhamento.TabStop = false;
			this.grbAlinhamento.Text = "Alinhamento";
			// 
			// rbtAlignCentro
			// 
			this.rbtAlignCentro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.rbtAlignCentro.Location = new System.Drawing.Point(7, 83);
			this.rbtAlignCentro.Name = "rbtAlignCentro";
			this.rbtAlignCentro.Size = new System.Drawing.Size(86, 21);
			this.rbtAlignCentro.TabIndex = 3;
			this.rbtAlignCentro.Text = "Centro";
			// 
			// rbtAlignEsquerda
			// 
			this.rbtAlignEsquerda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.rbtAlignEsquerda.Location = new System.Drawing.Point(7, 36);
			this.rbtAlignEsquerda.Name = "rbtAlignEsquerda";
			this.rbtAlignEsquerda.Size = new System.Drawing.Size(86, 20);
			this.rbtAlignEsquerda.TabIndex = 2;
			this.rbtAlignEsquerda.Text = "Esquerda";
			// 
			// rbtAlignDireita
			// 
			this.rbtAlignDireita.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.rbtAlignDireita.Location = new System.Drawing.Point(7, 60);
			this.rbtAlignDireita.Name = "rbtAlignDireita";
			this.rbtAlignDireita.Size = new System.Drawing.Size(86, 21);
			this.rbtAlignDireita.TabIndex = 1;
			this.rbtAlignDireita.Text = "Direita";
			// 
			// rbtAlignNenhum
			// 
			this.rbtAlignNenhum.Checked = true;
			this.rbtAlignNenhum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.rbtAlignNenhum.Location = new System.Drawing.Point(7, 14);
			this.rbtAlignNenhum.Name = "rbtAlignNenhum";
			this.rbtAlignNenhum.Size = new System.Drawing.Size(86, 21);
			this.rbtAlignNenhum.TabIndex = 0;
			this.rbtAlignNenhum.TabStop = true;
			this.rbtAlignNenhum.Text = "Nenhum";
			// 
			// grbFormatoFonte
			// 
			this.grbFormatoFonte.Controls.Add(this.chkExpandido);
			this.grbFormatoFonte.Controls.Add(this.chkItalico);
			this.grbFormatoFonte.Controls.Add(this.chkSublinhado);
			this.grbFormatoFonte.Controls.Add(this.chkNegrito);
			this.grbFormatoFonte.Location = new System.Drawing.Point(136, 88);
			this.grbFormatoFonte.Name = "grbFormatoFonte";
			this.grbFormatoFonte.Size = new System.Drawing.Size(112, 111);
			this.grbFormatoFonte.TabIndex = 15;
			this.grbFormatoFonte.TabStop = false;
			this.grbFormatoFonte.Text = "Formato Fonte";
			// 
			// chkExpandido
			// 
			this.chkExpandido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.chkExpandido.Location = new System.Drawing.Point(8, 88);
			this.chkExpandido.Name = "chkExpandido";
			this.chkExpandido.Size = new System.Drawing.Size(87, 21);
			this.chkExpandido.TabIndex = 3;
			this.chkExpandido.Text = "Expandido";
			// 
			// chkItalico
			// 
			this.chkItalico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.chkItalico.Location = new System.Drawing.Point(8, 40);
			this.chkItalico.Name = "chkItalico";
			this.chkItalico.Size = new System.Drawing.Size(87, 20);
			this.chkItalico.TabIndex = 2;
			this.chkItalico.Text = "It·lico";
			// 
			// chkSublinhado
			// 
			this.chkSublinhado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.chkSublinhado.Location = new System.Drawing.Point(8, 64);
			this.chkSublinhado.Name = "chkSublinhado";
			this.chkSublinhado.Size = new System.Drawing.Size(87, 21);
			this.chkSublinhado.TabIndex = 1;
			this.chkSublinhado.Text = "Sublinhado";
			// 
			// chkNegrito
			// 
			this.chkNegrito.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.chkNegrito.Location = new System.Drawing.Point(8, 16);
			this.chkNegrito.Name = "chkNegrito";
			this.chkNegrito.Size = new System.Drawing.Size(87, 21);
			this.chkNegrito.TabIndex = 0;
			this.chkNegrito.Text = "Negrito";
			// 
			// grbTamanhoFonte
			// 
			this.grbTamanhoFonte.Controls.Add(this.rbtNormal);
			this.grbTamanhoFonte.Controls.Add(this.rbtElite);
			this.grbTamanhoFonte.Controls.Add(this.rbtCondensado);
			this.grbTamanhoFonte.Location = new System.Drawing.Point(8, 88);
			this.grbTamanhoFonte.Name = "grbTamanhoFonte";
			this.grbTamanhoFonte.Size = new System.Drawing.Size(112, 110);
			this.grbTamanhoFonte.TabIndex = 14;
			this.grbTamanhoFonte.TabStop = false;
			this.grbTamanhoFonte.Text = "Tamanho Fonte";
			// 
			// rbtNormal
			// 
			this.rbtNormal.Checked = true;
			this.rbtNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.rbtNormal.Location = new System.Drawing.Point(8, 24);
			this.rbtNormal.Name = "rbtNormal";
			this.rbtNormal.Size = new System.Drawing.Size(86, 21);
			this.rbtNormal.TabIndex = 3;
			this.rbtNormal.TabStop = true;
			this.rbtNormal.Text = "Normal";
			// 
			// rbtElite
			// 
			this.rbtElite.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.rbtElite.Location = new System.Drawing.Point(8, 52);
			this.rbtElite.Name = "rbtElite";
			this.rbtElite.Size = new System.Drawing.Size(86, 21);
			this.rbtElite.TabIndex = 2;
			this.rbtElite.Text = "Elite";
			// 
			// rbtCondensado
			// 
			this.rbtCondensado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.rbtCondensado.Location = new System.Drawing.Point(8, 80);
			this.rbtCondensado.Name = "rbtCondensado";
			this.rbtCondensado.Size = new System.Drawing.Size(86, 21);
			this.rbtCondensado.TabIndex = 0;
			this.rbtCondensado.Text = "Condensado";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(8, 24);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(128, 16);
			this.label2.TabIndex = 13;
			this.label2.Text = "Texto a ser impresso:";
			// 
			// txtTexto
			// 
			this.txtTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtTexto.Location = new System.Drawing.Point(8, 40);
			this.txtTexto.Name = "txtTexto";
			this.txtTexto.Size = new System.Drawing.Size(344, 20);
			this.txtTexto.TabIndex = 12;
			this.txtTexto.Text = "Teste de impressao";
			// 
			// btnImprimir
			// 
			this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnImprimir.Location = new System.Drawing.Point(8, 224);
			this.btnImprimir.Name = "btnImprimir";
			this.btnImprimir.Size = new System.Drawing.Size(112, 24);
			this.btnImprimir.TabIndex = 11;
			this.btnImprimir.Text = "Imprimir";
			this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.btnImprimirCaracterGrafico);
			this.groupBox3.Controls.Add(this.groupBox4);
			this.groupBox3.Controls.Add(this.label14);
			this.groupBox3.Controls.Add(this.label13);
			this.groupBox3.Controls.Add(this.label9);
			this.groupBox3.Controls.Add(this.label10);
			this.groupBox3.Controls.Add(this.label11);
			this.groupBox3.Controls.Add(this.label12);
			this.groupBox3.Controls.Add(this.label7);
			this.groupBox3.Controls.Add(this.label8);
			this.groupBox3.Controls.Add(this.label6);
			this.groupBox3.Controls.Add(this.label5);
			this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.groupBox3.Location = new System.Drawing.Point(432, 8);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(208, 256);
			this.groupBox3.TabIndex = 23;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Caracter Gr·fico";
			// 
			// btnImprimirCaracterGrafico
			// 
			this.btnImprimirCaracterGrafico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnImprimirCaracterGrafico.Location = new System.Drawing.Point(40, 224);
			this.btnImprimirCaracterGrafico.Name = "btnImprimirCaracterGrafico";
			this.btnImprimirCaracterGrafico.Size = new System.Drawing.Size(160, 24);
			this.btnImprimirCaracterGrafico.TabIndex = 11;
			this.btnImprimirCaracterGrafico.Text = "Imprimir";
			this.btnImprimirCaracterGrafico.Click += new System.EventHandler(this.btnImprimirCaracterGrafico_Click);
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.checkBox81);
			this.groupBox4.Controls.Add(this.checkBox80);
			this.groupBox4.Controls.Add(this.checkBox79);
			this.groupBox4.Controls.Add(this.checkBox78);
			this.groupBox4.Controls.Add(this.checkBox77);
			this.groupBox4.Controls.Add(this.checkBox76);
			this.groupBox4.Controls.Add(this.checkBox75);
			this.groupBox4.Controls.Add(this.checkBox74);
			this.groupBox4.Controls.Add(this.checkBox73);
			this.groupBox4.Controls.Add(this.checkBox72);
			this.groupBox4.Controls.Add(this.checkBox71);
			this.groupBox4.Controls.Add(this.checkBox70);
			this.groupBox4.Controls.Add(this.checkBox69);
			this.groupBox4.Controls.Add(this.checkBox68);
			this.groupBox4.Controls.Add(this.checkBox67);
			this.groupBox4.Controls.Add(this.checkBox66);
			this.groupBox4.Controls.Add(this.checkBox54);
			this.groupBox4.Controls.Add(this.checkBox53);
			this.groupBox4.Controls.Add(this.checkBox52);
			this.groupBox4.Controls.Add(this.checkBox51);
			this.groupBox4.Controls.Add(this.checkBox50);
			this.groupBox4.Controls.Add(this.checkBox49);
			this.groupBox4.Controls.Add(this.checkBox48);
			this.groupBox4.Controls.Add(this.checkBox47);
			this.groupBox4.Controls.Add(this.checkBox46);
			this.groupBox4.Controls.Add(this.checkBox45);
			this.groupBox4.Controls.Add(this.checkBox44);
			this.groupBox4.Controls.Add(this.checkBox43);
			this.groupBox4.Controls.Add(this.checkBox42);
			this.groupBox4.Controls.Add(this.checkBox41);
			this.groupBox4.Controls.Add(this.checkBox40);
			this.groupBox4.Controls.Add(this.checkBox39);
			this.groupBox4.Controls.Add(this.checkBox38);
			this.groupBox4.Controls.Add(this.checkBox37);
			this.groupBox4.Controls.Add(this.checkBox63);
			this.groupBox4.Controls.Add(this.checkBox62);
			this.groupBox4.Controls.Add(this.checkBox61);
			this.groupBox4.Controls.Add(this.checkBox60);
			this.groupBox4.Controls.Add(this.checkBox59);
			this.groupBox4.Controls.Add(this.checkBox58);
			this.groupBox4.Controls.Add(this.checkBox57);
			this.groupBox4.Controls.Add(this.checkBox56);
			this.groupBox4.Controls.Add(this.checkBox55);
			this.groupBox4.Controls.Add(this.checkBox65);
			this.groupBox4.Controls.Add(this.checkBox64);
			this.groupBox4.Controls.Add(this.checkBox36);
			this.groupBox4.Controls.Add(this.checkBox35);
			this.groupBox4.Controls.Add(this.checkBox34);
			this.groupBox4.Controls.Add(this.checkBox33);
			this.groupBox4.Controls.Add(this.checkBox32);
			this.groupBox4.Controls.Add(this.checkBox31);
			this.groupBox4.Controls.Add(this.checkBox30);
			this.groupBox4.Controls.Add(this.checkBox18);
			this.groupBox4.Controls.Add(this.checkBox17);
			this.groupBox4.Controls.Add(this.checkBox16);
			this.groupBox4.Controls.Add(this.checkBox15);
			this.groupBox4.Controls.Add(this.checkBox14);
			this.groupBox4.Controls.Add(this.checkBox13);
			this.groupBox4.Controls.Add(this.checkBox12);
			this.groupBox4.Controls.Add(this.checkBox11);
			this.groupBox4.Controls.Add(this.checkBox10);
			this.groupBox4.Controls.Add(this.checkBox9);
			this.groupBox4.Controls.Add(this.checkBox8);
			this.groupBox4.Controls.Add(this.checkBox7);
			this.groupBox4.Controls.Add(this.checkBox6);
			this.groupBox4.Controls.Add(this.checkBox5);
			this.groupBox4.Controls.Add(this.checkBox4);
			this.groupBox4.Controls.Add(this.checkBox3);
			this.groupBox4.Controls.Add(this.checkBox2);
			this.groupBox4.Controls.Add(this.checkBox1);
			this.groupBox4.Controls.Add(this.checkBox27);
			this.groupBox4.Controls.Add(this.checkBox26);
			this.groupBox4.Controls.Add(this.checkBox25);
			this.groupBox4.Controls.Add(this.checkBox24);
			this.groupBox4.Controls.Add(this.checkBox23);
			this.groupBox4.Controls.Add(this.checkBox22);
			this.groupBox4.Controls.Add(this.checkBox21);
			this.groupBox4.Controls.Add(this.checkBox20);
			this.groupBox4.Controls.Add(this.checkBox19);
			this.groupBox4.Controls.Add(this.checkBox29);
			this.groupBox4.Controls.Add(this.checkBox28);
			this.groupBox4.Location = new System.Drawing.Point(40, 40);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(160, 176);
			this.groupBox4.TabIndex = 10;
			this.groupBox4.TabStop = false;
			// 
			// checkBox81
			// 
			this.checkBox81.Checked = true;
			this.checkBox81.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox81.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox81.Location = new System.Drawing.Point(136, 146);
			this.checkBox81.Name = "checkBox81";
			this.checkBox81.Size = new System.Drawing.Size(16, 24);
			this.checkBox81.TabIndex = 80;
			// 
			// checkBox80
			// 
			this.checkBox80.Checked = true;
			this.checkBox80.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox80.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox80.Location = new System.Drawing.Point(136, 129);
			this.checkBox80.Name = "checkBox80";
			this.checkBox80.Size = new System.Drawing.Size(16, 24);
			this.checkBox80.TabIndex = 81;
			// 
			// checkBox79
			// 
			this.checkBox79.Checked = true;
			this.checkBox79.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox79.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox79.Location = new System.Drawing.Point(136, 112);
			this.checkBox79.Name = "checkBox79";
			this.checkBox79.Size = new System.Drawing.Size(16, 24);
			this.checkBox79.TabIndex = 82;
			// 
			// checkBox78
			// 
			this.checkBox78.Checked = true;
			this.checkBox78.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox78.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox78.Location = new System.Drawing.Point(136, 95);
			this.checkBox78.Name = "checkBox78";
			this.checkBox78.Size = new System.Drawing.Size(16, 24);
			this.checkBox78.TabIndex = 83;
			// 
			// checkBox77
			// 
			this.checkBox77.Checked = true;
			this.checkBox77.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox77.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox77.Location = new System.Drawing.Point(136, 77);
			this.checkBox77.Name = "checkBox77";
			this.checkBox77.Size = new System.Drawing.Size(16, 24);
			this.checkBox77.TabIndex = 87;
			// 
			// checkBox76
			// 
			this.checkBox76.Checked = true;
			this.checkBox76.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox76.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox76.Location = new System.Drawing.Point(136, 59);
			this.checkBox76.Name = "checkBox76";
			this.checkBox76.Size = new System.Drawing.Size(16, 24);
			this.checkBox76.TabIndex = 86;
			// 
			// checkBox75
			// 
			this.checkBox75.Checked = true;
			this.checkBox75.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox75.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox75.Location = new System.Drawing.Point(136, 42);
			this.checkBox75.Name = "checkBox75";
			this.checkBox75.Size = new System.Drawing.Size(16, 24);
			this.checkBox75.TabIndex = 85;
			// 
			// checkBox74
			// 
			this.checkBox74.Checked = true;
			this.checkBox74.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox74.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox74.Location = new System.Drawing.Point(136, 25);
			this.checkBox74.Name = "checkBox74";
			this.checkBox74.Size = new System.Drawing.Size(16, 24);
			this.checkBox74.TabIndex = 84;
			// 
			// checkBox73
			// 
			this.checkBox73.Checked = true;
			this.checkBox73.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox73.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox73.Location = new System.Drawing.Point(136, 8);
			this.checkBox73.Name = "checkBox73";
			this.checkBox73.Size = new System.Drawing.Size(16, 24);
			this.checkBox73.TabIndex = 88;
			// 
			// checkBox72
			// 
			this.checkBox72.Checked = true;
			this.checkBox72.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox72.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox72.Location = new System.Drawing.Point(120, 146);
			this.checkBox72.Name = "checkBox72";
			this.checkBox72.Size = new System.Drawing.Size(16, 24);
			this.checkBox72.TabIndex = 53;
			// 
			// checkBox71
			// 
			this.checkBox71.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox71.Location = new System.Drawing.Point(120, 129);
			this.checkBox71.Name = "checkBox71";
			this.checkBox71.Size = new System.Drawing.Size(16, 24);
			this.checkBox71.TabIndex = 57;
			// 
			// checkBox70
			// 
			this.checkBox70.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox70.Location = new System.Drawing.Point(120, 112);
			this.checkBox70.Name = "checkBox70";
			this.checkBox70.Size = new System.Drawing.Size(16, 24);
			this.checkBox70.TabIndex = 59;
			// 
			// checkBox69
			// 
			this.checkBox69.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox69.Location = new System.Drawing.Point(120, 95);
			this.checkBox69.Name = "checkBox69";
			this.checkBox69.Size = new System.Drawing.Size(16, 24);
			this.checkBox69.TabIndex = 62;
			// 
			// checkBox68
			// 
			this.checkBox68.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox68.Location = new System.Drawing.Point(120, 77);
			this.checkBox68.Name = "checkBox68";
			this.checkBox68.Size = new System.Drawing.Size(16, 24);
			this.checkBox68.TabIndex = 76;
			// 
			// checkBox67
			// 
			this.checkBox67.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox67.Location = new System.Drawing.Point(120, 59);
			this.checkBox67.Name = "checkBox67";
			this.checkBox67.Size = new System.Drawing.Size(16, 24);
			this.checkBox67.TabIndex = 72;
			// 
			// checkBox66
			// 
			this.checkBox66.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox66.Location = new System.Drawing.Point(120, 42);
			this.checkBox66.Name = "checkBox66";
			this.checkBox66.Size = new System.Drawing.Size(16, 24);
			this.checkBox66.TabIndex = 70;
			// 
			// checkBox54
			// 
			this.checkBox54.Checked = true;
			this.checkBox54.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox54.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox54.Location = new System.Drawing.Point(88, 146);
			this.checkBox54.Name = "checkBox54";
			this.checkBox54.Size = new System.Drawing.Size(16, 24);
			this.checkBox54.TabIndex = 78;
			// 
			// checkBox53
			// 
			this.checkBox53.Checked = true;
			this.checkBox53.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox53.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox53.Location = new System.Drawing.Point(88, 129);
			this.checkBox53.Name = "checkBox53";
			this.checkBox53.Size = new System.Drawing.Size(16, 24);
			this.checkBox53.TabIndex = 65;
			// 
			// checkBox52
			// 
			this.checkBox52.Checked = true;
			this.checkBox52.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox52.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox52.Location = new System.Drawing.Point(88, 112);
			this.checkBox52.Name = "checkBox52";
			this.checkBox52.Size = new System.Drawing.Size(16, 24);
			this.checkBox52.TabIndex = 68;
			// 
			// checkBox51
			// 
			this.checkBox51.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox51.Location = new System.Drawing.Point(88, 95);
			this.checkBox51.Name = "checkBox51";
			this.checkBox51.Size = new System.Drawing.Size(16, 24);
			this.checkBox51.TabIndex = 73;
			// 
			// checkBox50
			// 
			this.checkBox50.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox50.Location = new System.Drawing.Point(88, 77);
			this.checkBox50.Name = "checkBox50";
			this.checkBox50.Size = new System.Drawing.Size(16, 24);
			this.checkBox50.TabIndex = 74;
			// 
			// checkBox49
			// 
			this.checkBox49.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox49.Location = new System.Drawing.Point(88, 59);
			this.checkBox49.Name = "checkBox49";
			this.checkBox49.Size = new System.Drawing.Size(16, 24);
			this.checkBox49.TabIndex = 64;
			// 
			// checkBox48
			// 
			this.checkBox48.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox48.Location = new System.Drawing.Point(88, 42);
			this.checkBox48.Name = "checkBox48";
			this.checkBox48.Size = new System.Drawing.Size(16, 24);
			this.checkBox48.TabIndex = 61;
			// 
			// checkBox47
			// 
			this.checkBox47.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox47.Location = new System.Drawing.Point(88, 25);
			this.checkBox47.Name = "checkBox47";
			this.checkBox47.Size = new System.Drawing.Size(16, 24);
			this.checkBox47.TabIndex = 56;
			// 
			// checkBox46
			// 
			this.checkBox46.Checked = true;
			this.checkBox46.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox46.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox46.Location = new System.Drawing.Point(88, 8);
			this.checkBox46.Name = "checkBox46";
			this.checkBox46.Size = new System.Drawing.Size(16, 24);
			this.checkBox46.TabIndex = 54;
			// 
			// checkBox45
			// 
			this.checkBox45.Checked = true;
			this.checkBox45.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox45.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox45.Location = new System.Drawing.Point(72, 146);
			this.checkBox45.Name = "checkBox45";
			this.checkBox45.Size = new System.Drawing.Size(16, 24);
			this.checkBox45.TabIndex = 52;
			// 
			// checkBox44
			// 
			this.checkBox44.Checked = true;
			this.checkBox44.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox44.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox44.Location = new System.Drawing.Point(72, 129);
			this.checkBox44.Name = "checkBox44";
			this.checkBox44.Size = new System.Drawing.Size(16, 24);
			this.checkBox44.TabIndex = 48;
			// 
			// checkBox43
			// 
			this.checkBox43.Checked = true;
			this.checkBox43.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox43.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox43.Location = new System.Drawing.Point(72, 112);
			this.checkBox43.Name = "checkBox43";
			this.checkBox43.Size = new System.Drawing.Size(16, 24);
			this.checkBox43.TabIndex = 49;
			// 
			// checkBox42
			// 
			this.checkBox42.Checked = true;
			this.checkBox42.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox42.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox42.Location = new System.Drawing.Point(72, 95);
			this.checkBox42.Name = "checkBox42";
			this.checkBox42.Size = new System.Drawing.Size(16, 24);
			this.checkBox42.TabIndex = 50;
			// 
			// checkBox41
			// 
			this.checkBox41.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox41.Location = new System.Drawing.Point(72, 77);
			this.checkBox41.Name = "checkBox41";
			this.checkBox41.Size = new System.Drawing.Size(16, 24);
			this.checkBox41.TabIndex = 51;
			// 
			// checkBox40
			// 
			this.checkBox40.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox40.Location = new System.Drawing.Point(72, 59);
			this.checkBox40.Name = "checkBox40";
			this.checkBox40.Size = new System.Drawing.Size(16, 24);
			this.checkBox40.TabIndex = 47;
			// 
			// checkBox39
			// 
			this.checkBox39.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox39.Location = new System.Drawing.Point(72, 42);
			this.checkBox39.Name = "checkBox39";
			this.checkBox39.Size = new System.Drawing.Size(16, 24);
			this.checkBox39.TabIndex = 46;
			// 
			// checkBox38
			// 
			this.checkBox38.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox38.Location = new System.Drawing.Point(72, 25);
			this.checkBox38.Name = "checkBox38";
			this.checkBox38.Size = new System.Drawing.Size(16, 24);
			this.checkBox38.TabIndex = 45;
			// 
			// checkBox37
			// 
			this.checkBox37.Checked = true;
			this.checkBox37.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox37.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox37.Location = new System.Drawing.Point(72, 8);
			this.checkBox37.Name = "checkBox37";
			this.checkBox37.Size = new System.Drawing.Size(16, 24);
			this.checkBox37.TabIndex = 44;
			// 
			// checkBox63
			// 
			this.checkBox63.Checked = true;
			this.checkBox63.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox63.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox63.Location = new System.Drawing.Point(104, 146);
			this.checkBox63.Name = "checkBox63";
			this.checkBox63.Size = new System.Drawing.Size(16, 24);
			this.checkBox63.TabIndex = 55;
			// 
			// checkBox62
			// 
			this.checkBox62.Checked = true;
			this.checkBox62.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox62.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox62.Location = new System.Drawing.Point(104, 129);
			this.checkBox62.Name = "checkBox62";
			this.checkBox62.Size = new System.Drawing.Size(16, 24);
			this.checkBox62.TabIndex = 58;
			// 
			// checkBox61
			// 
			this.checkBox61.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox61.Location = new System.Drawing.Point(104, 112);
			this.checkBox61.Name = "checkBox61";
			this.checkBox61.Size = new System.Drawing.Size(16, 24);
			this.checkBox61.TabIndex = 60;
			// 
			// checkBox60
			// 
			this.checkBox60.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox60.Location = new System.Drawing.Point(104, 95);
			this.checkBox60.Name = "checkBox60";
			this.checkBox60.Size = new System.Drawing.Size(16, 24);
			this.checkBox60.TabIndex = 63;
			// 
			// checkBox59
			// 
			this.checkBox59.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox59.Location = new System.Drawing.Point(104, 77);
			this.checkBox59.Name = "checkBox59";
			this.checkBox59.Size = new System.Drawing.Size(16, 24);
			this.checkBox59.TabIndex = 75;
			// 
			// checkBox58
			// 
			this.checkBox58.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox58.Location = new System.Drawing.Point(104, 59);
			this.checkBox58.Name = "checkBox58";
			this.checkBox58.Size = new System.Drawing.Size(16, 24);
			this.checkBox58.TabIndex = 71;
			// 
			// checkBox57
			// 
			this.checkBox57.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox57.Location = new System.Drawing.Point(104, 42);
			this.checkBox57.Name = "checkBox57";
			this.checkBox57.Size = new System.Drawing.Size(16, 24);
			this.checkBox57.TabIndex = 69;
			// 
			// checkBox56
			// 
			this.checkBox56.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox56.Location = new System.Drawing.Point(104, 25);
			this.checkBox56.Name = "checkBox56";
			this.checkBox56.Size = new System.Drawing.Size(16, 24);
			this.checkBox56.TabIndex = 67;
			// 
			// checkBox55
			// 
			this.checkBox55.Checked = true;
			this.checkBox55.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox55.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox55.Location = new System.Drawing.Point(104, 8);
			this.checkBox55.Name = "checkBox55";
			this.checkBox55.Size = new System.Drawing.Size(16, 24);
			this.checkBox55.TabIndex = 79;
			// 
			// checkBox65
			// 
			this.checkBox65.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox65.Location = new System.Drawing.Point(120, 25);
			this.checkBox65.Name = "checkBox65";
			this.checkBox65.Size = new System.Drawing.Size(16, 24);
			this.checkBox65.TabIndex = 66;
			// 
			// checkBox64
			// 
			this.checkBox64.Checked = true;
			this.checkBox64.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox64.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox64.Location = new System.Drawing.Point(120, 8);
			this.checkBox64.Name = "checkBox64";
			this.checkBox64.Size = new System.Drawing.Size(16, 24);
			this.checkBox64.TabIndex = 77;
			// 
			// checkBox36
			// 
			this.checkBox36.Checked = true;
			this.checkBox36.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox36.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox36.Location = new System.Drawing.Point(56, 146);
			this.checkBox36.Name = "checkBox36";
			this.checkBox36.Size = new System.Drawing.Size(16, 24);
			this.checkBox36.TabIndex = 35;
			// 
			// checkBox35
			// 
			this.checkBox35.Checked = true;
			this.checkBox35.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox35.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox35.Location = new System.Drawing.Point(56, 129);
			this.checkBox35.Name = "checkBox35";
			this.checkBox35.Size = new System.Drawing.Size(16, 24);
			this.checkBox35.TabIndex = 36;
			// 
			// checkBox34
			// 
			this.checkBox34.Checked = true;
			this.checkBox34.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox34.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox34.Location = new System.Drawing.Point(56, 112);
			this.checkBox34.Name = "checkBox34";
			this.checkBox34.Size = new System.Drawing.Size(16, 24);
			this.checkBox34.TabIndex = 37;
			// 
			// checkBox33
			// 
			this.checkBox33.Checked = true;
			this.checkBox33.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox33.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox33.Location = new System.Drawing.Point(56, 95);
			this.checkBox33.Name = "checkBox33";
			this.checkBox33.Size = new System.Drawing.Size(16, 24);
			this.checkBox33.TabIndex = 38;
			// 
			// checkBox32
			// 
			this.checkBox32.Checked = true;
			this.checkBox32.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox32.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox32.Location = new System.Drawing.Point(56, 77);
			this.checkBox32.Name = "checkBox32";
			this.checkBox32.Size = new System.Drawing.Size(16, 24);
			this.checkBox32.TabIndex = 42;
			// 
			// checkBox31
			// 
			this.checkBox31.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox31.Location = new System.Drawing.Point(56, 59);
			this.checkBox31.Name = "checkBox31";
			this.checkBox31.Size = new System.Drawing.Size(16, 24);
			this.checkBox31.TabIndex = 41;
			// 
			// checkBox30
			// 
			this.checkBox30.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox30.Location = new System.Drawing.Point(56, 42);
			this.checkBox30.Name = "checkBox30";
			this.checkBox30.Size = new System.Drawing.Size(16, 24);
			this.checkBox30.TabIndex = 40;
			// 
			// checkBox18
			// 
			this.checkBox18.Checked = true;
			this.checkBox18.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox18.Location = new System.Drawing.Point(24, 146);
			this.checkBox18.Name = "checkBox18";
			this.checkBox18.Size = new System.Drawing.Size(16, 24);
			this.checkBox18.TabIndex = 43;
			// 
			// checkBox17
			// 
			this.checkBox17.Checked = true;
			this.checkBox17.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox17.Location = new System.Drawing.Point(24, 129);
			this.checkBox17.Name = "checkBox17";
			this.checkBox17.Size = new System.Drawing.Size(16, 24);
			this.checkBox17.TabIndex = 39;
			// 
			// checkBox16
			// 
			this.checkBox16.Checked = true;
			this.checkBox16.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox16.Location = new System.Drawing.Point(24, 112);
			this.checkBox16.Name = "checkBox16";
			this.checkBox16.Size = new System.Drawing.Size(16, 24);
			this.checkBox16.TabIndex = 40;
			// 
			// checkBox15
			// 
			this.checkBox15.Checked = true;
			this.checkBox15.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox15.Location = new System.Drawing.Point(24, 95);
			this.checkBox15.Name = "checkBox15";
			this.checkBox15.Size = new System.Drawing.Size(16, 24);
			this.checkBox15.TabIndex = 41;
			// 
			// checkBox14
			// 
			this.checkBox14.Checked = true;
			this.checkBox14.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox14.Location = new System.Drawing.Point(24, 77);
			this.checkBox14.Name = "checkBox14";
			this.checkBox14.Size = new System.Drawing.Size(16, 24);
			this.checkBox14.TabIndex = 42;
			// 
			// checkBox13
			// 
			this.checkBox13.Checked = true;
			this.checkBox13.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox13.Location = new System.Drawing.Point(24, 59);
			this.checkBox13.Name = "checkBox13";
			this.checkBox13.Size = new System.Drawing.Size(16, 24);
			this.checkBox13.TabIndex = 38;
			// 
			// checkBox12
			// 
			this.checkBox12.Checked = true;
			this.checkBox12.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox12.Location = new System.Drawing.Point(24, 42);
			this.checkBox12.Name = "checkBox12";
			this.checkBox12.Size = new System.Drawing.Size(16, 24);
			this.checkBox12.TabIndex = 37;
			// 
			// checkBox11
			// 
			this.checkBox11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox11.Location = new System.Drawing.Point(24, 25);
			this.checkBox11.Name = "checkBox11";
			this.checkBox11.Size = new System.Drawing.Size(16, 24);
			this.checkBox11.TabIndex = 36;
			// 
			// checkBox10
			// 
			this.checkBox10.Checked = true;
			this.checkBox10.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox10.Location = new System.Drawing.Point(24, 8);
			this.checkBox10.Name = "checkBox10";
			this.checkBox10.Size = new System.Drawing.Size(16, 24);
			this.checkBox10.TabIndex = 35;
			// 
			// checkBox9
			// 
			this.checkBox9.BackColor = System.Drawing.SystemColors.Control;
			this.checkBox9.Checked = true;
			this.checkBox9.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox9.Location = new System.Drawing.Point(8, 146);
			this.checkBox9.Name = "checkBox9";
			this.checkBox9.Size = new System.Drawing.Size(16, 24);
			this.checkBox9.TabIndex = 34;
			// 
			// checkBox8
			// 
			this.checkBox8.Checked = true;
			this.checkBox8.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox8.Location = new System.Drawing.Point(8, 129);
			this.checkBox8.Name = "checkBox8";
			this.checkBox8.Size = new System.Drawing.Size(16, 24);
			this.checkBox8.TabIndex = 30;
			// 
			// checkBox7
			// 
			this.checkBox7.BackColor = System.Drawing.SystemColors.Control;
			this.checkBox7.Checked = true;
			this.checkBox7.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox7.Location = new System.Drawing.Point(8, 112);
			this.checkBox7.Name = "checkBox7";
			this.checkBox7.Size = new System.Drawing.Size(16, 24);
			this.checkBox7.TabIndex = 31;
			// 
			// checkBox6
			// 
			this.checkBox6.Checked = true;
			this.checkBox6.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox6.Location = new System.Drawing.Point(8, 95);
			this.checkBox6.Name = "checkBox6";
			this.checkBox6.Size = new System.Drawing.Size(16, 24);
			this.checkBox6.TabIndex = 32;
			// 
			// checkBox5
			// 
			this.checkBox5.Checked = true;
			this.checkBox5.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox5.Location = new System.Drawing.Point(8, 77);
			this.checkBox5.Name = "checkBox5";
			this.checkBox5.Size = new System.Drawing.Size(16, 24);
			this.checkBox5.TabIndex = 33;
			// 
			// checkBox4
			// 
			this.checkBox4.Checked = true;
			this.checkBox4.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox4.Location = new System.Drawing.Point(8, 59);
			this.checkBox4.Name = "checkBox4";
			this.checkBox4.Size = new System.Drawing.Size(16, 24);
			this.checkBox4.TabIndex = 29;
			// 
			// checkBox3
			// 
			this.checkBox3.Checked = true;
			this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox3.Location = new System.Drawing.Point(8, 42);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.Size = new System.Drawing.Size(16, 24);
			this.checkBox3.TabIndex = 28;
			// 
			// checkBox2
			// 
			this.checkBox2.Checked = true;
			this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox2.Location = new System.Drawing.Point(8, 25);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(16, 24);
			this.checkBox2.TabIndex = 27;
			// 
			// checkBox1
			// 
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox1.Location = new System.Drawing.Point(8, 8);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(16, 24);
			this.checkBox1.TabIndex = 26;
			// 
			// checkBox27
			// 
			this.checkBox27.Checked = true;
			this.checkBox27.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox27.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox27.Location = new System.Drawing.Point(40, 146);
			this.checkBox27.Name = "checkBox27";
			this.checkBox27.Size = new System.Drawing.Size(16, 24);
			this.checkBox27.TabIndex = 35;
			// 
			// checkBox26
			// 
			this.checkBox26.Checked = true;
			this.checkBox26.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox26.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox26.Location = new System.Drawing.Point(40, 129);
			this.checkBox26.Name = "checkBox26";
			this.checkBox26.Size = new System.Drawing.Size(16, 24);
			this.checkBox26.TabIndex = 36;
			// 
			// checkBox25
			// 
			this.checkBox25.Checked = true;
			this.checkBox25.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox25.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox25.Location = new System.Drawing.Point(40, 112);
			this.checkBox25.Name = "checkBox25";
			this.checkBox25.Size = new System.Drawing.Size(16, 24);
			this.checkBox25.TabIndex = 37;
			// 
			// checkBox24
			// 
			this.checkBox24.Checked = true;
			this.checkBox24.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox24.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox24.Location = new System.Drawing.Point(40, 95);
			this.checkBox24.Name = "checkBox24";
			this.checkBox24.Size = new System.Drawing.Size(16, 24);
			this.checkBox24.TabIndex = 38;
			// 
			// checkBox23
			// 
			this.checkBox23.Checked = true;
			this.checkBox23.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox23.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox23.Location = new System.Drawing.Point(40, 77);
			this.checkBox23.Name = "checkBox23";
			this.checkBox23.Size = new System.Drawing.Size(16, 24);
			this.checkBox23.TabIndex = 42;
			// 
			// checkBox22
			// 
			this.checkBox22.Checked = true;
			this.checkBox22.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox22.Location = new System.Drawing.Point(40, 59);
			this.checkBox22.Name = "checkBox22";
			this.checkBox22.Size = new System.Drawing.Size(16, 24);
			this.checkBox22.TabIndex = 41;
			// 
			// checkBox21
			// 
			this.checkBox21.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
			this.checkBox21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox21.Location = new System.Drawing.Point(40, 46);
			this.checkBox21.Name = "checkBox21";
			this.checkBox21.Size = new System.Drawing.Size(16, 24);
			this.checkBox21.TabIndex = 40;
			// 
			// checkBox20
			// 
			this.checkBox20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox20.Location = new System.Drawing.Point(40, 25);
			this.checkBox20.Name = "checkBox20";
			this.checkBox20.Size = new System.Drawing.Size(16, 24);
			this.checkBox20.TabIndex = 39;
			// 
			// checkBox19
			// 
			this.checkBox19.Checked = true;
			this.checkBox19.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox19.Location = new System.Drawing.Point(40, 8);
			this.checkBox19.Name = "checkBox19";
			this.checkBox19.Size = new System.Drawing.Size(16, 24);
			this.checkBox19.TabIndex = 43;
			// 
			// checkBox29
			// 
			this.checkBox29.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox29.Location = new System.Drawing.Point(56, 25);
			this.checkBox29.Name = "checkBox29";
			this.checkBox29.Size = new System.Drawing.Size(16, 24);
			this.checkBox29.TabIndex = 39;
			// 
			// checkBox28
			// 
			this.checkBox28.Checked = true;
			this.checkBox28.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox28.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox28.Location = new System.Drawing.Point(56, 8);
			this.checkBox28.Name = "checkBox28";
			this.checkBox28.Size = new System.Drawing.Size(16, 24);
			this.checkBox28.TabIndex = 43;
			// 
			// label14
			// 
			this.label14.Location = new System.Drawing.Point(48, 24);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(152, 23);
			this.label14.TabIndex = 9;
			this.label14.Text = "0    1   2    3   4   5   6   7   8";
			// 
			// label13
			// 
			this.label13.Location = new System.Drawing.Point(8, 190);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(24, 16);
			this.label13.TabIndex = 8;
			this.label13.Text = "128";
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(8, 172);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(24, 16);
			this.label9.TabIndex = 7;
			this.label9.Text = "1";
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(8, 155);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(24, 16);
			this.label10.TabIndex = 6;
			this.label10.Text = "2";
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(8, 138);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(24, 16);
			this.label11.TabIndex = 5;
			this.label11.Text = "4";
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(8, 121);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(24, 16);
			this.label12.TabIndex = 4;
			this.label12.Text = "8";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(8, 104);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(24, 16);
			this.label7.TabIndex = 3;
			this.label7.Text = "16";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(8, 87);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(24, 16);
			this.label8.TabIndex = 2;
			this.label8.Text = "32";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(8, 70);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(24, 16);
			this.label6.TabIndex = 1;
			this.label6.Text = "64";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(8, 52);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(24, 16);
			this.label5.TabIndex = 0;
			this.label5.Text = "128";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btnAutenticar);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.txtTextoAutenticacao);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(232, 280);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(176, 136);
			this.groupBox2.TabIndex = 22;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "AutenticaÁ„o";
			// 
			// btnAutenticar
			// 
			this.btnAutenticar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnAutenticar.Location = new System.Drawing.Point(8, 104);
			this.btnAutenticar.Name = "btnAutenticar";
			this.btnAutenticar.Size = new System.Drawing.Size(152, 24);
			this.btnAutenticar.TabIndex = 2;
			this.btnAutenticar.Text = "Autenticar";
			this.btnAutenticar.Click += new System.EventHandler(this.btnAutenticar_Click);
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label4.Location = new System.Drawing.Point(8, 32);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(40, 16);
			this.label4.TabIndex = 1;
			this.label4.Text = "Texto:";
			// 
			// txtTextoAutenticacao
			// 
			this.txtTextoAutenticacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtTextoAutenticacao.Location = new System.Drawing.Point(8, 48);
			this.txtTextoAutenticacao.Name = "txtTextoAutenticacao";
			this.txtTextoAutenticacao.Size = new System.Drawing.Size(152, 20);
			this.txtTextoAutenticacao.TabIndex = 0;
			this.txtTextoAutenticacao.Text = "Teste de autenticaÁ„o";
			// 
			// btnAbrirGaveta
			// 
			this.btnAbrirGaveta.Location = new System.Drawing.Point(432, 352);
			this.btnAbrirGaveta.Name = "btnAbrirGaveta";
			this.btnAbrirGaveta.Size = new System.Drawing.Size(208, 24);
			this.btnAbrirGaveta.TabIndex = 21;
			this.btnAbrirGaveta.Text = "Abrir gaveta";
			this.btnAbrirGaveta.Click += new System.EventHandler(this.btnAbrirGaveta_Click);
			// 
			// btnCorteTotalPapel
			// 
			this.btnCorteTotalPapel.Location = new System.Drawing.Point(432, 320);
			this.btnCorteTotalPapel.Name = "btnCorteTotalPapel";
			this.btnCorteTotalPapel.Size = new System.Drawing.Size(208, 24);
			this.btnCorteTotalPapel.TabIndex = 20;
			this.btnCorteTotalPapel.Text = "Corte total do papel";
			this.btnCorteTotalPapel.Click += new System.EventHandler(this.btnCorteTotalPapel_Click);
			// 
			// btnCorteParcialPapel
			// 
			this.btnCorteParcialPapel.Location = new System.Drawing.Point(432, 288);
			this.btnCorteParcialPapel.Name = "btnCorteParcialPapel";
			this.btnCorteParcialPapel.Size = new System.Drawing.Size(208, 24);
			this.btnCorteParcialPapel.TabIndex = 19;
			this.btnCorteParcialPapel.Text = "Corte parcial do papel ";
			this.btnCorteParcialPapel.Click += new System.EventHandler(this.btnCorteParcialPapel_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rbtGaveta);
			this.groupBox1.Controls.Add(this.rbtImpressora);
			this.groupBox1.Controls.Add(this.txtStatus);
			this.groupBox1.Controls.Add(this.btnLerStatus);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(32, 280);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(184, 136);
			this.groupBox1.TabIndex = 18;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Status";
			// 
			// rbtGaveta
			// 
			this.rbtGaveta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.rbtGaveta.Location = new System.Drawing.Point(104, 24);
			this.rbtGaveta.Name = "rbtGaveta";
			this.rbtGaveta.Size = new System.Drawing.Size(64, 16);
			this.rbtGaveta.TabIndex = 3;
			this.rbtGaveta.Text = "Gaveta";
			// 
			// rbtImpressora
			// 
			this.rbtImpressora.Checked = true;
			this.rbtImpressora.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.rbtImpressora.Location = new System.Drawing.Point(16, 24);
			this.rbtImpressora.Name = "rbtImpressora";
			this.rbtImpressora.Size = new System.Drawing.Size(104, 16);
			this.rbtImpressora.TabIndex = 2;
			this.rbtImpressora.TabStop = true;
			this.rbtImpressora.Text = "Impressora";
			// 
			// txtStatus
			// 
			this.txtStatus.Location = new System.Drawing.Point(16, 48);
			this.txtStatus.Multiline = true;
			this.txtStatus.Name = "txtStatus";
			this.txtStatus.Size = new System.Drawing.Size(144, 48);
			this.txtStatus.TabIndex = 1;
			this.txtStatus.Text = "";
			// 
			// btnLerStatus
			// 
			this.btnLerStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnLerStatus.Location = new System.Drawing.Point(16, 104);
			this.btnLerStatus.Name = "btnLerStatus";
			this.btnLerStatus.Size = new System.Drawing.Size(144, 24);
			this.btnLerStatus.TabIndex = 0;
			this.btnLerStatus.Text = "Ler Status";
			this.btnLerStatus.Click += new System.EventHandler(this.btnLerStatus_Click);
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.groupBox6);
			this.tabPage2.Controls.Add(this.grbPosicaoLengenda);
			this.tabPage2.Controls.Add(this.groupBox7);
			this.tabPage2.Controls.Add(this.grbFonte);
			this.tabPage2.Controls.Add(this.groupBox5);
			this.tabPage2.Controls.Add(this.btnImprimirCodigoBarras);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Size = new System.Drawing.Size(654, 430);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "CÛdigo de barras";
			// 
			// groupBox6
			// 
			this.groupBox6.Controls.Add(this.txtCodigoBarras);
			this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.groupBox6.Location = new System.Drawing.Point(40, 272);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new System.Drawing.Size(576, 104);
			this.groupBox6.TabIndex = 5;
			this.groupBox6.TabStop = false;
			this.groupBox6.Text = "CÛdigo";
			// 
			// txtCodigoBarras
			// 
			this.txtCodigoBarras.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtCodigoBarras.Location = new System.Drawing.Point(168, 40);
			this.txtCodigoBarras.Name = "txtCodigoBarras";
			this.txtCodigoBarras.Size = new System.Drawing.Size(240, 20);
			this.txtCodigoBarras.TabIndex = 0;
			this.txtCodigoBarras.Text = "";
			// 
			// grbPosicaoLengenda
			// 
			this.grbPosicaoLengenda.Controls.Add(this.rbtNaoImprimeCaracteres);
			this.grbPosicaoLengenda.Controls.Add(this.rbtCaracteresAcimaAbaixoCodigo);
			this.grbPosicaoLengenda.Controls.Add(this.rbtCaracteresAbaixoCodigo);
			this.grbPosicaoLengenda.Controls.Add(this.rbtCaracteresAcimaCodigo);
			this.grbPosicaoLengenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.grbPosicaoLengenda.Location = new System.Drawing.Point(416, 136);
			this.grbPosicaoLengenda.Name = "grbPosicaoLengenda";
			this.grbPosicaoLengenda.Size = new System.Drawing.Size(200, 120);
			this.grbPosicaoLengenda.TabIndex = 4;
			this.grbPosicaoLengenda.TabStop = false;
			this.grbPosicaoLengenda.Text = "PosiÁ„o dos Caracteres";
			// 
			// rbtNaoImprimeCaracteres
			// 
			this.rbtNaoImprimeCaracteres.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.rbtNaoImprimeCaracteres.Location = new System.Drawing.Point(16, 89);
			this.rbtNaoImprimeCaracteres.Name = "rbtNaoImprimeCaracteres";
			this.rbtNaoImprimeCaracteres.Size = new System.Drawing.Size(168, 16);
			this.rbtNaoImprimeCaracteres.TabIndex = 4;
			this.rbtNaoImprimeCaracteres.Text = "N„o imprime os caracteres";
			// 
			// rbtCaracteresAcimaAbaixoCodigo
			// 
			this.rbtCaracteresAcimaAbaixoCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.rbtCaracteresAcimaAbaixoCodigo.Location = new System.Drawing.Point(16, 65);
			this.rbtCaracteresAcimaAbaixoCodigo.Name = "rbtCaracteresAcimaAbaixoCodigo";
			this.rbtCaracteresAcimaAbaixoCodigo.Size = new System.Drawing.Size(160, 16);
			this.rbtCaracteresAcimaAbaixoCodigo.TabIndex = 3;
			this.rbtCaracteresAcimaAbaixoCodigo.Text = "Acima e abaixo do cÛdigo";
			// 
			// rbtCaracteresAbaixoCodigo
			// 
			this.rbtCaracteresAbaixoCodigo.Checked = true;
			this.rbtCaracteresAbaixoCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.rbtCaracteresAbaixoCodigo.Location = new System.Drawing.Point(16, 44);
			this.rbtCaracteresAbaixoCodigo.Name = "rbtCaracteresAbaixoCodigo";
			this.rbtCaracteresAbaixoCodigo.Size = new System.Drawing.Size(120, 16);
			this.rbtCaracteresAbaixoCodigo.TabIndex = 2;
			this.rbtCaracteresAbaixoCodigo.TabStop = true;
			this.rbtCaracteresAbaixoCodigo.Text = "Abaixo do CÛdigo";
			// 
			// rbtCaracteresAcimaCodigo
			// 
			this.rbtCaracteresAcimaCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.rbtCaracteresAcimaCodigo.Location = new System.Drawing.Point(16, 24);
			this.rbtCaracteresAcimaCodigo.Name = "rbtCaracteresAcimaCodigo";
			this.rbtCaracteresAcimaCodigo.Size = new System.Drawing.Size(120, 16);
			this.rbtCaracteresAcimaCodigo.TabIndex = 1;
			this.rbtCaracteresAcimaCodigo.Text = "Acima do cÛdigo";
			// 
			// groupBox7
			// 
			this.groupBox7.Controls.Add(this.rbtGrossa);
			this.groupBox7.Controls.Add(this.rbtMedia);
			this.groupBox7.Controls.Add(this.rbtFina);
			this.groupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.groupBox7.Location = new System.Drawing.Point(232, 136);
			this.groupBox7.Name = "groupBox7";
			this.groupBox7.Size = new System.Drawing.Size(152, 120);
			this.groupBox7.TabIndex = 3;
			this.groupBox7.TabStop = false;
			this.groupBox7.Text = "Largura das barras";
			// 
			// rbtGrossa
			// 
			this.rbtGrossa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.rbtGrossa.Location = new System.Drawing.Point(16, 80);
			this.rbtGrossa.Name = "rbtGrossa";
			this.rbtGrossa.Size = new System.Drawing.Size(88, 16);
			this.rbtGrossa.TabIndex = 2;
			this.rbtGrossa.Text = "Grossa";
			// 
			// rbtMedia
			// 
			this.rbtMedia.Checked = true;
			this.rbtMedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.rbtMedia.Location = new System.Drawing.Point(16, 56);
			this.rbtMedia.Name = "rbtMedia";
			this.rbtMedia.Size = new System.Drawing.Size(88, 16);
			this.rbtMedia.TabIndex = 1;
			this.rbtMedia.TabStop = true;
			this.rbtMedia.Text = "MÈdia";
			// 
			// rbtFina
			// 
			this.rbtFina.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.rbtFina.Location = new System.Drawing.Point(16, 32);
			this.rbtFina.Name = "rbtFina";
			this.rbtFina.Size = new System.Drawing.Size(88, 16);
			this.rbtFina.TabIndex = 0;
			this.rbtFina.Text = "Fina";
			// 
			// grbFonte
			// 
			this.grbFonte.Controls.Add(this.rbtFonteCondensada);
			this.grbFonte.Controls.Add(this.rbtFonteNormal);
			this.grbFonte.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.grbFonte.Location = new System.Drawing.Point(40, 136);
			this.grbFonte.Name = "grbFonte";
			this.grbFonte.Size = new System.Drawing.Size(160, 120);
			this.grbFonte.TabIndex = 2;
			this.grbFonte.TabStop = false;
			this.grbFonte.Text = "Fonte";
			// 
			// rbtFonteCondensada
			// 
			this.rbtFonteCondensada.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.rbtFonteCondensada.Location = new System.Drawing.Point(16, 72);
			this.rbtFonteCondensada.Name = "rbtFonteCondensada";
			this.rbtFonteCondensada.Size = new System.Drawing.Size(88, 16);
			this.rbtFonteCondensada.TabIndex = 2;
			this.rbtFonteCondensada.Text = "Condensada";
			// 
			// rbtFonteNormal
			// 
			this.rbtFonteNormal.Checked = true;
			this.rbtFonteNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.rbtFonteNormal.Location = new System.Drawing.Point(16, 40);
			this.rbtFonteNormal.Name = "rbtFonteNormal";
			this.rbtFonteNormal.Size = new System.Drawing.Size(88, 16);
			this.rbtFonteNormal.TabIndex = 1;
			this.rbtFonteNormal.TabStop = true;
			this.rbtFonteNormal.Text = "Normal";
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.cboCodigoBarras);
			this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.groupBox5.Location = new System.Drawing.Point(40, 8);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(576, 104);
			this.groupBox5.TabIndex = 0;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Escolha o cÛdigo de barras";
			// 
			// cboCodigoBarras
			// 
			this.cboCodigoBarras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboCodigoBarras.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cboCodigoBarras.Items.AddRange(new object[] {
																 "EAN 8",
																 "EAN 13",
																 "CODABAR",
																 "CODE 39",
																 "CODE 93",
																 "CODE 128",
																 "ISBN",
																 "ITF",
																 "MSI",
																 "PDF 417",
																 "PLESSEY",
																 "UPCA",
																 "UPCE"});
			this.cboCodigoBarras.Location = new System.Drawing.Point(160, 40);
			this.cboCodigoBarras.Name = "cboCodigoBarras";
			this.cboCodigoBarras.Size = new System.Drawing.Size(208, 21);
			this.cboCodigoBarras.TabIndex = 0;
			this.cboCodigoBarras.SelectedIndexChanged += new System.EventHandler(this.cboCodigoBarras_SelectedIndexChanged);
			// 
			// btnImprimirCodigoBarras
			// 
			this.btnImprimirCodigoBarras.Location = new System.Drawing.Point(504, 392);
			this.btnImprimirCodigoBarras.Name = "btnImprimirCodigoBarras";
			this.btnImprimirCodigoBarras.Size = new System.Drawing.Size(104, 23);
			this.btnImprimirCodigoBarras.TabIndex = 1;
			this.btnImprimirCodigoBarras.Text = "Imprimir";
			this.btnImprimirCodigoBarras.Click += new System.EventHandler(this.btnImprimirCodigoBarras_Click);
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.grbQualidadeImpressao);
			this.tabPage3.Controls.Add(this.grbRotacao);
			this.tabPage3.Controls.Add(this.chkAjustarImagemPapel);
			this.tabPage3.Controls.Add(this.grbOrientacaoPapel);
			this.tabPage3.Controls.Add(this.groupBox8);
			this.tabPage3.Controls.Add(this.grbDithering);
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Size = new System.Drawing.Size(654, 430);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Bitmap";
			// 
			// grbQualidadeImpressao
			// 
			this.grbQualidadeImpressao.Controls.Add(this.cboQualidadeImpressao);
			this.grbQualidadeImpressao.Enabled = false;
			this.grbQualidadeImpressao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.grbQualidadeImpressao.Location = new System.Drawing.Point(488, 272);
			this.grbQualidadeImpressao.Name = "grbQualidadeImpressao";
			this.grbQualidadeImpressao.Size = new System.Drawing.Size(152, 72);
			this.grbQualidadeImpressao.TabIndex = 11;
			this.grbQualidadeImpressao.TabStop = false;
			this.grbQualidadeImpressao.Text = "Qualidade de Impress„o";
			// 
			// cboQualidadeImpressao
			// 
			this.cboQualidadeImpressao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboQualidadeImpressao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cboQualidadeImpressao.Items.AddRange(new object[] {
																	   "Normal",
																	   "Alta",
																	   "Muito Alta",
																	   "Baixa",
																	   "Muito Baixa"});
			this.cboQualidadeImpressao.Location = new System.Drawing.Point(8, 32);
			this.cboQualidadeImpressao.Name = "cboQualidadeImpressao";
			this.cboQualidadeImpressao.Size = new System.Drawing.Size(136, 21);
			this.cboQualidadeImpressao.TabIndex = 0;
			this.cboQualidadeImpressao.SelectedIndexChanged += new System.EventHandler(this.cboQualidadeImpressao_SelectedIndexChanged);
			// 
			// grbRotacao
			// 
			this.grbRotacao.Controls.Add(this.btnAplicar);
			this.grbRotacao.Controls.Add(this.label15);
			this.grbRotacao.Controls.Add(this.txtGraus);
			this.grbRotacao.Enabled = false;
			this.grbRotacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.grbRotacao.Location = new System.Drawing.Point(488, 96);
			this.grbRotacao.Name = "grbRotacao";
			this.grbRotacao.Size = new System.Drawing.Size(152, 88);
			this.grbRotacao.TabIndex = 3;
			this.grbRotacao.TabStop = false;
			this.grbRotacao.Text = "RotaÁ„o";
			// 
			// btnAplicar
			// 
			this.btnAplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnAplicar.Location = new System.Drawing.Point(16, 56);
			this.btnAplicar.Name = "btnAplicar";
			this.btnAplicar.Size = new System.Drawing.Size(120, 24);
			this.btnAplicar.TabIndex = 8;
			this.btnAplicar.Text = "Aplicar";
			this.btnAplicar.Click += new System.EventHandler(this.btnAplicar_Click);
			// 
			// label15
			// 
			this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label15.Location = new System.Drawing.Point(16, 24);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(40, 16);
			this.label15.TabIndex = 1;
			this.label15.Text = "Graus: ";
			// 
			// txtGraus
			// 
			this.txtGraus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtGraus.Location = new System.Drawing.Point(64, 24);
			this.txtGraus.MaxLength = 3;
			this.txtGraus.Name = "txtGraus";
			this.txtGraus.Size = new System.Drawing.Size(72, 20);
			this.txtGraus.TabIndex = 0;
			this.txtGraus.Text = "";
			// 
			// chkAjustarImagemPapel
			// 
			this.chkAjustarImagemPapel.Enabled = false;
			this.chkAjustarImagemPapel.Location = new System.Drawing.Point(488, 368);
			this.chkAjustarImagemPapel.Name = "chkAjustarImagemPapel";
			this.chkAjustarImagemPapel.Size = new System.Drawing.Size(152, 16);
			this.chkAjustarImagemPapel.TabIndex = 2;
			this.chkAjustarImagemPapel.Text = "Ajustar imagem ao papel";
			this.chkAjustarImagemPapel.CheckedChanged += new System.EventHandler(this.chkAjustarImagemPapel_CheckedChanged);
			// 
			// grbOrientacaoPapel
			// 
			this.grbOrientacaoPapel.Controls.Add(this.rbtPaisagem);
			this.grbOrientacaoPapel.Controls.Add(this.rbtRetrato);
			this.grbOrientacaoPapel.Enabled = false;
			this.grbOrientacaoPapel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.grbOrientacaoPapel.Location = new System.Drawing.Point(488, 8);
			this.grbOrientacaoPapel.Name = "grbOrientacaoPapel";
			this.grbOrientacaoPapel.Size = new System.Drawing.Size(152, 80);
			this.grbOrientacaoPapel.TabIndex = 1;
			this.grbOrientacaoPapel.TabStop = false;
			this.grbOrientacaoPapel.Text = "OrientaÁ„o do Papel";
			// 
			// rbtPaisagem
			// 
			this.rbtPaisagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.rbtPaisagem.Location = new System.Drawing.Point(16, 48);
			this.rbtPaisagem.Name = "rbtPaisagem";
			this.rbtPaisagem.Size = new System.Drawing.Size(104, 16);
			this.rbtPaisagem.TabIndex = 1;
			this.rbtPaisagem.Text = "Paisagem";
			// 
			// rbtRetrato
			// 
			this.rbtRetrato.Checked = true;
			this.rbtRetrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.rbtRetrato.Location = new System.Drawing.Point(16, 24);
			this.rbtRetrato.Name = "rbtRetrato";
			this.rbtRetrato.Size = new System.Drawing.Size(104, 16);
			this.rbtRetrato.TabIndex = 0;
			this.rbtRetrato.TabStop = true;
			this.rbtRetrato.Text = "Retrato";
			// 
			// groupBox8
			// 
			this.groupBox8.Controls.Add(this.txtPathImagem);
			this.groupBox8.Controls.Add(this.btnImprimirBitmap);
			this.groupBox8.Controls.Add(this.btnAbrirImagem);
			this.groupBox8.Controls.Add(this.pctImage);
			this.groupBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.groupBox8.Location = new System.Drawing.Point(8, 8);
			this.groupBox8.Name = "groupBox8";
			this.groupBox8.Size = new System.Drawing.Size(464, 416);
			this.groupBox8.TabIndex = 0;
			this.groupBox8.TabStop = false;
			this.groupBox8.Text = "Imagem";
			// 
			// txtPathImagem
			// 
			this.txtPathImagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtPathImagem.Location = new System.Drawing.Point(8, 24);
			this.txtPathImagem.Name = "txtPathImagem";
			this.txtPathImagem.Size = new System.Drawing.Size(408, 20);
			this.txtPathImagem.TabIndex = 6;
			this.txtPathImagem.Text = "";
			// 
			// btnImprimirBitmap
			// 
			this.btnImprimirBitmap.Enabled = false;
			this.btnImprimirBitmap.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnImprimirBitmap.Location = new System.Drawing.Point(352, 384);
			this.btnImprimirBitmap.Name = "btnImprimirBitmap";
			this.btnImprimirBitmap.Size = new System.Drawing.Size(104, 24);
			this.btnImprimirBitmap.TabIndex = 4;
			this.btnImprimirBitmap.Text = "Imprimir Imagem";
			this.btnImprimirBitmap.Click += new System.EventHandler(this.btnImprimirBitmap_Click);
			// 
			// btnAbrirImagem
			// 
			this.btnAbrirImagem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnAbrirImagem.Location = new System.Drawing.Point(424, 23);
			this.btnAbrirImagem.Name = "btnAbrirImagem";
			this.btnAbrirImagem.Size = new System.Drawing.Size(32, 23);
			this.btnAbrirImagem.TabIndex = 3;
			this.btnAbrirImagem.Text = "...";
			this.btnAbrirImagem.Click += new System.EventHandler(this.btnAbrirImagem_Click);
			// 
			// pctImage
			// 
			this.pctImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pctImage.Location = new System.Drawing.Point(8, 56);
			this.pctImage.Name = "pctImage";
			this.pctImage.Size = new System.Drawing.Size(448, 312);
			this.pctImage.TabIndex = 2;
			this.pctImage.TabStop = false;
			// 
			// grbDithering
			// 
			this.grbDithering.Controls.Add(this.cboDithering);
			this.grbDithering.Enabled = false;
			this.grbDithering.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.grbDithering.Location = new System.Drawing.Point(488, 192);
			this.grbDithering.Name = "grbDithering";
			this.grbDithering.Size = new System.Drawing.Size(152, 72);
			this.grbDithering.TabIndex = 9;
			this.grbDithering.TabStop = false;
			this.grbDithering.Text = "Dithering";
			// 
			// cboDithering
			// 
			this.cboDithering.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboDithering.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cboDithering.Items.AddRange(new object[] {
															  "Bayer",
															  "Burkes",
															  "FloydSteinberg",
															  "JarvisJudiceNinke",
															  "Sierra",
															  "StevensonArce",
															  "Stucki"});
			this.cboDithering.Location = new System.Drawing.Point(8, 32);
			this.cboDithering.Name = "cboDithering";
			this.cboDithering.Size = new System.Drawing.Size(136, 21);
			this.cboDithering.TabIndex = 0;
			this.cboDithering.SelectedIndexChanged += new System.EventHandler(this.cboDithering_SelectedIndexChanged);
			// 
			// btnSair
			// 
			this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnSair.Location = new System.Drawing.Point(558, 504);
			this.btnSair.Name = "btnSair";
			this.btnSair.Size = new System.Drawing.Size(112, 24);
			this.btnSair.TabIndex = 12;
			this.btnSair.Text = "Sair";
			this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.Filter = "Image files (*.jpg,*.png,*.tif,*.bmp,*.gif)|*.jpg;*.png;*.tif;*.bmp;*.gif|JPG fil" +
				"es (*.jpg)|*.jpg|PNG files (*.png)|*.png|TIF files (*.tif)|*.tif|BMP files (*.bm" +
				"p)|*.bmp|GIF files (*.gif)|*.gif";
			this.openFileDialog1.Title = "Abrir Imagem";
			// 
			// frmPrincipal
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(696, 534);
			this.Controls.Add(this.btnSair);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.cboImpressora);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cboPortaComunicacao);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmPrincipal";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "TesteMiniPrinter - Aplicativo de Exemplo para MiniImpressoras usando o Bematech F" +
				"lash Builder";
			this.Load += new System.EventHandler(this.frmPrincipal_Load);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.grbImpressaoTexto.ResumeLayout(false);
			this.grbAlinhamento.ResumeLayout(false);
			this.grbFormatoFonte.ResumeLayout(false);
			this.grbTamanhoFonte.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.groupBox6.ResumeLayout(false);
			this.grbPosicaoLengenda.ResumeLayout(false);
			this.groupBox7.ResumeLayout(false);
			this.grbFonte.ResumeLayout(false);
			this.groupBox5.ResumeLayout(false);
			this.tabPage3.ResumeLayout(false);
			this.grbQualidadeImpressao.ResumeLayout(false);
			this.grbRotacao.ResumeLayout(false);
			this.grbOrientacaoPapel.ResumeLayout(false);
			this.groupBox8.ResumeLayout(false);
			this.grbDithering.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new frmPrincipal());
		}

		private void btnImprimir_Click(object sender, System.EventArgs e)
		{
			// tamanho do caracter
			TextoFormatado.TamanhoCaracter tamanhoCaracter;
			if (rbtCondensado.Checked)
			{
				tamanhoCaracter = TextoFormatado.TamanhoCaracter.Condensado;
			}
			else if (rbtElite.Checked )
			{
				tamanhoCaracter = TextoFormatado.TamanhoCaracter.Elite;
			}
			else 
			{
				tamanhoCaracter = TextoFormatado.TamanhoCaracter.Normal;
			}
			
			// formato do caracter
			TextoFormatado.FormatoCaracter formato = TextoFormatado.FormatoCaracter.Normal;
			if (chkNegrito.Checked)
			{
				formato |= TextoFormatado.FormatoCaracter.Negrito;
			}
			if (chkItalico.Checked)
			{
				formato |= TextoFormatado.FormatoCaracter.Italico;
			}
			if (chkExpandido.Checked)
			{
				formato |= TextoFormatado.FormatoCaracter.Expandido;
			}
			if (chkSublinhado.Checked)
			{
				formato |= TextoFormatado.FormatoCaracter.Sublinhado;
			}

			// alinhamento do texto
			TextoFormatado.TipoAlinhamento alinhamento;

			//TODO Fabio: Revisar alinhamento com com caracter sublinhado

			if (rbtAlignNenhum.Checked )
			{
				alinhamento = TextoFormatado.TipoAlinhamento.SemAlinhamento;
			}
			else if (rbtAlignEsquerda.Checked )
			{
				alinhamento = TextoFormatado.TipoAlinhamento.Esquerda;
			}
			else if (rbtAlignDireita.Checked)
			{
				alinhamento = TextoFormatado.TipoAlinhamento.Direita;
			}
			else 
			{
				alinhamento = TextoFormatado.TipoAlinhamento.Centralizado;
			}
			
			TextoFormatado texto = new TextoFormatado(txtTexto.Text + "\r\n", tamanhoCaracter, formato, alinhamento);
			texto.TabelaCaracteres = miniPrinter.TabelaCaracteres;

			try
			{
				miniPrinter.Imprimir(texto);
			}
			catch (MiniImpressoraException erro)
			{
				MessageBox.Show(erro.Message, "TestMiniPrinter", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void frmPrincipal_Load(object sender, System.EventArgs e)
		{
			cboPortaComunicacao.SelectedIndex = 0;
			cboImpressora.SelectedIndex = 5;
		}

		private void cboPortaComunicacao_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			miniPrinter.NomePorta = cboPortaComunicacao.Text;
		}

		private void cboImpressora_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			switch (cboImpressora.SelectedIndex)
			{
				case 0: miniPrinter.Modelo = ModeloImpressoraNaoFiscal.MP20CI; break;
				case 1: miniPrinter.Modelo = ModeloImpressoraNaoFiscal.MP20MI; break;
				case 2: miniPrinter.Modelo = ModeloImpressoraNaoFiscal.MP20TH; break;
				case 3: miniPrinter.Modelo = ModeloImpressoraNaoFiscal.MP2000CI; break;
				case 4: miniPrinter.Modelo = ModeloImpressoraNaoFiscal.MP2000TH; break;
				case 5: miniPrinter.Modelo = ModeloImpressoraNaoFiscal.MP2100TH; break;
			}
		}

		private void btnLerStatus_Click(object sender, System.EventArgs e)
		{
			if (btnLerStatus.Text == "Ler Status")
			{
				btnLerStatus.Text = "Parar Leitura";
			}
			else
			{
				btnLerStatus.Text = "Ler Status";
			}
			
			Application.DoEvents();

			try
			{

				if (rbtImpressora.Checked)
				{
					StatusMiniImpressora status;
			
					while (btnLerStatus.Text != "Ler Status")
					{
						txtStatus.Clear();
				
						status = miniPrinter.LerStatus();

						if (!status.OffLine && !status.SemPapel && !status.HeadUp)
						{
							txtStatus.Text = "Ok";
						}
						else
						{
							if (status.OffLine)
							{
								txtStatus.Text += "Off-line\r\n";
							}
							if (status.SemPapel)
							{
								txtStatus.Text += "Sem papel\r\n";
							}
							if (status.HeadUp)
							{
								txtStatus.Text += "HeadUp";
							}
						}

						Application.DoEvents();
					}
				}
				else
				{
					while (btnLerStatus.Text != "Ler Status")
					{
						txtStatus.Clear();
				
						if (miniPrinter.LerStatusGaveta() == 1)
						{
							txtStatus.Text = "Sensor aberto";
						}
						else
						{
							txtStatus.Text = "Sensor fechado";
						}

						Application.DoEvents();
					}
				}
			}
			catch (BematechException erro)
			{
				MessageBox.Show(erro.Message, "TestMiniPrinter", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			btnLerStatus.Text = "Ler Status";
			txtStatus.Clear();
		}

		private void btnCorteParcialPapel_Click(object sender, System.EventArgs e)
		{
			try
			{
				miniPrinter.CortarPapel(true);
			}
			catch (BematechException erro)
			{
				MessageBox.Show(erro.Message, "TestMiniPrinter", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnCorteTotalPapel_Click(object sender, System.EventArgs e)
		{
			try
			{
				miniPrinter.CortarPapel(false);
			}
			catch (BematechException erro)
			{
				MessageBox.Show(erro.Message, "TestMiniPrinter", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnAbrirGaveta_Click(object sender, System.EventArgs e)
		{
			try
			{
				miniPrinter.AbrirGaveta();
			}
			catch (BematechException erro)
			{
				MessageBox.Show(erro.Message, "TestMiniPrinter", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnAutenticar_Click(object sender, System.EventArgs e)
		{
			try
			{
				miniPrinter.AutenticarDocumento(txtTextoAutenticacao.Text + "\r\n", 2);
			}
			catch (MiniImpressoraException erro)
			{
				MessageBox.Show(erro.Message, "TestMiniPrinter", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnImprimirCaracterGrafico_Click(object sender, System.EventArgs e)
		{
			byte byte1 = 0;
			byte byte2 = 0;
			CaracterGrafico caracterGrafico = new CaracterGrafico();
			
			#region coluna0
			if (checkBox1.Checked)
				byte1 += 128;
			if (checkBox2.Checked)
				byte1 += 64;
			if (checkBox3.Checked)
				byte1 += 32;
			if (checkBox4.Checked)
				byte1 += 16;
			if (checkBox5.Checked)
				byte1 += 8;
			if (checkBox6.Checked)
				byte1 += 4;
			if (checkBox7.Checked)
				byte1 += 2;
			if (checkBox8.Checked)
				byte1 += 1;
			if (checkBox9.Checked)
				byte2 = 128;

			caracterGrafico.SetarColuna(0, byte1, byte2);
			#endregion

			#region coluna1
			byte1 = 0;
			byte2 = 0;
			if (checkBox10.Checked)
				byte1 += 128;
			if (checkBox11.Checked)
				byte1 += 64;
			if (checkBox12.Checked)
				byte1 += 32;
			if (checkBox13.Checked)
				byte1 += 16;
			if (checkBox14.Checked)
				byte1 += 8;
			if (checkBox15.Checked)
				byte1 += 4;
			if (checkBox16.Checked)
				byte1 += 2;
			if (checkBox17.Checked)
				byte1 += 1;
			if (checkBox18.Checked)
				byte2 = 128;
			
			caracterGrafico.SetarColuna(1, byte1, byte2);
			#endregion

			#region coluna2
			byte1 = 0;
			byte2 = 0;
			if (checkBox19.Checked)
				byte1 += 128;
			if (checkBox20.Checked)
				byte1 += 64;
			if (checkBox21.Checked)
				byte1 += 32;
			if (checkBox22.Checked)
				byte1 += 16;
			if (checkBox23.Checked)
				byte1 += 8;
			if (checkBox24.Checked)
				byte1 += 4;
			if (checkBox25.Checked)
				byte1 += 2;
			if (checkBox26.Checked)
				byte1 += 1;
			if (checkBox27.Checked)
				byte2 = 128;
			
			caracterGrafico.SetarColuna(2, byte1, byte2);
			#endregion

			#region coluna3
			byte1 = 0;
			byte2 = 0;
			if (checkBox28.Checked)
				byte1 += 128;
			if (checkBox29.Checked)
				byte1 += 64;
			if (checkBox30.Checked)
				byte1 += 32;
			if (checkBox31.Checked)
				byte1 += 16;
			if (checkBox32.Checked)
				byte1 += 8;
			if (checkBox33.Checked)
				byte1 += 4;
			if (checkBox34.Checked)
				byte1 += 2;
			if (checkBox35.Checked)
				byte1 += 1;
			if (checkBox36.Checked)
				byte2 = 128;
			
			caracterGrafico.SetarColuna(3, byte1, byte2);
			#endregion

			#region coluna4
			byte1 = 0;
			byte2 = 0;
			if (checkBox37.Checked)
				byte1 += 128;
			if (checkBox38.Checked)
				byte1 += 64;
			if (checkBox39.Checked)
				byte1 += 32;
			if (checkBox40.Checked)
				byte1 += 16;
			if (checkBox41.Checked)
				byte1 += 8;
			if (checkBox42.Checked)
				byte1 += 4;
			if (checkBox43.Checked)
				byte1 += 2;
			if (checkBox44.Checked)
				byte1 += 1;
			if (checkBox45.Checked)
				byte2 = 128;
			
			caracterGrafico.SetarColuna(4, byte1, byte2);
			#endregion

			#region coluna5
			byte1 = 0;
			byte2 = 0;
			if (checkBox46.Checked)
				byte1 += 128;
			if (checkBox47.Checked)
				byte1 += 64;
			if (checkBox48.Checked)
				byte1 += 32;
			if (checkBox49.Checked)
				byte1 += 16;
			if (checkBox50.Checked)
				byte1 += 8;
			if (checkBox51.Checked)
				byte1 += 4;
			if (checkBox52.Checked)
				byte1 += 2;
			if (checkBox53.Checked)
				byte1 += 1;
			if (checkBox54.Checked)
				byte2 = 128;
			
			caracterGrafico.SetarColuna(5, byte1, byte2);
			#endregion

			#region coluna6
			byte1 = 0;
			byte2 = 0;
			if (checkBox55.Checked)
				byte1 += 128;
			if (checkBox56.Checked)
				byte1 += 64;
			if (checkBox57.Checked)
				byte1 += 32;
			if (checkBox58.Checked)
				byte1 += 16;
			if (checkBox59.Checked)
				byte1 += 8;
			if (checkBox60.Checked)
				byte1 += 4;
			if (checkBox61.Checked)
				byte1 += 2;
			if (checkBox62.Checked)
				byte1 += 1;
			if (checkBox63.Checked)
				byte2 = 128;
			
			caracterGrafico.SetarColuna(6, byte1, byte2);
			#endregion

			#region coluna7
			byte1 = 0;
			byte2 = 0;
			if (checkBox64.Checked)
				byte1 += 128;
			if (checkBox65.Checked)
				byte1 += 64;
			if (checkBox66.Checked)
				byte1 += 32;
			if (checkBox67.Checked)
				byte1 += 16;
			if (checkBox68.Checked)
				byte1 += 8;
			if (checkBox69.Checked)
				byte1 += 4;
			if (checkBox70.Checked)
				byte1 += 2;
			if (checkBox71.Checked)
				byte1 += 1;
			if (checkBox72.Checked)
				byte2 = 128;
			
			caracterGrafico.SetarColuna(7, byte1, byte2);
			#endregion

			#region coluna8
			byte1 = 0;
			byte2 = 0;
			if (checkBox73.Checked)
				byte1 += 128;
			if (checkBox74.Checked)
				byte1 += 64;
			if (checkBox75.Checked)
				byte1 += 32;
			if (checkBox76.Checked)
				byte1 += 16;
			if (checkBox77.Checked)
				byte1 += 8;
			if (checkBox78.Checked)
				byte1 += 4;
			if (checkBox79.Checked)
				byte1 += 2;
			if (checkBox80.Checked)
				byte1 += 1;
			if (checkBox81.Checked)
				byte2 = 128;
			
			caracterGrafico.SetarColuna(8, byte1, byte2);
			#endregion

			try
			{
				miniPrinter.Imprimir(caracterGrafico);
				miniPrinter.Imprimir(" Caracter gr·fico\r\n");
			}
			catch (MiniImpressoraException erro)
			{
				MessageBox.Show(erro.Message, "TestMiniPrinter", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void cboCodigoBarras_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			switch (cboCodigoBarras.SelectedIndex)
			{
				case 0: txtCodigoBarras.Text = "1234567";break;
				case 1: txtCodigoBarras.Text = "123456789012";break;
				case 2: txtCodigoBarras.Text = "123-456/001";break;
				case 3: txtCodigoBarras.Text = "ABC-12345";break;
				case 4: txtCodigoBarras.Text = "ABC-123__";break;
				case 5: txtCodigoBarras.Text = "[Bema]}2^;";break;
				case 6: txtCodigoBarras.Text = "1-56592-292-X 90000";break;
				case 7: txtCodigoBarras.Text = "0123456789012345";break;
				case 8: txtCodigoBarras.Text = "092581";break;
				case 9: txtCodigoBarras.Text = "Com a Bematech vocÍ pode mais.!!!";break;
				case 10: txtCodigoBarras.Text = "09adef";break;
				case 11: txtCodigoBarras.Text = "12345678901";break;
				case 12: txtCodigoBarras.Text = "123456";break;
			}
		}

		private void btnImprimirCodigoBarras_Click(object sender, System.EventArgs e)
		{
			CodigoBarras codigoBarras;
			switch (cboCodigoBarras.SelectedIndex)
			{
				case 0: codigoBarras = new EAN8(); break;
				case 1: codigoBarras = new EAN13();break;
				case 2: codigoBarras = new CODABAR();break;
				case 3: codigoBarras = new CODE39();break;
				case 4: codigoBarras = new CODE93();break;
				case 5: codigoBarras = new CODE128();break;
				case 6: codigoBarras = new ISBN();break;
				case 7: codigoBarras = new ITF();break;
				case 8: codigoBarras = new MSI();break;
				case 9: codigoBarras = new PDF417();break;
				case 10: codigoBarras = new PLESSEY();break;
				case 11: codigoBarras = new UPCA();break;
				case 12: codigoBarras = new UPCE();break;
				default: codigoBarras = new EAN13();break;
			}

			codigoBarras.Codigo = txtCodigoBarras.Text;
			
			// fonte
			if (rbtFonteNormal.Checked)
			{
				codigoBarras.Fonte = CodigoBarras.FonteLegenda.Normal;
			}
			else
			{
				codigoBarras.Fonte = CodigoBarras.FonteLegenda.Condensada;
			}
			
			// largura das barras
			if (rbtFina.Checked)
			{
				codigoBarras.Largura = CodigoBarras.LarguraBarra.Fina;
			}
			else if(rbtMedia.Checked)
			{
				codigoBarras.Largura = CodigoBarras.LarguraBarra.Media;
			}
			else
			{
				codigoBarras.Largura = CodigoBarras.LarguraBarra.Grossa;
			}

			// posicao legenda
			if (rbtCaracteresAbaixoCodigo.Checked)
			{
				codigoBarras.Posicao = CodigoBarras.PosicaoLegenda.Abaixo;
			}
			else if(rbtCaracteresAcimaCodigo.Checked)
			{
				codigoBarras.Posicao = CodigoBarras.PosicaoLegenda.Acima;
			}
			else if(rbtCaracteresAcimaAbaixoCodigo.Checked)
			{
				codigoBarras.Posicao = CodigoBarras.PosicaoLegenda.AcimaAbaixo;
			}
			else
			{
				codigoBarras.Posicao = CodigoBarras.PosicaoLegenda.Nenhuma;
			}

			try
			{
				miniPrinter.Imprimir(codigoBarras);
			}
			catch (BematechException erro)
			{
				MessageBox.Show(erro.Message, "TestMiniPrinter", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnImprimirCaracteresAcentuados_Click(object sender, System.EventArgs e)
		{
			if (cboImpressora.SelectedIndex == 0 ||
				cboImpressora.SelectedIndex == 1)
			{
				// caracteres ABICOMP
				txtTexto.Text = "‚‰‡Â·„ÈÍÎËÔÓÏÌÛıÙˆÚ˙¸˚˘Áˇƒ¿¡¬√À…» œÃÕŒ÷”‘“’‹⁄€Ÿ«Ò—ﬂ±£∫ø" + "\r\n";
			}
			else
			{
				// caracteres CODEPAGE 850
				txtTexto.Text = "‚‰‡Â·„ÈÍÎËÔÓÏÌÛıÙˆÚ˙¸˚˘Áˇƒ¿¡¬√À…» œÃÕŒ÷”‘“’‹⁄€Ÿ«Ò—˝›ﬂµ˛ﬁ±æ¯£ÿ◊É™∫øΩºÊ∆" + "\r\n";
			}
			try
			{
				miniPrinter.Imprimir(txtTexto.Text);
			}
			catch (MiniImpressoraException erro)
			{
				MessageBox.Show(erro.Message, "TestMiniPrinter", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void tabControl1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if (tabControl1.SelectedIndex == 1)
			{
				if (cboCodigoBarras.SelectedIndex == -1)
				{
					cboCodigoBarras.SelectedIndex = 1;
				}
			}
		}

		private void btnSair_Click(object sender, System.EventArgs e)
		{
			Application.Exit();
		}

		private void btnAbrirImagem_Click(object sender, System.EventArgs e)
		{
			if(openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				txtPathImagem.Text = openFileDialog1.FileName;
				pctImage.Image = Image.FromFile(txtPathImagem.Text);
				bitmap = new ImpressaoBitmap((Bitmap) pctImage.Image);

				grbOrientacaoPapel.Enabled = true;
				grbRotacao.Enabled = true;
				grbDithering.Enabled = true;
				chkAjustarImagemPapel.Enabled = true;
				btnImprimirBitmap.Enabled = true;
				grbQualidadeImpressao.Enabled = true;
				if (cboDithering.SelectedIndex == -1)
				{
					cboDithering.SelectedIndex = 3;
				}
				if (cboQualidadeImpressao.SelectedIndex == -1)
				{
					cboQualidadeImpressao.SelectedIndex = 0;
				}
			}
		}

		private void btnImprimirBitmap_Click(object sender, System.EventArgs e)
		{
			try
			{
				if (bitmap != null)
				{
					bitmap.FormatoPaisagem = rbtPaisagem.Checked;
					miniPrinter.Imprimir(bitmap);
					miniPrinter.Imprimir("\r\n\r\n\r\n\r\n");
					miniPrinter.CortarPapel(true);
				}
			}
			catch (MiniImpressoraException erro)
			{
				MessageBox.Show(erro.Message, "TestMiniPrinter", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		
		}

		private void btnAplicar_Click(object sender, System.EventArgs e)
		{
			if (bitmap != null)
			{
				bitmap.GirarImagem(Convert.ToInt32(txtGraus.Text));
				pctImage.Image = bitmap.Bitmap;
			}
		}

		private void cboDithering_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if (bitmap != null)
			{
				switch (cboDithering.Text)
				{
					case "Bayer": bitmap.Dithering = BitmapDithering.Bayer; break;
					case "Burkes": bitmap.Dithering = BitmapDithering.Burkes; break;
					case "FloydSteinberg": bitmap.Dithering = BitmapDithering.FloydSteinberg; break;
					case "JarvisJudiceNinke": bitmap.Dithering = BitmapDithering.JarvisJudiceNinke; break;
					case "Sierra": bitmap.Dithering = BitmapDithering.Sierra; break;
					case "StevensonArce": bitmap.Dithering = BitmapDithering.StevensonArce; break;
					case "Stucki": bitmap.Dithering = BitmapDithering.Stucki; break;
				}
			}
		}

		private void chkAjustarImagemPapel_CheckedChanged(object sender, System.EventArgs e)
		{
			if (chkAjustarImagemPapel.Checked)
			{
				pctImage.SizeMode = PictureBoxSizeMode.StretchImage;
			}
			else
			{
				pctImage.SizeMode = PictureBoxSizeMode.Normal;
			}
			bitmap.AjustaImagemAoPapel = chkAjustarImagemPapel.Checked;
		}

		private void cboQualidadeImpressao_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if (bitmap != null)
			{
				switch (cboQualidadeImpressao.Text)
				{
					case "Normal": bitmap.QualidadeImpressao = QualidadeImpressao.Normal; break;
					case "Alta": bitmap.QualidadeImpressao = QualidadeImpressao.Alta; break;
					case "Muito Alta": bitmap.QualidadeImpressao = QualidadeImpressao.MuitoAlta; break;
					case "Baixa": bitmap.QualidadeImpressao = QualidadeImpressao.Baixa; break;
					case "Muito Baixa": bitmap.QualidadeImpressao = QualidadeImpressao.MuitoBaixa; break;
				}
			}
		}

	}
}
