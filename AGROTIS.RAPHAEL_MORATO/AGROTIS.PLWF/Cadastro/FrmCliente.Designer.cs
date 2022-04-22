namespace AGROTIS.PLWF.Cadastro
{
    partial class FrmCliente
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCliente));
            this.tbcPainel = new MetroFramework.Controls.MetroTabControl();
            this.mtbCadastro = new MetroFramework.Controls.MetroTabPage();
            this.btnNovo = new MetroFramework.Controls.MetroButton();
            this.btnSalvar = new MetroFramework.Controls.MetroButton();
            this.btnExcluir = new MetroFramework.Controls.MetroButton();
            this.btnCancelar = new MetroFramework.Controls.MetroButton();
            this.pnlCampos = new MetroFramework.Controls.MetroPanel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.txtCodIBGE = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.txtComp = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.txtCep = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtUf = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtCidade = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtBairro = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtLogradouro = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtId = new MetroFramework.Controls.MetroTextBox();
            this.lblNome = new MetroFramework.Controls.MetroLabel();
            this.txtNome = new MetroFramework.Controls.MetroTextBox();
            this.mtbFiltro = new MetroFramework.Controls.MetroTabPage();
            this.dgvFitro = new MetroFramework.Controls.MetroGrid();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logradouroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.complementoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bairroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsFiltro = new System.Windows.Forms.BindingSource(this.components);
            this.btnPesquisar = new MetroFramework.Controls.MetroButton();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtNomeF = new MetroFramework.Controls.MetroTextBox();
            this.tbcPainel.SuspendLayout();
            this.mtbCadastro.SuspendLayout();
            this.pnlCampos.SuspendLayout();
            this.mtbFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFitro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFiltro)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcPainel
            // 
            this.tbcPainel.Controls.Add(this.mtbCadastro);
            this.tbcPainel.Controls.Add(this.mtbFiltro);
            this.tbcPainel.Location = new System.Drawing.Point(23, 63);
            this.tbcPainel.Multiline = true;
            this.tbcPainel.Name = "tbcPainel";
            this.tbcPainel.SelectedIndex = 1;
            this.tbcPainel.Size = new System.Drawing.Size(690, 372);
            this.tbcPainel.TabIndex = 36;
            this.tbcPainel.UseSelectable = true;
            this.tbcPainel.SelectedIndexChanged += new System.EventHandler(this.tbcPainel_SelectedIndexChanged);
            // 
            // mtbCadastro
            // 
            this.mtbCadastro.Controls.Add(this.btnNovo);
            this.mtbCadastro.Controls.Add(this.btnSalvar);
            this.mtbCadastro.Controls.Add(this.btnExcluir);
            this.mtbCadastro.Controls.Add(this.btnCancelar);
            this.mtbCadastro.Controls.Add(this.pnlCampos);
            this.mtbCadastro.HorizontalScrollbarBarColor = true;
            this.mtbCadastro.HorizontalScrollbarHighlightOnWheel = false;
            this.mtbCadastro.HorizontalScrollbarSize = 10;
            this.mtbCadastro.Location = new System.Drawing.Point(4, 38);
            this.mtbCadastro.Name = "mtbCadastro";
            this.mtbCadastro.Size = new System.Drawing.Size(682, 330);
            this.mtbCadastro.TabIndex = 0;
            this.mtbCadastro.Text = "Cadastro";
            this.mtbCadastro.VerticalScrollbarBarColor = true;
            this.mtbCadastro.VerticalScrollbarHighlightOnWheel = false;
            this.mtbCadastro.VerticalScrollbarSize = 10;
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(3, 301);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(59, 23);
            this.btnNovo.TabIndex = 8;
            this.btnNovo.Text = "&Novo";
            this.btnNovo.UseSelectable = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(68, 301);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(59, 23);
            this.btnSalvar.TabIndex = 9;
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.UseSelectable = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(133, 301);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(59, 23);
            this.btnExcluir.TabIndex = 10;
            this.btnExcluir.Text = "&Excluir";
            this.btnExcluir.UseSelectable = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(198, 301);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(59, 23);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseSelectable = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // pnlCampos
            // 
            this.pnlCampos.BackColor = System.Drawing.Color.White;
            this.pnlCampos.Controls.Add(this.metroLabel10);
            this.pnlCampos.Controls.Add(this.txtCodIBGE);
            this.pnlCampos.Controls.Add(this.metroLabel9);
            this.pnlCampos.Controls.Add(this.txtComp);
            this.pnlCampos.Controls.Add(this.metroLabel8);
            this.pnlCampos.Controls.Add(this.txtCep);
            this.pnlCampos.Controls.Add(this.metroLabel5);
            this.pnlCampos.Controls.Add(this.txtUf);
            this.pnlCampos.Controls.Add(this.metroLabel3);
            this.pnlCampos.Controls.Add(this.txtCidade);
            this.pnlCampos.Controls.Add(this.metroLabel2);
            this.pnlCampos.Controls.Add(this.txtBairro);
            this.pnlCampos.Controls.Add(this.metroLabel1);
            this.pnlCampos.Controls.Add(this.txtLogradouro);
            this.pnlCampos.Controls.Add(this.metroLabel6);
            this.pnlCampos.Controls.Add(this.txtId);
            this.pnlCampos.Controls.Add(this.lblNome);
            this.pnlCampos.Controls.Add(this.txtNome);
            this.pnlCampos.HorizontalScrollbarBarColor = true;
            this.pnlCampos.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlCampos.HorizontalScrollbarSize = 10;
            this.pnlCampos.Location = new System.Drawing.Point(3, 3);
            this.pnlCampos.Name = "pnlCampos";
            this.pnlCampos.Size = new System.Drawing.Size(665, 292);
            this.pnlCampos.TabIndex = 0;
            this.pnlCampos.VerticalScrollbarBarColor = false;
            this.pnlCampos.VerticalScrollbarHighlightOnWheel = false;
            this.pnlCampos.VerticalScrollbarSize = 10;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(3, 252);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(104, 19);
            this.metroLabel10.TabIndex = 48;
            this.metroLabel10.Text = "Código do IBGE";
            // 
            // txtCodIBGE
            // 
            this.txtCodIBGE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // 
            // 
            this.txtCodIBGE.CustomButton.Image = null;
            this.txtCodIBGE.CustomButton.Location = new System.Drawing.Point(82, 1);
            this.txtCodIBGE.CustomButton.Name = "";
            this.txtCodIBGE.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCodIBGE.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCodIBGE.CustomButton.TabIndex = 1;
            this.txtCodIBGE.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCodIBGE.CustomButton.UseSelectable = true;
            this.txtCodIBGE.CustomButton.Visible = false;
            this.txtCodIBGE.DisplayIcon = true;
            this.txtCodIBGE.Lines = new string[0];
            this.txtCodIBGE.Location = new System.Drawing.Point(113, 248);
            this.txtCodIBGE.MaxLength = 25;
            this.txtCodIBGE.Name = "txtCodIBGE";
            this.txtCodIBGE.PasswordChar = '\0';
            this.txtCodIBGE.ReadOnly = true;
            this.txtCodIBGE.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCodIBGE.SelectedText = "";
            this.txtCodIBGE.SelectionLength = 0;
            this.txtCodIBGE.SelectionStart = 0;
            this.txtCodIBGE.ShortcutsEnabled = true;
            this.txtCodIBGE.ShowClearButton = true;
            this.txtCodIBGE.Size = new System.Drawing.Size(104, 23);
            this.txtCodIBGE.TabIndex = 9;
            this.txtCodIBGE.UseCustomBackColor = true;
            this.txtCodIBGE.UseSelectable = true;
            this.txtCodIBGE.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCodIBGE.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(3, 131);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(94, 19);
            this.metroLabel9.TabIndex = 46;
            this.metroLabel9.Text = "Complemento";
            // 
            // txtComp
            // 
            // 
            // 
            // 
            this.txtComp.CustomButton.Image = null;
            this.txtComp.CustomButton.Location = new System.Drawing.Point(516, 1);
            this.txtComp.CustomButton.Name = "";
            this.txtComp.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtComp.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtComp.CustomButton.TabIndex = 1;
            this.txtComp.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtComp.CustomButton.UseSelectable = true;
            this.txtComp.CustomButton.Visible = false;
            this.txtComp.DisplayIcon = true;
            this.txtComp.Lines = new string[0];
            this.txtComp.Location = new System.Drawing.Point(113, 127);
            this.txtComp.MaxLength = 150;
            this.txtComp.Name = "txtComp";
            this.txtComp.PasswordChar = '\0';
            this.txtComp.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtComp.SelectedText = "";
            this.txtComp.SelectionLength = 0;
            this.txtComp.SelectionStart = 0;
            this.txtComp.ShortcutsEnabled = true;
            this.txtComp.ShowClearButton = true;
            this.txtComp.Size = new System.Drawing.Size(538, 23);
            this.txtComp.TabIndex = 5;
            this.txtComp.UseSelectable = true;
            this.txtComp.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtComp.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(3, 74);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(33, 19);
            this.metroLabel8.TabIndex = 44;
            this.metroLabel8.Text = "CEP";
            // 
            // txtCep
            // 
            // 
            // 
            // 
            this.txtCep.CustomButton.Image = null;
            this.txtCep.CustomButton.Location = new System.Drawing.Point(82, 1);
            this.txtCep.CustomButton.Name = "";
            this.txtCep.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCep.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCep.CustomButton.TabIndex = 1;
            this.txtCep.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCep.CustomButton.UseSelectable = true;
            this.txtCep.CustomButton.Visible = false;
            this.txtCep.DisplayIcon = true;
            this.txtCep.Lines = new string[0];
            this.txtCep.Location = new System.Drawing.Point(113, 70);
            this.txtCep.MaxLength = 9;
            this.txtCep.Name = "txtCep";
            this.txtCep.PasswordChar = '\0';
            this.txtCep.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCep.SelectedText = "";
            this.txtCep.SelectionLength = 0;
            this.txtCep.SelectionStart = 0;
            this.txtCep.ShortcutsEnabled = true;
            this.txtCep.ShowClearButton = true;
            this.txtCep.Size = new System.Drawing.Size(104, 23);
            this.txtCep.TabIndex = 3;
            this.txtCep.UseSelectable = true;
            this.txtCep.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCep.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtCep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RestrigirCaracterCEP);
            this.txtCep.Validated += new System.EventHandler(this.txtCep_Validated);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(3, 223);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(25, 19);
            this.metroLabel5.TabIndex = 42;
            this.metroLabel5.Text = "UF";
            // 
            // txtUf
            // 
            this.txtUf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // 
            // 
            this.txtUf.CustomButton.Image = null;
            this.txtUf.CustomButton.Location = new System.Drawing.Point(82, 1);
            this.txtUf.CustomButton.Name = "";
            this.txtUf.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtUf.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUf.CustomButton.TabIndex = 1;
            this.txtUf.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUf.CustomButton.UseSelectable = true;
            this.txtUf.CustomButton.Visible = false;
            this.txtUf.DisplayIcon = true;
            this.txtUf.Lines = new string[0];
            this.txtUf.Location = new System.Drawing.Point(113, 219);
            this.txtUf.MaxLength = 2;
            this.txtUf.Name = "txtUf";
            this.txtUf.PasswordChar = '\0';
            this.txtUf.ReadOnly = true;
            this.txtUf.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUf.SelectedText = "";
            this.txtUf.SelectionLength = 0;
            this.txtUf.SelectionStart = 0;
            this.txtUf.ShortcutsEnabled = true;
            this.txtUf.ShowClearButton = true;
            this.txtUf.Size = new System.Drawing.Size(104, 23);
            this.txtUf.TabIndex = 8;
            this.txtUf.UseCustomBackColor = true;
            this.txtUf.UseSelectable = true;
            this.txtUf.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUf.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(3, 194);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(51, 19);
            this.metroLabel3.TabIndex = 40;
            this.metroLabel3.Text = "Cidade";
            // 
            // txtCidade
            // 
            this.txtCidade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // 
            // 
            this.txtCidade.CustomButton.Image = null;
            this.txtCidade.CustomButton.Location = new System.Drawing.Point(516, 1);
            this.txtCidade.CustomButton.Name = "";
            this.txtCidade.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCidade.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCidade.CustomButton.TabIndex = 1;
            this.txtCidade.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCidade.CustomButton.UseSelectable = true;
            this.txtCidade.CustomButton.Visible = false;
            this.txtCidade.DisplayIcon = true;
            this.txtCidade.Lines = new string[0];
            this.txtCidade.Location = new System.Drawing.Point(113, 190);
            this.txtCidade.MaxLength = 150;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.PasswordChar = '\0';
            this.txtCidade.ReadOnly = true;
            this.txtCidade.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCidade.SelectedText = "";
            this.txtCidade.SelectionLength = 0;
            this.txtCidade.SelectionStart = 0;
            this.txtCidade.ShortcutsEnabled = true;
            this.txtCidade.ShowClearButton = true;
            this.txtCidade.Size = new System.Drawing.Size(538, 23);
            this.txtCidade.TabIndex = 7;
            this.txtCidade.UseCustomBackColor = true;
            this.txtCidade.UseSelectable = true;
            this.txtCidade.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCidade.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(3, 165);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(45, 19);
            this.metroLabel2.TabIndex = 38;
            this.metroLabel2.Text = "Bairro";
            // 
            // txtBairro
            // 
            this.txtBairro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // 
            // 
            this.txtBairro.CustomButton.Image = null;
            this.txtBairro.CustomButton.Location = new System.Drawing.Point(516, 1);
            this.txtBairro.CustomButton.Name = "";
            this.txtBairro.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBairro.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBairro.CustomButton.TabIndex = 1;
            this.txtBairro.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBairro.CustomButton.UseSelectable = true;
            this.txtBairro.CustomButton.Visible = false;
            this.txtBairro.DisplayIcon = true;
            this.txtBairro.Lines = new string[0];
            this.txtBairro.Location = new System.Drawing.Point(113, 161);
            this.txtBairro.MaxLength = 150;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.PasswordChar = '\0';
            this.txtBairro.ReadOnly = true;
            this.txtBairro.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBairro.SelectedText = "";
            this.txtBairro.SelectionLength = 0;
            this.txtBairro.SelectionStart = 0;
            this.txtBairro.ShortcutsEnabled = true;
            this.txtBairro.ShowClearButton = true;
            this.txtBairro.Size = new System.Drawing.Size(538, 23);
            this.txtBairro.TabIndex = 6;
            this.txtBairro.UseCustomBackColor = true;
            this.txtBairro.UseSelectable = true;
            this.txtBairro.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBairro.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(3, 102);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(79, 19);
            this.metroLabel1.TabIndex = 36;
            this.metroLabel1.Text = "Logradouro";
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // 
            // 
            this.txtLogradouro.CustomButton.Image = null;
            this.txtLogradouro.CustomButton.Location = new System.Drawing.Point(516, 1);
            this.txtLogradouro.CustomButton.Name = "";
            this.txtLogradouro.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtLogradouro.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLogradouro.CustomButton.TabIndex = 1;
            this.txtLogradouro.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLogradouro.CustomButton.UseSelectable = true;
            this.txtLogradouro.CustomButton.Visible = false;
            this.txtLogradouro.DisplayIcon = true;
            this.txtLogradouro.Lines = new string[0];
            this.txtLogradouro.Location = new System.Drawing.Point(113, 98);
            this.txtLogradouro.MaxLength = 150;
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.PasswordChar = '\0';
            this.txtLogradouro.ReadOnly = true;
            this.txtLogradouro.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLogradouro.SelectedText = "";
            this.txtLogradouro.SelectionLength = 0;
            this.txtLogradouro.SelectionStart = 0;
            this.txtLogradouro.ShortcutsEnabled = true;
            this.txtLogradouro.ShowClearButton = true;
            this.txtLogradouro.Size = new System.Drawing.Size(538, 23);
            this.txtLogradouro.TabIndex = 4;
            this.txtLogradouro.UseCustomBackColor = true;
            this.txtLogradouro.UseSelectable = true;
            this.txtLogradouro.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLogradouro.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(3, 16);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(53, 19);
            this.metroLabel6.TabIndex = 34;
            this.metroLabel6.Text = "Código";
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // 
            // 
            this.txtId.CustomButton.Image = null;
            this.txtId.CustomButton.Location = new System.Drawing.Point(37, 1);
            this.txtId.CustomButton.Name = "";
            this.txtId.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtId.CustomButton.TabIndex = 1;
            this.txtId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtId.CustomButton.UseSelectable = true;
            this.txtId.CustomButton.Visible = false;
            this.txtId.DisplayIcon = true;
            this.txtId.Lines = new string[0];
            this.txtId.Location = new System.Drawing.Point(113, 12);
            this.txtId.MaxLength = 25;
            this.txtId.Name = "txtId";
            this.txtId.PasswordChar = '\0';
            this.txtId.ReadOnly = true;
            this.txtId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtId.SelectedText = "";
            this.txtId.SelectionLength = 0;
            this.txtId.SelectionStart = 0;
            this.txtId.ShortcutsEnabled = true;
            this.txtId.ShowClearButton = true;
            this.txtId.Size = new System.Drawing.Size(59, 23);
            this.txtId.TabIndex = 1;
            this.txtId.UseCustomBackColor = true;
            this.txtId.UseSelectable = true;
            this.txtId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(3, 45);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(46, 19);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            // 
            // 
            // 
            this.txtNome.CustomButton.Image = null;
            this.txtNome.CustomButton.Location = new System.Drawing.Point(516, 1);
            this.txtNome.CustomButton.Name = "";
            this.txtNome.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNome.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNome.CustomButton.TabIndex = 1;
            this.txtNome.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNome.CustomButton.UseSelectable = true;
            this.txtNome.CustomButton.Visible = false;
            this.txtNome.DisplayIcon = true;
            this.txtNome.Lines = new string[0];
            this.txtNome.Location = new System.Drawing.Point(113, 41);
            this.txtNome.MaxLength = 100;
            this.txtNome.Name = "txtNome";
            this.txtNome.PasswordChar = '\0';
            this.txtNome.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNome.SelectedText = "";
            this.txtNome.SelectionLength = 0;
            this.txtNome.SelectionStart = 0;
            this.txtNome.ShortcutsEnabled = true;
            this.txtNome.ShowClearButton = true;
            this.txtNome.Size = new System.Drawing.Size(538, 23);
            this.txtNome.TabIndex = 2;
            this.txtNome.UseSelectable = true;
            this.txtNome.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNome.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtbFiltro
            // 
            this.mtbFiltro.Controls.Add(this.dgvFitro);
            this.mtbFiltro.Controls.Add(this.btnPesquisar);
            this.mtbFiltro.Controls.Add(this.metroLabel4);
            this.mtbFiltro.Controls.Add(this.txtNomeF);
            this.mtbFiltro.HorizontalScrollbarBarColor = true;
            this.mtbFiltro.HorizontalScrollbarHighlightOnWheel = false;
            this.mtbFiltro.HorizontalScrollbarSize = 10;
            this.mtbFiltro.Location = new System.Drawing.Point(4, 38);
            this.mtbFiltro.Name = "mtbFiltro";
            this.mtbFiltro.Size = new System.Drawing.Size(682, 330);
            this.mtbFiltro.TabIndex = 1;
            this.mtbFiltro.Text = "Filtro";
            this.mtbFiltro.VerticalScrollbarBarColor = true;
            this.mtbFiltro.VerticalScrollbarHighlightOnWheel = false;
            this.mtbFiltro.VerticalScrollbarSize = 10;
            // 
            // dgvFitro
            // 
            this.dgvFitro.AllowUserToAddRows = false;
            this.dgvFitro.AllowUserToDeleteRows = false;
            this.dgvFitro.AllowUserToResizeColumns = false;
            this.dgvFitro.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Azure;
            this.dgvFitro.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvFitro.AutoGenerateColumns = false;
            this.dgvFitro.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvFitro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFitro.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvFitro.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFitro.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvFitro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFitro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.logradouroDataGridViewTextBoxColumn,
            this.complementoDataGridViewTextBoxColumn,
            this.bairroDataGridViewTextBoxColumn,
            this.cidadeDataGridViewTextBoxColumn,
            this.uFDataGridViewTextBoxColumn});
            this.dgvFitro.DataSource = this.bsFiltro;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFitro.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvFitro.EnableHeadersVisualStyles = false;
            this.dgvFitro.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvFitro.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvFitro.Location = new System.Drawing.Point(3, 44);
            this.dgvFitro.MultiSelect = false;
            this.dgvFitro.Name = "dgvFitro";
            this.dgvFitro.ReadOnly = true;
            this.dgvFitro.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFitro.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvFitro.RowHeadersVisible = false;
            this.dgvFitro.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvFitro.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvFitro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFitro.Size = new System.Drawing.Size(679, 269);
            this.dgvFitro.TabIndex = 27;
            this.dgvFitro.UseCustomBackColor = true;
            this.dgvFitro.UseCustomForeColor = true;
            this.dgvFitro.UseStyleColors = true;
            this.dgvFitro.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFitro_CellDoubleClick);
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "Código";
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            this.codigoDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoDataGridViewTextBoxColumn.Width = 50;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // logradouroDataGridViewTextBoxColumn
            // 
            this.logradouroDataGridViewTextBoxColumn.DataPropertyName = "Logradouro";
            this.logradouroDataGridViewTextBoxColumn.HeaderText = "Logradouro";
            this.logradouroDataGridViewTextBoxColumn.Name = "logradouroDataGridViewTextBoxColumn";
            this.logradouroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // complementoDataGridViewTextBoxColumn
            // 
            this.complementoDataGridViewTextBoxColumn.DataPropertyName = "Complemento";
            this.complementoDataGridViewTextBoxColumn.HeaderText = "Complemento";
            this.complementoDataGridViewTextBoxColumn.Name = "complementoDataGridViewTextBoxColumn";
            this.complementoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bairroDataGridViewTextBoxColumn
            // 
            this.bairroDataGridViewTextBoxColumn.DataPropertyName = "Bairro";
            this.bairroDataGridViewTextBoxColumn.HeaderText = "Bairro";
            this.bairroDataGridViewTextBoxColumn.Name = "bairroDataGridViewTextBoxColumn";
            this.bairroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cidadeDataGridViewTextBoxColumn
            // 
            this.cidadeDataGridViewTextBoxColumn.DataPropertyName = "Cidade";
            this.cidadeDataGridViewTextBoxColumn.HeaderText = "Cidade";
            this.cidadeDataGridViewTextBoxColumn.Name = "cidadeDataGridViewTextBoxColumn";
            this.cidadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uFDataGridViewTextBoxColumn
            // 
            this.uFDataGridViewTextBoxColumn.DataPropertyName = "UF";
            this.uFDataGridViewTextBoxColumn.HeaderText = "UF";
            this.uFDataGridViewTextBoxColumn.Name = "uFDataGridViewTextBoxColumn";
            this.uFDataGridViewTextBoxColumn.ReadOnly = true;
            this.uFDataGridViewTextBoxColumn.Width = 30;
            // 
            // bsFiltro
            // 
            this.bsFiltro.DataSource = typeof(AGROTIS.CUL.Model.Cadastro.ClienteCUL);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.BackgroundImage")));
            this.btnPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPesquisar.Location = new System.Drawing.Point(649, 5);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(33, 23);
            this.btnPesquisar.TabIndex = 20;
            this.btnPesquisar.UseSelectable = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(3, 9);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(46, 19);
            this.metroLabel4.TabIndex = 19;
            this.metroLabel4.Text = "Nome";
            // 
            // txtNomeF
            // 
            this.txtNomeF.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtNomeF.CustomButton.Image = null;
            this.txtNomeF.CustomButton.Location = new System.Drawing.Point(566, 1);
            this.txtNomeF.CustomButton.Name = "";
            this.txtNomeF.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNomeF.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNomeF.CustomButton.TabIndex = 1;
            this.txtNomeF.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNomeF.CustomButton.UseSelectable = true;
            this.txtNomeF.CustomButton.Visible = false;
            this.txtNomeF.DisplayIcon = true;
            this.txtNomeF.Lines = new string[0];
            this.txtNomeF.Location = new System.Drawing.Point(55, 5);
            this.txtNomeF.MaxLength = 25;
            this.txtNomeF.Name = "txtNomeF";
            this.txtNomeF.PasswordChar = '\0';
            this.txtNomeF.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNomeF.SelectedText = "";
            this.txtNomeF.SelectionLength = 0;
            this.txtNomeF.SelectionStart = 0;
            this.txtNomeF.ShortcutsEnabled = true;
            this.txtNomeF.ShowClearButton = true;
            this.txtNomeF.Size = new System.Drawing.Size(588, 23);
            this.txtNomeF.TabIndex = 7;
            this.txtNomeF.UseSelectable = true;
            this.txtNomeF.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNomeF.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 437);
            this.Controls.Add(this.tbcPainel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCliente";
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.FrmCliente_Load);
            this.tbcPainel.ResumeLayout(false);
            this.mtbCadastro.ResumeLayout(false);
            this.pnlCampos.ResumeLayout(false);
            this.pnlCampos.PerformLayout();
            this.mtbFiltro.ResumeLayout(false);
            this.mtbFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFitro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFiltro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tbcPainel;
        private MetroFramework.Controls.MetroTabPage mtbCadastro;
        private MetroFramework.Controls.MetroButton btnNovo;
        private MetroFramework.Controls.MetroButton btnSalvar;
        private MetroFramework.Controls.MetroButton btnExcluir;
        private MetroFramework.Controls.MetroButton btnCancelar;
        private MetroFramework.Controls.MetroPanel pnlCampos;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox txtId;
        private MetroFramework.Controls.MetroLabel lblNome;
        private MetroFramework.Controls.MetroTextBox txtNome;
        private MetroFramework.Controls.MetroTabPage mtbFiltro;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtNomeF;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox txtCep;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtUf;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtCidade;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtBairro;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtLogradouro;
        private System.Windows.Forms.BindingSource bsFiltro;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroTextBox txtCodIBGE;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTextBox txtComp;
        private MetroFramework.Controls.MetroButton btnPesquisar;
        private MetroFramework.Controls.MetroGrid dgvFitro;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn logradouroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn complementoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bairroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uFDataGridViewTextBoxColumn;
    }
}