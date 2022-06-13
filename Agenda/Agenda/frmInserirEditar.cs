namespace Agenda
{
    public partial class frmInserirEditar : Form
    {
        int indice;
        //===========================================
        public frmInserirEditar()
        {
            InitializeComponent();
            ConstroiLista();
        }
        //===========================================
        private void label2_Click(object sender, EventArgs e)
        {

        }
        //===========================================
        private void cmd_apagar_Click(object sender, EventArgs e)
        {
            //apaga o resgistro selecionado

            //eliminar o resgistro da lista
            cl_geral.LISTA_CONTATOS.RemoveAt(indice);
            //renovar o ficheiro
            cl_geral.GravarFicheiro();
            //recisntruir a lista de contatos
            ConstroiLista();
        }
        //===========================================
        private void cmd_fechar_Click(object sender, EventArgs e)
        {
            //fechar quadro
            this.Close();
        }
        //===========================================

        private void frmInserirEditar_Load(object sender, EventArgs e)
        {

        }
        //===========================================
        private void ConstroiLista()
        {
            //adiciona à lista de contatos os contatos registrados
            lista_contatos.Items.Clear();  
            
            foreach (cl_contato contato in cl_geral.LISTA_CONTATOS)
            {
                lista_contatos.Items.Add(contato.nome + " (" + contato.numero + ")"); ;  
            }
            //atualiza o número de registros
            label_numero_registros.Text = "Registros: " + lista_contatos.Items.Count;

            //impedir edição e eliminação do registro
            cmd_apagar.Enabled = false;
            cmd_editar.Enabled = false; 
        }
        //===========================================
        private void cmd_salvar_Click(object sender, EventArgs e)
        {
            //insere um novo resgistro na lista

            //verifica se todos os campos estão preenchidos
            if(text_nome.Text == "" || text_numero.Text == "")
            {
                MessageBox.Show("Os campos não estão todos preenchidos.");
                return; 
            }
            //verifica se existe registro igual na lista
            foreach(cl_contato contato in cl_geral.LISTA_CONTATOS)
            {
                if(contato.nome == text_nome.Text && contato.numero == text_numero.Text)
                {
                    MessageBox.Show("ERRO! Esse registro já existe");
                    return;
                }
            }

            //gravar novo registro
            cl_geral.GravarNovoRegistro(text_nome.Text, text_numero.Text);

            //atualizar lista de contatos
            ConstroiLista();

            //prepara o quadro para novo registro
            text_nome.Text = string.Empty;
            text_numero.Text = string.Empty;
            text_nome.Focus();

        }
        //===========================================
        private void lista_contatos_SelectedIndexChanged(object sender, EventArgs e)
        {
            //verificar se indice -1
            indice = lista_contatos.SelectedIndex;
            cmd_editar.Enabled = true;
            cmd_apagar.Enabled = true;

            cmd_salvar.Enabled = false;

            var contato = cl_geral.RetornaContato(indice);
            text_nome.Text = contato?.nome ?? string.Empty;
            text_numero.Text = contato?.numero ?? string.Empty; 
        }

        private void cmd_editar_Click(object sender, EventArgs e)
        {
            cl_contato novo_contato = new cl_contato();
            novo_contato.nome = text_nome.Text;
            novo_contato.numero = text_numero.Text;

            cl_geral.EditarContato(indice, novo_contato);
            ConstroiLista();
            cl_geral.GravarFicheiro();
            
        }

        private void cmd_novo_Click(object sender, EventArgs e)
        {
            cmd_editar.Enabled = false;
            cmd_apagar.Enabled = false;
            cmd_salvar.Enabled = true;

            text_nome.Text = string.Empty;
            text_numero.Text = string.Empty;

        }
    }
}
