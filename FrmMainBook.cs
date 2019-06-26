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

        SqlConnection con = new SqlConnection(" server =. ;  database= db_LibraryMS; Integrated Security = SSPI; Persist Security info= False");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter dataAdapter = new SqlDataAdapter();
        DataSet dataSet = new DataSet();




        private void FrmMainBook_Load(object sender, EventArgs e)
        {
            




            // TODO: This line of code loads data into the 'db_LibraryMSDataSet.tb_bookinfo' table. You can move, or remove it, as needed.
            this.tb_bookinfoTableAdapter.Fill(this.db_LibraryMSDataSet.tb_bookinfo);
         

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string connString = "server=localhost;database=db_LibraryMS;Trusted_Connection=SSPI";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                //connect database
                conn.Open();
                string sql = "insert into tb_bookinfo(bookcode,bookname,price,pubname,inTime) values (@bookcode,@bookname,@price,@pubname,@inTime)";

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
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("insert won!", "wanning");

                }
            }



        }


        private void BtnClear_Click(object sender, EventArgs e)
        {
            this.txtBarCode.Clear();

            this.txtBookName.Clear();

            this.txtPrice.Clear();

            this.txtPublisher.Clear();

            this.txtBarCode.Focus();
        }

        private void TxtBarCode_Validated(object sender, EventArgs e)
        {
            if (txtBarCode.Text.Trim() == " " || txtBarCode.TextLength == 0)

            {

                MessageBox.Show("Book code can't be empty!", "wanning");
                Lbl_Bookcode.ForeColor = Color.Red;
                txtBarCode.Focus();

                return;

            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
           Object obj = dgvBookList.CurrentRow.DataBoundItem;
            DataRowView row = (DataRowView)obj;
           
        }

        private void DgvBookList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DgvBookList_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            for (int i = 0; i < dgvBookList.Rows[e.RowIndex].Cells.Count; i++)
            {
                dgvBookList[i, e.RowIndex].Style.BackColor = Color.Yellow;
            }
        }
    }
}
