using System.Configuration;
using Ecommerce.BusienessLogic;

namespace Ecommerce.PresentationLayer
{
    public partial class Register_Page : Form
    {
        User user;
        public Register_Page()
        {
            InitializeComponent();
            user = new User(ConfigurationManager.ConnectionStrings["Ecommerce"].ConnectionString);
        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_Page login_Page = new Login_Page();
            login_Page.Show();
        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            string name = name_text.Text;
            int age = (int)age_Value.Value;
            string password = pass_text.Text;
            string address = add_text.Text;
            string email = email_text.Text;


            if (name_text.Text == string.Empty || age_Value.Value == 0 || pass_text.Text == "" || add_text.Text == "" || email_text.Text == "")
            {
                MessageBox.Show("You Must Fill All Fields In Form");
            }
            else
            {
                user.AddUser(name, password, email, age, address);
                name_text.Text = "";
                age_Value.Value = 0;
                pass_text.Text = "";
                add_text.Text = "";
                email_text.Text = "";

                this.Hide();
                Login_Page login_Page = new Login_Page();
                login_Page.Show();
            }
        }
    }
}