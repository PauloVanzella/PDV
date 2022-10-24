using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDV.Enumeradores
{
    public class TipoFormaEmissao
    {
        public enum FormaEmissao
        {
            Normal, // = 0
            FSIA, // = 1
            EPEC, // = 2
            FSDA, // = 3
            SVC_AN, // = 4
            SVC_RS,// = 5
            NFC_OFFLINE // = 6


        }
    }
}
