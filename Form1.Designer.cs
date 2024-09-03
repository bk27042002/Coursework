
namespace Coursework
{
    partial class Form1
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
            this.userControlAuthor1 = new Coursework.UserControlAuthor();
            this.userControlGuest1 = new Coursework.UserControlGuest();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonRegistration = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxRegPassword = new System.Windows.Forms.TextBox();
            this.textBoxRegLogin = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxRegPasswordRepit = new System.Windows.Forms.TextBox();
            this.buttonReader = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // userControlAuthor1
            // 
            this.userControlAuthor1.Location = new System.Drawing.Point(-1, -2);
            this.userControlAuthor1.Name = "userControlAuthor1";
            this.userControlAuthor1.Size = new System.Drawing.Size(1081, 605);
            this.userControlAuthor1.TabIndex = 0;
            // 
            // userControlGuest1
            // 
            this.userControlGuest1.Location = new System.Drawing.Point(-1, -2);
            this.userControlGuest1.Name = "userControlGuest1";
            this.userControlGuest1.Size = new System.Drawing.Size(1081, 605);
            this.userControlGuest1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonReader);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBoxRegPasswordRepit);
            this.panel1.Controls.Add(this.buttonRegistration);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBoxRegPassword);
            this.panel1.Controls.Add(this.textBoxRegLogin);
            this.panel1.Controls.Add(this.buttonLogin);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxPassword);
            this.panel1.Controls.Add(this.textBoxLogin);
            this.panel1.Location = new System.Drawing.Point(-1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1081, 605);
            this.panel1.TabIndex = 2;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(288, 215);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(100, 20);
            this.textBoxLogin.TabIndex = 0;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(288, 254);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(100, 20);
            this.textBoxPassword.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(288, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(288, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Пароль";
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(288, 281);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(100, 34);
            this.buttonLogin.TabIndex = 4;
            this.buttonLogin.Text = "Войти как автор";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonRegistration
            // 
            this.buttonRegistration.Location = new System.Drawing.Point(444, 321);
            this.buttonRegistration.Name = "buttonRegistration";
            this.buttonRegistration.Size = new System.Drawing.Size(134, 36);
            this.buttonRegistration.TabIndex = 9;
            this.buttonRegistration.Text = "Зарегистрироваться";
            this.buttonRegistration.UseVisualStyleBackColor = true;
            this.buttonRegistration.Click += new System.EventHandler(this.buttonRegistration_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(444, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Пароль";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(444, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Логин";
            // 
            // textBoxRegPassword
            // 
            this.textBoxRegPassword.Location = new System.Drawing.Point(444, 254);
            this.textBoxRegPassword.Name = "textBoxRegPassword";
            this.textBoxRegPassword.Size = new System.Drawing.Size(134, 20);
            this.textBoxRegPassword.TabIndex = 6;
            // 
            // textBoxRegLogin
            // 
            this.textBoxRegLogin.Location = new System.Drawing.Point(444, 215);
            this.textBoxRegLogin.Name = "textBoxRegLogin";
            this.textBoxRegLogin.Size = new System.Drawing.Size(134, 20);
            this.textBoxRegLogin.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(444, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Повторите пароль";
            // 
            // textBoxRegPasswordRepit
            // 
            this.textBoxRegPasswordRepit.Location = new System.Drawing.Point(444, 295);
            this.textBoxRegPasswordRepit.Name = "textBoxRegPasswordRepit";
            this.textBoxRegPasswordRepit.Size = new System.Drawing.Size(134, 20);
            this.textBoxRegPasswordRepit.TabIndex = 10;
            // 
            // buttonReader
            // 
            this.buttonReader.Location = new System.Drawing.Point(620, 215);
            this.buttonReader.Name = "buttonReader";
            this.buttonReader.Size = new System.Drawing.Size(124, 79);
            this.buttonReader.TabIndex = 12;
            this.buttonReader.Text = "Войти как читатель";
            this.buttonReader.UseVisualStyleBackColor = true;
            this.buttonReader.Click += new System.EventHandler(this.buttonReader_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 602);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.userControlGuest1);
            this.Controls.Add(this.userControlAuthor1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private UserControlAuthor userControlAuthor1;
        private UserControlGuest userControlGuest1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonReader;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxRegPasswordRepit;
        private System.Windows.Forms.Button buttonRegistration;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxRegPassword;
        private System.Windows.Forms.TextBox textBoxRegLogin;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxLogin;
    }
}

