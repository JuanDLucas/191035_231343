using _191035_231343.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _191035_231343.Views
{
    public partial class FrmCidade : Form
    {
        Cidade c;
        public FrmCidade()
        {
            InitializeComponent();
        }

        void limpaControles()
        {
            txtID.Clear();
            txtNome.Clear();
            txtUF.Clear();
            txtPesquisa.Clear();
        }

        // carrega dados do banco no grid
        void carregarGrid(string pesquisa)
        {
            c = new Cidade()
            {
                nome = pesquisa
            };
            dgvCidades.DataSource = c.Consultar();
        }

        // limpa campos e carrega o grid com os campos ao carregar o form
        private void FrmCidades_Load(object sender, EventArgs e)
        {
            limpaControles();
            carregarGrid("");
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            // c = novo objeto
            // Cidade = classe 
            
            // cria um novo(new) objeto(c ou "inicial") da classe(cidade ou "nome da classe")
            c = new Cidade()
            {
                // vincula os valores das caixas de texto aos atributos da classe(campos do banco)
                nome = txtNome.Text,
                uf = txtUF.Text
            };
            c.Incluir();

            limpaControles();
            carregarGrid("");
        }

        

        private void dgvCidades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCidades.RowCount > 0)
            {
                // caixas de texto (entrada de dados) recebem os valores selecionados(no grid) nos respectivos campos
                txtID.Text = dgvCidades.CurrentRow.Cells["id"].Value.ToString();
                txtNome.Text = dgvCidades.CurrentRow.Cells["nome"].Value.ToString();
                txtUF.Text = dgvCidades.CurrentRow.Cells["uf"].Value.ToString();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtID.Text == String.Empty) return;

            c = new Cidade()
            {
                id = int.Parse(txtID.Text),
                nome = txtNome.Text,
                uf = txtUF.Text
            };
            c.Alterar();

            limpaControles();
            carregarGrid("");

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if(txtID.Text == "") return;

            if(MessageBox.Show("Deseja exluir a cidade?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                c = new Cidade()
                {
                    id = int.Parse(txtID.Text)
                };
                c.Excluir();

                limpaControles();
                carregarGrid("");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpaControles();
            carregarGrid("");
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            carregarGrid(txtPesquisa.Text);
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            // fecha o formulario em questão
            Close();
        }

        
    }
}
