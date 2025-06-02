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
    public partial class novastarefas : Form
    {
        public novastarefas()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addtarefa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(namebox.Text) ||
                string.IsNullOrWhiteSpace(descbox.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos antes de inserir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Cria um novo objeto Pessoa com os dados das TextBox
            var novataref = new Tarefa
            {
                Nome = namebox.Text,
                Descricao = descbox.Text,
                Status = "Pendente"
            };

            // Adiciona a nova pessoa à lista de pessoas
            DadosCompartilhados.Tarefas.Add(novataref);

            // Exibição da Mensagem de inclusão
            MessageBox.Show("Tarefa inserido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Limpar();
        }
        private void Limpar()
        {
            namebox.Clear();
            descbox.Clear();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        
    }
}
