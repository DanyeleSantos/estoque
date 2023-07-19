namespace Aula08Estoque
{
    public partial class Form1 : Form
    {
        // Variáveis globais 
        List<string> produtoNome = new List<string>();
        List<int> produtoQuantidade = new List<int>();
        
        



        public Form1()
        {
            InitializeComponent();
        }
        // Minhas funções
        void adicionaProduto()
        {
            string nome = txtNome.Text;
            int quantidade = int.Parse(txtQuantidade.Text);
            produtoNome.Add(nome);
            produtoQuantidade.Add(quantidade);
        }

        void atualizaInterface()
        {
            int quantidadeCadastradas = produtoNome.Count();
            lblCadastro.Text = quantidadeCadastradas.ToString();
        }
        void limpaCampos()
        {
            txtNome.Clear();
            txtQuantidade.Clear();
            txtNome.Focus();
        }
        void verProduto( bool primeiro) 
        {
            string nome;
            int quantidade;

            if (primeiro == true) 
            {
                nome = produtoNome[0];
                quantidade = produtoQuantidade[0];
            }
            else
            {
                nome = produtoNome[ produtoNome.Count() - 1 ];
                quantidade = produtoQuantidade[ produtoQuantidade.Count() - 1 ];
            }

            MessageBox.Show($"Nome: {nome}, Quantidade: {quantidade}");

        }
        void removeProduto()
        {
            produtoNome.RemoveAt(0);
            produtoQuantidade.RemoveAt(0);

        }





        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            adicionaProduto();
            atualizaInterface();
            limpaCampos(); 
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpaCampos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            verProduto(true);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            verProduto(false);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            removeProduto();
            atualizaInterface();
            MessageBox.Show("produto removido");
        }
    }
}