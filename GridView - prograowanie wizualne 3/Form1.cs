using System.Windows.Forms;
using System.IO;
using System.Data;
using System.Text;
using System.Xml.Serialization;
using System.Runtime.CompilerServices;
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

                        if (row.Length == 5)
                        {
                            dataGridView1.Rows.Add(row[0], row[1], row[2], row[3], row[4]);
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

                dataGridView1.Rows.Add(form2.ID, form2.Imie, form2.Nazwisko, form2.Wiek, form2.Stanowisko);
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

        private List<Person> GetPeopleFromDataGridView()
        {
            List<Person> people = new List<Person>();
            int idCounter = 1; // Mo¿esz mieæ w³asne ID, albo u¿yæ tej prostej wersji

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    int.TryParse(row.Cells[0].Value?.ToString(), out int ID);
                    string firstName = row.Cells[1].Value?.ToString();
                    string lastName = row.Cells[2].Value?.ToString();
                    int.TryParse(row.Cells[3].Value?.ToString(), out int age);
                    string position = row.Cells[4].Value?.ToString();

                    people.Add(new Person(ID, firstName, lastName, age, position));
                }
            }

            return people;
        }

        private void SavePeopleToXml(string filePath)
        {
            List<Person> people = GetPeopleFromDataGridView();
            XmlSerializer serializer = new XmlSerializer(typeof(List<Person>));

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                serializer.Serialize(writer, people);
            }

            MessageBox.Show("Dane zosta³y zapisane do pliku XML.");
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Pliki XML|*.xml";
                saveFileDialog.Title = "Zapisz do XML";
                saveFileDialog.FileName = "dane.xml";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    SavePeopleToXml(saveFileDialog.FileName);
                }
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Pliki XML (*.xml)|*.xml";
                openFileDialog.Title = "Wczytaj plik XML";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string filePath = openFileDialog.FileName;

                        XmlSerializer serializer = new XmlSerializer(typeof(List<Person>));

                        using (FileStream fs = new FileStream(filePath, FileMode.Open))
                        {
                            List<Person> people = (List<Person>)serializer.Deserialize(fs);

                            if (people != null)
                            {
                                dataGridView1.Rows.Clear();
                                foreach (Person person in people)
                                {
                                    dataGridView1.Rows.Add(person.ID, person.FirstName, person.LastName, person.Age, person.Position);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Brak danych w pliku XML.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("B³¹d podczas wczytywania pliku XML: " + ex.Message, "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
