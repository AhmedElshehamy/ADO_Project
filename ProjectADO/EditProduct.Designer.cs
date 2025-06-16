namespace Ecommerce.PresentationLayer
{
    partial class EditProduct
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
            cb_cat = new ComboBox();
            label7 = new Label();
            btn_del = new Button();
            btn_update = new Button();
            btn_add = new Button();
            price_value = new NumericUpDown();
            label4 = new Label();
            product_text = new TextBox();
            label2 = new Label();
            label1 = new Label();
            dgv_product = new DataGridView();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)price_value).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_product).BeginInit();
            SuspendLayout();
            // 
            // cb_cat
            // 
            cb_cat.FormattingEnabled = true;
            cb_cat.Location = new Point(372, 76);
            cb_cat.Name = "cb_cat";
            cb_cat.Size = new Size(121, 23);
            cb_cat.TabIndex = 34;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(308, 81);
            label7.Name = "label7";
            label7.Size = new Size(55, 15);
            label7.TabIndex = 33;
            label7.Text = "Category";
            // 
            // btn_del
            // 
            btn_del.Location = new Point(664, 138);
            btn_del.Name = "btn_del";
            btn_del.Size = new Size(75, 23);
            btn_del.TabIndex = 32;
            btn_del.Text = "Delete";
            btn_del.UseVisualStyleBackColor = true;
            btn_del.Click += btn_del_Click;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(513, 138);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(75, 23);
            btn_update.TabIndex = 31;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(341, 138);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(75, 23);
            btn_add.TabIndex = 30;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // price_value
            // 
            price_value.Location = new Point(115, 119);
            price_value.Name = "price_value";
            price_value.Size = new Size(120, 23);
            price_value.TabIndex = 29;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 118);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 26;
            label4.Text = "Price";
            // 
            // product_text
            // 
            product_text.Location = new Point(115, 73);
            product_text.Name = "product_text";
            product_text.Size = new Size(120, 23);
            product_text.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 76);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 22;
            label2.Text = "Product Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(331, 23);
            label1.Name = "label1";
            label1.Size = new Size(162, 37);
            label1.TabIndex = 21;
            label1.Text = "Edit Product";
            // 
            // dgv_product
            // 
            dgv_product.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_product.Location = new Point(216, 179);
            dgv_product.Name = "dgv_product";
            dgv_product.Size = new Size(575, 248);
            dgv_product.TabIndex = 20;
            dgv_product.RowHeaderMouseDoubleClick += dgv_product_RowHeaderMouseDoubleClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 9);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 35;
            label3.Text = "Back >";
            label3.Click += label3_Click;
            // 
            // EditProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(cb_cat);
            Controls.Add(label7);
            Controls.Add(btn_del);
            Controls.Add(btn_update);
            Controls.Add(btn_add);
            Controls.Add(price_value);
            Controls.Add(label4);
            Controls.Add(product_text);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgv_product);
            Name = "EditProduct";
            Text = "EditProduct";
            Load += EditProduct_Load;
            ((System.ComponentModel.ISupportInitialize)price_value).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_product).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cb_cat;
        private Label label7;
        private Button btn_del;
        private Button btn_update;
        private Button btn_add;
        private NumericUpDown price_value;
        private Label label4;
        private TextBox product_text;
        private Label label2;
        private Label label1;
        private DataGridView dgv_product;
        private Label label3;
    }
}