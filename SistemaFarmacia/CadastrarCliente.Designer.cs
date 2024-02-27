namespace SistemaFarmacia
{
    partial class CadastrarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarCliente));
            this.label1 = new System.Windows.Forms.Label();
            this.nomeCliente = new System.Windows.Forms.TextBox();
            this.planoSaude = new System.Windows.Forms.TextBox();
            this.farmPopular = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.confCliente = new System.Windows.Forms.Button();
            this.c = new System.Windows.Forms.Label();
            this.codCliente = new System.Windows.Forms.MaskedTextBox();
            this.RG = new System.Windows.Forms.MaskedTextBox();
            this.telefone = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(62, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastrar Cliente";
            // 
            // nomeCliente
            // 
            this.nomeCliente.Location = new System.Drawing.Point(124, 138);
            this.nomeCliente.Name = "nomeCliente";
            this.nomeCliente.Size = new System.Drawing.Size(167, 20);
            this.nomeCliente.TabIndex = 1;
            this.nomeCliente.TextChanged += new System.EventHandler(this.nomeCliente_TextChanged);
            // 
            // planoSaude
            // 
            this.planoSaude.Location = new System.Drawing.Point(197, 216);
            this.planoSaude.Name = "planoSaude";
            this.planoSaude.Size = new System.Drawing.Size(94, 20);
            this.planoSaude.TabIndex = 4;
            this.planoSaude.TextChanged += new System.EventHandler(this.planoSaude_TextChanged);
            // 
            // farmPopular
            // 
            this.farmPopular.Location = new System.Drawing.Point(197, 242);
            this.farmPopular.Name = "farmPopular";
            this.farmPopular.Size = new System.Drawing.Size(94, 20);
            this.farmPopular.TabIndex = 5;
            this.farmPopular.TextChanged += new System.EventHandler(this.farmPopular_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "RG";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Telefone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tem plano de saúde?";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(69, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Utiliza farmácia popular?";
            // 
            // confCliente
            // 
            this.confCliente.BackColor = System.Drawing.Color.OliveDrab;
            this.confCliente.Location = new System.Drawing.Point(149, 307);
            this.confCliente.Name = "confCliente";
            this.confCliente.Size = new System.Drawing.Size(75, 23);
            this.confCliente.TabIndex = 11;
            this.confCliente.Text = "Confirmar";
            this.confCliente.UseVisualStyleBackColor = false;
            this.confCliente.Click += new System.EventHandler(this.confCliente_Click);
            // 
            // c
            // 
            this.c.AutoSize = true;
            this.c.Location = new System.Drawing.Point(69, 116);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(40, 13);
            this.c.TabIndex = 12;
            this.c.Text = "Código";
            // 
            // codCliente
            // 
            this.codCliente.Location = new System.Drawing.Point(124, 109);
            this.codCliente.Mask = "0000";
            this.codCliente.Name = "codCliente";
            this.codCliente.Size = new System.Drawing.Size(55, 20);
            this.codCliente.TabIndex = 13;
            this.codCliente.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.codCliente_MaskInputRejected);
            // 
            // RG
            // 
            this.RG.Location = new System.Drawing.Point(124, 164);
            this.RG.Mask = "000000000-0";
            this.RG.Name = "RG";
            this.RG.Size = new System.Drawing.Size(55, 20);
            this.RG.TabIndex = 14;
            this.RG.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.RG_MaskInputRejected);
            // 
            // telefone
            // 
            this.telefone.Location = new System.Drawing.Point(124, 193);
            this.telefone.Mask = "(00)00000-0000";
            this.telefone.Name = "telefone";
            this.telefone.Size = new System.Drawing.Size(167, 20);
            this.telefone.TabIndex = 15;
            this.telefone.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.telefone_MaskInputRejected);
            // 
            // CadastrarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(361, 450);
            this.Controls.Add(this.telefone);
            this.Controls.Add(this.RG);
            this.Controls.Add(this.codCliente);
            this.Controls.Add(this.c);
            this.Controls.Add(this.confCliente);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.farmPopular);
            this.Controls.Add(this.planoSaude);
            this.Controls.Add(this.nomeCliente);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CadastrarCliente";
            this.Text = "Cadastrar Cliente";
            this.Load += new System.EventHandler(this.CadastrarCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nomeCliente;
        private System.Windows.Forms.TextBox planoSaude;
        private System.Windows.Forms.TextBox farmPopular;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button confCliente;
        private System.Windows.Forms.Label c;
        private System.Windows.Forms.MaskedTextBox codCliente;
        private System.Windows.Forms.MaskedTextBox RG;
        private System.Windows.Forms.MaskedTextBox telefone;
    }
}