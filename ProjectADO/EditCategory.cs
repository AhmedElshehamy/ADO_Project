using System.Configuration;
using Ecommerce.BusienessLogic;

namespace Ecommerce.PresentationLayer
{
    public partial class EditCategory : Form
    {
        Category category;
        public EditCategory()
        {
            InitializeComponent();
            category = new Category(ConfigurationManager.ConnectionStrings["Ecommerce"].ConnectionString);
        }

        private void EditCategory_Load(object sender, EventArgs e)
        {

            btn_del.Hide();
            btn_update.Hide();

            dgv_category.DataSource = category.GetDataCategory();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string categoryName = cat_text.Text;
            if (category.AddCategoryByAdmin(categoryName) > 0)
            {
                MessageBox.Show("Category added successfully!");
                cat_text.Clear();
                dgv_category.DataSource = category.GetDataCategory();
            }
        }
        int id;

        private void dgv_category_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = (int)dgv_category.SelectedRows[0].Cells[0].Value;
            cat_text.Text = dgv_category.Rows[e.RowIndex].Cells["CategoryName"].Value.ToString();
            btn_update.Show();
            btn_del.Show();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (category.EditCategoryByAdmin(id, cat_text.Text) > 0)
            {
                MessageBox.Show("Category updated successfully!", "Success");
                cat_text.Clear();
                dgv_category.DataSource = category.GetDataCategory();
            }
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this category?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {

                if (category.DeleteCategoryByAdmin(id) > 0)
                {
                    MessageBox.Show("Category deleted successfully!");
                    cat_text.Clear();
                    dgv_category.DataSource = category.GetDataCategory();
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminDashboard adminDashboard = new AdminDashboard();
            adminDashboard.Show();
        }
    }
}
