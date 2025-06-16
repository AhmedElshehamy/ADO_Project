namespace Ecommerce.PresentationLayer
{
    partial class EditPassword
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
            oldPassword_text = new TextBox();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            newPassword_text = new TextBox();
            label2 = new Label();
            checkBox3 = new CheckBox();
            confirmPassword_text = new TextBox();
            label3 = new Label();
            btn_changePassword = new Button();
            btn_clear = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(523, 37);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 0;
            label1.Text = "Old Password";
            // 
            // oldPassword_text
            // 
            oldPassword_text.Location = new Point(640, 34);
            oldPassword_text.Name = "oldPassword_text";
            oldPassword_text.Size = new Size(100, 23);
            oldPassword_text.TabIndex = 1;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(685, 63);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(55, 19);
            checkBox1.TabIndex = 2;
            checkBox1.Text = "Show";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(685, 155);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(55, 19);
            checkBox2.TabIndex = 5;
            checkBox2.Text = "Show";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // newPassword_text
            // 
            newPassword_text.Location = new Point(640, 126);
            newPassword_text.Name = "newPassword_text";
            newPassword_text.Size = new Size(100, 23);
            newPassword_text.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(523, 129);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 3;
            label2.Text = "New Password";
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(685, 237);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(55, 19);
            checkBox3.TabIndex = 8;
            checkBox3.Text = "Show";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // confirmPassword_text
            // 
            confirmPassword_text.Location = new Point(640, 208);
            confirmPassword_text.Name = "confirmPassword_text";
            confirmPassword_text.Size = new Size(100, 23);
            confirmPassword_text.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(523, 216);
            label3.Name = "label3";
            label3.Size = new Size(104, 15);
            label3.TabIndex = 6;
            label3.Text = "Confirm Password";
            // 
            // btn_changePassword
            // 
            btn_changePassword.Location = new Point(533, 284);
            btn_changePassword.Name = "btn_changePassword";
            btn_changePassword.Size = new Size(115, 31);
            btn_changePassword.TabIndex = 9;
            btn_changePassword.Text = "Change Password";
            btn_changePassword.UseVisualStyleBackColor = true;
            btn_changePassword.Click += btn_changePassword_Click;
            // 
            // btn_clear
            // 
            btn_clear.Location = new Point(685, 284);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(93, 31);
            btn_clear.TabIndex = 10;
            btn_clear.Text = "Clear";
            btn_clear.UseVisualStyleBackColor = true;
            btn_clear.Click += btn_clear_Click;
            // 
            // EditPassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_clear);
            Controls.Add(btn_changePassword);
            Controls.Add(checkBox3);
            Controls.Add(confirmPassword_text);
            Controls.Add(label3);
            Controls.Add(checkBox2);
            Controls.Add(newPassword_text);
            Controls.Add(label2);
            Controls.Add(checkBox1);
            Controls.Add(oldPassword_text);
            Controls.Add(label1);
            Name = "EditPassword";
            Text = "EditPassword";
            Load += EditPassword_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox oldPassword_text;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private TextBox newPassword_text;
        private Label label2;
        private CheckBox checkBox3;
        private TextBox confirmPassword_text;
        private Label label3;
        private Button btn_changePassword;
        private Button btn_clear;
    }
}