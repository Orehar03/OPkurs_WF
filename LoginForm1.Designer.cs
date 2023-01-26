namespace OP_k_WF
{
    partial class LoginForm1
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
            this.EnterButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PassField = new System.Windows.Forms.TextBox();
            this.LoginField = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ExitX = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelReg = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // EnterButton
            // 
            this.EnterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(175)))), ((int)(((byte)(41)))));
            this.EnterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EnterButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(142)))), ((int)(((byte)(35)))));
            this.EnterButton.FlatAppearance.BorderSize = 2;
            this.EnterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EnterButton.Font = new System.Drawing.Font("Corbel", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnterButton.Location = new System.Drawing.Point(130, 405);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(124, 45);
            this.EnterButton.TabIndex = 9;
            this.EnterButton.Text = "Войти";
            this.EnterButton.UseVisualStyleBackColor = false;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(175)))), ((int)(((byte)(41)))));
            this.label3.Location = new System.Drawing.Point(60, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 27);
            this.label3.TabIndex = 7;
            this.label3.Text = "Пароль";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(175)))), ((int)(((byte)(41)))));
            this.label2.Location = new System.Drawing.Point(65, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 27);
            this.label2.TabIndex = 8;
            this.label2.Text = "Логин";
            // 
            // PassField
            // 
            this.PassField.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PassField.Location = new System.Drawing.Point(65, 321);
            this.PassField.Name = "PassField";
            this.PassField.Size = new System.Drawing.Size(252, 30);
            this.PassField.TabIndex = 5;
            this.PassField.UseSystemPasswordChar = true;
            this.PassField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PassField_KeyPress_1);
            // 
            // LoginField
            // 
            this.LoginField.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginField.Location = new System.Drawing.Point(65, 196);
            this.LoginField.Multiline = true;
            this.LoginField.Name = "LoginField";
            this.LoginField.Size = new System.Drawing.Size(252, 35);
            this.LoginField.TabIndex = 6;
            this.LoginField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LoginField_KeyPress);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(175)))), ((int)(((byte)(41)))));
            this.panel2.Controls.Add(this.ExitX);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(388, 85);
            this.panel2.TabIndex = 4;
            // 
            // ExitX
            // 
            this.ExitX.AutoSize = true;
            this.ExitX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitX.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitX.Location = new System.Drawing.Point(364, 0);
            this.ExitX.Name = "ExitX";
            this.ExitX.Size = new System.Drawing.Size(25, 26);
            this.ExitX.TabIndex = 11;
            this.ExitX.Text = "X";
            this.ExitX.Click += new System.EventHandler(this.ExitX_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Corbel", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 85);
            this.label1.TabIndex = 0;
            this.label1.Text = "АВТОРИЗАЦИЯ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            // 
            // LabelReg
            // 
            this.LabelReg.AutoSize = true;
            this.LabelReg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelReg.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelReg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(175)))), ((int)(((byte)(41)))));
            this.LabelReg.Location = new System.Drawing.Point(143, 464);
            this.LabelReg.Name = "LabelReg";
            this.LabelReg.Size = new System.Drawing.Size(98, 19);
            this.LabelReg.TabIndex = 10;
            this.LabelReg.Text = "Регистрация";
            this.LabelReg.Click += new System.EventHandler(this.LabelReg_Click);
            // 
            // LoginForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(91)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(388, 505);
            this.Controls.Add(this.LabelReg);
            this.Controls.Add(this.EnterButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PassField);
            this.Controls.Add(this.LoginField);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm1";
            this.Text = "LoginForm1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LoginForm1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LoginForm1_MouseMove);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EnterButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PassField;
        private System.Windows.Forms.TextBox LoginField;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelReg;
        private System.Windows.Forms.Label ExitX;
    }
}