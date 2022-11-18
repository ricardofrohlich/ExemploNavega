namespace ExemploNavega
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cadastroDeProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("oi!");
            
            CadastroProdutosFrm cadprod = new CadastroProdutosFrm(this, label1.Text);
            cadprod.Show();
            this.Hide();

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}