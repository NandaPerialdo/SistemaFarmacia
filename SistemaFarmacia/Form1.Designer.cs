namespace SistemaFarmacia
{
    partial class Menu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.label1 = new System.Windows.Forms.Label();
            this.cadastrarCliente = new System.Windows.Forms.Button();
            this.cadastrarProduto = new System.Windows.Forms.Button();
            this.cadastrarFarmacia = new System.Windows.Forms.Button();
            this.registrarCompra = new System.Windows.Forms.Button();
            this.exibirRanking = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(134, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cadastrarCliente
            // 
            this.cadastrarCliente.Location = new System.Drawing.Point(122, 284);
            this.cadastrarCliente.Name = "cadastrarCliente";
            this.cadastrarCliente.Size = new System.Drawing.Size(108, 22);
            this.cadastrarCliente.TabIndex = 1;
            this.cadastrarCliente.Text = "Cadastrar Cliente";
            this.cadastrarCliente.UseVisualStyleBackColor = true;
            this.cadastrarCliente.Click += new System.EventHandler(this.cadastrarCliente_Click);
            // 
            // cadastrarProduto
            // 
            this.cadastrarProduto.Location = new System.Drawing.Point(122, 256);
            this.cadastrarProduto.Name = "cadastrarProduto";
            this.cadastrarProduto.Size = new System.Drawing.Size(108, 22);
            this.cadastrarProduto.TabIndex = 2;
            this.cadastrarProduto.Text = "Cadastrar Produto";
            this.cadastrarProduto.UseVisualStyleBackColor = true;
            this.cadastrarProduto.Click += new System.EventHandler(this.cadastrarProduto_Click);
            // 
            // cadastrarFarmacia
            // 
            this.cadastrarFarmacia.Location = new System.Drawing.Point(122, 312);
            this.cadastrarFarmacia.Name = "cadastrarFarmacia";
            this.cadastrarFarmacia.Size = new System.Drawing.Size(108, 23);
            this.cadastrarFarmacia.TabIndex = 3;
            this.cadastrarFarmacia.Text = "Cadastrar Farmácia";
            this.cadastrarFarmacia.UseVisualStyleBackColor = true;
            this.cadastrarFarmacia.Click += new System.EventHandler(this.cadastrarFarmacia_Click);
            // 
            // registrarCompra
            // 
            this.registrarCompra.Location = new System.Drawing.Point(91, 150);
            this.registrarCompra.Name = "registrarCompra";
            this.registrarCompra.Size = new System.Drawing.Size(169, 35);
            this.registrarCompra.TabIndex = 4;
            this.registrarCompra.Text = "Registrar Compra";
            this.registrarCompra.UseVisualStyleBackColor = true;
            this.registrarCompra.Click += new System.EventHandler(this.registrarCompra_Click);
            // 
            // exibirRanking
            // 
            this.exibirRanking.Location = new System.Drawing.Point(91, 191);
            this.exibirRanking.Name = "exibirRanking";
            this.exibirRanking.Size = new System.Drawing.Size(169, 31);
            this.exibirRanking.TabIndex = 5;
            this.exibirRanking.Text = "Exibir Ranking";
            this.exibirRanking.UseVisualStyleBackColor = true;
            this.exibirRanking.Click += new System.EventHandler(this.exibirRanking_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(361, 450);
            this.Controls.Add(this.exibirRanking);
            this.Controls.Add(this.registrarCompra);
            this.Controls.Add(this.cadastrarFarmacia);
            this.Controls.Add(this.cadastrarProduto);
            this.Controls.Add(this.cadastrarCliente);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cadastrarCliente;
        private System.Windows.Forms.Button cadastrarProduto;
        private System.Windows.Forms.Button cadastrarFarmacia;
        private System.Windows.Forms.Button registrarCompra;
        private System.Windows.Forms.Button exibirRanking;
    }
}

