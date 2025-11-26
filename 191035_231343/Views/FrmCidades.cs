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
    public partial class FrmCidades : Form
    {
        Cidade c;
        public FrmCidades()
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

        void carregarGrid(string pesquisa)
        {
            c = new Cidade()
            {
                nome = pesquisa
            };
            dgvCidades.DataSource = c.Consultar();
        }
    }
}
