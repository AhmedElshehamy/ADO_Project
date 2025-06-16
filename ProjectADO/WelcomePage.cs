using System.Configuration;
using Ecommerce.BusienessLogic;
using Ecommerce.PresentationLayer;

namespace ProjectADO
{
    public partial class WelcomePage : Form
    {
        User user;
        public WelcomePage()
        {
            InitializeComponent();
            user = new User(ConfigurationManager.ConnectionStrings["Ecommerce"].ConnectionString);

        }

        private void btn_Reg_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register_Page register_Page = new Register_Page();
            register_Page.Show();


        }

        private void btn_log_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Login_Page login_Page = new Login_Page();
            login_Page.Show();
        }
    }
}
