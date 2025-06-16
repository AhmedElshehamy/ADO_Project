namespace Ecommerce.PresentationLayer
{
    partial class EditCategory
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
            btn_del = new Button();
            btn_update = new Button();
            btn_add = new Button();
            cat_text = new TextBox();
            label2 = new Label();
            label1 = new Label();
            dgv_category = new DataGridView();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_category).BeginInit();
            SuspendLayout();
            // 
            // btn_del
            // 
            btn_del.Location = new Point(656, 138);
            btn_del.Name = "btn_del";
            btn_del.Size = new Size(75, 23);
            btn_del.TabIndex = 43;
            btn_del.Text = "Delete";
            btn_del.UseVisualStyleBackColor = true;
            btn_del.Click += btn_del_Click;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(505, 138);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(75, 23);
            btn_update.TabIndex = 42;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(333, 138);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(75, 23);
            btn_add.TabIndex = 41;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // cat_text
            // 
            cat_text.Location = new Point(107, 73);
            cat_text.Name = "cat_text";
            cat_text.Size = new Size(120, 23);
            cat_text.TabIndex = 38;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 76);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 37;
            label2.Text = "Category Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(323, 23);
            label1.Name = "label1";
            label1.Size = new Size(178, 37);
            label1.TabIndex = 36;
            label1.Text = "Edit Category";
            // 
            // dgv_category
            // 
            dgv_category.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_category.Location = new Point(208, 179);
            dgv_category.Name = "dgv_category";
            dgv_category.Size = new Size(575, 248);
            dgv_category.TabIndex = 35;
            dgv_category.RowHeaderMouseDoubleClick += dgv_category_RowHeaderMouseDoubleClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 18);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 44;
            label3.Text = " Back > ";
            label3.Click += label3_Click;
            // 
            // EditCategory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(btn_del);
            Controls.Add(btn_update);
            Controls.Add(btn_add);
            Controls.Add(cat_text);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgv_category);
            Name = "EditCategory";
            Text = "EditCategorycs";
            Load += EditCategory_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_category).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_del;
        private Button btn_update;
        private Button btn_add;
        private TextBox cat_text;
        private Label label2;
        private Label label1;
        private DataGridView dgv_category;
        private Label label3;
    }
}