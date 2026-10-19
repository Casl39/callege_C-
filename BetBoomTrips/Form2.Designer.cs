namespace BetBoomTrips
{
    partial class regist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(regist));
            this.full_name = new System.Windows.Forms.TextBox();
            this.male = new System.Windows.Forms.RadioButton();
            this.female = new System.Windows.Forms.RadioButton();
            this.born = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.pole = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.number = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.signIn = new System.Windows.Forms.Button();
            this.loginSign = new System.Windows.Forms.TextBox();
            this.password1 = new System.Windows.Forms.TextBox();
            this.password2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textQueson = new System.Windows.Forms.TextBox();
            this.clear = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // full_name
            // 
            this.full_name.Location = new System.Drawing.Point(108, 77);
            this.full_name.Name = "full_name";
            this.full_name.Size = new System.Drawing.Size(159, 20);
            this.full_name.TabIndex = 0;
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.BackColor = System.Drawing.Color.Transparent;
            this.male.ForeColor = System.Drawing.Color.Transparent;
            this.male.Location = new System.Drawing.Point(108, 116);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(34, 17);
            this.male.TabIndex = 1;
            this.male.TabStop = true;
            this.male.Text = "М";
            this.male.UseVisualStyleBackColor = false;
            // 
            // female
            // 
            this.female.AutoSize = true;
            this.female.BackColor = System.Drawing.Color.Transparent;
            this.female.ForeColor = System.Drawing.Color.White;
            this.female.Location = new System.Drawing.Point(233, 116);
            this.female.Name = "female";
            this.female.Size = new System.Drawing.Size(36, 17);
            this.female.TabIndex = 2;
            this.female.TabStop = true;
            this.female.Text = "Ж";
            this.female.UseVisualStyleBackColor = false;
            // 
            // born
            // 
            this.born.Location = new System.Drawing.Point(99, 153);
            this.born.Name = "born";
            this.born.Size = new System.Drawing.Size(200, 20);
            this.born.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(108, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Введите своё ФИО";
            // 
            // pole
            // 
            this.pole.AutoSize = true;
            this.pole.BackColor = System.Drawing.Color.Transparent;
            this.pole.ForeColor = System.Drawing.Color.White;
            this.pole.Location = new System.Drawing.Point(108, 100);
            this.pole.Name = "pole";
            this.pole.Size = new System.Drawing.Size(49, 13);
            this.pole.TabIndex = 5;
            this.pole.Text = "Ваш пол";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(96, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Введите свою дату рождения";
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(108, 192);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(159, 20);
            this.email.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(105, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Введите свою почту";
            // 
            // number
            // 
            this.number.Location = new System.Drawing.Point(133, 231);
            this.number.Mask = "+7(999) 000-00-00";
            this.number.Name = "number";
            this.number.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.number.Size = new System.Drawing.Size(106, 20);
            this.number.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(104, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Введите свой номер телефона";
            // 
            // signIn
            // 
            this.signIn.Location = new System.Drawing.Point(121, 444);
            this.signIn.Name = "signIn";
            this.signIn.Size = new System.Drawing.Size(131, 25);
            this.signIn.TabIndex = 11;
            this.signIn.Text = "Зарегистрироваться";
            this.signIn.UseVisualStyleBackColor = true;
            this.signIn.Click += new System.EventHandler(this.signIn_Click);
            // 
            // loginSign
            // 
            this.loginSign.Location = new System.Drawing.Point(108, 268);
            this.loginSign.Name = "loginSign";
            this.loginSign.Size = new System.Drawing.Size(159, 20);
            this.loginSign.TabIndex = 12;
            // 
            // password1
            // 
            this.password1.Location = new System.Drawing.Point(108, 310);
            this.password1.Name = "password1";
            this.password1.PasswordChar = '*';
            this.password1.Size = new System.Drawing.Size(159, 20);
            this.password1.TabIndex = 13;
            // 
            // password2
            // 
            this.password2.Location = new System.Drawing.Point(108, 351);
            this.password2.Name = "password2";
            this.password2.PasswordChar = '*';
            this.password2.Size = new System.Drawing.Size(159, 20);
            this.password2.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(108, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Введите логин";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(108, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Введите пароль";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(108, 335);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Введите пароль еще раз";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBox1.Location = new System.Drawing.Point(32, 421);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(323, 17);
            this.checkBox1.TabIndex = 18;
            this.checkBox1.Text = "Я согласен с условиями обработки персональных данных";
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Девичья фамилия матери",
            "Кличка питомца",
            "Любимое блюдо"});
            this.comboBox1.Location = new System.Drawing.Point(52, 394);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 19;
            // 
            // textQueson
            // 
            this.textQueson.Location = new System.Drawing.Point(199, 395);
            this.textQueson.Name = "textQueson";
            this.textQueson.Size = new System.Drawing.Size(100, 20);
            this.textQueson.TabIndex = 20;
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(62, 475);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 21;
            this.clear.Text = "Очистить";
            this.clear.UseVisualStyleBackColor = true;
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(233, 475);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 22;
            this.back.Text = "Назад";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // regist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BetBoomTrips.Properties.Resources.images;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(407, 510);
            this.Controls.Add(this.back);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.textQueson);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.password2);
            this.Controls.Add(this.password1);
            this.Controls.Add(this.loginSign);
            this.Controls.Add(this.signIn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.number);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.email);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pole);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.born);
            this.Controls.Add(this.female);
            this.Controls.Add(this.male);
            this.Controls.Add(this.full_name);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "regist";
            this.Text = "Регистрация";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox full_name;
        private System.Windows.Forms.RadioButton male;
        private System.Windows.Forms.RadioButton female;
        private System.Windows.Forms.DateTimePicker born;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label pole;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox number;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button signIn;
        private System.Windows.Forms.TextBox loginSign;
        private System.Windows.Forms.TextBox password1;
        private System.Windows.Forms.TextBox password2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textQueson;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button back;
    }
}