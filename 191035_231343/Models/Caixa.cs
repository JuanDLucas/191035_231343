using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _191035_231343.Models
{
    internal class Caixa
    {
        public int id { get; set; }
        public int idContas { get; set; } // referencia a tabela de contas a receber, para podermos acessar idVendaCab e idCliente
        public double dinheiro { get; set; }
        public double cheque {  get; set; }
        public double cartao { get; set; }
        public double pix { get; set; }
        public double boleto { get; set; }
    }
}
