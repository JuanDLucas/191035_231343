using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace _191035_231343.Models
{
    internal class VendaDet
    {
        public int Id { get; set; }
        public int idVenda { get; set; }
        public int idProduto {  get; set; }
        public double qtde { get; set; }
        public double vlrUnit {  get; set; }
    }
}
