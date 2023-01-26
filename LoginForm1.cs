using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Security.Cryptography;

namespace OP_k_WF
{
    public partial class LoginForm1 : Form
    {
        public LoginForm1()
        {
            InitializeComponent();

            this.PassField.AutoSize = false;
            this.PassField.Size = new Size(this.PassField.Size.Width, 35);
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            Autho();
        }
        public void Autho()
        {
            if (LoginField.Text == "" || PassField.Text == "")
            {
                MessageBox.Show("Заполните поля!");
                return;
            } // проверка на заполнение полей

            string loginUser = LoginField.Text;
            string passwordUser = Hash.hashPass(PassField.Text);

            SQLiteConnection connection = new SQLiteConnection("Data Source=databasefile.db");
            connection.Open();

            SQLiteCommand com = connection.CreateCommand();
            com.Connection = connection;

            SQLiteDataAdapter adapter = new SQLiteDataAdapter();
            DataTable table = new DataTable();

            com.CommandText = "SELECT * FROM 'users' WHERE login = @login AND pass = @pass";

            com.Parameters.Add("@login", DbType.String).Value = LoginField.Text;
            com.Parameters.Add("@pass", DbType.String).Value = Hash.hashPass(PassField.Text);

            adapter.SelectCommand = com;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Успешная авторизация!");
                this.Hide(); // форма авторизации скрывается
                MainForm form_main = new MainForm();
                form_main.ShowDialog(); // переход к главной форме
                this.Close(); // закрывается форма авторизации
            }
            else
            {
                MessageBox.Show("Не верный логин или пароль!");
                LoginField.Clear();
                PassField.Clear();
            }
        }
        private void ExitX_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        Point lastPoint;

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void LoginForm1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void LoginForm1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void LabelReg_Click(object sender, EventArgs e)
        {
            this.Hide(); // форма авторизации скрывается
            RegForm form_reg = new RegForm();
            form_reg.ShowDialog(); // переход к главной форме
            this.Close(); // закрывается форма авторизации
        }

        private void LoginField_KeyPress(object sender, KeyPressEventArgs e)
        {
            char s = e.KeyChar;
            if (!Char.IsLetter(s) && !Char.IsPunctuation(s) && s != 8)
                e.Handled = true;
        }
        private void PassField_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            char s = e.KeyChar;
            if (!Char.IsLetterOrDigit(s) && !Char.IsPunctuation(s) && s != 8)
                e.Handled = true;
        }
    }
}