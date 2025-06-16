using System.Configuration;
using System.Data;
using Ecommerce.BusienessLogic;

namespace Ecommerce.PresentationLayer
{
    public partial class HomePage : Form
    {
        Product product;
        Favorites favorites;
        DataTable userData;
        public HomePage(DataTable user)
        {
            InitializeComponent();
            product = new Product(ConfigurationManager.ConnectionStrings["Ecommerce"].ConnectionString);
            userData = user;
            favorites = new Favorites(ConfigurationManager.ConnectionStrings["Ecommerce"].ConnectionString);
        }


        private void v_btn_Click(object sender, EventArgs e)
        {
            Login_Page login_Page = new Login_Page();

            this.Hide();
            ProductPage productPage = new ProductPage(userData);
            productPage.Show();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            //label2.Text = userData.Rows[0]["Username"].ToString();
        }

        private void btn_favorites_Click(object sender, EventArgs e)
        {
            this.Hide();
            FavoritesPage favoritesPage = new FavoritesPage(userData);
            favoritesPage.Show();
        }

        private void mProfile_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditProfile editProfile = new EditProfile(userData);
            editProfile.Show();
        }
    }
}
