namespace boasVindas
{
    public partial class frmAula01 : Form
    {
        public frmAula01()
        {
            InitializeComponent();
        }

        private void btnBoasVindas_Click(object sender, EventArgs e)
        {
            string nomeUsuario;//Declaração variável do tipo string

            nomeUsuario = txtNome.Text;

            //Concatenar

            MessageBox.Show($"Bem vindo ao C# {nomeUsuario}", "Olá", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lblMensagem.Text = $"Bem vindo ao C# {nomeUsuario}";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}