namespace GridView___prograowanie_wizualne_3
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Imie = new DataGridViewTextBoxColumn();
            Nazwisko = new DataGridViewTextBoxColumn();
            Wiek = new DataGridViewTextBoxColumn();
            Stanowisko = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(1225, 283);
            button1.Name = "button1";
            button1.Size = new Size(204, 75);
            button1.TabIndex = 0;
            button1.Text = "Dodaj";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(1225, 467);
            button2.Name = "button2";
            button2.Size = new Size(204, 72);
            button2.TabIndex = 1;
            button2.Text = "Usuń";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(247, 794);
            button3.Name = "button3";
            button3.Size = new Size(301, 95);
            button3.TabIndex = 2;
            button3.Text = "Zapis do .csv";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(647, 794);
            button4.Name = "button4";
            button4.Size = new Size(301, 95);
            button4.TabIndex = 3;
            button4.Text = "Odczyt z .csv";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, Imie, Nazwisko, Wiek, Stanowisko });
            dataGridView1.Location = new Point(71, 48);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(1073, 699);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ID
            // 
            ID.HeaderText = "ID pracownika";
            ID.MinimumWidth = 10;
            ID.Name = "ID";
            ID.Width = 200;
            // 
            // Imie
            // 
            Imie.HeaderText = "Imie";
            Imie.MinimumWidth = 10;
            Imie.Name = "Imie";
            Imie.Width = 200;
            // 
            // Nazwisko
            // 
            Nazwisko.HeaderText = "Nazwisko";
            Nazwisko.MinimumWidth = 10;
            Nazwisko.Name = "Nazwisko";
            Nazwisko.Width = 200;
            // 
            // Wiek
            // 
            Wiek.HeaderText = "Wiek";
            Wiek.MinimumWidth = 10;
            Wiek.Name = "Wiek";
            Wiek.Width = 200;
            // 
            // Stanowisko
            // 
            Stanowisko.MinimumWidth = 10;
            Stanowisko.Name = "Stanowisko";
            Stanowisko.Width = 200;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1485, 950);
            Controls.Add(dataGridView1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Arkusz danych";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Imie;
        private DataGridViewTextBoxColumn Nazwisko;
        private DataGridViewTextBoxColumn Wiek;
        private DataGridViewTextBoxColumn Stanowisko;
        

    }
}
