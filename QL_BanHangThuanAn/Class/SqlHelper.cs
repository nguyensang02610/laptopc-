using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QL_BanHangThuanAn
{
    class SqlHelper
    {
        public static int loainguoidung;
        public static string tennguoidung;
        public static string ConnectString = @"Data Source=.\SQLEXPRESS;Initial Catalog=Quanlybanhang;Integrated Security=True";
        public static SqlConnection con;
    }
}
