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
    public partial class Afto : Form
    {
        public Afto()
        {
            InitializeComponent();
            AppData.userSet = new DataSet();
            string connectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=TourismDB; Integrated Security=False";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            if (sqlConnection.State == ConnectionState.Open)
            {
                string selectQuery = "SELECT * FROM Users";
                AppData.sqlDataAdapter = new SqlDataAdapter(selectQuery, sqlConnection);
                AppData.sqlDataAdapter.Fill(AppData.userSet);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (login.Text == "" && password.Text == "")
            {
                MessageBox.Show("Заполните логин и пароль!", "Пустые поля", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            foreach (DataRow row in AppData.userSet.Tables[0].Rows)
            {
                if (row["lodin"].ToString() == login.Text)
                {
                    if (row["password"].ToString() == password.Text)
                    {
                        //MessageBox.Show("Вы успешный."+ row["FULLname"].ToString() ,"Можете работать", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (row["role"].ToString() == "1")
                        {
                            MessageBox.Show("Добро пожаловать, АДМИНИСТРАТОР!", "Приветствие", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            MessageBox.Show("Желаете открыть панель управления?", "Вопрос ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            MessageBox.Show("У вас есть 5 необработанных заявок!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            MessageBox.Show("Авторизация прошла успешно!", "Поздравляю", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            vasVidno vasVidno = new vasVidno();
                            vasVidno.Show();
                            this.Hide();
                        }
                        else if (row["role"].ToString() == "2")
                        {
                            MessageBox.Show("Здравствуйте," + row["FULLname"].ToString() + "! Вы вошли как МЕНЕДЖЕР.»", "Приветствие", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            MessageBox.Show("Показать список клиентов?", "Вопрос ", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                            MessageBox.Show("Заканчиваются лицензии! Осталось 3 дня", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            MessageBox.Show("Авторизация прошла успешно!", "Поздравляю", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            vasVidno vasVidno = new vasVidno();
                            vasVidno.Show();
                            this.Hide();
                        }
                        else if(row["role"].ToString() == "3")
                        {
                            MessageBox.Show("Здравствуйте," + row["FULLname"].ToString() + "! Вы вошли как ПОЛЬЗОВАТЕЛЬ.»", "Приветствие", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            MessageBox.Show("Хотите обновить профиль?", "Вопрос ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            MessageBox.Show("Доступ к этой функции запрещён!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            MessageBox.Show("Авторизация прошла успешно!", "Поздравляю", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            vasVidno vasVidno = new vasVidno();
                            vasVidno.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Неверная роль!", "Роль пользователя не определена!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Неверный пароль!", "Неверный пароль", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    return;
                }
            }
            MessageBox.Show("Неверный логин!", "Неверный логин", MessageBoxButtons.OK, MessageBoxIcon.Error);           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Вы вошли как ГОСТЬ. Доступ ограничен.", "Уведомление о статусе", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show("Для полного доступа авторизуйтесь.»", "Напоминание ", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }

        private void exit_Click(object sender, EventArgs e)
        {
            password.Clear();
            login.Clear();
            MessageBox.Show("Вы вышли", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void registration_Click(object sender, EventArgs e)
        {
            regist regist = new regist();
            regist.Show();
            this.Hide();
        }
    }
}
