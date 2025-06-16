using System.Configuration;
using System.Data;
using Ecommerce.BusienessLogic;

namespace Ecommerce.PresentationLayer
{
    public partial class EditProduct : Form
    {
        Product product;
        Category category;
        public EditProduct()
        {
            InitializeComponent();
            product = new Product(ConfigurationManager.ConnectionStrings["Ecommerce"].ConnectionString);
            category = new Category(ConfigurationManager.ConnectionStrings["Ecommerce"].ConnectionString);
        }

        private void EditProduct_Load(object sender, EventArgs e)
        {
            DataTable dt = category.GetDataCategory();
            cb_cat.DataSource = dt;
            cb_cat.ValueMember = "CategoryId";
            cb_cat.DisplayMember = "CategoryName";

            DataTable dataTable = product.GetProductData();
            dgv_product.DataSource = dataTable;

            btn_del.Hide();
            btn_update.Hide();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            int categoryId = Convert.ToInt32(cb_cat.SelectedValue);
            string productName = product_text.Text;
            int priceValue = (int)price_value.Value;

            if (product.AddProductByAdmin(productName, priceValue, categoryId) > 0)
            {
                MessageBox.Show("Product added successfully!");
                dgv_product.DataSource = product.GetProductData();
            }
        }

        int id;
        private void dgv_product_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            price_value.Minimum = 0;
            price_value.Maximum = 1000000;
            id = (int)dgv_product.SelectedRows[0].Cells[0].Value;
            product_text.Text = dgv_product.Rows[e.RowIndex].Cells["ProductName"].Value.ToString();
            price_value.Value = Convert.ToInt32(dgv_product.Rows[e.RowIndex].Cells["Price"].Value);
            cb_cat.SelectedValue = dgv_product.Rows[e.RowIndex].Cells["CategoryId"].Value;

            btn_update.Show();
            btn_del.Show();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string productName = product_text.Text;
            int price = (int)price_value.Value;
            int categoryId = Convert.ToInt32(cb_cat.SelectedValue);

            if (product.updateProductByAdmin(id, productName, price, categoryId) > 0)
            {
                MessageBox.Show("Product updated successfully!");


                dgv_product.DataSource = product.GetProductData();
            }
            else
            {
                MessageBox.Show("Failed to update product.");
            }

        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this product?", "Confirm Deletion", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (product.deleteProductByAdmin(id) > 0)
                {
                    MessageBox.Show("Product deleted successfully!");


                    dgv_product.DataSource = product.GetProductData();


                    product_text.Text = "";
                    price_value.Value = 0;
                    cb_cat.SelectedIndex = 0;
                    id = 0;
                }
                else
                {
                    MessageBox.Show("Failed to delete product.");
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
