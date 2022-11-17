using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDV.Controllers
{
    public class Utilitarios
    {
        public string AplicarMascaraTelefone(string strNumero)
        {
            // por omissão tem 10 ou menos dígitos
            string strMascara = "{0:(00)0000-0000}";
            // converter o texto em número
            long lngNumero = Convert.ToInt64(strNumero);

            if (strNumero.Length == 11)
                strMascara = "{0:(00)00000-0000}";

            return string.Format(strMascara, lngNumero);
        }
    }
}
