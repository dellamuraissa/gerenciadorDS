namespace gerenciamentodetarefas
{
    partial class tarefasconcluidas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxtarefa = new TextBox();
            SuspendLayout();
            // 
            // textBoxtarefa
            // 
            textBoxtarefa.Location = new Point(124, 56);
            textBoxtarefa.Multiline = true;
            textBoxtarefa.Name = "textBoxtarefa";
            textBoxtarefa.Size = new Size(240, 272);
            textBoxtarefa.TabIndex = 0;
            textBoxtarefa.TextChanged += textBoxtarefa_TextChanged;
            // 
            // tarefasconcluidas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxtarefa);
            Name = "tarefasconcluidas";
            Text = "tarefasconcluidas";
            Load += tarefasconcluidas_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxtarefa;
        private Label label2;
    }
}