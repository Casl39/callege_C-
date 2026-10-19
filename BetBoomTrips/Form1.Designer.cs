namespace BetBoomTrips
{
    partial class Afto
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Afto));
            this.login = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.login_user = new System.Windows.Forms.Label();
            this.password_user = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Button();
            this.registration = new System.Windows.Forms.Button();
            this.guess = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(32, 53);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(157, 20);
            this.login.TabIndex = 0;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(32, 100);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(157, 20);
            this.password.TabIndex = 1;
            // 
            // login_user
            // 
            this.login_user.AutoSize = true;
            this.login_user.BackColor = System.Drawing.Color.Transparent;
            this.login_user.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.login_user.Location = new System.Drawing.Point(32, 34);
            this.login_user.Name = "login_user";
            this.login_user.Size = new System.Drawing.Size(38, 13);
            this.login_user.TabIndex = 2;
            this.login_user.Text = "Логин";
            // 
            // password_user
            // 
            this.password_user.AutoSize = true;
            this.password_user.BackColor = System.Drawing.Color.Transparent;
            this.password_user.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.password_user.Location = new System.Drawing.Point(35, 84);
            this.password_user.Name = "password_user";
            this.password_user.Size = new System.Drawing.Size(45, 13);
            this.password_user.TabIndex = 3;
            this.password_user.Text = "Пароль";
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.Color.Transparent;
            this.start.Location = new System.Drawing.Point(64, 140);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(75, 23);
            this.start.TabIndex = 4;
            this.start.Text = "Войти";
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.button1_Click);
            // 
            // registration
            // 
            this.registration.Location = new System.Drawing.Point(53, 169);
            this.registration.Name = "registration";
            this.registration.Size = new System.Drawing.Size(102, 25);
            this.registration.TabIndex = 5;
            this.registration.Text = "Регистрация";
            this.registration.UseVisualStyleBackColor = true;
            this.registration.Click += new System.EventHandler(this.registration_Click);
            // 
            // guess
            // 
            this.guess.Location = new System.Drawing.Point(53, 200);
            this.guess.Name = "guess";
            this.guess.Size = new System.Drawing.Size(102, 25);
            this.guess.TabIndex = 6;
            this.guess.Text = "Войти как гость";
            this.guess.UseVisualStyleBackColor = true;
            this.guess.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.Location = new System.Drawing.Point(135, 12);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 7;
            this.exit.Text = "Выйти";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Afto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = global::BetBoomTrips.Properties.Resources.fon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(222, 257);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.guess);
            this.Controls.Add(this.registration);
            this.Controls.Add(this.start);
            this.Controls.Add(this.password_user);
            this.Controls.Add(this.login_user);
            this.Controls.Add(this.password);
            this.Controls.Add(this.login);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Afto";
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label login_user;
        private System.Windows.Forms.Label password_user;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button registration;
        private System.Windows.Forms.Button guess;
        private System.Windows.Forms.Button exit;
    }
}

