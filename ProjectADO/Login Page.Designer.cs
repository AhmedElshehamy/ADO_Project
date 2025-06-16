namespace Ecommerce.PresentationLayer
{
    partial class Login_Page
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
            label1 = new Label();
            label2 = new Label();
            nameLoginPage_Text = new TextBox();
            password_LoginPage = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            Login_btn = new Button();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.System;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(361, 25);
            label1.Name = "label1";
            label1.Size = new Size(84, 37);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(490, 133);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // nameLoginPage_Text
            // 
            nameLoginPage_Text.Location = new Point(588, 130);
            nameLoginPage_Text.Name = "nameLoginPage_Text";
            nameLoginPage_Text.Size = new Size(124, 23);
            nameLoginPage_Text.TabIndex = 2;
            // 
            // password_LoginPage
            // 
            password_LoginPage.Location = new Point(588, 188);
            password_LoginPage.Name = "password_LoginPage";
            password_LoginPage.Size = new Size(124, 23);
            password_LoginPage.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(490, 191);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(486, 294);
            label4.Name = "label4";
            label4.Size = new Size(153, 25);
            label4.TabIndex = 5;
            label4.Text = "Not a Member ? ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F);
            label5.ForeColor = SystemColors.HotTrack;
            label5.Location = new Point(645, 294);
            label5.Name = "label5";
            label5.Size = new Size(81, 25);
            label5.TabIndex = 6;
            label5.Text = "Sign_Up";
            label5.Click += label5_Click;
            // 
            // Login_btn
            // 
            Login_btn.Location = new Point(588, 238);
            Login_btn.Name = "Login_btn";
            Login_btn.Size = new Size(130, 33);
            Login_btn.TabIndex = 7;
            Login_btn.Text = "Login";
            Login_btn.UseVisualStyleBackColor = true;
            Login_btn.Click += Login_btn_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(657, 217);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(55, 19);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "Show";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Login_Page
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(checkBox1);
            Controls.Add(Login_btn);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(password_LoginPage);
            Controls.Add(label3);
            Controls.Add(nameLoginPage_Text);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Login_Page";
            Text = "Login_Page";
            Load += Login_Page_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox nameLoginPage_Text;
        private TextBox password_LoginPage;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button Login_btn;
        private CheckBox checkBox1;
    }
}