using System.Configuration;
using System.Data;
using Ecommerce.BusienessLogic;

namespace Ecommerce.PresentationLayer
{
    public partial class EditProfile : Form
    {
        User user;
        DataTable userData;
        public EditProfile(DataTable userdata)
        {
            InitializeComponent();
            user = new User(ConfigurationManager.ConnectionStrings["Ecommerce"].ConnectionString);
            userData = userdata;
        }
        int id;
        private void EditProfile_Load_1(object sender, EventArgs e)
        {
            id = (int)userData.Rows[0]["UserID"];
            DataTable dt = user.SelectedUserById(id);
            name_text.Text = dt.Rows[0]["UserName"].ToString();
            age_upDowun.Value = (int)dt.Rows[0]["Age"];
            Email_text.Text = dt.Rows[0]["email"].ToString();
            Address_Text.Text = dt.Rows[0]["Address"].ToString();
        }

        private void update_profile_Click(object sender, EventArgs e)
        {
            id = (int)userData.Rows[0]["UserID"];
            DataTable dt = user.SelectedUserById(id);

            if (name_text.Text == dt.Rows[0]["UserName"].ToString() &&
                age_upDowun.Value.ToString() == dt.Rows[0]["Age"].ToString() &&
                Email_text.Text == dt.Rows[0]["email"].ToString() &&
                Address_Text.Text == dt.Rows[0]["Address"].ToString())
            {
                MessageBox.Show("You Must Update At Least One Field To Update Your Profile");
            }
            else
            {
                if (user.updateUserProfile(id, name_text.Text, (int)age_upDowun.Value, Email_text.Text, Address_Text.Text) > 0)
                {
                    MessageBox.Show("Your Profile Has Been Updated Successfully!");
                }
            }
        }

        private void btn_password_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditPassword editPassword = new EditPassword(userData);
            editPassword.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage homePage = new HomePage(userData);
            homePage.Show();
        }
    }
}
