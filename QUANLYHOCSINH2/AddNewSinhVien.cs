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

namespace QUANLYHOCSINH2
{
    public partial class AddNewSinhVien : Form
    {
        public bool flag;
        public AddNewSinhVien()
        {
            InitializeComponent();
        }

        private void BntThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BntCatGiu_Click(object sender, EventArgs e)
        {
            string cn = @"Data Source=MACPRO-PC\SQL2008;Initial Catalog=QUANLYSINHVIEN2;Integrated Security=true";
            SqlConnection con = new SqlConnection(cn);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            if (flag)
            {
                string strQuery = String.Format("INSERT INTO [dbo].[DANHMUCSINHVIEN]([MASINHVIEN],[TENSINHVIEN],[QUEQUAN],[GIOITINH]) VALUES(N'{0}',N'{1}',N'{2}',N'{3}')", TxtMaSinhVien.Text, TxtTenSinhVien.Text, TxtQueQuan.Text, CobGioiTinh.Text);
                SqlCommand cmd = new SqlCommand(strQuery, con);
                cmd.ExecuteNonQuery();
                con.Dispose();
                cmd.Dispose();
                MessageBox.Show("Thêm thành công");
            }
            else
            {
                string strQuery = String.Format("UPDATE [dbo].[DANHMUCSINHVIEN] SET  [TENSINHVIEN] ={0},[QUEQUAN] =N'{1}',[GIOITINH] =N'{2}' WHERE MASINHVIEN=N'{3}' ", TxtTenSinhVien.Text, TxtQueQuan.Text, CobGioiTinh.Text, TxtMaSinhVien.Text);
                SqlCommand cmd = new SqlCommand(strQuery, con);

              //  clsSinhVien sv = new clsSinhVien("",;


                cmd.ExecuteNonQuery();
                con.Dispose();
                cmd.Dispose();
                MessageBox.Show("Sửa thành công");
            }

        }

        private void AddNewSinhVien_Load(object sender, EventArgs e)
        {

        }
    }
}
