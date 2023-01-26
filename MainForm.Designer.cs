namespace OP_k_WF
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ExitXs = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NeotsortTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SortButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.OtsortTB = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ScrButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.EnterUserMasButtton = new System.Windows.Forms.Button();
            this.UserNumbersTB = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(175)))), ((int)(((byte)(41)))));
            this.panel1.Controls.Add(this.ExitXs);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(981, 100);
            this.panel1.TabIndex = 0;
            // 
            // ExitXs
            // 
            this.ExitXs.AutoSize = true;
            this.ExitXs.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitXs.Location = new System.Drawing.Point(950, 0);
            this.ExitXs.Name = "ExitXs";
            this.ExitXs.Size = new System.Drawing.Size(31, 33);
            this.ExitXs.TabIndex = 1;
            this.ExitXs.Text = "X";
            this.ExitXs.Click += new System.EventHandler(this.ExitXs_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Corbel", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(981, 100);
            this.label1.TabIndex = 0;
            this.label1.Text = "Гномья сортировка";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            // 
            // NeotsortTB
            // 
            this.NeotsortTB.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NeotsortTB.Location = new System.Drawing.Point(354, 156);
            this.NeotsortTB.Multiline = true;
            this.NeotsortTB.Name = "NeotsortTB";
            this.NeotsortTB.ReadOnly = true;
            this.NeotsortTB.Size = new System.Drawing.Size(249, 95);
            this.NeotsortTB.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(175)))), ((int)(((byte)(41)))));
            this.label5.Location = new System.Drawing.Point(350, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(236, 23);
            this.label5.TabIndex = 2;
            this.label5.Text = "Неотсортированный массив";
            // 
            // SortButton
            // 
            this.SortButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(175)))), ((int)(((byte)(41)))));
            this.SortButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(142)))), ((int)(((byte)(35)))));
            this.SortButton.FlatAppearance.BorderSize = 2;
            this.SortButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SortButton.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SortButton.Location = new System.Drawing.Point(354, 272);
            this.SortButton.Name = "SortButton";
            this.SortButton.Size = new System.Drawing.Size(145, 41);
            this.SortButton.TabIndex = 6;
            this.SortButton.Text = "Сортировка";
            this.SortButton.UseVisualStyleBackColor = false;
            this.SortButton.Click += new System.EventHandler(this.SortButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(175)))), ((int)(((byte)(41)))));
            this.label7.Location = new System.Drawing.Point(654, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(218, 23);
            this.label7.TabIndex = 2;
            this.label7.Text = "Отсортированный массив";
            // 
            // OtsortTB
            // 
            this.OtsortTB.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OtsortTB.Location = new System.Drawing.Point(658, 156);
            this.OtsortTB.Multiline = true;
            this.OtsortTB.Name = "OtsortTB";
            this.OtsortTB.ReadOnly = true;
            this.OtsortTB.Size = new System.Drawing.Size(249, 95);
            this.OtsortTB.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OP_k_WF.Properties.Resources.ezgif_com_gif_maker__2_;
            this.pictureBox1.Location = new System.Drawing.Point(216, 396);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(568, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(175)))), ((int)(((byte)(41)))));
            this.label3.Location = new System.Drawing.Point(334, 363);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(340, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "GIF-анимация как работает Гномья сортировка";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(175)))), ((int)(((byte)(41)))));
            this.label6.Location = new System.Drawing.Point(297, 508);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(404, 19);
            this.label6.TabIndex = 8;
            this.label6.Text = "Для скриншота окна сортировки нажмите на эту кнопку";
            // 
            // ScrButton
            // 
            this.ScrButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(175)))), ((int)(((byte)(41)))));
            this.ScrButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(142)))), ((int)(((byte)(35)))));
            this.ScrButton.FlatAppearance.BorderSize = 2;
            this.ScrButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ScrButton.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ScrButton.Location = new System.Drawing.Point(384, 464);
            this.ScrButton.Name = "ScrButton";
            this.ScrButton.Size = new System.Drawing.Size(219, 41);
            this.ScrButton.TabIndex = 6;
            this.ScrButton.Text = "Сфоткать гномика";
            this.ScrButton.UseVisualStyleBackColor = false;
            this.ScrButton.Click += new System.EventHandler(this.ScrButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(175)))), ((int)(((byte)(41)))));
            this.label8.Location = new System.Drawing.Point(73, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 23);
            this.label8.TabIndex = 2;
            this.label8.Text = "Введите числа";
            // 
            // EnterUserMasButtton
            // 
            this.EnterUserMasButtton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(175)))), ((int)(((byte)(41)))));
            this.EnterUserMasButtton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(142)))), ((int)(((byte)(35)))));
            this.EnterUserMasButtton.FlatAppearance.BorderSize = 2;
            this.EnterUserMasButtton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EnterUserMasButtton.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnterUserMasButtton.Location = new System.Drawing.Point(77, 238);
            this.EnterUserMasButtton.Name = "EnterUserMasButtton";
            this.EnterUserMasButtton.Size = new System.Drawing.Size(75, 28);
            this.EnterUserMasButtton.TabIndex = 9;
            this.EnterUserMasButtton.Text = "Ввести";
            this.EnterUserMasButtton.UseVisualStyleBackColor = false;
            this.EnterUserMasButtton.Click += new System.EventHandler(this.EnterUserMasButtton_Click);
            // 
            // UserNumbersTB
            // 
            this.UserNumbersTB.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserNumbersTB.Location = new System.Drawing.Point(77, 204);
            this.UserNumbersTB.Multiline = true;
            this.UserNumbersTB.Name = "UserNumbersTB";
            this.UserNumbersTB.Size = new System.Drawing.Size(226, 28);
            this.UserNumbersTB.TabIndex = 10;
            this.UserNumbersTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UserNumbersTB_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(175)))), ((int)(((byte)(41)))));
            this.label9.Location = new System.Drawing.Point(73, 163);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(211, 19);
            this.label9.TabIndex = 2;
            this.label9.Text = "(ручной ввод массива чисел)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(175)))), ((int)(((byte)(41)))));
            this.label2.Location = new System.Drawing.Point(73, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "ЧЕРЕЗ ПРОБЕЛ!";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(91)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(981, 544);
            this.Controls.Add(this.UserNumbersTB);
            this.Controls.Add(this.EnterUserMasButtton);
            this.Controls.Add(this.ScrButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SortButton);
            this.Controls.Add(this.OtsortTB);
            this.Controls.Add(this.NeotsortTB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NeotsortTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button SortButton;
        private System.Windows.Forms.Label ExitXs;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox OtsortTB;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ScrButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button EnterUserMasButtton;
        private System.Windows.Forms.TextBox UserNumbersTB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
    }
}