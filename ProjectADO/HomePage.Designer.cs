namespace Ecommerce.PresentationLayer
{
    partial class HomePage
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
            label2 = new Label();
            v_btn = new Button();
            btn_favorites = new Button();
            mProfile_btn = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.Location = new Point(262, 9);
            label2.Name = "label2";
            label2.Size = new Size(225, 37);
            label2.TabIndex = 1;
            label2.Text = "Ecommerce Chart";
            // 
            // v_btn
            // 
            v_btn.Font = new Font("Segoe UI", 14F);
            v_btn.Location = new Point(150, 186);
            v_btn.Name = "v_btn";
            v_btn.Size = new Size(166, 61);
            v_btn.TabIndex = 2;
            v_btn.Text = "View Product";
            v_btn.UseVisualStyleBackColor = true;
            v_btn.Click += v_btn_Click;
            // 
            // btn_favorites
            // 
            btn_favorites.AccessibleRole = AccessibleRole.ScrollBar;
            btn_favorites.Font = new Font("Segoe UI", 14F);
            btn_favorites.Location = new Point(460, 186);
            btn_favorites.Name = "btn_favorites";
            btn_favorites.Size = new Size(170, 61);
            btn_favorites.TabIndex = 3;
            btn_favorites.Text = "View Favorites";
            btn_favorites.UseVisualStyleBackColor = true;
            btn_favorites.Click += btn_favorites_Click;
            // 
            // mProfile_btn
            // 
            mProfile_btn.Font = new Font("Segoe UI", 14F);
            mProfile_btn.Location = new Point(282, 299);
            mProfile_btn.Name = "mProfile_btn";
            mProfile_btn.Size = new Size(166, 61);
            mProfile_btn.TabIndex = 4;
            mProfile_btn.Text = "Mange Profile";
            mProfile_btn.UseVisualStyleBackColor = true;
            mProfile_btn.Click += mProfile_btn_Click;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(mProfile_btn);
            Controls.Add(btn_favorites);
            Controls.Add(v_btn);
            Controls.Add(label2);
            Name = "HomePage";
            Text = "HomePage";
            Load += HomePage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Button v_btn;
        private Button btn_favorites;
        private Button mProfile_btn;
    }
}