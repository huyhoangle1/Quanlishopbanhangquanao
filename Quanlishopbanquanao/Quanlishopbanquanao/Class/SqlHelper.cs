using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Quanlishopbanquanao
{
    class SqlHelper
    {
        public static int loainguoidung;
        public static string tennguoidung;
        public static string ConnectString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=Quanlybanhang;Persist Security Info=True;User ID=sa;Password = 123";
        public static SqlConnection con;
    }
}
