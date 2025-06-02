namespace gerenciamentodetarefas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel3 = new Panel();
            panel2 = new Panel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel1 = new Panel();
            label2 = new Label();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.LavenderBlush;
            panel3.Location = new Point(203, 57);
            panel3.Name = "panel3";
            panel3.Size = new Size(600, 390);
            panel3.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Location = new Point(-2, 57);
            panel2.Name = "panel2";
            panel2.Size = new Size(206, 390);
            panel2.TabIndex = 7;
            // 
            // button4
            // 
            button4.BackColor = Color.LavenderBlush;
            button4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(26, 250);
            button4.Name = "button4";
            button4.Size = new Size(150, 48);
            button4.TabIndex = 23;
            button4.Text = "Fechar";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.LavenderBlush;
            button3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(26, 178);
            button3.Name = "button3";
            button3.Size = new Size(150, 48);
            button3.TabIndex = 2;
            button3.Text = "Tarefas Concluidas";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.LavenderBlush;
            button2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(26, 106);
            button2.Name = "button2";
            button2.Size = new Size(150, 48);
            button2.TabIndex = 1;
            button2.Text = "Tarefas Pendentes";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.LavenderBlush;
            button1.CausesValidation = false;
            button1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(26, 32);
            button1.Name = "button1";
            button1.Size = new Size(150, 48);
            button1.TabIndex = 0;
            button1.Text = "Novas Tarefas";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Pink;
            panel1.Controls.Add(label2);
            panel1.Location = new Point(-2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(804, 57);
            panel1.TabIndex = 6;
            panel1.Paint += panel1_Paint;
            // 
            // label2
            // 
            label2.Font = new Font("Gill Sans MT", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(26, 9);
            label2.Name = "label2";
            label2.Size = new Size(360, 45);
            label2.TabIndex = 0;
            label2.Text = "Gerenciador de Tarefas";
            label2.Click += label2_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Panel panel2;
        private Button button3;
        private Button button2;
        private Button button1;
        private Panel panel1;
        private Label label2;
        private Button button4;
    }
}
