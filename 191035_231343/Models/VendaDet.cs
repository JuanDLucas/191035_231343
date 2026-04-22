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
        public int idVendaCab { get; set; }
        public int idProduto {  get; set; }
        public double qtde { get; set; }
        public double vlrUnit {  get; set; }

        public void Incluir()
        {
            try
            {
                Banco.Conexao.Open();
                Banco.Comando = new MySqlCommand(
                    "INSERT INTO VENDA_DET (idVendaCab, idProduto, qtde, vlrUnit) " +
                    "VALUES (@idVendaCab, @idProduto, @qtde, @vlrUnit)", Banco.Conexao);
                Banco.Comando.Parameters.AddWithValue("@idVendaCab", idVendaCab);
                Banco.Comando.Parameters.AddWithValue("@idProduto", idProduto);
                Banco.Comando.Parameters.AddWithValue("@qtde", qtde);
                Banco.Comando.Parameters.AddWithValue("@vlrUnit", vlrUnit);
                Banco.Comando.ExecuteNonQuery();
                Banco.Conexao.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
