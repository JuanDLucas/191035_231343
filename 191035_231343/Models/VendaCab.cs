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
    internal class VendaCab
    {
        public int Id { get; set; }
        public int idCliente { get; set; }
        public DateTime data { get; set; } 
        public double total { get; set; }
    }
}
