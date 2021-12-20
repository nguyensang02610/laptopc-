using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using QL_BanHangThuanAn.Class;
using System.Globalization;

namespace QL_BanHangThuanAn
{
    public partial class Bieudo : Form
    {
        public Bieudo()
        {
            InitializeComponent();
            LoadComboBox();
        }

        private void Bieudo_Load(object sender, EventArgs e)
        {
            //Loa biểu đồ
            SqlCommand cmd = new SqlCommand("select MONTH(Ngayban) as 'Thang',sum(Tongtien) as 'DoanhThu' FROM tblHDBan WHERE YEAR(Ngayban) = Year(GETDATE()) GROUP BY MONTH(Ngayban)", SqlHelper.con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            chartDoanhthu.ChartAreas["ChartArea1"].AxisX.Title = "Doanh số bán hàng theo tháng";
            chartDoanhthu.ChartAreas["ChartArea1"].AxisY.Title = "Doanh thu";
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i]["DoanhThu"] != null)
                {
                    chartDoanhthu.Series["Doanhthu"].Points.AddXY(dt.Rows[i]["Thang"], dt.Rows[i]["DoanhThu"]);
                }     
            }
            //Load box
            String sql = "select  SUM(Tongtien) as 'Tongtien',SUM(Soluong) as 'Soluong' FROM tblHDBan,tblChitietHDBan where tblHDBan.MaHDBan = tblChitietHDBan.MaHDBan and YEAR(Ngayban) = Year(GETDATE())";
            DataTable data = Functions.GetDataToTable(sql);
            int tt = int.Parse(data.Rows[0]["Tongtien"].ToString());
            String sl = data.Rows[0]["Soluong"].ToString();
            txtDoanhthu.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", tt)+" VNĐ";
            txtTotalProduct.Text = sl;
        }

        public void LoadComboBox()
        {
            SqlCommand cmd = new SqlCommand("SELECT DISTINCT month(Ngayban) as 'Thang' FROM tblHDBan", SqlHelper.con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbThang.DataSource = dt;
            cbThang.DisplayMember = "Thang";
            cbThang.ValueMember = "Thang";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Load biểu đồ
            chartDoanhthu.Series["Doanhthu"].Points.Clear();
            String sql = "select DAY(Ngayban) as 'Ngay',sum(Tongtien) as 'DoanhThu' FROM tblHDBan WHERE YEAR(Ngayban) = Year(GETDATE()) AND MONTH(Ngayban) = @thang GROUP BY DAY(Ngayban)";
            String thang = cbThang.SelectedValue.ToString(); 
            SqlCommand cmd = new SqlCommand(sql, SqlHelper.con);
            cmd.Parameters.Add(new SqlParameter("@thang", thang));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            chartDoanhthu.ChartAreas["ChartArea1"].AxisX.Title = "Doanh số bán hàng theo ngày của tháng";
            chartDoanhthu.ChartAreas["ChartArea1"].AxisY.Title = "Doanh thu";
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i]["DoanhThu"] != null)
                {
                    chartDoanhthu.Series["Doanhthu"].Points.AddXY(dt.Rows[i]["Ngay"], dt.Rows[i]["DoanhThu"]);
                }
            }
            //Load số liệu
            String sql2 = "select sum(Soluong) AS 'Soluong' , SUM(Tongtien) as 'Tongtien' from tblChitietHDBan,tblHDBan where tblHDBan.MaHDBan = tblChitietHDBan.MaHDBan and MONTH(Ngayban) = @thang2 ";
            SqlCommand cmd2= new SqlCommand(sql2, SqlHelper.con);
            cmd2.Parameters.Add(new SqlParameter("@thang2",thang));
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            int tt = int.Parse(dt2.Rows[0]["Tongtien"].ToString());
            String sl = dt2.Rows[0]["Soluong"].ToString();
            txtDoanhthu.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", tt) + " VNĐ";
            txtTotalProduct.Text = sl;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            chartDoanhthu.Series["Doanhthu"].Points.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String thang = cbThang.SelectedValue.ToString();    
            MessageBox.Show(thang);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmTKKinhdoanh frmTKKD = new frmTKKinhdoanh();
            frmTKKD.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmBaocaosanpham frmBCSP = new frmBaocaosanpham();
            frmBCSP.Show();
        }
    }
}
