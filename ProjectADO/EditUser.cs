using System.Configuration;
using System.Data;
using Ecommerce.BusienessLogic;

namespace Ecommerce.PresentationLayer
{
    public partial class EditUser : Form
    {
        User user;
        Category category;
        public EditUser()
        {
            InitializeComponent();
            user = new User(ConfigurationManager.ConnectionStrings["Ecommerce"].ConnectionString);
            category = new Category(ConfigurationManager.ConnectionStrings["Ecommerce"].ConnectionString);


            DataTable dt2 = user.GetAdminOrUser();

            cb_role.DataSource = dt2;
            cb_role.DisplayMember = "Role";
            cb_role.ValueMember = "Role";

        }

        private void EditUser_Load(object sender, EventArgs e)
        {
            btn_update.Hide();
            btn_del.Hide();
            dgv_user.DataSource = user.GetAllUser();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (user.AddNewUser(user_text.Text, (int)age_value.Value, address_text.Text, cb_role.SelectedValue.ToString(), address_text.Text, password_text.Text) > 0)
            {
                MessageBox.Show("User Is Added Done");
                dgv_user.DataSource = user.GetAllUser();
            }

            user_text.Text = address_text.Text = password_text.Text = email_text.Text = "";
            age_value.Value = 0;
            cb_role.SelectedIndex = 0;
        }
        int id;
        private void dgv_user_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = (int)dgv_user.SelectedRows[0].Cells[0].Value;
            //DataTable dt = user.getUserById(id);
            //cb_role.SelectedValue = dt.Rows[0]["Role"].ToString();
            //btn_update.Show();
            //btn_del.Show();

            DataTable dt2 = user.GetAdminOrUser();

            cb_role.DataSource = dt2;
            cb_role.DisplayMember = "Role";
            cb_role.ValueMember = "Role";

            btn_update.Show();
            btn_del.Show();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {

            if (dgv_user.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgv_user.SelectedRows[0].Cells[0].Value);
                DataTable dt = user.getUserById(id);


                if (cb_role.SelectedValue != null && cb_role.SelectedValue.ToString() == dt.Rows[0]["Role"].ToString())
                {
                    MessageBox.Show("You Didn't Change the User's Role.");
                }
                else
                {
                    if (cb_role.SelectedValue != null && user.UpdateRoleOfUserByAdmin(id, cb_role.SelectedValue.ToString()) > 0)
                    {
                        MessageBox.Show("The User's Role Has Been Updated Successfully.");


                        dgv_user.DataSource = user.GetAllUser();


                        DataTable updatedRoles = user.GetAllUser();
                        cb_role.DataSource = updatedRoles;
                        cb_role.DisplayMember = "Role";
                        cb_role.ValueMember = "Role";


                        cb_role.SelectedValue = cb_role.SelectedValue.ToString();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a user.");
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminDashboard adminDashboard = new AdminDashboard();
            adminDashboard.Show();
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this product?", "Confirm Deletion", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (user.deleteUserByAdmin(id) > 0)
                {
                    MessageBox.Show("Product deleted successfully!");


                    dgv_user.DataSource = user.GetAllUser();


                    user_text.Text = address_text.Text = email_text.Text = password_text.Text = "";
                    age_value.Value = 0;
                    cb_role.SelectedIndex = 0;

                }
                else
                {
                    MessageBox.Show("Failed to delete product.");
                }
            }
        }
    }
}
