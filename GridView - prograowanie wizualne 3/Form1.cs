using System.Windows.Forms;
using System.IO;
using System.Data;
using System.Text;
namespace GridView___prograowanie_wizualne_3
{
    public partial class Form1 : Form
    {


        private void SaveDataGridViewToCsv(string filePath)
        {
            try
            {
                StringBuilder csvContent = new StringBuilder();

            
                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                {
                    csvContent.Append(dataGridView1.Columns[i].HeaderText);
                    if (i < dataGridView1.Columns.Count - 1)
                        csvContent.Append(",");
                }
                csvContent.AppendLine();

                // Wiersze danych
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (!row.IsNewRow) 
                    {
                        for (int i = 0; i < dataGridView1.Columns.Count; i++)
                        {
                            csvContent.Append(row.Cells[i].Value);
                            if (i < dataGridView1.Columns.Count - 1)
                                csvContent.Append(",");
                        }
                        csvContent.AppendLine();
                    }
                }

    
                File.WriteAllText(filePath, csvContent.ToString(), Encoding.UTF8);
                MessageBox.Show("Dane zapisane do pliku: " + filePath, "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("B³¹d podczas zapisu pliku: " + ex.Message, "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadCsvToDataGridView(string filePath)
        {
            try
            {
                string[] lines = File.ReadAllLines(filePath);

                if (lines.Length > 0)
                {
                    dataGridView1.Rows.Clear(); 

                    for (int i = 1; i < lines.Length; i++) 
                    {
                        string[] row = lines[i].Split(',');

                        if (row.Length == 3) 
                        {
                            dataGridView1.Rows.Add(row[0], row[1], row[2]);
                        }
                        else
                        {
                            MessageBox.Show("Niepoprawny format pliku!", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("B³¹d podczas wczytywania pliku: " + ex.Message);
            }
        }
        public Form1()
        {
            InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            if (form2.ShowDialog() == DialogResult.OK)
            {
                
                dataGridView1.Rows.Add(form2.Imie, form2.Nazwisko, form2.Wiek, form2.Stanowisko);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
     
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Zaznacz wiersz do usuniêcia.", "Brak zaznaczenia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Pliki CSV|*.csv";
                saveFileDialog.Title = "Zapisz jako";
                saveFileDialog.FileName = "dane.csv";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    SaveDataGridViewToCsv(saveFileDialog.FileName);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Wybierz plik do odczytu";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                   string filePath = openFileDialog.FileName;
    LoadCsvToDataGridView(filePath);
                }

            }


        }

    }
}
