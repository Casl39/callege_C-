using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BetBoomTrips
{
    public partial class regist : Form
    {
        public regist()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void signIn_Click(object sender, EventArgs e)
        {
            DateTime d = DateTime.Today.AddYears(-14);
            if (full_name.Text == "")
            {
                MessageBox.Show("Заполните своё ФИО", "Пустые поля", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!male.Checked && !female.Checked)
            {
                MessageBox.Show("Выберете пол", "Пустые поля", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (born.Value.Date > d)
            {
                MessageBox.Show("Вам должно быть больше 14 лет", "Вы маленький", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!Regex.IsMatch(email.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Email введен неправильно", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!number.MaskCompleted)
            {
                MessageBox.Show("Напишите номер телефона", "Пустые поля", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(!Regex.IsMatch(password1.Text, @"^(?=.* [A - Z])(?=.*\d).{ 6,}$"))
            {
                MessageBox.Show("Ваш пароль слишком простой", "Пароль", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(password1.Text != password2.Text)
            {
                MessageBox.Show("Пароли не совпадают", "Пароли", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!checkBox1.Checked)
            {
                MessageBox.Show("Нужно согласиться с соглашением", "Соглашение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            Afto betBoomTrips = new Afto();
            betBoomTrips.Show();
            this.Hide();
        }
    }
}
