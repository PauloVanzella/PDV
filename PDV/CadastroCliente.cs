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
using PDV.Controllers;
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
            
        }

  

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            AdicionarRegistros();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ExcluirCampo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AlterarCampos();
        }



        private void AlterarCampos()
        {
            bool alterado = false;
            try
            {
                using (var repo = new PDVContext())
                {
                    IList<Cliente> clientes = repo.Cliente.ToList();
                    foreach (var item in clientes)
                    {
                        if (item.CPF == CPF.Text)
                        {
                            item.CPF = CPF.Text;
                            item.Nome = Nome.Text;
                            item.DataNascimento = ConverterData(DataNascimento.Text);


                            repo.Cliente.Update(item);
                            repo.SaveChanges();
                            MessageBox.Show("Alterado Com sucesso");
                            LimparCampos();
                            alterado = true;
                            break;
                        }
                    }
                    if (!alterado)
                    {
                        MessageBox.Show("Não foi Possível Encontrar");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AdicionarRegistros()
        {
            try
            {
                Cliente cliente = new Cliente();
                cliente.CPF = CPF.Text;
                cliente.Nome = Nome.Text;
                cliente.DataNascimento = ConverterData(DataNascimento.Text);
                using (var repo = new PDVContext())
                {
                    repo.Cliente.Add(cliente);
                    repo.SaveChanges();
                }
                LimparCampos();
                MessageBox.Show("Adicionado com sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LimparCampos()
        {
            CPF.Text = "";
            Nome.Text = "";
            DataNascimento.Text = "";
        }

        private void ExcluirCampo()
        {
            bool excluido = false;
            try
            {
                using (var repo = new PDVContext())
                {
                    IList<Cliente> clientes = repo.Cliente.ToList();
                    foreach (var item in clientes)
                    {
                        if (item.CPF == CPF.Text)
                        {
                            repo.Cliente.Remove(item);
                            repo.SaveChanges();
                            MessageBox.Show("Excluido Com sucesso");
                            LimparCampos();
                            excluido = true;
                            break;
                        }
                    }
                    if (!excluido)
                    {
                        MessageBox.Show("Não foi Possível Encontrar");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public DateTime ConverterData(string data)
        {
            DateTime dataConvertida = DateTime.Parse(data);
            return dataConvertida;
        }
    }
}
