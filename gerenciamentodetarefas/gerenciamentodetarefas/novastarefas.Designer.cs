namespace gerenciamentodetarefas
{
    partial class novastarefas
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
            panel3 = new Panel();
            label3 = new Label();
            label2 = new Label();
            namebox = new TextBox();
            descbox = new TextBox();
            button5 = new Button();
            button4 = new Button();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.LavenderBlush;
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(namebox);
            panel3.Controls.Add(descbox);
            panel3.Controls.Add(button5);
            panel3.Controls.Add(button4);
            panel3.Location = new Point(1, 7);
            panel3.Name = "panel3";
            panel3.Size = new Size(1014, 575);
            panel3.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(168, 133);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 9;
            label3.Text = "Descrição";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(168, 89);
            label2.Name = "label2";
            label2.Size = new Size(91, 15);
            label2.TabIndex = 8;
            label2.Text = "Nome da Tarefa";
            // 
            // namebox
            // 
            namebox.Location = new Point(168, 107);
            namebox.Name = "namebox";
            namebox.Size = new Size(248, 23);
            namebox.TabIndex = 5;
            // 
            // descbox
            // 
            descbox.Location = new Point(168, 151);
            descbox.Multiline = true;
            descbox.Name = "descbox";
            descbox.Size = new Size(248, 55);
            descbox.TabIndex = 4;
            // 
            // button5
            // 
            button5.BackColor = Color.Pink;
            button5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(302, 212);
            button5.Name = "button5";
            button5.Size = new Size(114, 37);
            button5.TabIndex = 3;
            button5.Text = "Limpar";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Pink;
            button4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(168, 212);
            button4.Name = "button4";
            button4.Size = new Size(128, 37);
            button4.TabIndex = 1;
            button4.Text = "Adicionar ";
            button4.UseVisualStyleBackColor = false;
            button4.Click += addtarefa_Click;
            // 
            // novastarefas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(1011, 594);
            Controls.Add(panel3);
            Name = "novastarefas";
            Text = "novastarefas";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Button button4;
        private Button button5;
        private TextBox namebox;
        private TextBox descbox;
        private Label label3;
        private Label label2;
    }
}