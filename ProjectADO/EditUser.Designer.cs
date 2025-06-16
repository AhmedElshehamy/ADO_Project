namespace Ecommerce.PresentationLayer
{
    partial class EditUser
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
            dgv_user = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            user_text = new TextBox();
            address_text = new TextBox();
            label3 = new Label();
            label4 = new Label();
            email_text = new TextBox();
            label5 = new Label();
            age_value = new NumericUpDown();
            btn_add = new Button();
            btn_update = new Button();
            btn_del = new Button();
            cb_role = new ComboBox();
            label7 = new Label();
            password_text = new TextBox();
            label6 = new Label();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_user).BeginInit();
            ((System.ComponentModel.ISupportInitialize)age_value).BeginInit();
            SuspendLayout();
            // 
            // dgv_user
            // 
            dgv_user.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_user.Location = new Point(219, 165);
            dgv_user.Name = "dgv_user";
            dgv_user.Size = new Size(575, 248);
            dgv_user.TabIndex = 0;
            dgv_user.RowHeaderMouseDoubleClick += dgv_user_RowHeaderMouseDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(334, 9);
            label1.Name = "label1";
            label1.Size = new Size(123, 37);
            label1.TabIndex = 1;
            label1.Text = "Edit User";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 59);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 2;
            label2.Text = "User Name";
            // 
            // user_text
            // 
            user_text.Location = new Point(118, 59);
            user_text.Name = "user_text";
            user_text.Size = new Size(120, 23);
            user_text.TabIndex = 3;
            // 
            // address_text
            // 
            address_text.Location = new Point(394, 59);
            address_text.Name = "address_text";
            address_text.Size = new Size(100, 23);
            address_text.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(315, 59);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 4;
            label3.Text = "Address";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 104);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 6;
            label4.Text = "Age";
            // 
            // email_text
            // 
            email_text.Location = new Point(394, 104);
            email_text.Name = "email_text";
            email_text.Size = new Size(100, 23);
            email_text.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(315, 104);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 8;
            label5.Text = "Email";
            // 
            // age_value
            // 
            age_value.Location = new Point(118, 105);
            age_value.Name = "age_value";
            age_value.Size = new Size(120, 23);
            age_value.TabIndex = 11;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(12, 165);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(75, 23);
            btn_add.TabIndex = 13;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(127, 165);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(75, 23);
            btn_update.TabIndex = 14;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // btn_del
            // 
            btn_del.Location = new Point(70, 219);
            btn_del.Name = "btn_del";
            btn_del.Size = new Size(75, 23);
            btn_del.TabIndex = 15;
            btn_del.Text = "Delete";
            btn_del.UseVisualStyleBackColor = true;
            btn_del.Click += btn_del_Click;
            // 
            // cb_role
            // 
            cb_role.FormattingEnabled = true;
            cb_role.Location = new Point(634, 105);
            cb_role.Name = "cb_role";
            cb_role.Size = new Size(121, 23);
            cb_role.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(548, 105);
            label7.Name = "label7";
            label7.Size = new Size(30, 15);
            label7.TabIndex = 16;
            label7.Text = "Role";
            // 
            // password_text
            // 
            password_text.Location = new Point(634, 56);
            password_text.Name = "password_text";
            password_text.Size = new Size(121, 23);
            password_text.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(555, 56);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 18;
            label6.Text = "Password";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(39, 9);
            label8.Name = "label8";
            label8.Size = new Size(43, 15);
            label8.TabIndex = 20;
            label8.Text = "Back >";
            label8.Click += label8_Click;
            // 
            // EditUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label8);
            Controls.Add(password_text);
            Controls.Add(label6);
            Controls.Add(cb_role);
            Controls.Add(label7);
            Controls.Add(btn_del);
            Controls.Add(btn_update);
            Controls.Add(btn_add);
            Controls.Add(age_value);
            Controls.Add(email_text);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(address_text);
            Controls.Add(label3);
            Controls.Add(user_text);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgv_user);
            Name = "EditUser";
            Text = "EditUser";
            Load += EditUser_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_user).EndInit();
            ((System.ComponentModel.ISupportInitialize)age_value).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_user;
        private Label label1;
        private Label label2;
        private TextBox user_text;
        private TextBox address_text;
        private Label label3;
        private Label label4;
        private TextBox email_text;
        private Label label5;
        private NumericUpDown age_value;
        private Button btn_add;
        private Button btn_update;
        private Button btn_del;
        private ComboBox cb_role;
        private Label label7;
        private TextBox password_text;
        private Label label6;
        private Label label8;
    }
}