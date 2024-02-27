namespace SistemaFarmacia
{
    partial class CadastrarProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarProduto));
            this.label1 = new System.Windows.Forms.Label();
            this.nomeProduto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.confProduto = new System.Windows.Forms.Button();
            this.valorProduto = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.codProduto = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(60, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastrar Produto";
            // 
            // nomeProduto
            // 
            this.nomeProduto.Location = new System.Drawing.Point(174, 180);
            this.nomeProduto.Name = "nomeProduto";
            this.nomeProduto.Size = new System.Drawing.Size(125, 20);
            this.nomeProduto.TabIndex = 1;
            this.nomeProduto.TextChanged += new System.EventHandler(this.nomeProduto_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome do Produto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(137, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Valor";
            // 
            // confProduto
            // 
            this.confProduto.BackColor = System.Drawing.Color.OliveDrab;
            this.confProduto.Location = new System.Drawing.Point(140, 277);
            this.confProduto.Name = "confProduto";
            this.confProduto.Size = new System.Drawing.Size(75, 23);
            this.confProduto.TabIndex = 5;
            this.confProduto.Text = "Confirmar";
            this.confProduto.UseVisualStyleBackColor = false;
            this.confProduto.Click += new System.EventHandler(this.confProduto_Click);
            // 
            // valorProduto
            // 
            this.valorProduto.Location = new System.Drawing.Point(174, 206);
            this.valorProduto.Mask = "000,00";
            this.valorProduto.Name = "valorProduto";
            this.valorProduto.Size = new System.Drawing.Size(100, 20);
            this.valorProduto.TabIndex = 6;
            this.valorProduto.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.valorProduto_MaskInputRejected);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Codigo do Produto";
            // 
            // codProduto
            // 
            this.codProduto.Location = new System.Drawing.Point(174, 157);
            this.codProduto.Mask = "000";
            this.codProduto.Name = "codProduto";
            this.codProduto.Size = new System.Drawing.Size(41, 20);
            this.codProduto.TabIndex = 8;
            this.codProduto.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.codProduto_MaskInputRejected);
            // 
            // CadastrarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(361, 450);
            this.Controls.Add(this.codProduto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.valorProduto);
            this.Controls.Add(this.confProduto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nomeProduto);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CadastrarProduto";
            this.Text = "Cadastrar Produto";
            this.Load += new System.EventHandler(this.CadastrarProduto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nomeProduto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button confProduto;
        private System.Windows.Forms.MaskedTextBox valorProduto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox codProduto;
    }
}