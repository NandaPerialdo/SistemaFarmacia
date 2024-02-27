namespace SistemaFarmacia
{
    partial class CadastrarFarmacia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarFarmacia));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.confFarmacia = new System.Windows.Forms.Button();
            this.codFarmacia = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(43, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastrar Farmacia";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(162, 203);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(142, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome da Farmacia";
            // 
            // confFarmacia
            // 
            this.confFarmacia.BackColor = System.Drawing.Color.OliveDrab;
            this.confFarmacia.Location = new System.Drawing.Point(147, 241);
            this.confFarmacia.Name = "confFarmacia";
            this.confFarmacia.Size = new System.Drawing.Size(75, 23);
            this.confFarmacia.TabIndex = 3;
            this.confFarmacia.Text = "Confirmar";
            this.confFarmacia.UseVisualStyleBackColor = false;
            this.confFarmacia.Click += new System.EventHandler(this.confFarmacia_Click);
            // 
            // codFarmacia
            // 
            this.codFarmacia.Location = new System.Drawing.Point(162, 177);
            this.codFarmacia.Name = "codFarmacia";
            this.codFarmacia.Size = new System.Drawing.Size(100, 20);
            this.codFarmacia.TabIndex = 5;
            this.codFarmacia.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.codFarmacia_MaskInputRejected);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Codigo da Farmacia";
            // 
            // CadastrarFarmacia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(361, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.codFarmacia);
            this.Controls.Add(this.confFarmacia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CadastrarFarmacia";
            this.Text = "Cadastrar Farmacia";
            this.Load += new System.EventHandler(this.CadastrarFarmacia_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button confFarmacia;
        private System.Windows.Forms.MaskedTextBox codFarmacia;
        private System.Windows.Forms.Label label3;
    }
}