namespace Agenda
{
    public partial class fmrMenu : Form
    {
        public fmrMenu()
        {
            InitializeComponent();

            //carrega os contatos
            cl_geral.ConstroiListaContatos();

            //apresenta versao do programa
            label_versao.Text = cl_geral.versao;
        }

        private void label_versao_Click(object sender, EventArgs e)
        {

        }

        private void cmd_inserir_editar_Click(object sender, EventArgs e)
        {
            //abre o quadro para gestao dos contatos
            frmInserirEditar formulario = new frmInserirEditar();
            formulario.ShowDialog();    
        }

        private void cmd_pesquisar_Click(object sender, EventArgs e)
        {
            //abrir o quadro de pesquisa
            frmTexto f = new frmTexto();
            f.ShowDialog();

            //quando fechar o quadro, verifica se foi cancelado
            if (f.cancelado) return;

            //abrir quadro com resultados da pesquisa
            frmResultados ff = new frmResultados(f.texto);
            ff.ShowDialog();    

        }

        private void cmd_sair_Click(object sender, EventArgs e)
        {
            //sair da aplicação

            //pergunte se pretende mesmo sair da aplicação
            if (MessageBox.Show("Deseja sair da aplicação?", "SAIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

            //sair da aplicação definitivamente
            Application.Exit();
        }

        private void fmrMenu_Load(object sender, EventArgs e)
        {

        }
    }
}