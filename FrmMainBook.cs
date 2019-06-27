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
    public partial class FrmMainBook : Form
    {
        public FrmMainBook()
        {
            InitializeComponent();
            this.dgvBookList.AutoGenerateColumns = false;
        }

    




        private void FrmMainBook_Load(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
           // loginForm.MdiParent = this;
           
            loginForm.Show();
           // this.Dispose();
           
            




            // TODO: This line of code loads data into the 'db_LibraryMSDataSet.tb_bookinfo' table. You can move, or remove it, as needed.
            this.tb_bookinfoTableAdapter.Fill(this.db_LibraryMSDataSet.tb_bookinfo);
         

        }


        public int ExecuteNonQuery(string sql)
        {

            string connString = "server=localhost;database=db_LibraryMS;Trusted_Connection=SSPI";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                //connect database
                conn.Open();
               

                //
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.Add(new SqlParameter("@bookcode", SqlDbType.NVarChar, 30));
                    cmd.Parameters.Add(new SqlParameter("@BookName", SqlDbType.NVarChar, 50));
                    cmd.Parameters.Add(new SqlParameter("@Price", SqlDbType.Money));
                    cmd.Parameters.Add(new SqlParameter("@pubname", SqlDbType.NVarChar, 100));
                    cmd.Parameters.Add(new SqlParameter("@inTime", SqlDbType.DateTime));

                    // 
                    cmd.Parameters["@bookcode"].Value = this.txtBarCode.Text;
                    cmd.Parameters["@bookname"].Value = this.txtBookName.Text;
                    cmd.Parameters["@price"].Value = Convert.ToDouble(this.txtPrice.Text);
                    cmd.Parameters["@pubname"].Value = this.txtPublisher.Text;
                    cmd.Parameters["@inTime"].Value = Convert.ToDateTime(this.dtpIntime.Text);




                    //
                   return cmd.ExecuteNonQuery();
                   

                }
            }



        }



        private void BtnAdd_Click(object sender, EventArgs e)
        {
        
                string sql = "insert into tb_bookinfo(bookcode,bookname,price,pubname,inTime) values (@bookcode,@bookname,@price,@pubname,@inTime)";
                ExecuteNonQuery(sql);
            this.tb_bookinfoTableAdapter.Fill(this.db_LibraryMSDataSet.tb_bookinfo);
            MessageBox.Show("insert successful!");

   
        }


        private void BtnClear_Click(object sender, EventArgs e)
        {
            this.txtBarCode.Clear();

            this.txtBookName.Clear();

            this.txtPrice.Clear();

            this.txtPublisher.Clear();

            this.txtBarCode.Focus();
        }

       
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            //Object obj = dgvBookList.CurrentRow.DataBoundItem;
            // DataRowView row = (DataRowView)obj;

            string sql = "update tb_bookinfo set bookcode=@bookcode,bookname=@bookname,price=@price,pubname=@pubname,inTime=@inTime where bookcode= @bookcode";

            ExecuteNonQuery(sql);
            this.tb_bookinfoTableAdapter.Fill(this.db_LibraryMSDataSet.tb_bookinfo);
            MessageBox.Show("edit successful!");
        }

        private void DgvBookList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBarCode.Text = dgvBookList.CurrentRow.Cells["bookcode"].Value.ToString();
            txtBookName.Text = dgvBookList.CurrentRow.Cells["bookname"].Value.ToString();
            txtPrice.Text = dgvBookList.CurrentRow.Cells["price"].Value.ToString();
            txtPublisher.Text = dgvBookList.CurrentRow.Cells["publisher"].Value.ToString();
            dtpIntime.Text = dgvBookList.CurrentRow.Cells["inTime"].Value.ToString();


        }

        private void DgvBookList_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            for (int i = 0; i < dgvBookList.Rows[e.RowIndex].Cells.Count; i++)
            {
                dgvBookList[i, e.RowIndex].Style.BackColor = Color.Yellow;
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            string sql = "delete from tb_bookinfo where bookcode= @bookcode";
            ExecuteNonQuery(sql);
            this.tb_bookinfoTableAdapter.Fill(this.db_LibraryMSDataSet.tb_bookinfo);
            MessageBox.Show("delete successful!");
        }
    }
}
