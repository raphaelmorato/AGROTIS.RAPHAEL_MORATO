namespace AGROTIS.PLWF.Principal
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.mtlCliente = new MetroFramework.Controls.MetroTile();
            this.mtlProduto = new MetroFramework.Controls.MetroTile();
            this.mtlPedido = new MetroFramework.Controls.MetroTile();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // mtlCliente
            // 
            this.mtlCliente.ActiveControl = null;
            this.mtlCliente.Location = new System.Drawing.Point(70, 77);
            this.mtlCliente.Name = "mtlCliente";
            this.mtlCliente.Size = new System.Drawing.Size(146, 102);
            this.mtlCliente.TabIndex = 0;
            this.mtlCliente.Text = "Cliente";
            this.mtlCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtlCliente.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtlCliente.UseSelectable = true;
            this.mtlCliente.Click += new System.EventHandler(this.mtlCliente_Click);
            // 
            // mtlProduto
            // 
            this.mtlProduto.ActiveControl = null;
            this.mtlProduto.Location = new System.Drawing.Point(268, 77);
            this.mtlProduto.Name = "mtlProduto";
            this.mtlProduto.Size = new System.Drawing.Size(146, 102);
            this.mtlProduto.TabIndex = 0;
            this.mtlProduto.Text = "Produto";
            this.mtlProduto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtlProduto.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtlProduto.UseSelectable = true;
            this.mtlProduto.Click += new System.EventHandler(this.mtlProduto_Click);
            // 
            // mtlPedido
            // 
            this.mtlPedido.ActiveControl = null;
            this.mtlPedido.Location = new System.Drawing.Point(462, 77);
            this.mtlPedido.Name = "mtlPedido";
            this.mtlPedido.Size = new System.Drawing.Size(146, 102);
            this.mtlPedido.TabIndex = 0;
            this.mtlPedido.Text = "Colocação de \r\nPedidos";
            this.mtlPedido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtlPedido.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtlPedido.UseSelectable = true;
            this.mtlPedido.Click += new System.EventHandler(this.mtlPedido_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(462, 226);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(210, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Desenvolvido por Raphael Morato";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 265);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.mtlPedido);
            this.Controls.Add(this.mtlProduto);
            this.Controls.Add(this.mtlCliente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.Resizable = false;
            this.Text = "AGROTIS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile mtlCliente;
        private MetroFramework.Controls.MetroTile mtlProduto;
        private MetroFramework.Controls.MetroTile mtlPedido;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}