namespace AGROTIS.PLWF.Financeiro
{
    partial class FrmPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPedido));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbcPainel = new MetroFramework.Controls.MetroTabControl();
            this.mtbCadastro = new MetroFramework.Controls.MetroTabPage();
            this.btnNovo = new MetroFramework.Controls.MetroButton();
            this.btnSalvar = new MetroFramework.Controls.MetroButton();
            this.btnExcluir = new MetroFramework.Controls.MetroButton();
            this.btnCancelar = new MetroFramework.Controls.MetroButton();
            this.pnlCampos = new MetroFramework.Controls.MetroPanel();
            this.btnAdicionar = new MetroFramework.Controls.MetroButton();
            this.dtpDtEmissao = new System.Windows.Forms.DateTimePicker();
            this.txtQtd = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cboProduto = new System.Windows.Forms.ComboBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.txtIdProduto = new MetroFramework.Controls.MetroTextBox();
            this.cboCliente = new System.Windows.Forms.ComboBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.txtIdCliente = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtId = new MetroFramework.Controls.MetroTextBox();
            this.lblNome = new MetroFramework.Controls.MetroLabel();
            this.mtbFiltro = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtNomeF = new MetroFramework.Controls.MetroTextBox();
            this.btnPesquisar = new MetroFramework.Controls.MetroButton();
            this.dgvFiltro = new MetroFramework.Controls.MetroGrid();
            this.dataEmissaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPedidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsFiltro = new System.Windows.Forms.BindingSource(this.components);
            this.dgvProd = new MetroFramework.Controls.MetroGrid();
            this.bsProd = new System.Windows.Forms.BindingSource(this.components);
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pesoLiquidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pesoTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoUnitarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbcPainel.SuspendLayout();
            this.mtbCadastro.SuspendLayout();
            this.pnlCampos.SuspendLayout();
            this.mtbFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiltro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFiltro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProd)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcPainel
            // 
            this.tbcPainel.Controls.Add(this.mtbCadastro);
            this.tbcPainel.Controls.Add(this.mtbFiltro);
            this.tbcPainel.Location = new System.Drawing.Point(23, 67);
            this.tbcPainel.Multiline = true;
            this.tbcPainel.Name = "tbcPainel";
            this.tbcPainel.SelectedIndex = 1;
            this.tbcPainel.Size = new System.Drawing.Size(690, 306);
            this.tbcPainel.TabIndex = 37;
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
            this.mtbCadastro.Size = new System.Drawing.Size(682, 264);
            this.mtbCadastro.TabIndex = 0;
            this.mtbCadastro.Text = "Cadastro";
            this.mtbCadastro.VerticalScrollbarBarColor = true;
            this.mtbCadastro.VerticalScrollbarHighlightOnWheel = false;
            this.mtbCadastro.VerticalScrollbarSize = 10;
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(3, 238);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(59, 23);
            this.btnNovo.TabIndex = 8;
            this.btnNovo.Text = "&Novo";
            this.btnNovo.UseSelectable = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(68, 238);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(59, 23);
            this.btnSalvar.TabIndex = 9;
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.UseSelectable = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(133, 238);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(59, 23);
            this.btnExcluir.TabIndex = 10;
            this.btnExcluir.Text = "&Excluir";
            this.btnExcluir.UseSelectable = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(198, 238);
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
            this.pnlCampos.Controls.Add(this.dgvProd);
            this.pnlCampos.Controls.Add(this.btnAdicionar);
            this.pnlCampos.Controls.Add(this.dtpDtEmissao);
            this.pnlCampos.Controls.Add(this.txtQtd);
            this.pnlCampos.Controls.Add(this.metroLabel1);
            this.pnlCampos.Controls.Add(this.cboProduto);
            this.pnlCampos.Controls.Add(this.metroLabel9);
            this.pnlCampos.Controls.Add(this.txtIdProduto);
            this.pnlCampos.Controls.Add(this.cboCliente);
            this.pnlCampos.Controls.Add(this.metroLabel8);
            this.pnlCampos.Controls.Add(this.txtIdCliente);
            this.pnlCampos.Controls.Add(this.metroLabel6);
            this.pnlCampos.Controls.Add(this.txtId);
            this.pnlCampos.Controls.Add(this.lblNome);
            this.pnlCampos.HorizontalScrollbarBarColor = true;
            this.pnlCampos.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlCampos.HorizontalScrollbarSize = 10;
            this.pnlCampos.Location = new System.Drawing.Point(3, 3);
            this.pnlCampos.Name = "pnlCampos";
            this.pnlCampos.Size = new System.Drawing.Size(665, 229);
            this.pnlCampos.TabIndex = 0;
            this.pnlCampos.VerticalScrollbarBarColor = false;
            this.pnlCampos.VerticalScrollbarHighlightOnWheel = false;
            this.pnlCampos.VerticalScrollbarSize = 10;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(622, 73);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(29, 23);
            this.btnAdicionar.TabIndex = 12;
            this.btnAdicionar.Text = "+";
            this.btnAdicionar.UseSelectable = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // dtpDtEmissao
            // 
            this.dtpDtEmissao.Enabled = false;
            this.dtpDtEmissao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDtEmissao.Location = new System.Drawing.Point(571, 11);
            this.dtpDtEmissao.Name = "dtpDtEmissao";
            this.dtpDtEmissao.Size = new System.Drawing.Size(80, 20);
            this.dtpDtEmissao.TabIndex = 38;
            // 
            // txtQtd
            // 
            // 
            // 
            // 
            this.txtQtd.CustomButton.Image = null;
            this.txtQtd.CustomButton.Location = new System.Drawing.Point(37, 1);
            this.txtQtd.CustomButton.Name = "";
            this.txtQtd.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtQtd.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtQtd.CustomButton.TabIndex = 1;
            this.txtQtd.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtQtd.CustomButton.UseSelectable = true;
            this.txtQtd.CustomButton.Visible = false;
            this.txtQtd.DisplayIcon = true;
            this.txtQtd.Lines = new string[0];
            this.txtQtd.Location = new System.Drawing.Point(557, 74);
            this.txtQtd.MaxLength = 5;
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.PasswordChar = '\0';
            this.txtQtd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtQtd.SelectedText = "";
            this.txtQtd.SelectionLength = 0;
            this.txtQtd.SelectionStart = 0;
            this.txtQtd.ShortcutsEnabled = true;
            this.txtQtd.ShowClearButton = true;
            this.txtQtd.Size = new System.Drawing.Size(59, 23);
            this.txtQtd.TabIndex = 52;
            this.txtQtd.UseSelectable = true;
            this.txtQtd.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtQtd.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtQtd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoNum_KeyPress);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(473, 78);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(78, 19);
            this.metroLabel1.TabIndex = 51;
            this.metroLabel1.Text = "Quantidade";
            // 
            // cboProduto
            // 
            this.cboProduto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboProduto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboProduto.DropDownHeight = 80;
            this.cboProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboProduto.FormattingEnabled = true;
            this.cboProduto.IntegralHeight = false;
            this.cboProduto.Location = new System.Drawing.Point(164, 73);
            this.cboProduto.Name = "cboProduto";
            this.cboProduto.Size = new System.Drawing.Size(303, 23);
            this.cboProduto.TabIndex = 49;
            this.cboProduto.SelectionChangeCommitted += new System.EventHandler(this.cboProduto_SelectionChangeCommitted);
            this.cboProduto.Validating += new System.ComponentModel.CancelEventHandler(this.cboProduto_Validating);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(3, 73);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(57, 19);
            this.metroLabel9.TabIndex = 48;
            this.metroLabel9.Text = "Produto";
            // 
            // txtIdProduto
            // 
            // 
            // 
            // 
            this.txtIdProduto.CustomButton.Image = null;
            this.txtIdProduto.CustomButton.Location = new System.Drawing.Point(37, 1);
            this.txtIdProduto.CustomButton.Name = "";
            this.txtIdProduto.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtIdProduto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtIdProduto.CustomButton.TabIndex = 1;
            this.txtIdProduto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtIdProduto.CustomButton.UseSelectable = true;
            this.txtIdProduto.CustomButton.Visible = false;
            this.txtIdProduto.DisplayIcon = true;
            this.txtIdProduto.Lines = new string[0];
            this.txtIdProduto.Location = new System.Drawing.Point(99, 73);
            this.txtIdProduto.MaxLength = 5;
            this.txtIdProduto.Name = "txtIdProduto";
            this.txtIdProduto.PasswordChar = '\0';
            this.txtIdProduto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtIdProduto.SelectedText = "";
            this.txtIdProduto.SelectionLength = 0;
            this.txtIdProduto.SelectionStart = 0;
            this.txtIdProduto.ShortcutsEnabled = true;
            this.txtIdProduto.ShowClearButton = true;
            this.txtIdProduto.Size = new System.Drawing.Size(59, 23);
            this.txtIdProduto.TabIndex = 47;
            this.txtIdProduto.UseSelectable = true;
            this.txtIdProduto.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtIdProduto.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtIdProduto.TextChanged += new System.EventHandler(this.txtIdProduto_TextChanged);
            this.txtIdProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoNum_KeyPress);
            this.txtIdProduto.Validating += new System.ComponentModel.CancelEventHandler(this.txtIdProduto_Validating);
            // 
            // cboCliente
            // 
            this.cboCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboCliente.DropDownHeight = 80;
            this.cboCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.IntegralHeight = false;
            this.cboCliente.Location = new System.Drawing.Point(164, 45);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(303, 23);
            this.cboCliente.TabIndex = 46;
            this.cboCliente.SelectionChangeCommitted += new System.EventHandler(this.cboCliente_SelectionChangeCommitted);
            this.cboCliente.Validating += new System.ComponentModel.CancelEventHandler(this.cboCliente_Validating);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(3, 45);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(49, 19);
            this.metroLabel8.TabIndex = 44;
            this.metroLabel8.Text = "Cliente";
            // 
            // txtIdCliente
            // 
            // 
            // 
            // 
            this.txtIdCliente.CustomButton.Image = null;
            this.txtIdCliente.CustomButton.Location = new System.Drawing.Point(37, 1);
            this.txtIdCliente.CustomButton.Name = "";
            this.txtIdCliente.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtIdCliente.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtIdCliente.CustomButton.TabIndex = 1;
            this.txtIdCliente.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtIdCliente.CustomButton.UseSelectable = true;
            this.txtIdCliente.CustomButton.Visible = false;
            this.txtIdCliente.DisplayIcon = true;
            this.txtIdCliente.Lines = new string[0];
            this.txtIdCliente.Location = new System.Drawing.Point(99, 45);
            this.txtIdCliente.MaxLength = 5;
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.PasswordChar = '\0';
            this.txtIdCliente.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtIdCliente.SelectedText = "";
            this.txtIdCliente.SelectionLength = 0;
            this.txtIdCliente.SelectionStart = 0;
            this.txtIdCliente.ShortcutsEnabled = true;
            this.txtIdCliente.ShowClearButton = true;
            this.txtIdCliente.Size = new System.Drawing.Size(59, 23);
            this.txtIdCliente.TabIndex = 3;
            this.txtIdCliente.UseSelectable = true;
            this.txtIdCliente.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtIdCliente.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtIdCliente.TextChanged += new System.EventHandler(this.txtIdCliente_TextChanged);
            this.txtIdCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoNum_KeyPress);
            this.txtIdCliente.Validating += new System.ComponentModel.CancelEventHandler(this.txtIdCliente_Validating);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(3, 16);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(90, 19);
            this.metroLabel6.TabIndex = 34;
            this.metroLabel6.Text = "Nº do Pedido";
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
            this.txtId.Location = new System.Drawing.Point(99, 12);
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
            this.lblNome.Location = new System.Drawing.Point(459, 11);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(106, 19);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Data de emissão";
            // 
            // mtbFiltro
            // 
            this.mtbFiltro.Controls.Add(this.dgvFiltro);
            this.mtbFiltro.Controls.Add(this.btnPesquisar);
            this.mtbFiltro.Controls.Add(this.metroLabel4);
            this.mtbFiltro.Controls.Add(this.txtNomeF);
            this.mtbFiltro.HorizontalScrollbarBarColor = true;
            this.mtbFiltro.HorizontalScrollbarHighlightOnWheel = false;
            this.mtbFiltro.HorizontalScrollbarSize = 10;
            this.mtbFiltro.Location = new System.Drawing.Point(4, 38);
            this.mtbFiltro.Name = "mtbFiltro";
            this.mtbFiltro.Size = new System.Drawing.Size(682, 264);
            this.mtbFiltro.TabIndex = 1;
            this.mtbFiltro.Text = "Filtro";
            this.mtbFiltro.VerticalScrollbarBarColor = true;
            this.mtbFiltro.VerticalScrollbarHighlightOnWheel = false;
            this.mtbFiltro.VerticalScrollbarSize = 10;
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
            this.txtNomeF.CustomButton.Location = new System.Drawing.Point(460, 1);
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
            // btnPesquisar
            // 
            this.btnPesquisar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.BackgroundImage")));
            this.btnPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPesquisar.Location = new System.Drawing.Point(646, 5);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(33, 23);
            this.btnPesquisar.TabIndex = 27;
            this.btnPesquisar.UseSelectable = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // dgvFiltro
            // 
            this.dgvFiltro.AllowUserToAddRows = false;
            this.dgvFiltro.AllowUserToDeleteRows = false;
            this.dgvFiltro.AllowUserToResizeColumns = false;
            this.dgvFiltro.AllowUserToResizeRows = false;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.Azure;
            this.dgvFiltro.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvFiltro.AutoGenerateColumns = false;
            this.dgvFiltro.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvFiltro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFiltro.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvFiltro.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFiltro.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dgvFiltro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFiltro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPedidoDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.dataEmissaoDataGridViewTextBoxColumn});
            this.dgvFiltro.DataSource = this.bsFiltro;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFiltro.DefaultCellStyle = dataGridViewCellStyle19;
            this.dgvFiltro.EnableHeadersVisualStyles = false;
            this.dgvFiltro.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvFiltro.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvFiltro.Location = new System.Drawing.Point(2, 34);
            this.dgvFiltro.MultiSelect = false;
            this.dgvFiltro.Name = "dgvFiltro";
            this.dgvFiltro.ReadOnly = true;
            this.dgvFiltro.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFiltro.RowHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.dgvFiltro.RowHeadersVisible = false;
            this.dgvFiltro.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvFiltro.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvFiltro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFiltro.Size = new System.Drawing.Size(679, 233);
            this.dgvFiltro.TabIndex = 28;
            this.dgvFiltro.UseCustomBackColor = true;
            this.dgvFiltro.UseCustomForeColor = true;
            this.dgvFiltro.UseStyleColors = true;
            this.dgvFiltro.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFiltro_CellDoubleClick);
            // 
            // dataEmissaoDataGridViewTextBoxColumn
            // 
            this.dataEmissaoDataGridViewTextBoxColumn.DataPropertyName = "DataEmissao";
            this.dataEmissaoDataGridViewTextBoxColumn.HeaderText = "Data de Emissão";
            this.dataEmissaoDataGridViewTextBoxColumn.Name = "dataEmissaoDataGridViewTextBoxColumn";
            this.dataEmissaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idPedidoDataGridViewTextBoxColumn
            // 
            this.idPedidoDataGridViewTextBoxColumn.DataPropertyName = "IdPedido";
            this.idPedidoDataGridViewTextBoxColumn.HeaderText = "Código do pedido";
            this.idPedidoDataGridViewTextBoxColumn.Name = "idPedidoDataGridViewTextBoxColumn";
            this.idPedidoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bsFiltro
            // 
            this.bsFiltro.DataSource = typeof(AGROTIS.Model.Financeiro.PedidoFiltroGrid);
            // 
            // dgvProd
            // 
            this.dgvProd.AllowUserToAddRows = false;
            this.dgvProd.AllowUserToResizeColumns = false;
            this.dgvProd.AllowUserToResizeRows = false;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.Azure;
            this.dgvProd.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle21;
            this.dgvProd.AutoGenerateColumns = false;
            this.dgvProd.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvProd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProd.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvProd.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.dgvProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn,
            this.quantidadeDataGridViewTextBoxColumn,
            this.pesoLiquidoDataGridViewTextBoxColumn,
            this.pesoTotalDataGridViewTextBoxColumn,
            this.precoUnitarioDataGridViewTextBoxColumn,
            this.precoTotalDataGridViewTextBoxColumn});
            this.dgvProd.DataSource = this.bsProd;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProd.DefaultCellStyle = dataGridViewCellStyle23;
            this.dgvProd.EnableHeadersVisualStyles = false;
            this.dgvProd.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvProd.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvProd.Location = new System.Drawing.Point(3, 102);
            this.dgvProd.MultiSelect = false;
            this.dgvProd.Name = "dgvProd";
            this.dgvProd.ReadOnly = true;
            this.dgvProd.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProd.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.dgvProd.RowHeadersVisible = false;
            this.dgvProd.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvProd.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvProd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProd.Size = new System.Drawing.Size(648, 125);
            this.dgvProd.TabIndex = 53;
            this.dgvProd.UseCustomBackColor = true;
            this.dgvProd.UseCustomForeColor = true;
            this.dgvProd.UseStyleColors = true;
            this.dgvProd.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgvProd_UserDeletingRow);
            // 
            // bsProd
            // 
            this.bsProd.DataSource = typeof(AGROTIS.Model.Financeiro.PedidoItemGrid);
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "Código";
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            this.codigoDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoDataGridViewTextBoxColumn.Width = 70;
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "Descrição";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            this.descricaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantidadeDataGridViewTextBoxColumn
            // 
            this.quantidadeDataGridViewTextBoxColumn.DataPropertyName = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.HeaderText = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.Name = "quantidadeDataGridViewTextBoxColumn";
            this.quantidadeDataGridViewTextBoxColumn.ReadOnly = true;
            this.quantidadeDataGridViewTextBoxColumn.Width = 70;
            // 
            // pesoLiquidoDataGridViewTextBoxColumn
            // 
            this.pesoLiquidoDataGridViewTextBoxColumn.DataPropertyName = "PesoLiquido";
            this.pesoLiquidoDataGridViewTextBoxColumn.HeaderText = "Peso Líquido";
            this.pesoLiquidoDataGridViewTextBoxColumn.Name = "pesoLiquidoDataGridViewTextBoxColumn";
            this.pesoLiquidoDataGridViewTextBoxColumn.ReadOnly = true;
            this.pesoLiquidoDataGridViewTextBoxColumn.Width = 70;
            // 
            // pesoTotalDataGridViewTextBoxColumn
            // 
            this.pesoTotalDataGridViewTextBoxColumn.DataPropertyName = "PesoTotal";
            this.pesoTotalDataGridViewTextBoxColumn.HeaderText = "Peso Total";
            this.pesoTotalDataGridViewTextBoxColumn.Name = "pesoTotalDataGridViewTextBoxColumn";
            this.pesoTotalDataGridViewTextBoxColumn.ReadOnly = true;
            this.pesoTotalDataGridViewTextBoxColumn.Width = 70;
            // 
            // precoUnitarioDataGridViewTextBoxColumn
            // 
            this.precoUnitarioDataGridViewTextBoxColumn.DataPropertyName = "PrecoUnitario";
            this.precoUnitarioDataGridViewTextBoxColumn.HeaderText = "Preço unitário";
            this.precoUnitarioDataGridViewTextBoxColumn.Name = "precoUnitarioDataGridViewTextBoxColumn";
            this.precoUnitarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.precoUnitarioDataGridViewTextBoxColumn.Width = 70;
            // 
            // precoTotalDataGridViewTextBoxColumn
            // 
            this.precoTotalDataGridViewTextBoxColumn.DataPropertyName = "PrecoTotal";
            this.precoTotalDataGridViewTextBoxColumn.HeaderText = "Preço Total";
            this.precoTotalDataGridViewTextBoxColumn.Name = "precoTotalDataGridViewTextBoxColumn";
            this.precoTotalDataGridViewTextBoxColumn.ReadOnly = true;
            this.precoTotalDataGridViewTextBoxColumn.Width = 70;
            // 
            // FrmPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 382);
            this.Controls.Add(this.tbcPainel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPedido";
            this.Resizable = false;
            this.Text = "Colocação de Pedidos";
            this.Load += new System.EventHandler(this.FrmPedido_Load);
            this.tbcPainel.ResumeLayout(false);
            this.mtbCadastro.ResumeLayout(false);
            this.pnlCampos.ResumeLayout(false);
            this.pnlCampos.PerformLayout();
            this.mtbFiltro.ResumeLayout(false);
            this.mtbFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiltro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFiltro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProd)).EndInit();
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
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox txtIdCliente;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox txtId;
        private MetroFramework.Controls.MetroLabel lblNome;
        private MetroFramework.Controls.MetroTabPage mtbFiltro;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtNomeF;
        private MetroFramework.Controls.MetroButton btnAdicionar;
        private System.Windows.Forms.DateTimePicker dtpDtEmissao;
        private MetroFramework.Controls.MetroTextBox txtQtd;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.ComboBox cboProduto;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTextBox txtIdProduto;
        private System.Windows.Forms.ComboBox cboCliente;
        private MetroFramework.Controls.MetroButton btnPesquisar;
        private MetroFramework.Controls.MetroGrid dgvFiltro;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPedidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataEmissaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bsFiltro;
        private MetroFramework.Controls.MetroGrid dgvProd;
        private System.Windows.Forms.BindingSource bsProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pesoLiquidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pesoTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoUnitarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoTotalDataGridViewTextBoxColumn;
    }
}