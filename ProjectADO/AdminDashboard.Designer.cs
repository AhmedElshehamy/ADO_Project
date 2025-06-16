namespace Ecommerce.PresentationLayer
{
    partial class AdminDashboard
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
            btn_user = new Button();
            btn_product = new Button();
            btn_Cat = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(297, 28);
            label1.Name = "label1";
            label1.Size = new Size(146, 37);
            label1.TabIndex = 0;
            label1.Text = "DashBoard";
            // 
            // btn_user
            // 
            btn_user.Location = new Point(222, 175);
            btn_user.Name = "btn_user";
            btn_user.Size = new Size(117, 46);
            btn_user.TabIndex = 2;
            btn_user.Text = "User";
            btn_user.UseVisualStyleBackColor = true;
            btn_user.Click += btn_user_Click;
            // 
            // btn_product
            // 
            btn_product.Location = new Point(319, 276);
            btn_product.Name = "btn_product";
            btn_product.Size = new Size(124, 48);
            btn_product.TabIndex = 3;
            btn_product.Text = "Product";
            btn_product.UseVisualStyleBackColor = true;
            btn_product.Click += btn_product_Click;
            // 
            // btn_Cat
            // 
            btn_Cat.Location = new Point(500, 175);
            btn_Cat.Name = "btn_Cat";
            btn_Cat.Size = new Size(111, 46);
            btn_Cat.TabIndex = 4;
            btn_Cat.Text = "Category";
            btn_Cat.UseVisualStyleBackColor = true;
            btn_Cat.Click += btn_Cat_Click;
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_Cat);
            Controls.Add(btn_product);
            Controls.Add(btn_user);
            Controls.Add(label1);
            Name = "AdminDashboard";
            Text = "AdminDashboard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn_user;
        private Button btn_product;
        private Button btn_Cat;
    }
}