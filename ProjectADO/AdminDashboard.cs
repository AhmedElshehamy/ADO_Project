using System.Configuration;
using Ecommerce.BusienessLogic;

namespace Ecommerce.PresentationLayer
{
    public partial class AdminDashboard : Form
    {
        User user;
        Product product;
        Category category;
        public AdminDashboard()
        {
            InitializeComponent();
            user = new User(ConfigurationManager.ConnectionStrings["Ecommerce"].ConnectionString);
            product = new Product(ConfigurationManager.ConnectionStrings["Ecommerce"].ConnectionString);
            category = new Category(ConfigurationManager.ConnectionStrings["Ecommerce"].ConnectionString);

        }



        private void btn_user_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditUser editUser = new EditUser();
            editUser.Show();
        }


        private void btn_product_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditProduct editProduct = new EditProduct();
            editProduct.Show();
        }

        private void btn_Cat_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditCategory editCategory = new EditCategory();
            editCategory.Show();
        }


    }
}
