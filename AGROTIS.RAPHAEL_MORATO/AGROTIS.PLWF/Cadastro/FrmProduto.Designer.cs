namespace AGROTIS.PLWF.Cadastro
{
    partial class FrmProduto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProduto));
            this.tbcPainel = new MetroFramework.Controls.MetroTabControl();
            this.mtbCadastro = new MetroFramework.Controls.MetroTabPage();
            this.btnNovo = new MetroFramework.Controls.MetroButton();
            this.btnSalvar = new MetroFramework.Controls.MetroButton();
            this.btnExcluir = new MetroFramework.Controls.MetroButton();
            this.btnCancelar = new MetroFramework.Controls.MetroButton();
            this.pnlCampos = new MetroFramework.Controls.MetroPanel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.txtPesoLiquido = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtPrecoUnitario = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtId = new MetroFramework.Controls.MetroTextBox();
            this.lblNome = new MetroFramework.Controls.MetroLabel();
            this.txtDescricao = new MetroFramework.Controls.MetroTextBox();
            this.mtbFiltro = new MetroFramework.Controls.MetroTabPage();
            this.dgvFitro = new MetroFramework.Controls.MetroGrid();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pesoLiquidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoUnitarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsFiltro = new System.Windows.Forms.BindingSource(this.components);
            this.btnPesquisar = new MetroFramework.Controls.MetroButton();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtDescFiltro = new MetroFramework.Controls.MetroTextBox();
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
            this.tbcPainel.SelectedIndex = 0;
            this.tbcPainel.Size = new System.Drawing.Size(690, 225);
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
            this.mtbCadastro.Size = new System.Drawing.Size(682, 183);
            this.mtbCadastro.TabIndex = 0;
            this.mtbCadastro.Text = "Cadastro";
            this.mtbCadastro.VerticalScrollbarBarColor = true;
            this.mtbCadastro.VerticalScrollbarHighlightOnWheel = false;
            this.mtbCadastro.VerticalScrollbarSize = 10;
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(0, 152);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(59, 23);
            this.btnNovo.TabIndex = 8;
            this.btnNovo.Text = "&Novo";
            this.btnNovo.UseSelectable = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(65, 152);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(59, 23);
            this.btnSalvar.TabIndex = 9;
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.UseSelectable = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(130, 152);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(59, 23);
            this.btnExcluir.TabIndex = 10;
            this.btnExcluir.Text = "&Excluir";
            this.btnExcluir.UseSelectable = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(195, 152);
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
            this.pnlCampos.Controls.Add(this.metroLabel2);
            this.pnlCampos.Controls.Add(this.metroLabel8);
            this.pnlCampos.Controls.Add(this.txtPesoLiquido);
            this.pnlCampos.Controls.Add(this.metroLabel1);
            this.pnlCampos.Controls.Add(this.txtPrecoUnitario);
            this.pnlCampos.Controls.Add(this.metroLabel6);
            this.pnlCampos.Controls.Add(this.txtId);
            this.pnlCampos.Controls.Add(this.lblNome);
            this.pnlCampos.Controls.Add(this.txtDescricao);
            this.pnlCampos.HorizontalScrollbarBarColor = true;
            this.pnlCampos.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlCampos.HorizontalScrollbarSize = 10;
            this.pnlCampos.Location = new System.Drawing.Point(3, 3);
            this.pnlCampos.Name = "pnlCampos";
            this.pnlCampos.Size = new System.Drawing.Size(665, 142);
            this.pnlCampos.TabIndex = 0;
            this.pnlCampos.VerticalScrollbarBarColor = false;
            this.pnlCampos.VerticalScrollbarHighlightOnWheel = false;
            this.pnlCampos.VerticalScrollbarSize = 10;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(205, 73);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(17, 19);
            this.metroLabel2.TabIndex = 45;
            this.metroLabel2.Text = "g";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(3, 74);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(80, 19);
            this.metroLabel8.TabIndex = 44;
            this.metroLabel8.Text = "Peso líquido";
            // 
            // txtPesoLiquido
            // 
            // 
            // 
            // 
            this.txtPesoLiquido.CustomButton.Image = null;
            this.txtPesoLiquido.CustomButton.Location = new System.Drawing.Point(82, 1);
            this.txtPesoLiquido.CustomButton.Name = "";
            this.txtPesoLiquido.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPesoLiquido.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPesoLiquido.CustomButton.TabIndex = 1;
            this.txtPesoLiquido.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPesoLiquido.CustomButton.UseSelectable = true;
            this.txtPesoLiquido.CustomButton.Visible = false;
            this.txtPesoLiquido.DisplayIcon = true;
            this.txtPesoLiquido.Lines = new string[0];
            this.txtPesoLiquido.Location = new System.Drawing.Point(100, 69);
            this.txtPesoLiquido.MaxLength = 8;
            this.txtPesoLiquido.Name = "txtPesoLiquido";
            this.txtPesoLiquido.PasswordChar = '\0';
            this.txtPesoLiquido.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPesoLiquido.SelectedText = "";
            this.txtPesoLiquido.SelectionLength = 0;
            this.txtPesoLiquido.SelectionStart = 0;
            this.txtPesoLiquido.ShortcutsEnabled = true;
            this.txtPesoLiquido.ShowClearButton = true;
            this.txtPesoLiquido.Size = new System.Drawing.Size(104, 23);
            this.txtPesoLiquido.TabIndex = 3;
            this.txtPesoLiquido.UseSelectable = true;
            this.txtPesoLiquido.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPesoLiquido.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPesoLiquido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoDecimal);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(3, 102);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(91, 19);
            this.metroLabel1.TabIndex = 36;
            this.metroLabel1.Text = "Preço unitário";
            // 
            // txtPrecoUnitario
            // 
            // 
            // 
            // 
            this.txtPrecoUnitario.CustomButton.Image = null;
            this.txtPrecoUnitario.CustomButton.Location = new System.Drawing.Point(82, 1);
            this.txtPrecoUnitario.CustomButton.Name = "";
            this.txtPrecoUnitario.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPrecoUnitario.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPrecoUnitario.CustomButton.TabIndex = 1;
            this.txtPrecoUnitario.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPrecoUnitario.CustomButton.UseSelectable = true;
            this.txtPrecoUnitario.CustomButton.Visible = false;
            this.txtPrecoUnitario.DisplayIcon = true;
            this.txtPrecoUnitario.Lines = new string[0];
            this.txtPrecoUnitario.Location = new System.Drawing.Point(100, 98);
            this.txtPrecoUnitario.MaxLength = 8;
            this.txtPrecoUnitario.Name = "txtPrecoUnitario";
            this.txtPrecoUnitario.PasswordChar = '\0';
            this.txtPrecoUnitario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPrecoUnitario.SelectedText = "";
            this.txtPrecoUnitario.SelectionLength = 0;
            this.txtPrecoUnitario.SelectionStart = 0;
            this.txtPrecoUnitario.ShortcutsEnabled = true;
            this.txtPrecoUnitario.ShowClearButton = true;
            this.txtPrecoUnitario.Size = new System.Drawing.Size(104, 23);
            this.txtPrecoUnitario.TabIndex = 4;
            this.txtPrecoUnitario.UseSelectable = true;
            this.txtPrecoUnitario.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPrecoUnitario.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPrecoUnitario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoDecimal);
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
            this.txtId.Location = new System.Drawing.Point(100, 12);
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
            this.lblNome.Size = new System.Drawing.Size(65, 19);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Descrição";
            // 
            // txtDescricao
            // 
            // 
            // 
            // 
            this.txtDescricao.CustomButton.Image = null;
            this.txtDescricao.CustomButton.Location = new System.Drawing.Point(534, 1);
            this.txtDescricao.CustomButton.Name = "";
            this.txtDescricao.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDescricao.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDescricao.CustomButton.TabIndex = 1;
            this.txtDescricao.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDescricao.CustomButton.UseSelectable = true;
            this.txtDescricao.CustomButton.Visible = false;
            this.txtDescricao.DisplayIcon = true;
            this.txtDescricao.Lines = new string[0];
            this.txtDescricao.Location = new System.Drawing.Point(100, 41);
            this.txtDescricao.MaxLength = 150;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.PasswordChar = '\0';
            this.txtDescricao.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDescricao.SelectedText = "";
            this.txtDescricao.SelectionLength = 0;
            this.txtDescricao.SelectionStart = 0;
            this.txtDescricao.ShortcutsEnabled = true;
            this.txtDescricao.ShowClearButton = true;
            this.txtDescricao.Size = new System.Drawing.Size(556, 23);
            this.txtDescricao.TabIndex = 2;
            this.txtDescricao.UseSelectable = true;
            this.txtDescricao.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDescricao.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtbFiltro
            // 
            this.mtbFiltro.Controls.Add(this.dgvFitro);
            this.mtbFiltro.Controls.Add(this.btnPesquisar);
            this.mtbFiltro.Controls.Add(this.metroLabel4);
            this.mtbFiltro.Controls.Add(this.txtDescFiltro);
            this.mtbFiltro.HorizontalScrollbarBarColor = true;
            this.mtbFiltro.HorizontalScrollbarHighlightOnWheel = false;
            this.mtbFiltro.HorizontalScrollbarSize = 10;
            this.mtbFiltro.Location = new System.Drawing.Point(4, 38);
            this.mtbFiltro.Name = "mtbFiltro";
            this.mtbFiltro.Size = new System.Drawing.Size(682, 183);
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
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Azure;
            this.dgvFitro.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFitro.AutoGenerateColumns = false;
            this.dgvFitro.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvFitro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFitro.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvFitro.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFitro.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFitro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFitro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn,
            this.pesoLiquidoDataGridViewTextBoxColumn,
            this.precoUnitarioDataGridViewTextBoxColumn});
            this.dgvFitro.DataSource = this.bsFiltro;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFitro.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvFitro.EnableHeadersVisualStyles = false;
            this.dgvFitro.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvFitro.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvFitro.Location = new System.Drawing.Point(3, 34);
            this.dgvFitro.MultiSelect = false;
            this.dgvFitro.Name = "dgvFitro";
            this.dgvFitro.ReadOnly = true;
            this.dgvFitro.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFitro.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvFitro.RowHeadersVisible = false;
            this.dgvFitro.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvFitro.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvFitro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFitro.Size = new System.Drawing.Size(679, 142);
            this.dgvFitro.TabIndex = 26;
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
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "Descrição";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            this.descricaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pesoLiquidoDataGridViewTextBoxColumn
            // 
            this.pesoLiquidoDataGridViewTextBoxColumn.DataPropertyName = "PesoLiquido";
            this.pesoLiquidoDataGridViewTextBoxColumn.HeaderText = "Peso Líquido";
            this.pesoLiquidoDataGridViewTextBoxColumn.Name = "pesoLiquidoDataGridViewTextBoxColumn";
            this.pesoLiquidoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // precoUnitarioDataGridViewTextBoxColumn
            // 
            this.precoUnitarioDataGridViewTextBoxColumn.DataPropertyName = "PrecoUnitario";
            this.precoUnitarioDataGridViewTextBoxColumn.HeaderText = "Preço Unitário";
            this.precoUnitarioDataGridViewTextBoxColumn.Name = "precoUnitarioDataGridViewTextBoxColumn";
            this.precoUnitarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bsFiltro
            // 
            this.bsFiltro.DataSource = typeof(AGROTIS.CUL.Model.Cadastro.ProdutoCUL);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.BackgroundImage")));
            this.btnPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPesquisar.Location = new System.Drawing.Point(649, 5);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(33, 23);
            this.btnPesquisar.TabIndex = 9;
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
            // txtDescFiltro
            // 
            this.txtDescFiltro.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtDescFiltro.CustomButton.Image = null;
            this.txtDescFiltro.CustomButton.Location = new System.Drawing.Point(556, 1);
            this.txtDescFiltro.CustomButton.Name = "";
            this.txtDescFiltro.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDescFiltro.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDescFiltro.CustomButton.TabIndex = 1;
            this.txtDescFiltro.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDescFiltro.CustomButton.UseSelectable = true;
            this.txtDescFiltro.CustomButton.Visible = false;
            this.txtDescFiltro.DisplayIcon = true;
            this.txtDescFiltro.Lines = new string[0];
            this.txtDescFiltro.Location = new System.Drawing.Point(65, 5);
            this.txtDescFiltro.MaxLength = 25;
            this.txtDescFiltro.Name = "txtDescFiltro";
            this.txtDescFiltro.PasswordChar = '\0';
            this.txtDescFiltro.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDescFiltro.SelectedText = "";
            this.txtDescFiltro.SelectionLength = 0;
            this.txtDescFiltro.SelectionStart = 0;
            this.txtDescFiltro.ShortcutsEnabled = true;
            this.txtDescFiltro.ShowClearButton = true;
            this.txtDescFiltro.Size = new System.Drawing.Size(578, 23);
            this.txtDescFiltro.TabIndex = 7;
            this.txtDescFiltro.UseSelectable = true;
            this.txtDescFiltro.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDescFiltro.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // FrmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 300);
            this.Controls.Add(this.tbcPainel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmProduto";
            this.Resizable = false;
            this.Text = "Produto";
            this.Load += new System.EventHandler(this.FrmProduto_Load);
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
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox txtPesoLiquido;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtPrecoUnitario;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox txtId;
        private MetroFramework.Controls.MetroLabel lblNome;
        private MetroFramework.Controls.MetroTextBox txtDescricao;
        private MetroFramework.Controls.MetroTabPage mtbFiltro;
        private MetroFramework.Controls.MetroGrid dgvFitro;
        private MetroFramework.Controls.MetroButton btnPesquisar;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtDescFiltro;
        private System.Windows.Forms.BindingSource bsFiltro;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pesoLiquidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoUnitarioDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}