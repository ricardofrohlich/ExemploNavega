using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemploNavega
{
    public partial class CadastroProdutosFrm : Form
    {
        Form1 fm1;
        string labelFM1;
        public CadastroProdutosFrm(Form1 fm1, string labelFM1)
        {
            InitializeComponent();
            this.fm1 = fm1;
            this.labelFM1 = labelFM1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // Form1 frm = new Form1();
           // frm.Show();
            this.Close();
            fm1.Show();
        }

        private void CadastroProdutosFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            fm1.Show();
        }

        private void CadastroProdutosFrm_Load(object sender, EventArgs e)
        {
            label2.Text = labelFM1;
        }
    }
}
