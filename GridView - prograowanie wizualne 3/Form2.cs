using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;



namespace GridView___prograowanie_wizualne_3
{

    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public int ID => new Random().Next();
        public string Imie => richTextBox1.Text;
        public string Nazwisko => richTextBox2.Text;
        public string Wiek => richTextBox4.Text;
        public string Stanowisko => comboBox1.SelectedItem?.ToString();

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
