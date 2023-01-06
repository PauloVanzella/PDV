using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PDV.Models;

namespace PDV
{
    public partial class CadastroClienteCH : Form
    {
        public CadastroClienteCH()
        {
            InitializeComponent();
        }
        private void CadastroClienteCH_Load(object sender, EventArgs e)
        {

        }
        //    public void AdicionarRegistrosCliente()
        //    {
        //        try
        //        {
        //            Cliente cliente = new Cliente();
        //            if (!ValidaCPF(CPF.Text))
        //                throw new Exception("CPF invalido");
        //            cliente.CPF = CPF.Text;
        //            cliente.Nome = Nome.Text;
        //            cliente.DataNascimento = ConverterData(DataNascimento.Text);
        //            using (var repo = new PDVContext())
        //            {
        //                repo.Cliente.Add(cliente);
        //                repo.SaveChanges();
        //            }
        //            LimparCampos();
        //            MessageBox.Show("Adicionado com sucesso");
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show(ex.Message);
        //        }
        //    }

        //    public static bool ValidaCPF(string cpf)
        //    {
        //        int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
        //        int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
        //        string tempCpf;
        //        string digito;
        //        int soma;
        //        int resto;
        //        cpf = cpf.Trim();
        //        cpf = cpf.Replace(".", "").Replace("-", "");
        //        if (cpf.Length != 11)
        //            return false;
        //        tempCpf = cpf.Substring(0, 9);
        //        soma = 0;

        //        for (int i = 0; i < 9; i++)
        //            soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
        //        resto = soma % 11;
        //        if (resto < 2)
        //            resto = 0;
        //        else
        //            resto = 11 - resto;
        //        digito = resto.ToString();
        //        tempCpf = tempCpf + digito;
        //        soma = 0;
        //        for (int i = 0; i < 10; i++)
        //            soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
        //        resto = soma % 11;
        //        if (resto < 2)
        //            resto = 0;
        //        else
        //            resto = 11 - resto;
        //        digito = digito + resto.ToString();
        //        return cpf.EndsWith(digito);
        //    }

        //    public DateTime ConverterData(string data)
        //    {
        //        DateTime dataConvertida = DateTime.Parse(data);
        //        return dataConvertida;
        //    }

        //    public void AlterarCampos()
        //    {
        //        bool alterado = false;
        //        try
        //        {
        //            using (var repo = new PDVContext())
        //            {
        //                IList<Cliente> clientes = repo.Cliente.ToList();
        //                var cpfFormatado = String.Join("", CPF.Text.Split('@', '-', '.', ';', '\''));
        //                foreach (var item in clientes)
        //                {
        //                    if (item.CPF == cpfFormatado)
        //                    {
        //                        item.CPF = cpfFormatado;
        //                        item.Nome = Nome.Text;
        //                        item.DataNascimento = ConverterData(DataNascimento.Text);


        //                        repo.Cliente.Update(item);
        //                        repo.SaveChanges();
        //                        MessageBox.Show("Alterado Com sucesso");
        //                        LimparCampos();
        //                        alterado = true;
        //                        break;
        //                    }
        //                }
        //                if (!alterado)
        //                {
        //                    MessageBox.Show("Não foi Possível Encontrar");
        //                }
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show(ex.Message);
        //        }
        //    }
        //    public void ExcluirCampo()
        //    {
        //        bool excluido = false;
        //        try
        //        {
        //            using (var repo = new PDVContext())
        //            {
        //                IList<Cliente> clientes = repo.Cliente.ToList();
        //                foreach (var item in clientes)
        //                {
        //                    if (item.CPF == CPF.Text)
        //                    {
        //                        repo.Cliente.Remove(item);
        //                        repo.SaveChanges();
        //                        MessageBox.Show("Excluido Com sucesso");
        //                        LimparCampos();
        //                        excluido = true;
        //                        break;
        //                    }
        //                }
        //                if (!excluido)
        //                {
        //                    MessageBox.Show("Não foi Possível Encontrar");
        //                }
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show(ex.Message);
        //        }
        //    }
        //    public void LimparCampos()
        //    {
        //        CPF.Text = "";
        //        Nome.Text = "";
        //        DataNascimento.Text = "";
        //    }

        //    public void BuscarCampos()
        //    {
        //        bool encontrado = false;
        //        try
        //        {
        //            using (var repo = new PDVContext())
        //            {
        //                IList<Cliente> clientes = repo.Cliente.ToList();
        //                var cpfFormatado = String.Join("", CPF.Text.Split('@', '-', '.', ';', '\''));

        //                foreach (var item in clientes)
        //                {
        //                    if (item.CPF == cpfFormatado)
        //                    {
        //                        item.CPF = cpfFormatado;
        //                        Nome.Text = item.Nome;
        //                        DataNascimento.Text = item.DataNascimento.ToString("dd/MM/yyyy");
        //                        encontrado = true;

        //                        break;
        //                    }
        //                }
        //                if (!encontrado)
        //                {
        //                    MessageBox.Show("Não foi Possível Encontrar");
        //                }
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show(ex.Message);
        //        }
        //    }


        //    private void DataNascimento_Leave(object sender, EventArgs e)
        //    {
        //        var cont = 0;
        //        var formatado = DataNascimento.Text;
        //        DataNascimento.Text = "";
        //        foreach (char c in formatado)
        //        {
        //            cont++;
        //            if (cont == 3 || cont == 5)
        //            {
        //                DataNascimento.Text += "/";
        //            }

        //            DataNascimento.Text += c;
        //        }
        //    }

        //    private void label3_Click(object sender, EventArgs e)
        //    {

        //    }

        //    private void CPF_TextChanged(object sender, EventArgs e)
        //    {

        //    }

        //    private void label4_Click(object sender, EventArgs e)
        //    {

        //    }

        //    private void CPF_Leave_1(object sender, EventArgs e)
        //    {
        //        var formatado = CPF.Text;
        //        var cont = 0;

        //        CPF.Text = "";
        //        foreach (char c in formatado)
        //        {
        //            cont++;
        //            if (cont == 4 || cont == 7)
        //            {
        //                CPF.Text += ".";
        //            }
        //            if (cont == 10)
        //                CPF.Text += "-";
        //            CPF.Text += c;
        //        }
        //    }

        //    private void label11_Click(object sender, EventArgs e)
        //    {

        //    }

        //    private void textBox8_TextChanged(object sender, EventArgs e)
        //    {

        //    }
    }

}
