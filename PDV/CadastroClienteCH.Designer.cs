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
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(103, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "Nome:";
            // 
            // Nome
            // 
            this.Nome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Nome.Location = new System.Drawing.Point(162, 83);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(615, 27);
            this.Nome.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(103, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 37);
            this.label3.TabIndex = 22;
            this.label3.Text = "CPF:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // CPF
            // 
            this.CPF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CPF.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CPF.Location = new System.Drawing.Point(177, 18);
            this.CPF.Name = "CPF";
            this.CPF.Size = new System.Drawing.Size(393, 43);
            this.CPF.TabIndex = 24;
            this.CPF.TextChanged += new System.EventHandler(this.CPF_TextChanged);
            this.CPF.Leave += new System.EventHandler(this.CPF_Leave_1);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(751, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 28);
            this.label4.TabIndex = 23;
            this.label4.Text = "Data Nascimento:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // DataNascimento
            // 
            this.DataNascimento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DataNascimento.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DataNascimento.Location = new System.Drawing.Point(937, 24);
            this.DataNascimento.Name = "DataNascimento";
            this.DataNascimento.Size = new System.Drawing.Size(204, 39);
            this.DataNascimento.TabIndex = 25;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.DataNascimento);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Nome);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.CPF);
            this.panel1.Location = new System.Drawing.Point(27, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1144, 133);
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
            this.Load += new System.EventHandler(this.CadastroClienteCH_Load);
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