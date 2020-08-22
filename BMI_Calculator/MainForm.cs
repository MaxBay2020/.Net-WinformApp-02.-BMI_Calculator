using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_Calculator
{
    public partial class MainForm : Form
    {
        //name
        private string _name;
        //cm
        private double _height;
        //kg
        private double _weight;

        //table;
        public static DataTable table = null;

        //record list
        List<Cong_BMIRecord> records = new List<Cong_BMIRecord>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread th = new Thread(delegate () { new SplashScreen().ShowDialog(); });
            th.Start();
            this.Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            height_comb.SelectedIndex = 0;
            weight_comb.SelectedIndex = 0;

            //BMIRecord record = new BMIRecord("Lucy", 166, 51);

            //this.dataGridView1.DataSource = records;

            //create a table
            table = new DataTable();
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Height", typeof(double));
            table.Columns.Add("Weight", typeof(double));
            table.Columns.Add("BMI", typeof(double));
            table.Columns.Add("Comment", typeof(string));
            table.Columns.Add("Date", typeof(DateTime));

            //original data
            //table.Rows.Add(1, "Lucy", 166, 51, 18.2, "Healthy Weight", DateTime.Now.ToShortDateString());
            //table.Rows.Add(2, "David", 176, 73, 20, "Healthy Weight", DateTime.Now.ToShortDateString());
            //table.Rows.Add(3, "Nick", 178, 88, 26, "Overweight", DateTime.Now.ToShortDateString());
            //table.Rows.Add(4, "Chris", 162, 47, 18.2, "Underweight", DateTime.Now.ToShortDateString());

            string[] lines = File.ReadAllLines(@".\data.txt");
            string[] values;

            for (int i = 0; i < lines.Length; i++)
            {
                values = lines[i].ToString().Split('\t');
                string[] row = new string[values.Length];

                for (int j = 0; j < values.Length; j++)
                {
                    row[j] = values[j].Trim();
                }
                table.Rows.Add(row);
            }

            dataGridView1.DataSource = table;
            }

        private void confirm_btn_Click(object sender, EventArgs e)
        {
            //name;
            _name = name_txt.Text;

            //verify data
            try
            {
                Convert.ToDouble(height_txt.Text);
                Convert.ToDouble(weight_txt.Text);

            }
            catch (Exception)
            {
                MessageBox.Show("The data is in valid.");

                name_txt.Text = "";
                height_txt.Text = "";
                weight_txt.Text = "";

                return;
            }

            //height;
            if (height_comb.SelectedIndex == 0)
            {
                //cm selected;
                _height = Convert.ToDouble(height_txt.Text);
            }
            else
            {
                //inch selected;
                //1 inch = 2.54 cm
                _height = Convert.ToDouble(height_txt.Text) * 2.54;
            }

            //weight
            if (weight_comb.SelectedIndex == 0)
            {
                //kg selected;
                _weight = Convert.ToDouble(weight_txt.Text);
            }
            else
            {
                //pound selected;
                //1 pound = 0.4536 kg;
                _weight = Convert.ToDouble(weight_txt.Text) * 0.4536;
            }



            Cong_BMIRecord record = new Cong_BMIRecord(_name, _height, _weight);
            double bmi = record.CalculateBMI(_height,_weight);
            string comment = record.HealthStatus(bmi);

            records.Add(record);

            //Show result
            Cong_App.value = record.ToString();

            ResultForm resultFrm = new ResultForm();
            resultFrm.Show();


            name_txt.Text = "";
            height_txt.Text = "";
            weight_txt.Text = "";

            //foreach (BMIRecord item in records)
            //{
            //    MessageBox.Show(item.Name+"---"+item.Height+"---"+item.Weight);
            //}

            //add new record to table
            table.Rows.Add(Cong_BMIRecord._id, record.Name, record.Height, record.Weight, bmi, comment, DateTime.Now.ToShortDateString());
            dataGridView1.DataSource = table;
        }

        private void import_btn_Click(object sender, EventArgs e)
        {
            try
            {
                int rowIndex = dataGridView1.CurrentCell.RowIndex;
                dataGridView1.Rows.RemoveAt(rowIndex);
            }
            catch (Exception)
            {

                MessageBox.Show("There is no record!");
                return;
            }
            
        }

        private void insert_btn_Click(object sender, EventArgs e)
        {
            BMI_tab.SelectedIndex = 0;
        }

        [STAThread]
        private void importBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Please choose a txt file";
            ofd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            ofd.InitialDirectory = Application.StartupPath + @".\";
            ofd.Multiselect = true;
            ofd.ShowDialog();


            try
            {
                string[] lines = File.ReadAllLines(ofd.FileName);
                string[] values;

                for (int i = 0; i < lines.Length; i++)
                {
                    values = lines[i].ToString().Split('\t');
                    string[] row = new string[values.Length];

                    for (int j = 0; j < values.Length; j++)
                    {
                        row[j] = values[j].Trim();
                    }
                    table.Rows.Add(row);
                }

                dataGridView1.DataSource = table;
            }
            catch (Exception)
            {

                MessageBox.Show("The data is not valid.");
            };
            
        }
    }
}
