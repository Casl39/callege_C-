using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BetBoomTrips
{
    public partial class vasVidno : Form
    {
        public vasVidno()
        {
            InitializeComponent();
            BindTripsToDataGridView();
            
        }
        public static void LoadTripsData()
        {
            try
            {
                string connectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=TourismDB; Integrated Security=False";
                
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();

                    if (sqlConnection.State == ConnectionState.Open)
                    {
                        string selectQuery = "SELECT * FROM Trips";
                        AppData.sqlDataAdapterTrip = new SqlDataAdapter(selectQuery, sqlConnection);

                        SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(AppData.sqlDataAdapterTrip);

                        AppData.BetBoomTrip = new DataSet();
                        AppData.sqlDataAdapterTrip.Fill(AppData.BetBoomTrip,"Trips");
                    }
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static List<trips> GetTripsList()
        {
            var trips = new List<trips>();
            if (AppData.BetBoomTrip?.Tables["Trips"] != null)
            {
                foreach (DataRow row in AppData.BetBoomTrip.Tables["Trips"].Rows)
                {
                    trips.Add(new trips
                    {
                        id = Convert.ToInt32(row["id"]),
                        title = row["title"].ToString(),
                        description = row["description"].ToString(),
                        price = Convert.ToDecimal(row["price"]),
                        destination = row["destination"].ToString(),
                        duration = Convert.ToInt32(row["duration"]),
                        image_filename = row["image_filename"].ToString(),
                        start_date = Convert.ToDateTime(row["start_date"]),
                        end_date = Convert.ToDateTime(row["end_date"])
                    });
                }
            }
            return trips;
        }
        private void BindTripsToDataGridView()
        {
            //загружаем данные
            LoadTripsData();

            List<trips> tripsList = GetTripsList();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = tripsList;
        }
       
        private void DisplayTripImage(trips trips)
        {
            try
            {
                string fullPath;
                if (String.IsNullOrEmpty(trips.image_filename))
                    fullPath = @"..\..\Images\picture.png";
                else
                    fullPath = @"..\..\Images\" + trips.image_filename;

                using (var original = Image.FromFile(fullPath))
                {
                    var copy = new Bitmap(original);
                    pictureBox1.Image = copy;
                }
            }
            catch { }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                trips selectTrip = dataGridView1.SelectedRows[0].DataBoundItem as trips;
                if (selectTrip != null)
                {
                    DisplayTripImage(selectTrip);
                    label9.Text = selectTrip.title;
                    label10.Text = selectTrip.destination;
                    label11.Text = selectTrip.duration.ToString() + " дней";
                    label12.Text = selectTrip.price.ToString();
                    label13.Text = $"{selectTrip.start_date.ToShortDateString()} - {selectTrip.end_date.ToShortDateString()}";
                    label14.Text = selectTrip.description;
                }
            }
        }

        private void Addtrip_Click(object sender, EventArgs e)
        {
            AddTrips vasVidno = new AddTrips();
            vasVidno.Show();
            this.Hide();
        }
    }
}
