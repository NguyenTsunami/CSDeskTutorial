using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoAccessDatabaseViaADO.dal
{
    abstract class BaseDAO
    {
        public SqlConnection connection = new SqlConnection();
        public BaseDAO()
        {
            //Tạo đối tượng Connection
            connection = new SqlConnection();
            //Truyền vào chuỗi kết nối tới cơ sở dữ liệu
            //Sử dụng Application.StartupPath để lấy đường dẫn tới thư mục chứa file chạy chương trình 
            connection.ConnectionString = "Data Source=localhost,1433;Database=CSDESK_CustomerManagement;User ID=sa;Password=123456";
            connection.Open(); // mở kết nối
        }
    }
}
