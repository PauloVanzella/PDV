using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using System.Windows.Forms;
using PDV.Models;

namespace PDV.Controllers
{

    public class Logar
    {
        readonly PDVContext DbContext = new();
        public bool Login(string User, string Senha)
        {

            try
            {
                if (DbContext.Usuarios.Where(u => u.Usuario1 == User && u.Senha == Senha).Count() > 0)
                {
                    return true;

                   
                }
                else
                {
                    return false;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                return false;
            }
        }
    }
}
