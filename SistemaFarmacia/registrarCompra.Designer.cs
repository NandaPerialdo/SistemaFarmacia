namespace SistemaFarmacia
{
    partial class registrarCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(registrarCompra));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.confRegistro = new System.Windows.Forms.Button();
            this.codCliente = new System.Windows.Forms.MaskedTextBox();
            this.codProduto = new System.Windows.Forms.MaskedTextBox();
            this.codFarmacia = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(57, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registrar Compra";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Codigo do Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Codigo do Produto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Codigo da Farmacia";
            // 
            // confRegistro
            // 
            this.confRegistro.BackColor = System.Drawing.Color.OliveDrab;
            this.confRegistro.ForeColor = System.Drawing.Color.Black;
            this.confRegistro.Location = new System.Drawing.Point(119, 286);
            this.confRegistro.Name = "confRegistro";
            this.confRegistro.Size = new System.Drawing.Size(124, 23);
            this.confRegistro.TabIndex = 7;
            this.confRegistro.Text = "Confirmar Registro";
            this.confRegistro.UseVisualStyleBackColor = false;
            this.confRegistro.Click += new System.EventHandler(this.confRegistro_Click);
            // 
            // codCliente
            // 
            this.codCliente.Location = new System.Drawing.Point(143, 158);
            this.codCliente.Mask = "00000";
            this.codCliente.Name = "codCliente";
            this.codCliente.Size = new System.Drawing.Size(158, 20);
            this.codCliente.TabIndex = 8;
            this.codCliente.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.codCliente_MaskInputRejected);
            // 
            // codProduto
            // 
            this.codProduto.Location = new System.Drawing.Point(143, 182);
            this.codProduto.Mask = "00000";
            this.codProduto.Name = "codProduto";
            this.codProduto.Size = new System.Drawing.Size(158, 20);
            this.codProduto.TabIndex = 9;
            this.codProduto.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.codProduto_MaskInputRejected);
            // 
            // codFarmacia
            // 
            this.codFarmacia.Location = new System.Drawing.Point(143, 207);
            this.codFarmacia.Mask = "00000";
            this.codFarmacia.Name = "codFarmacia";
            this.codFarmacia.Size = new System.Drawing.Size(158, 20);
            this.codFarmacia.TabIndex = 10;
            this.codFarmacia.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.codFarmacia_MaskInputRejected);
            // 
            // registrarCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(361, 450);
            this.Controls.Add(this.codFarmacia);
            this.Controls.Add(this.codProduto);
            this.Controls.Add(this.codCliente);
            this.Controls.Add(this.confRegistro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "registrarCompra";
            this.Text = "Registrar Compra";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button confRegistro;
        private System.Windows.Forms.MaskedTextBox codCliente;
        private System.Windows.Forms.MaskedTextBox codProduto;
        private System.Windows.Forms.MaskedTextBox codFarmacia;
    }
}