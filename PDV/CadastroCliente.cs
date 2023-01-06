using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.Extensions.Options;
using PDV;
using PDV.Models;

namespace PlayerUI
{
    public partial class CadastroCliente : Form
    {
        public CadastroCliente()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private Form activeForm = null;
        
        private void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            produtoChildForm.Controls.Add(childForm);
            produtoChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            PDV.CadastroClienteCH cadastroClienteCH = new CadastroClienteCH();
            //cadastroClienteCH.BuscarCampos();
        }


        private void button6_Click(object sender, EventArgs e)
        {
                PDV.CadastroClienteCH cadastroClienteCH = new CadastroClienteCH();
                //cadastroClienteCH.AdicionarRegistrosCliente();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            PDV.CadastroClienteCH cadastroClienteCH = new CadastroClienteCH();
            //cadastroClienteCH.ExcluirCampo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PDV.CadastroClienteCH cadastroClienteCH = new CadastroClienteCH();
            //cadastroClienteCH.LimparCampos();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            PDV.CadastroClienteCH cadastroClienteCH = new CadastroClienteCH();
            //cadastroClienteCH.AlterarCampos();
        }

        private void CadastroCliente_Load(object sender, EventArgs e)
        {
            openChildForm(new CadastroClienteCH());
        }
    }
}
