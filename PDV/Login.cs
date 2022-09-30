using PDV.Models;
using PlayerUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WF_ModerUI;

namespace PDV
{
    public partial class Login : MaterialSkin.Controls.MaterialForm
    {
        Thread T1;

        public Login()
        {
            InitializeComponent();
        }

        readonly PDVContext DbContext = new();


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        } 

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (DbContext.Usuarios.Where(u => u.Usuario1 == User.Text && u.Senha == Password.Text).Count() > 0)
                {
                    MessageBox.Show("Bem vindo");

                    this.Close();
                    T1 = new Thread(AbrirHomeSistema);
                    T1.SetApartmentState(ApartmentState.STA);
                    T1.Start();
                }
                else
                {
                    MessageBox.Show("Dados Inválidos");
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

        }

        private void AbrirHomeSistema(object obj)
        {
            Application.Run(new Form1());


        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
