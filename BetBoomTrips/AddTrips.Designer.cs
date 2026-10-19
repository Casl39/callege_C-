namespace BetBoomTrips
{
    partial class AddTrips
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
            this.back = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.AddPrice = new System.Windows.Forms.TextBox();
            this.AddTrip = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.AddDestination = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AddDateStart = new System.Windows.Forms.DateTimePicker();
            this.AddTitle = new System.Windows.Forms.TextBox();
            this.AddDateEnd = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AddDescription = new System.Windows.Forms.TextBox();
            this.addImage = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(397, 518);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 45;
            this.back.Text = "Назад";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(226, 518);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 44;
            this.clear.Text = "Очистить";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(285, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Введите стоимость поездки";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // AddPrice
            // 
            this.AddPrice.Location = new System.Drawing.Point(285, 288);
            this.AddPrice.Name = "AddPrice";
            this.AddPrice.Size = new System.Drawing.Size(159, 20);
            this.AddPrice.TabIndex = 35;
            this.AddPrice.TextChanged += new System.EventHandler(this.loginSign_TextChanged);
            // 
            // AddTrip
            // 
            this.AddTrip.Location = new System.Drawing.Point(285, 487);
            this.AddTrip.Name = "AddTrip";
            this.AddTrip.Size = new System.Drawing.Size(131, 25);
            this.AddTrip.TabIndex = 34;
            this.AddTrip.Text = "Зарегистрироваться";
            this.AddTrip.UseVisualStyleBackColor = true;
            this.AddTrip.Click += new System.EventHandler(this.AddTrip_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(282, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Введите направление поездки";
            // 
            // AddDestination
            // 
            this.AddDestination.Location = new System.Drawing.Point(285, 243);
            this.AddDestination.Name = "AddDestination";
            this.AddDestination.Size = new System.Drawing.Size(159, 20);
            this.AddDestination.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(282, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Введите дату начала поездки";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(282, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Введите название поездки";
            // 
            // AddDateStart
            // 
            this.AddDateStart.Location = new System.Drawing.Point(285, 152);
            this.AddDateStart.Name = "AddDateStart";
            this.AddDateStart.Size = new System.Drawing.Size(200, 20);
            this.AddDateStart.TabIndex = 26;
            // 
            // AddTitle
            // 
            this.AddTitle.Location = new System.Drawing.Point(285, 112);
            this.AddTitle.Name = "AddTitle";
            this.AddTitle.Size = new System.Drawing.Size(159, 20);
            this.AddTitle.TabIndex = 23;
            // 
            // AddDateEnd
            // 
            this.AddDateEnd.Location = new System.Drawing.Point(285, 194);
            this.AddDateEnd.Name = "AddDateEnd";
            this.AddDateEnd.Size = new System.Drawing.Size(200, 20);
            this.AddDateEnd.TabIndex = 46;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(282, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 13);
            this.label8.TabIndex = 47;
            this.label8.Text = "Введите дату конца поездки";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(282, 351);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 48;
            this.label4.Text = "Введите описание";
            // 
            // AddDescription
            // 
            this.AddDescription.Location = new System.Drawing.Point(280, 367);
            this.AddDescription.Multiline = true;
            this.AddDescription.Name = "AddDescription";
            this.AddDescription.Size = new System.Drawing.Size(215, 114);
            this.AddDescription.TabIndex = 49;
            // 
            // addImage
            // 
            this.addImage.Location = new System.Drawing.Point(50, 445);
            this.addImage.Name = "addImage";
            this.addImage.Size = new System.Drawing.Size(133, 96);
            this.addImage.TabIndex = 50;
            this.addImage.Text = "Добавить изображение";
            this.addImage.UseVisualStyleBackColor = true;
            this.addImage.Click += new System.EventHandler(this.addImage_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(50, 419);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 51;
            // 
            // AddTrips
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BetBoomTrips.Properties.Resources.starwar;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(735, 623);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.addImage);
            this.Controls.Add(this.AddDescription);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.AddDateEnd);
            this.Controls.Add(this.back);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AddPrice);
            this.Controls.Add(this.AddTrip);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AddDestination);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddDateStart);
            this.Controls.Add(this.AddTitle);
            this.DoubleBuffered = true;
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Name = "AddTrips";
            this.Text = "AddTrips";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox AddPrice;
        private System.Windows.Forms.Button AddTrip;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AddDestination;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker AddDateStart;
        private System.Windows.Forms.TextBox AddTitle;
        private System.Windows.Forms.DateTimePicker AddDateEnd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AddDescription;
        private System.Windows.Forms.Button addImage;
        private System.Windows.Forms.TextBox textBox1;
    }
}