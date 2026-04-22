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

        public int Incluir()
        {
            try
            {
                Banco.Conexao.Open();
                Banco.Comando = new MySqlCommand(
                    "INSERT INTO VENDA_CAB (idCliente, data, total) " +
                    "VALUES (@idCliente, @data, @total)", Banco.Conexao);
                Banco.Comando.Parameters.AddWithValue("@idCliente", idCliente);
                Banco.Comando.Parameters.AddWithValue("@data", data);
                Banco.Comando.Parameters.AddWithValue("@total", total);
                Banco.Comando.ExecuteNonQuery();
                Banco.Conexao.Close();
                return (int)Banco.Comando.LastInsertedId;
            }
            catch (Exception e) 
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            
        }
    }
}
