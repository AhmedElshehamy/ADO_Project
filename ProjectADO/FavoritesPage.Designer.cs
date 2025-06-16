namespace Ecommerce.PresentationLayer
{
    partial class FavoritesPage
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
            dgv_Fav = new DataGridView();
            label1 = new Label();
            remove_fav = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_Fav).BeginInit();
            SuspendLayout();
            // 
            // dgv_Fav
            // 
            dgv_Fav.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Fav.Location = new Point(175, 189);
            dgv_Fav.Name = "dgv_Fav";
            dgv_Fav.Size = new Size(594, 228);
            dgv_Fav.TabIndex = 0;
            dgv_Fav.RowHeaderMouseDoubleClick += dgv_Fav_RowHeaderMouseDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(278, 24);
            label1.Name = "label1";
            label1.Size = new Size(194, 37);
            label1.TabIndex = 1;
            label1.Text = "Favorites  Page";
            // 
            // remove_fav
            // 
            remove_fav.Location = new Point(12, 189);
            remove_fav.Name = "remove_fav";
            remove_fav.Size = new Size(105, 36);
            remove_fav.TabIndex = 2;
            remove_fav.Text = "Remove";
            remove_fav.UseVisualStyleBackColor = true;
            remove_fav.Click += remove_fav_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 9);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 3;
            label2.Text = "Back >";
            label2.Click += label2_Click;
            // 
            // FavoritesPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(remove_fav);
            Controls.Add(label1);
            Controls.Add(dgv_Fav);
            Name = "FavoritesPage";
            Text = "FavoritesPage";
            Load += FavoritesPage_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_Fav).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_Fav;
        private Label label1;
        private Button remove_fav;
        private Label label2;
    }
}