using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gerenciamentodetarefas
{
    public partial class tarefaspendentes : Form
    {
        int tarefaAtualIndex = 0;
        

        public tarefaspendentes()
        {
            InitializeComponent();
        }

        private void AtualizarCampos(string parametro)
        {
            // Obtém o cliente atual
            var tarefaAtual = DadosCompartilhados.Tarefas[tarefaAtualIndex];

            //for (int i = 0; i < DadosTarefa.Tarefas.Count; i++)
            //{
            //    if (parametro == DadosTarefa.Tarefas[i].Status)
            //    {
            //        txtDescricaopen.Text = tarefaAtual.Nome;
            //        txtNomePen.Text = tarefaAtual.Descricao;
            //        datePen.Text = tarefaAtual.Data.ToString();

            //    }

            //}

            // Preenche os campos com os dados do cliente atual

            if (tarefaAtual.Status == parametro)
            {
                namebox.Text = tarefaAtual.Nome;
                descbox.Text = tarefaAtual.Descricao;
            }
            else
            {
                //
            }


            // Atualiza o estado dos botões
            button5.Enabled = tarefaAtualIndex > 0;
            button1.Enabled = tarefaAtualIndex < DadosCompartilhados.Tarefas.Count - 1;
            radioButton1.Checked = false;
        }
        private void listarTodos()
        {
            // Exibe os dados que você tenha uma TextBox chamada "textBoxClientes"
            textBoxtarefa.Multiline = true;                   // Certifique-se de que a propriedade Multiline está habilitada
            textBoxtarefa.ScrollBars = ScrollBars.Vertical;   // Adiciona barra de rolagem vertical, se necessário

            // Preenche a TextBox com os nomes e telefones
            textBoxtarefa.Text = string.Join(Environment.NewLine,
            DadosCompartilhados.Tarefas.Select(p => $"{p.Nome} - {p.Descricao}"));
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
            textBoxtarefa.ScrollBars = ScrollBars.Vertical;   // Adiciona barra de rolagem vertical, se necessário
            textBoxtarefa.Text = string.Join(Environment.NewLine, verifica);


        }

        private void FormListarClientes_Load(object sender, EventArgs e)
        {

        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Volta para o cliente anterior, se possível
            if (tarefaAtualIndex > 0)
            {
                tarefaAtualIndex--;
                AtualizarCampos("Pendente");
                //radioButton1.Checked = false;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Avança para o próximo cliente, se possível
            if (tarefaAtualIndex<DadosCompartilhados.Tarefas.Count - 1)
            {
                tarefaAtualIndex++;
                AtualizarCampos("Pendente");
                //radioButton1.Checked = false;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tarefaspendentes_Load(object sender, EventArgs e)
        {
            listarStatus("Pendente");
            AtualizarCampos("Pendente");
        }

       private void AtualizarStatus(string parametro)
        {
            for (int i = 0; i< DadosCompartilhados.Tarefas.Count; i++)
            {
                if (parametro == DadosCompartilhados.Tarefas[i].Nome)
                {
                    DadosCompartilhados.Tarefas[i].Status = "Concluído";
                }
                
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
            // seu código para alterar a variável aqui!!!!!!!
            if (radioButton1.Checked)
            {
                AtualizarStatus(namebox.Text);
            }
        }




    }
}
