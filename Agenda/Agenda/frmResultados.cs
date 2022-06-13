using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda
{
    public partial class frmResultados : Form
    {
        string texto;
        public frmResultados(string texto)
        {
            InitializeComponent();
            //definir o texto de pesquisa
            this.texto = texto.ToUpper();
        }

        private void label_numero_registros_Click(object sender, EventArgs e)
        {

        }

        private void frmResultados_Load(object sender, EventArgs e)
        {
            //executa a pesquisa e controi lista
            ExecutaPesquisa();
        }

        private void ExecutaPesquisa()
        {
            //realiza a pesquisa e apresenta dados
            List<cl_contato> lista_resultados = new List<cl_contato>();

            foreach (cl_contato contato in cl_geral.LISTA_CONTATOS)
            {
                if (contato.nome.ToUpper().Contains(texto) || contato.numero.ToUpper().Contains(texto))
                {
                    lista_resultados.Add(contato);
                }
            }
            //apresentar os resultados na lista
            lista_final.Items.Clear();
            foreach (cl_contato contato in lista_resultados)
                lista_final.Items.Add(contato.nome + " ("+ contato.numero + ")");

            label_numero_registros.Text = "Registros: " + lista_final.Items.Count;


        }

        private void cmd_fechar_Click(object sender, EventArgs e)
        {
            //fechar janela
            this.Close();
        }

        private void cmd_nova_pesquisa_Click(object sender, EventArgs e)
        {
            //pedir novo texto
            frmTexto f = new frmTexto();
            f.ShowDialog();

            //quando o quadro é fechado 
            if (f.cancelado) return;
            texto = f.texto.ToUpper();
            ExecutaPesquisa();
        }
    }
}
