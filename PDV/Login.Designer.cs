using MaterialSkin;

namespace PDV
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Red400, Primary.Red500,
                Primary.Red500, Accent.Red200,
                TextShade.WHITE
            );



            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.Password = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.User = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLogin = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Password
            // 
            this.Password.Depth = 0;
            this.Password.Hint = "Senha";
            this.Password.Location = new System.Drawing.Point(204, 232);
            this.Password.MaxLength = 32767;
            this.Password.MouseState = MaterialSkin.MouseState.HOVER;
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.SelectedText = "";
            this.Password.SelectionLength = 0;
            this.Password.SelectionStart = 0;
            this.Password.Size = new System.Drawing.Size(186, 23);
            this.Password.TabIndex = 0;
            this.Password.TabStop = false;
            this.Password.UseSystemPasswordChar = false;
            // 
            // User
            // 
            this.User.Depth = 0;
            this.User.Hint = "Usuário";
            this.User.Location = new System.Drawing.Point(204, 185);
            this.User.MaxLength = 32767;
            this.User.MouseState = MaterialSkin.MouseState.HOVER;
            this.User.Name = "User";
            this.User.PasswordChar = '\0';
            this.User.SelectedText = "";
            this.User.SelectionLength = 0;
            this.User.SelectionStart = 0;
            this.User.Size = new System.Drawing.Size(186, 23);
            this.User.TabIndex = 0;
            this.User.TabStop = false;
            this.User.UseSystemPasswordChar = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(250, 99);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.AutoSize = true;
            this.btnLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Depth = 0;
            this.btnLogin.Icon = null;
            this.btnLogin.Location = new System.Drawing.Point(262, 261);
            this.btnLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Primary = true;
            this.btnLogin.Size = new System.Drawing.Size(61, 36);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.User);
            this.Controls.Add(this.Password);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.Sizable = false;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField Password;
        private MaterialSkin.Controls.MaterialSingleLineTextField User;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialRaisedButton btnLogin;
    }
}
