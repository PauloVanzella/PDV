using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PDV.Enumeradores;

namespace PDV.Models
{
    public class Configuracao
    {
        public string Id_Configuracao { get; set; }
        public string RazaoSocial { get; set; }
        public string CNPJ { get; set; }
        public string CPF{ get; set; }
        public string InscricaoEstadual { get; set; }

        public string Telefone { get; set; }

        public string CEP { get; set; }

        public string Endereco { get; set; }

        public string CertificadoDigital { get; set; }

        public TipoCertificado.TipoCertificacao TipoCertificado { get; set; } 

        public bool ManterCertificado { get; set; }

        public string NumeroDeSerie { get; set; }   

        public string PathCertificado { get; set; }

        public string SenhaCertificado { get; set; }

        public TipoFormaEmissao.FormaEmissao FormaEmissao { get; set; }
    }
}
