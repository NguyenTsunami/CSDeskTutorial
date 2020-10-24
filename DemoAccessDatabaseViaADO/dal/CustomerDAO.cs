using DemoAccessDatabaseViaADO.model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAccessDatabaseViaADO.dal
{
    class CustomerDAO : BaseDAO
    {
        public ArrayList getCustomerList()
        {
            ArrayList list = new ArrayList();

            //Lấy toàn bộ dữ liệu từ bảng tblMatHang
            String sql = "Select * from Customer";

            //tạo đối tượng DataSet
            DataSet ds = new DataSet();

            //Khởi tạo đối tượng DataAdapter và cung cấp vào câu lệnh SQL và đối tượng Connection
            SqlDataAdapter dap = new SqlDataAdapter(sql, connection);

            //Dùng phương thức Fill của DataAdapter để đổ dữ liệu từ DataSource tới DataSet
            dap.Fill(ds, "customerList");

            //Tạo DataTable thu kết quả từ bảng
            DataTable dt = ds.Tables["customerList"];

            //Copy kết quả ra list
            foreach (DataRow row in dt.Rows)
            {
                list.Add(new Customer(Convert.ToInt32(row[0].ToString()),
                    row[1].ToString(),
                    row[2].ToString(),
                    row[3].ToString(),
                    row[4].ToString(),
                    row[5].ToString(),
                    row[6].ToString(),
                    row[7].ToString(),
                    row[8].ToString().Equals("False") ? "female" : "male"));
                //Console.WriteLine(row[8].ToString());
            }

            return list;
        }

        public void addCustomer(Customer customer)
        {
            String sql;

            //Tạo câu lệnh truy vấn Insert lấy dữ liệu từ các Control trên Form thiết kế
            sql = "INSERT INTO Customer VALUES (";
            sql += "N'" + customer.Name + "',";
            sql += "N'" + customer.Address + "',";
            sql += "N'" + customer.City + "',";
            sql += "N'" + customer.Country + "',";
            sql += "N'" + customer.Phone + "',";
            sql += "N'" + customer.Zipcode + "')";

            //Thực thi câu lệnh SQL sử dụng đối tượng Command
            SqlCommand cmd = new SqlCommand(sql, connection);
            cmd.ExecuteNonQuery();
        }

        public void editCustomer(Customer customer, int id)
        {
            String sql;

            //Tạo câu lệnh truy vấn Insert lấy dữ liệu từ các Control trên Form thiết kế
            sql = "UPDATE Customer SET ";
            sql += "name = N'" + customer.Name + "',";
            sql += "address = N'" + customer.Address + "',";
            sql += "city = N'" + customer.City + "',";
            sql += "country = N'" + customer.Country + "',";
            sql += "phone = N'" + customer.Phone + "',";
            sql += "zipcode = N'" + customer.Zipcode + "' ";
            sql += "WHERE id = " + id;

            //Thực thi câu lệnh SQL sử dụng đối tượng Command
            SqlCommand cmd = new SqlCommand(sql, connection);
            cmd.ExecuteNonQuery();
        }

        public void deleteCustomer(int id)
        {
            String sql;

            //Tạo câu lệnh truy vấn Insert lấy dữ liệu từ các Control trên Form thiết kế
            sql = "DELETE Customer WHERE id = " + id;

            //Thực thi câu lệnh SQL sử dụng đối tượng Command
            SqlCommand cmd = new SqlCommand(sql, connection);
            cmd.ExecuteNonQuery();
        }
    }
}
