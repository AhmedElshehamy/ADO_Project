namespace Ecommerce.PresentationLayer
{
    partial class Register_Page
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
            name_text = new TextBox();
            email_text = new TextBox();
            label3 = new Label();
            pass_text = new TextBox();
            label4 = new Label();
            add_text = new TextBox();
            label5 = new Label();
            label6 = new Label();
            age_Value = new NumericUpDown();
            register_btn = new Button();
            label7 = new Label();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)age_Value).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Pixel);
            label1.Location = new Point(263, 9);
            label1.Name = "label1";
            label1.Size = new Size(198, 41);
            label1.TabIndex = 0;
            label1.Text = "Register Page";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(266, 97);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // name_text
            // 
            name_text.Location = new Point(399, 94);
            name_text.Name = "name_text";
            name_text.Size = new Size(120, 23);
            name_text.TabIndex = 2;
            // 
            // email_text
            // 
            email_text.Location = new Point(399, 205);
            email_text.Name = "email_text";
            email_text.Size = new Size(120, 23);
            email_text.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(576, 102);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 3;
            label3.Text = "Age";
            // 
            // pass_text
            // 
            pass_text.Location = new Point(399, 146);
            pass_text.Name = "pass_text";
            pass_text.Size = new Size(120, 23);
            pass_text.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(266, 154);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 5;
            label4.Text = "Password";
            // 
            // add_text
            // 
            add_text.Location = new Point(668, 151);
            add_text.Name = "add_text";
            add_text.Size = new Size(120, 23);
            add_text.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(576, 154);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 7;
            label5.Text = "Address";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(266, 205);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 9;
            label6.Text = "Email";
            // 
            // age_Value
            // 
            age_Value.Location = new Point(668, 97);
            age_Value.Name = "age_Value";
            age_Value.Size = new Size(120, 23);
            age_Value.TabIndex = 10;
            // 
            // register_btn
            // 
            register_btn.Location = new Point(655, 205);
            register_btn.Name = "register_btn";
            register_btn.Size = new Size(133, 32);
            register_btn.TabIndex = 11;
            register_btn.Text = "Sign_Up";
            register_btn.UseVisualStyleBackColor = true;
            register_btn.Click += register_btn_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            label7.Location = new Point(576, 272);
            label7.Name = "label7";
            label7.Size = new Size(123, 19);
            label7.TabIndex = 12;
            label7.Text = "Have an Account ?";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            label8.ForeColor = SystemColors.HotTrack;
            label8.Location = new Point(705, 272);
            label8.Name = "label8";
            label8.Size = new Size(86, 21);
            label8.TabIndex = 13;
            label8.Text = "Login Here";
            label8.Click += label8_Click;
            // 
            // Register_Page
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(register_btn);
            Controls.Add(age_Value);
            Controls.Add(label6);
            Controls.Add(add_text);
            Controls.Add(label5);
            Controls.Add(pass_text);
            Controls.Add(label4);
            Controls.Add(email_text);
            Controls.Add(label3);
            Controls.Add(name_text);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Register_Page";
            Text = "Register_Page";
            ((System.ComponentModel.ISupportInitialize)age_Value).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox name_text;
        private TextBox email_text;
        private Label label3;
        private TextBox pass_text;
        private Label label4;
        private TextBox add_text;
        private Label label5;
        private Label label6;
        private NumericUpDown age_Value;
        private Button register_btn;
        private Label label7;
        private Label label8;
    }
}