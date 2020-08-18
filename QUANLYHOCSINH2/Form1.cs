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
using Infragistics.Win.UltraWinGrid;
namespace QUANLYHOCSINH2
{
    public partial class From1 : Form
    {
        public From1()
        {
            InitializeComponent();

            // LoadData();
        }

        private void ultraGrid1_InitializeLayout(object sender, Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs e)
        {

        }

        private void btnKetThuc_click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddNewSinhVien Frm1 = new AddNewSinhVien();
            Frm1.flag = true;
            Frm1.ShowDialog();

            LoadData();
        }

        private void LoadData()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();
            string cn = @"Data Source=MACPRO-PC\SQL2008;Initial Catalog=QUANLYSINHVIEN2;Integrated Security=true";
            SqlConnection con = new SqlConnection(cn);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            string SQL = "SELECT * FROM DANHMUCSINHVIEN ORDER BY MASINHVIEN";
            da = new SqlDataAdapter(SQL, cn);
            da.Fill(ds, "SINHVIEN");
            DBNoiDung.DataSource = ds;
            DBNoiDung.Refresh();
        }

        private void From1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            //UltraGridRow rw = DBNoiDung.ActiveRow;
            if (DBNoiDung.ActiveRow != null)
            {
                AddNewSinhVien Frm1 = new AddNewSinhVien();
                Frm1.TxtMaSinhVien.Text = DBNoiDung.ActiveRow.Cells["MASINHVIEN"].Value.ToString();
                Frm1.TxtTenSinhVien.Text = DBNoiDung.ActiveRow.Cells["TENSINHVIEN"].Value.ToString();
                Frm1.CobGioiTinh.Text = DBNoiDung.ActiveRow.Cells["GIOITINH"].Value.ToString();
                Frm1.TxtQueQuan.Text = DBNoiDung.ActiveRow.Cells["QUEQUAN"].Value.ToString();
                Frm1.flag = false;
                Frm1.ShowDialog();
                LoadData();
            }
            else
            {
                MessageBox.Show("Bạn phải chọn một mẩu tin cần sửa");
            }
        }

        private void DBNoiDung_DoubleClickCell(object sender, DoubleClickCellEventArgs e)
        {
            if (DBNoiDung.ActiveRow != null)
            {
                AddNewSinhVien Frm1 = new AddNewSinhVien();
                Frm1.TxtMaSinhVien.Text = DBNoiDung.ActiveRow.Cells["MASINHVIEN"].Value.ToString();
                Frm1.TxtTenSinhVien.Text = DBNoiDung.ActiveRow.Cells["TENSINHVIEN"].Value.ToString();
                Frm1.CobGioiTinh.Text = DBNoiDung.ActiveRow.Cells["GIOITINH"].Value.ToString();
                Frm1.TxtQueQuan.Text = DBNoiDung.ActiveRow.Cells["QUEQUAN"].Value.ToString();
                Frm1.flag = false;
                Frm1.ShowDialog();
                LoadData();
            }
            else
            {
                MessageBox.Show("Bạn phải chọn một mẩu tin cần sửa");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (DBNoiDung.ActiveRow != null)
            {
                string strID = DBNoiDung.ActiveRow.Cells["ID"].Value.ToString();
                DialogResult result = MessageBox.Show("Bạn có muốn xóa sinh viên có tên: " + DBNoiDung.ActiveRow.Cells["TENSINHVIEN"].Value.ToString() + " không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string cn = @"Data Source=MACPRO-PC\SQL2008;Initial Catalog=QUANLYSINHVIEN2;Integrated Security=true";
                    SqlConnection con = new SqlConnection(cn);
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    string strQuery = string.Format("DELETE FROM DANHMUCSINHVIEN WHERE ID={0}", strID);
                    SqlCommand cmd = new SqlCommand(strQuery, con);
                    cmd.ExecuteNonQuery();
                    con.Dispose();
                    cmd.Dispose();
                    MessageBox.Show("Xóa thành công");
                    LoadData();
                }

            }
            else
            {
                MessageBox.Show("Bạn phải chọn một mẩu tin cần xóa");
            }

        }
    }
}
