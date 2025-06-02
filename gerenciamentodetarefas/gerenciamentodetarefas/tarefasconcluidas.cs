using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace gerenciamentodetarefas
{
    public partial class tarefasconcluidas : Form
    {
        public tarefasconcluidas()
        {
            InitializeComponent();
        }
        private void listarStatus(string status)
        {
            List<string> verifica = new List<string>();

            foreach (var atuals in DadosCompartilhados.Tarefas)
            {
                if (atuals.Status == status)
                {
                    verifica.Add($"{atuals.Nome} - {atuals.Descricao} - {atuals.Status}");
                }
            }
            textBoxtarefa.Text = string.Join(Environment.NewLine, "Exibindo as tarefas com Status:", status);
            textBoxtarefa.Multiline = true;
            textBoxtarefa.Text = string.Join(Environment.NewLine, verifica);


        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tarefasconcluidas_Load(object sender, EventArgs e)
        {
            listarStatus("Concluído");
        }

        private void textBoxtarefa_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
