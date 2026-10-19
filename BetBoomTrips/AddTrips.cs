using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace BetBoomTrips
{
    public partial class AddTrips : Form
    {

        public AddTrips()
        {
            InitializeComponent();
        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void loginSign_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void AddTrip_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(AddTitle.Text) ||
                string.IsNullOrWhiteSpace(AddDestination.Text) ||
                string.IsNullOrWhiteSpace(AddPrice.Text) ||
                string.IsNullOrWhiteSpace(AddDescription.Text))
            {
                MessageBox.Show("Пустые поля", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectingString = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=TourismDB;Integrated Security=True";


            string query = @"INSERT INTO dbo.Trips (title, description, price, destination, duration,image_filename, start_date, end_date, created_at) 
                     VALUES (@title, @description, @price, @destination, @duration, @img_filename, @start_date, @end_date, @created_at)";

            using (SqlConnection connection = new SqlConnection(connectingString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@title", AddTitle.Text);
                        command.Parameters.AddWithValue("@description", AddDescription.Text);

                        decimal price;
                        if (!decimal.TryParse(AddPrice.Text, out price)) price = 0;
                        command.Parameters.AddWithValue("@price", price);

                        command.Parameters.AddWithValue("@destination", AddDestination.Text);

                        DateTime dataS = AddDateStart.Value.Date;
                        DateTime dataE = AddDateEnd.Value.Date;
                        TimeSpan dura = dataE - dataS;
                        int duration = dura.Days;
                        command.Parameters.AddWithValue("@duration", duration);
                        DateTime now = DateTime.Now;

                        command.Parameters.AddWithValue("@start_date", AddDateStart.Value);
                        command.Parameters.AddWithValue("@end_date", AddDateEnd.Value);
                        command.Parameters.AddWithValue("@img_filename", string.IsNullOrEmpty(fileroad) ? (object)DBNull.Value: fileroad);
                        command.Parameters.AddWithValue("@created_at", now);

                        // Выполняем
                        int result = command.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Поездка добавлена", "Успех");

                            AddTitle.Clear();
                            AddDestination.Clear();
                            AddPrice.Clear();
                            AddDescription.Clear();
                            AddDateStart.Value = DateTime.Now;
                            AddDateEnd.Value = DateTime.Now;
                        }
                        else
                        {
                            MessageBox.Show("Поездка не добавлена ", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Неправильная БД: " + ex.Message, "Ошибка соединения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            AddTitle.Clear();
            AddDestination.Clear();
            AddPrice.Clear();
            AddDescription.Clear();
            AddDateStart.Value = DateTime.Now;
            AddDateEnd.Value = DateTime.Now;
        }

        private void back_Click(object sender, EventArgs e)
        {
            vasVidno vasVidno = new vasVidno();
            vasVidno.Show();
            this.Hide();
        }
        string fileroad;
        private void addImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Выберите изображение для тура";
                openFileDialog.Filter =
                    "Изображения|*.jpg;*.jpeg;*.png;*.bmp;*.gif|Все файлы|*.*";
                
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    fileroad = openFileDialog.FileName;
                    string sourceFilePath = openFileDialog.FileName;
                    string fileName = Path.GetFileName(sourceFilePath);
                    string targetDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\Images");
                    string destFilePath = Path.Combine(targetDirectory, fileName);
                    File.Copy(sourceFilePath, destFilePath, true);
                    fileroad = Path.GetFileName(fileroad);
                }
            }
        }
    }
}
