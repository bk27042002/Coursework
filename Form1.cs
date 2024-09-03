using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ListUsers _users = new ListUsers();
        User _currentUser = null;
        private void Form1_Load(object sender, EventArgs e)
        {
            userControlGuest1.Start();
            _users.Load();
            
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if(_users.TryLogin(textBoxLogin.Text, textBoxPassword.Text))
            {
                panel1.Visible = false;
                userControlGuest1.Visible = false;
                userControlAuthor1.SetAuthor(textBoxLogin.Text);
            }else
            {
                MessageBox.Show("Проверьте правильность введения логина/пароля");
            }
        }

        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            if(textBoxRegPassword.Text == "")
            {
                MessageBox.Show("Введите пароли в оба поля!!!");
                return;
            }
            if(textBoxRegPasswordRepit.Text != textBoxRegPassword.Text)
            {
                MessageBox.Show("Пароли не совпадают!!!");
                return;
            }
            if(_users.FindByName(textBoxRegLogin.Text) != null)
            {
                MessageBox.Show("Логин уже занят!!!");
                return;
            }
            User newUser = new User(textBoxRegLogin.Text, textBoxRegPassword.Text);
            ListUsers.SaveNewUser(newUser);
            userControlAuthor1.SetAuthor(textBoxRegLogin.Text);
            userControlGuest1.Visible = false;
            panel1.Visible = false;
        }

        private void buttonReader_Click(object sender, EventArgs e)
        {
            userControlAuthor1.Visible = false;
            panel1.Visible = false;
        }
    }
}
