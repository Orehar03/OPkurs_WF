using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Numerics;

namespace OP_k_WF
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            NeotsortTB.ScrollBars = ScrollBars.Both;
            OtsortTB.ScrollBars = ScrollBars.Both;
        }

        private void ExitXs_Click(object sender, EventArgs e)
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

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void SortButton_Click(object sender, EventArgs e)
        {
            OtsortTB.Clear();
            string ass = NeotsortTB.Text;
            string[] mas = ass.Split(' ');
            if (UserNumbersTB.Text == "")
            {
                MessageBox.Show("Заполните поля!");
                return;
            } // проверка на заполнение полей

            if (UserNumbersTB.Text == " ")
            {
                MessageBox.Show("Пусто. Введите число.");
                return;
            }
            int n = mas.Length;
            int[] sas = new int[n];

            GnomeSortProg g = new GnomeSortProg();

            for (int i = 0; i < n; i++)
                sas[i] = Convert.ToInt32(mas[i]);

            g.GnomeSort(sas);

            for (int i = 0; i < n; i++)
                OtsortTB.Text += Convert.ToString(sas[i]) + " ";

            if (n == 1)
                OtsortTB.Text += "Одно отсортированное число? Класс!";
        }

        private void ScrButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = @"С://";
            sfd.RestoreDirectory = true;
            sfd.FileName = "Скриншот результата работы программы";
            sfd.DefaultExt = "JPG";
            sfd.Filter = "Image Files(.BMP)|.BMP|Image Files(.JPG)|.JPG|Image Files(.GIF)|.GIF|Image Files(.PNG)|.PNG|All files (.)|.";
            Rectangle bounds = this.Bounds;
            using (Bitmap bitmap = new Bitmap(bounds.Width, bounds.Height))
            {
                using (Graphics graph = Graphics.FromImage(bitmap))
                {
                    graph.CopyFromScreen(new Point(bounds.Left, bounds.Top), Point.Empty, bounds.Size);
                }
                if (sfd.ShowDialog() == DialogResult.OK)
                    bitmap.Save(sfd.FileName);
            }
        }

        private void EnterUserMasButtton_Click(object sender, EventArgs e)
        {
            NeotsortTB.Clear();
            OtsortTB.Clear();
            if (UserNumbersTB.Text == "")
            {
                MessageBox.Show("Заполните поля!");
                return;
            } // проверка на заполнение полей
            if (UserNumbersTB.Text == " ")
            {
                MessageBox.Show("Пусто. Введите число.");
                return;
            }
            NeotsortTB.Text = UserNumbersTB.Text;
        }

        private void UserNumbersTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            char s = e.KeyChar;
            if (!Char.IsDigit(s) && s != 8 && s != 32)
                e.Handled = true;
        }
    }
}