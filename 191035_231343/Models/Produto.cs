using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace _191035_231343.Models
{
    public class Produto
    {
        public int id { get; set; } 
        public string descricao { get; set; }
        public int idCategoria { get; set; }    
        public int idMarca { get; set; }
        public double estoque { get; set; }
        public double valorVenda { get; set; }
        public string foto { get; set; }

        public DataTable Consultar()
        {
            try
            {
                Banco.Comando = new MySqlCommand("SELECT p.*, m.marca, c.catgoria FROM Produtos p " +
                                                 "INNER JOIN Marcas m ON m.id = p.idMarca " + 
                                                 "INNER JOIN Categorias c ON c.id = p.idCategoria " +
                                                 "WHERE p.descricao LIKE @Descricao ORDER BY p.descricao", Banco.Conexao);
                Banco.Comando.Parameters.AddWithValue("@Descricao", descricao + "%");
                Banco.Adaptador = new MySqlDataAdapter(Banco.Comando);
                Banco.datTabela = new DataTable();
                Banco.Adaptador.Fill(Banco.datTabela);

                return Banco.datTabela;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

        }

        public void atualizarEstoque(double qtde)
        {
            try
            {
                Banco.AbrirConexao();
                Banco.Comando = new MySqlCommand("UPDATE produtos SET Estoque = Estoque - @qtde" +
                                                 "WHERE id = @id", Banco.Conexao);
                Banco.Comando.Parameters.AddWithValue("@qtde", qtde);
                Banco.Comando.Parameters.AddWithValue("@id", id);
                Banco.Comando.ExecuteNonQuery();

                Banco.FecharConexao();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
