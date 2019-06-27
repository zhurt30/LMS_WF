using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LMS_WindowsForms
{
    
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();


        }
        SqlConnection connection;
        private void Btn_Comfirm_Click(object sender, EventArgs e)
        {
            string connstr = "server =. ;  database=db_LibraryMS ; Integrated Security=SSPI; Persist Security info= False";
            string userName = Txt_RuserName.Text.Trim();

            try
            {
                connection = new SqlConnection(connstr);
                connection.Open();

                // Creating an SQL Command 
                String sql = "select * from tb_admin where name='" + userName + "'";

                SqlCommand command = new SqlCommand(sql, connection);
                // Setting the attributes for the command (optional)

                command.CommandTimeout = 15;
                // Create and execute the dataReader with the command (at the server)
                SqlDataReader reader = command.ExecuteReader();
                // Creating a local dataTable to hold the result of the command.ExecuteReader
                DataTable userDT = new DataTable();
                //Load results into the dataTable
                userDT.Load(reader);
                if (userDT.Rows.Count != 0)
                {
                    DialogResult result = MessageBox.Show("This User has exist !Do you want to registe to be a new user?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        Txt_RuserName.Text = "";
                        Txt_RuserPassword.Text = "";
                        Txt_RuserPassword2.Text = "";
                        Txt_RuserName.Focus();
                    }
                    else
                    {
                        LoginForm loginForm = new LoginForm();
                        loginForm.MdiParent = this.MdiParent;
                        loginForm.Show();
                        this.Dispose();
                        return;
                    }

                }

                else if (Txt_RuserName.Text.Length == 0)
                {
                    MessageBox.Show("Please input User Name !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Lbl_RuserName.ForeColor = Color.Red;
                    Txt_RuserName.Focus();

                }
                else if (Txt_RuserPassword.Text.Length == 0)
                {
                    Lbl_RuserName.ForeColor = Color.Black;
                    MessageBox.Show("Please input Password !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Lbl_RuserPassword.ForeColor = Color.Red;
                    Txt_RuserPassword.Focus();

                }
                else if (Txt_RuserPassword2.Text.Length == 0)
                {
                    Lbl_RuserPassword.ForeColor = Color.Black;
                    MessageBox.Show("Please comfirm Password !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Lbl_RuserPassword2.ForeColor = Color.Red;
                    Txt_RuserPassword2.Focus();

                }
                else if (!string.Equals(Txt_RuserPassword.Text, Txt_RuserPassword2.Text))
                {
                    Lbl_RuserPassword.ForeColor = Color.Black;
                    MessageBox.Show("Passwords are not inconsistent !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Txt_RuserPassword.Text = "";
                    Txt_RuserPassword2.Text = "";
                    Lbl_RuserPassword.ForeColor = Color.Red;
                    Lbl_RuserPassword2.ForeColor = Color.Red;
                    Txt_RuserPassword.Focus();
                }
                else
                {

                    Lbl_RuserPassword.ForeColor = Color.Black;
                    Lbl_RuserPassword2.ForeColor = Color.Black;
                    SqlCommand  command1 = new SqlCommand(" insert into tb_admin values('" +TxtID.Text+"','"+ userName+"','"+ Txt_RuserPassword.Text + "') ",connection);
                    command1.ExecuteNonQuery();
                    command1 = null;
                    MessageBox.Show("Registion is successful !!","Information");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                connection.Dispose();
                connection.Close();
            }
        }
        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            TxtID.Text = "";
            Txt_RuserName.Text = "";
            Txt_RuserPassword.Text = "";
            Txt_RuserPassword2.Text = "";
            MessageBox.Show("Reset is successful！", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void Btn_Back_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.MdiParent = this.MdiParent;
            loginForm.Show();
            this.Dispose();
        }


    }
}
