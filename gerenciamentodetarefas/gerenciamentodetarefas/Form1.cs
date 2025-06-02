namespace gerenciamentodetarefas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void mostrarnovastarefas()
        {
            novastarefas addtarefa = new novastarefas();
            addtarefa.TopLevel = false;
            addtarefa.FormBorderStyle = FormBorderStyle.None;
            addtarefa.Dock = DockStyle.Fill;
            panel3.Controls.Clear();
            panel3.Controls.Add(addtarefa);
            addtarefa.Show();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            mostrarnovastarefas();
        }
        private void mostrartarefaspendentes()
        {
            tarefaspendentes addtarefa = new tarefaspendentes();
            addtarefa.TopLevel = false;
            addtarefa.FormBorderStyle = FormBorderStyle.None;
            addtarefa.Dock = DockStyle.Fill;
            panel3.Controls.Clear();
            panel3.Controls.Add(addtarefa);
            addtarefa.Show();
        }
        private void mostrartarefasconcluidas()
        {
            tarefasconcluidas tarefaCon = new tarefasconcluidas();
            tarefaCon.TopLevel = false;
            tarefaCon.FormBorderStyle = FormBorderStyle.None;
            tarefaCon.Dock = DockStyle.Fill;
            panel3.Controls.Clear();
            panel3.Controls.Add(tarefaCon);
            tarefaCon.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            mostrartarefaspendentes();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            mostrartarefasconcluidas();
        }
    }
}
