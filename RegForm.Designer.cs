namespace OP_k_WF
{
    partial class RegForm
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
            this.ExitXr = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LoginFieldr = new System.Windows.Forms.TextBox();
            this.PasswordFieldr = new System.Windows.Forms.TextBox();
            this.NameFieldr = new System.Windows.Forms.TextBox();
            this.SurnameFieldr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.RegaButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(175)))), ((int)(((byte)(41)))));
            this.panel1.Controls.Add(this.ExitXr);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(606, 95);
            this.panel1.TabIndex = 0;
            // 
            // ExitXr
            // 
            this.ExitXr.AutoSize = true;
            this.ExitXr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitXr.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitXr.Location = new System.Drawing.Point(578, 0);
            this.ExitXr.Name = "ExitXr";
            this.ExitXr.Size = new System.Drawing.Size(28, 29);
            this.ExitXr.TabIndex = 1;
            this.ExitXr.Text = "X";
            this.ExitXr.Click += new System.EventHandler(this.ExitXr_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Corbel", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(606, 95);
            this.label1.TabIndex = 0;
            this.label1.Text = "Регистрация";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            // 
            // LoginFieldr
            // 
            this.LoginFieldr.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginFieldr.Location = new System.Drawing.Point(79, 174);
            this.LoginFieldr.Multiline = true;
            this.LoginFieldr.Name = "LoginFieldr";
            this.LoginFieldr.Size = new System.Drawing.Size(175, 29);
            this.LoginFieldr.TabIndex = 1;
            this.LoginFieldr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LoginFieldr_KeyPress);
            // 
            // PasswordFieldr
            // 
            this.PasswordFieldr.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordFieldr.Location = new System.Drawing.Point(79, 294);
            this.PasswordFieldr.Name = "PasswordFieldr";
            this.PasswordFieldr.Size = new System.Drawing.Size(175, 31);
            this.PasswordFieldr.TabIndex = 2;
            this.PasswordFieldr.UseSystemPasswordChar = true;
            this.PasswordFieldr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PasswordFieldr_KeyPress);
            // 
            // NameFieldr
            // 
            this.NameFieldr.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameFieldr.Location = new System.Drawing.Point(365, 174);
            this.NameFieldr.Multiline = true;
            this.NameFieldr.Name = "NameFieldr";
            this.NameFieldr.Size = new System.Drawing.Size(181, 29);
            this.NameFieldr.TabIndex = 3;
            this.NameFieldr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NameFieldr_KeyPress);
            // 
            // SurnameFieldr
            // 
            this.SurnameFieldr.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SurnameFieldr.Location = new System.Drawing.Point(365, 293);
            this.SurnameFieldr.Multiline = true;
            this.SurnameFieldr.Name = "SurnameFieldr";
            this.SurnameFieldr.Size = new System.Drawing.Size(181, 28);
            this.SurnameFieldr.TabIndex = 4;
            this.SurnameFieldr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SurnameFieldr_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(175)))), ((int)(((byte)(41)))));
            this.label2.Location = new System.Drawing.Point(78, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Логин";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(175)))), ((int)(((byte)(41)))));
            this.label3.Location = new System.Drawing.Point(78, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Пароль";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(175)))), ((int)(((byte)(41)))));
            this.label4.Location = new System.Drawing.Point(364, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Имя";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(175)))), ((int)(((byte)(41)))));
            this.label5.Location = new System.Drawing.Point(364, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "Фамилия";
            // 
            // RegaButton
            // 
            this.RegaButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(175)))), ((int)(((byte)(41)))));
            this.RegaButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegaButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(142)))), ((int)(((byte)(35)))));
            this.RegaButton.FlatAppearance.BorderSize = 2;
            this.RegaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegaButton.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegaButton.Location = new System.Drawing.Point(217, 362);
            this.RegaButton.Name = "RegaButton";
            this.RegaButton.Size = new System.Drawing.Size(193, 42);
            this.RegaButton.TabIndex = 9;
            this.RegaButton.Text = "Зарегистрироваться";
            this.RegaButton.UseVisualStyleBackColor = false;
            this.RegaButton.Click += new System.EventHandler(this.RegaButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(175)))), ((int)(((byte)(41)))));
            this.label6.Location = new System.Drawing.Point(534, 419);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 23);
            this.label6.TabIndex = 8;
            this.label6.Text = "Назад";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // RegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(91)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(606, 451);
            this.Controls.Add(this.RegaButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SurnameFieldr);
            this.Controls.Add(this.NameFieldr);
            this.Controls.Add(this.PasswordFieldr);
            this.Controls.Add(this.LoginFieldr);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegForm";
            this.Text = "RegForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RegForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RegForm_MouseMove);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ExitXr;
        private System.Windows.Forms.TextBox LoginFieldr;
        private System.Windows.Forms.TextBox PasswordFieldr;
        private System.Windows.Forms.TextBox NameFieldr;
        private System.Windows.Forms.TextBox SurnameFieldr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button RegaButton;
        private System.Windows.Forms.Label label6;
    }
}