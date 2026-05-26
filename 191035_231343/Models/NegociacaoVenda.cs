using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace _191035_231343.Models
{
    internal class NegociacaoVenda
    {
        public int id { get; set; }
        public int idVendaCab {  get; set; }
        public byte parcela {  get; set; }
        public DateTime data_vencto {  get; set; }
        public DateTime data_pagto { get; set; }
        public double vlr_parcela { get; set; }
        public Boolean status { get; set; }
                                           
        public void Incluir()
        {
            try
            {
                Banco.AbrirConexao();
                Banco.Comando = new MySqlCommand("INSERT INTO CONTAS_RECEBER (idVendaCab, parcela, " +
                                                "data_vencto, vlr_parcela, status) " +
                                                "VALUES (@idVendaCab, @parcela, @data_vencto, " +
                                                "@vlr_parcela, @status)", Banco.Conexao);                                               \"data_vencto, vlr_parcela, status                                                \"data_vencto, vlr_parcela, status)", Banco.Conexao);
                Banco.Comando.Parameters.AddWithValue("@idVendaCab", idVendaCab);
                Banco.Comando.Parameters.AddWithValue("@parcela", parcela);
                Banco.Comando.Parameters.AddWithValue("@data_vencto", data_vencto);
                Banco.Comando.Parameters.AddWithValue("@vlr_parcela", vlr_parcela);
                Banco.Comando.Parameters.AddWithValue("@status", status);
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
