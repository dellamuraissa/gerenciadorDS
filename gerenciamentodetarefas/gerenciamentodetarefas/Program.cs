namespace gerenciamentodetarefas
{
    public class Tarefa
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string  Status { get; set; }        
    }
    internal static class DadosCompartilhados
    {
        // Lista para armazenar os dados das pessoas
        public static List<Tarefa> Tarefas { get; } = new()
        {
            new Tarefa
            {
                Nome = "Matemática",
                Descricao = "Lista de exercicios",
                Status = "Pendente",
            },
            new Tarefa 
            {
                Nome = "Hístoria",
                Descricao = "Séminario",
                Status = "Concluido",

            },
            new Tarefa
            {
                Nome = "Inglês",
                Descricao = "Prova",
                Status = "Pendente",

            },
        };
        
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}