namespace Ecommerce.PresentationLayer
{
    partial class ProductPage
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
            dgv_product = new DataGridView();
            add_fav_btn = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_product).BeginInit();
            SuspendLayout();
            // 
            // dgv_product
            // 
            dgv_product.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_product.Location = new Point(276, 183);
            dgv_product.Name = "dgv_product";
            dgv_product.Size = new Size(512, 245);
            dgv_product.TabIndex = 0;
            dgv_product.RowHeaderMouseDoubleClick += dgv_product_RowHeaderMouseDoubleClick;
            // 
            // add_fav_btn
            // 
            add_fav_btn.Font = new Font("Segoe UI", 12F);
            add_fav_btn.Location = new Point(12, 183);
            add_fav_btn.Name = "add_fav_btn";
            add_fav_btn.Size = new Size(177, 45);
            add_fav_btn.TabIndex = 1;
            add_fav_btn.Text = "Add To Favorites";
            add_fav_btn.UseVisualStyleBackColor = true;
            add_fav_btn.Click += add_fav_btn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 9);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 2;
            label1.Text = "Back >";
            label1.Click += label1_Click;
            // 
            // ProductPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(add_fav_btn);
            Controls.Add(dgv_product);
            Name = "ProductPage";
            Text = "Product";
            Load += ProductPage_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_product).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_product;
        private Button add_fav_btn;
        private Label label1;
    }
}