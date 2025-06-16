using System.Configuration;
using System.Data;
using Ecommerce.BusienessLogic;

namespace Ecommerce.PresentationLayer
{
    public partial class Login_Page : Form
    {
        User user;
        DataTable userData;
        public Login_Page()
        {
            InitializeComponent();
            user = new User(ConfigurationManager.ConnectionStrings["Ecommerce"].ConnectionString);

        }

        private void Login_Page_Load(object sender, EventArgs e)
        {
            password_LoginPage.UseSystemPasswordChar = true;
        }
        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register_Page register_Page = new Register_Page();
            register_Page.Show();
        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
            string name = nameLoginPage_Text.Text;
            string password = password_LoginPage.Text;

            if (name == string.Empty || password == string.Empty)
            {
                MessageBox.Show("Must Fill This Fields");
            }

            if (user.GetUserLogin(name, password) == true)
            {
                userData = user.GetAutUser(name, password);
                this.Hide();
                //MessageBox.Show(userData.Rows[0]["Username"].ToString());
                HomePage homePage = new HomePage(userData);
                homePage.Show();

            }
            else if (user.GetAdminLogin(name, password) == true)
            {
                this.Hide();
                AdminDashboard adminDashboard = new AdminDashboard();
                adminDashboard.Show();
            }
            else
            {
                MessageBox.Show("Invalid User Name Or Password");
            }



        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox1.Checked)
            {
                password_LoginPage.UseSystemPasswordChar = false;
            }
            else
            {
                password_LoginPage.UseSystemPasswordChar = true;
            }
        }


    }
}
