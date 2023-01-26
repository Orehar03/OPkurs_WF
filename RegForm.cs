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
    public partial class RegForm : Form
    {
        public RegForm()
        {
            InitializeComponent();
            this.PasswordFieldr.AutoSize = false;
            this.PasswordFieldr.Size = new Size(this.PasswordFieldr.Size.Width, 29);
        }
        private void RegaButton_Click(object sender, EventArgs e)
        {
            Rega();
        }
        public void Rega()
        {
            string loginUser = LoginFieldr.Text;
            string passUser = Hash.hashPass(PasswordFieldr.Text);
            string nameUser = NameFieldr.Text;
            string surnameUser = SurnameFieldr.Text;

            if (NameFieldr.Text == "" && SurnameFieldr.Text == "" && LoginFieldr.Text == "" && PasswordFieldr.Text == "")
            {
                MessageBox.Show("Все поля пусты! Регистрация невозможна.");
                return;
            }
            if (NameFieldr.Text == "")
            {
                MessageBox.Show("Введите имя");
                return;
            }

            if (SurnameFieldr.Text == "")
            {
                MessageBox.Show("Введите фамилию");
                return;
            }

            if (LoginFieldr.Text == "")
            {
                MessageBox.Show("Введите логин");
                return;
            }

            if (PasswordFieldr.Text == "")
            {
                MessageBox.Show("Введите пароль");
                return;
            }

            if (CheckUser())
                return;

            Check();

            SQLiteConnection connection = new SQLiteConnection("Data Source=databasefile.db");
            connection.Open();

            SQLiteCommand com = connection.CreateCommand();
            com.Connection = connection;

            com.CommandText = "INSERT INTO users (login, pass, name, surname) VALUES (@login, @pass, @name, @surname)";
            com.Parameters.AddWithValue("@login", loginUser);
            com.Parameters.AddWithValue("@pass", passUser);
            com.Parameters.AddWithValue("@name", nameUser);
            com.Parameters.AddWithValue("@surname", surnameUser);
            int num = com.ExecuteNonQuery();

            if (num == 1)
            {
                MessageBox.Show("Аккаунт успешно создан!");
                this.Hide(); // форма авторизации скрывается
                LoginForm1 form_aut = new LoginForm1();
                form_aut.ShowDialog(); // переход к форме авторизации
                this.Close(); // закрывается форма авторизации
            }
            else
            {
                MessageBox.Show("Не получилось создать аккаунт! Проверьте введенные данные.");
            }
        }
        public bool CheckUser()
        {
            string loginUser = LoginFieldr.Text;

            SQLiteConnection connection = new SQLiteConnection("Data Source=databasefile.db");
            connection.Open();

            SQLiteCommand command = connection.CreateCommand();
            command.Connection = connection;

            SQLiteDataAdapter adapter = new SQLiteDataAdapter();
            DataTable table = new DataTable();

            command.CommandText = "SELECT * FROM 'users' WHERE login = @login";

            command.Parameters.Add("@login", DbType.String).Value = LoginFieldr.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Пользователь с таким логином уже существует!");
                LoginFieldr.Clear();
                PasswordFieldr.Clear();
                return true;
            }
            else
                return false;

        } // проверка на пользователя (для проверки)

        public void Check()
        {
            if (LoginFieldr.Text == "" || PasswordFieldr.Text == "" || NameFieldr.Text == "" || SurnameFieldr.Text == "")
            {
                MessageBox.Show("Заполните все поля!");
                return;
            } // проверка на заполнение полей
            if (CheckUser())
            {
                return;
            } // проверка на наличие уже имеющегося пользователя
        } // проверки
        

        private void ExitXr_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        Point lastPoint;
        private void RegForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void RegForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

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

        private void LoginFieldr_KeyPress(object sender, KeyPressEventArgs e)
        {
            char s = e.KeyChar;
            if (!Char.IsLetter(s) && !Char.IsPunctuation(s) && s != 8)
                e.Handled = true;
        }

        private void NameFieldr_KeyPress(object sender, KeyPressEventArgs e)
        {
            char s = e.KeyChar;
            if (!Char.IsLetter(s) && !Char.IsPunctuation(s) && s != 8)
                e.Handled = true;
        }

        private void SurnameFieldr_KeyPress(object sender, KeyPressEventArgs e)
        {
            char s = e.KeyChar;
            if (!Char.IsLetter(s) && !Char.IsPunctuation(s) && s != 8)
                e.Handled = true;
        }

        private void PasswordFieldr_KeyPress(object sender, KeyPressEventArgs e)
        {
            char s = e.KeyChar;
            if (!Char.IsLetterOrDigit(s) && !Char.IsPunctuation(s) && s != 8)
                e.Handled = true;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm1 register = new LoginForm1();
            DialogResult dialogResult = register.ShowDialog();
        }
    }
}