using System.Configuration;
using System.Data;
using Ecommerce.BusienessLogic;

namespace Ecommerce.PresentationLayer
{
    public partial class EditPassword : Form
    {
        User user;
        DataTable userData;
        public EditPassword(DataTable userdata)
        {
            InitializeComponent();
            user = new User(ConfigurationManager.ConnectionStrings["Ecommerce"].ConnectionString);
            userData = userdata;
        }


        private void EditPassword_Load(object sender, EventArgs e)
        {
            oldPassword_text.UseSystemPasswordChar = true;
            newPassword_text.UseSystemPasswordChar = true;
            confirmPassword_text.UseSystemPasswordChar = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox1.Checked)
            {
                oldPassword_text.UseSystemPasswordChar = false;
            }
            else
            {
                oldPassword_text.UseSystemPasswordChar = true;
            }
        }



        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox2.Checked)
            {
                newPassword_text.UseSystemPasswordChar = false;
            }
            else
            {
                newPassword_text.UseSystemPasswordChar = true;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                confirmPassword_text.UseSystemPasswordChar = false;
            }
            else
            {
                confirmPassword_text.UseSystemPasswordChar = true;
            }
        }

        int userId;
        private void btn_changePassword_Click(object sender, EventArgs e)
        {
            userId = (int)userData.Rows[0]["UserId"];
            DataTable dt = user.SelectedUserById(userId);
            string oldPassword = dt.Rows[0]["Password"].ToString();

            if (oldPassword_text.Text != oldPassword)
            {
                MessageBox.Show("Old Password Is Wrong");
            }
            else
            {
                if (newPassword_text.Text == string.Empty || confirmPassword_text.Text == string.Empty)
                {
                    MessageBox.Show("You Must Fill Password");
                }
                else
                {
                    if (newPassword_text.Text == confirmPassword_text.Text)
                    {
                        if (user.updatePasswordForThisUser(userId, newPassword_text.Text) > 0)
                        {
                            MessageBox.Show("Password Is Update");
                            this.Hide();
                            Login_Page login_Page = new Login_Page();
                            login_Page.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Password Not Matching");
                    }
                }
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            oldPassword_text.Text = string.Empty;
            newPassword_text.Text = string.Empty;
            confirmPassword_text.Text = string.Empty;
        }
    }
}
