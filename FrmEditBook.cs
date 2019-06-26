using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS_WindowsForms
{
    public partial class FrmEditBook : Form
    {
        public FrmEditBook()
        {
            InitializeComponent();
            //this.txtBarCode.Text = objBook.BarCode;

            //this.txtBookName.Text = objBook.BookName;

            //this.txtPrice.Text = objBook.Price.ToString();

            //this.dtpPublishDate.Text = objBook.PublishDate.ToShortDateString();//时间要用ToShortDateString()

            ////给下拉框赋值

            //this.cboxPubliserId.SelectedValue = objBook.PublisherId;

        }

        private void BtnCommit_Click(object sender, EventArgs e)
        {

        }
    }
}
