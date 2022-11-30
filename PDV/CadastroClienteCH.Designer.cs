namespace PDV
{
    partial class CadastroClienteCH
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
            this.label2 = new System.Windows.Forms.Label();
            this.Nome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CPF = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DataNascimento = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(64, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "Nome:";
            // 
            // Nome
            // 
            this.Nome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Nome.Location = new System.Drawing.Point(118, 61);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(292, 27);
            this.Nome.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "CPF:";
            // 
            // CPF
            // 
            this.CPF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CPF.Location = new System.Drawing.Point(118, 28);
            this.CPF.Name = "CPF";
            this.CPF.Size = new System.Drawing.Size(213, 27);
            this.CPF.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(334, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Data Nascimento:";
            // 
            // DataNascimento
            // 
            this.DataNascimento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DataNascimento.Location = new System.Drawing.Point(458, 31);
            this.DataNascimento.Name = "DataNascimento";
            this.DataNascimento.Size = new System.Drawing.Size(173, 27);
            this.DataNascimento.TabIndex = 25;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.DataNascimento);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Nome);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.CPF);
            this.panel1.Location = new System.Drawing.Point(198, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(785, 133);
            this.panel1.TabIndex = 28;
            // 
            // CadastroClienteCH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1232, 786);
            this.Controls.Add(this.panel1);
            this.Name = "CadastroClienteCH";
            this.Text = "CadastroClienteCH";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Nome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CPF;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DataNascimento;
        private System.Windows.Forms.Panel panel1;
    }
}