using System.Configuration;
using System.Data;
using Ecommerce.BusienessLogic;

namespace Ecommerce.PresentationLayer
{
    public partial class ProductPage : Form
    {
        Product product;
        Favorites favorites;
        DataTable userData;
        public ProductPage(DataTable user)
        {
            InitializeComponent();
            product = new Product(ConfigurationManager.ConnectionStrings["Ecommerce"].ConnectionString);
            favorites = new Favorites(ConfigurationManager.ConnectionStrings["Ecommerce"].ConnectionString);
            userData = user;
        }

        private void ProductPage_Load(object sender, EventArgs e)
        {
            dgv_product.DataSource = product.GetProductData();
            //label1.Text = userData.Rows[0]["UserId"].ToString();
        }
        int id;
        private void dgv_product_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgv_product.Rows.Count > 0)
            {
                id = (int)dgv_product.SelectedRows[0].Cells[0].Value;
            }
        }

        private void add_fav_btn_Click(object sender, EventArgs e)
        {
            int userID = Convert.ToInt32(userData.Rows[0]["UserId"]);
            int rowAffected = favorites.AddProductToFavorite(userID, id);
            if (rowAffected > 0)
            {
                MessageBox.Show("This Product Is Inserted To Favorites Age");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage homePage = new HomePage(userData);
            homePage.Show();
        }
    }
}
