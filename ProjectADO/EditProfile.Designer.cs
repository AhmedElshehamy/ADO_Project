namespace Ecommerce.PresentationLayer
{
    partial class EditProfile
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
            name_text = new TextBox();
            Email_text = new TextBox();
            label2 = new Label();
            label3 = new Label();
            Address_Text = new TextBox();
            label4 = new Label();
            update_profile = new Button();
            btn_password = new Button();
            age_upDowun = new NumericUpDown();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)age_upDowun).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(485, 51);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // name_text
            // 
            name_text.Location = new Point(597, 48);
            name_text.Name = "name_text";
            name_text.Size = new Size(120, 23);
            name_text.TabIndex = 1;
            // 
            // Email_text
            // 
            Email_text.Location = new Point(597, 104);
            Email_text.Name = "Email_text";
            Email_text.Size = new Size(120, 23);
            Email_text.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(485, 107);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 2;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(485, 163);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 4;
            label3.Text = "Age";
            // 
            // Address_Text
            // 
            Address_Text.Location = new Point(597, 213);
            Address_Text.Name = "Address_Text";
            Address_Text.Size = new Size(120, 23);
            Address_Text.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(485, 216);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 6;
            label4.Text = "Address";
            // 
            // update_profile
            // 
            update_profile.Location = new Point(669, 288);
            update_profile.Name = "update_profile";
            update_profile.Size = new Size(119, 23);
            update_profile.TabIndex = 8;
            update_profile.Text = "Save Changes";
            update_profile.UseVisualStyleBackColor = true;
            update_profile.Click += update_profile_Click;
            // 
            // btn_password
            // 
            btn_password.Location = new Point(485, 288);
            btn_password.Name = "btn_password";
            btn_password.Size = new Size(125, 23);
            btn_password.TabIndex = 9;
            btn_password.Text = "Update Password";
            btn_password.UseVisualStyleBackColor = true;
            btn_password.Click += btn_password_Click;
            // 
            // age_upDowun
            // 
            age_upDowun.Location = new Point(597, 161);
            age_upDowun.Name = "age_upDowun";
            age_upDowun.Size = new Size(120, 23);
            age_upDowun.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(40, 21);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 11;
            label5.Text = "Back >";
            label5.Click += label5_Click;
            // 
            // EditProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(age_upDowun);
            Controls.Add(btn_password);
            Controls.Add(update_profile);
            Controls.Add(Address_Text);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(Email_text);
            Controls.Add(label2);
            Controls.Add(name_text);
            Controls.Add(label1);
            Name = "EditProfile";
            Text = "EditProfile";
            Load += EditProfile_Load_1;
            ((System.ComponentModel.ISupportInitialize)age_upDowun).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox name_text;
        private TextBox Email_text;
        private Label label2;
        private Label label3;
        private TextBox Address_Text;
        private Label label4;
        private Button update_profile;
        private Button btn_password;
        private NumericUpDown age_upDowun;
        private Label label5;
    }
}