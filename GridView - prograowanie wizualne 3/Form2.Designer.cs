namespace GridView___prograowanie_wizualne_3
{
    partial class Form2
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
            richTextBox1 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            richTextBox4 = new RichTextBox();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(87, 58);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(325, 81);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(87, 187);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(325, 81);
            richTextBox2.TabIndex = 1;
            richTextBox2.Text = "";
            // 
            // richTextBox4
            // 
            richTextBox4.Location = new Point(87, 302);
            richTextBox4.Name = "richTextBox4";
            richTextBox4.Size = new Size(325, 81);
            richTextBox4.TabIndex = 2;
            richTextBox4.Text = "";
            // 
            // button1
            // 
            button1.Location = new Point(87, 536);
            button1.Name = "button1";
            button1.Size = new Size(325, 74);
            button1.TabIndex = 4;
            button1.Text = "Zatwierdź";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(485, 536);
            button2.Name = "button2";
            button2.Size = new Size(325, 74);
            button2.TabIndex = 5;
            button2.Text = "Anuluj";
            button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(485, 81);
            label1.Name = "label1";
            label1.Size = new Size(60, 32);
            label1.TabIndex = 6;
            label1.Text = "Imię";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(485, 206);
            label2.Name = "label2";
            label2.Size = new Size(114, 32);
            label2.TabIndex = 7;
            label2.Text = "Nazwisko";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(495, 333);
            label3.Name = "label3";
            label3.Size = new Size(67, 32);
            label3.TabIndex = 8;
            label3.Text = "Wiek";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(495, 443);
            label4.Name = "label4";
            label4.Size = new Size(133, 32);
            label4.TabIndex = 9;
            label4.Text = "Stanowisko";
            label4.Click += label4_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Dyrektor", "Asystent", "Pracownik biurowy ", "Kontraktor" });
            comboBox1.Location = new Point(87, 443);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(325, 40);
            comboBox1.TabIndex = 10;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(873, 669);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(richTextBox4);
            Controls.Add(richTextBox2);
            Controls.Add(richTextBox1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private RichTextBox richTextBox4;
        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox comboBox1;
    }
}