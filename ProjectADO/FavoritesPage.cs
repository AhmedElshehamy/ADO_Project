using System.Configuration;
using System.Data;
using Ecommerce.BusienessLogic;

namespace Ecommerce.PresentationLayer
{
    public partial class FavoritesPage : Form
    {
        Favorites favorites;
        DataTable userData;
        public FavoritesPage(DataTable user)
        {
            InitializeComponent();
            favorites = new Favorites(ConfigurationManager.ConnectionStrings["Ecommerce"].ConnectionString);
            userData = user;
        }
        int userID;
        private void FavoritesPage_Load(object sender, EventArgs e)
        {
            userID = Convert.ToInt32(userData.Rows[0]["UserId"]);
            dgv_Fav.DataSource = favorites.getFavProduct(userID);
        }
        int productId;
        private void dgv_Fav_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string selectedProductName = dgv_Fav.Rows[e.RowIndex].Cells["ProductName"].Value.ToString();
            productId = favorites.getFavProductByName(selectedProductName);
            //label2.Text = productId.ToString();
        }


        private void remove_fav_Click(object sender, EventArgs e)
        {

            if (favorites.removeProductFromFav(userID, productId) > 0)
            {
                MessageBox.Show("This Product Is Remove From Fav");
            }
            dgv_Fav.DataSource = favorites.getFavProduct(userID);

        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage homePage = new HomePage(userData);
            homePage.Show();
        }
    }
}
