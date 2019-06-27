
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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        public void LoadForm()
        {
            LoginForm Frm = new LoginForm();
            Frm.ShowDialog();
        }

        bool access = false;
        SqlConnection connection;
        private void Btn_Login_Click(object sender, EventArgs e)
        {
            string userName = Txt_UserName.Text.Trim();
            string password = Txt_Password.Text.Trim();
            

            if (String.IsNullOrEmpty(userName))
            {
                DialogResult result = MessageBox.Show("UserName is empty!Do you want to registe to be a new user?",
                       "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {                 
                    RegisterForm registerForm = new RegisterForm();
                    registerForm.MdiParent = this.MdiParent;
                    registerForm.Show();
                    this.Dispose();
                    return;
                }
                else
                {
                    MessageBox.Show("Please enter a valid userName");
                    Lbl_UserName.ForeColor = Color.Red;
                    Txt_UserName.Focus();
                    return;
                }
                
            }
            else
            {
                Lbl_UserName.ForeColor = Color.Black;
            }
        
            
                if (string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Please enter a valid password");
                    Lbl_Password.ForeColor = Color.Red;
                    Txt_Password.Focus();
                    return;
                }
                else
                {
                    Lbl_Password.ForeColor = Color.Black;
                }
            
            

            string connstr = "server =. ;  database= db_LibraryMS; Integrated Security=SSPI; Persist Security info= False";

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
                if (userDT.Rows.Count == 0)
                {
                    DialogResult result = MessageBox.Show("This User does not exist !Do you want to registe to be a new user?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        RegisterForm registerForm = new RegisterForm();
                        registerForm.MdiParent = this.MdiParent;
                        registerForm.Show();
                        this.Dispose();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("User is not exist");
                        Lbl_Password.ForeColor = Color.Red;
                        Lbl_UserName.ForeColor = Color.Red;
                        Txt_Password.Text = "";
                        Txt_UserName.Text = "";
                        return;
                    }

                }
                else
                {
                    Lbl_Password.ForeColor = Color.Black;
                    Lbl_UserName.ForeColor = Color.Black;
                }
                DataRow row = userDT.Rows[0];
                string dbPassword = (string)row["pwd"];
               // bool dbStatus = (bool)row["UserStatus"];

                if (!dbPassword.Equals(password))
                {
                    DialogResult result = MessageBox.Show("User Password is wrong !Do you want to registe to be a new user?",
                     "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        RegisterForm registerForm = new RegisterForm();
                        registerForm.MdiParent = this.MdiParent;
                        registerForm.Show();
                        this.Dispose();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Password is wrong ! Match upper/lower case !!");
                        MessageBox.Show("Login denied,please try again...");
                        Lbl_Password.ForeColor = Color.Red;
                        Txt_Password.Text = "";
                        Txt_Password.Focus();
                        return;
                    }

                }
                //else
                //{
                //    if (dbStatus == false)
                //    {
                //        DialogResult result = MessageBox.Show("This user is not actived!Do you want to registe to be a new user?",
                //     "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //        if (result == DialogResult.Yes)
                //        {
                //            RegisterForm registerForm = new RegisterForm();
                //            registerForm.MdiParent = this.MdiParent;
                //            registerForm.Show();
                //            this.Dispose();
                //            return;
                //        }
                //        else
                //        {
                //            MessageBox.Show("This user is not actived ");
                //            Txt_Password.Text = "";
                //            Txt_UserName.Text = "";
                //            Lbl_Password.ForeColor = Color.Red;
                //            Lbl_UserName.ForeColor = Color.Red;
                //            Txt_UserName.Focus();
                //            return;
                //        }

                    //}
                    else
                    {
                        access = true;
                        Lbl_Password.ForeColor = Color.Black;
                        Lbl_UserName.ForeColor = Color.Black;
                        MessageBox.Show("Login Successful");
                    DialogResult = DialogResult.OK;
                    this.Dispose();
                }
                //}
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

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Application.Exit();
        }

        private void FormAuth_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (access == false)
                Application.Exit();
        }
    }
}
