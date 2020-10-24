using DemoDataGridView.model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDataGridView.dal
{
    class CustomerDAO : BaseDAO
    {
        SqlDataAdapter adapter;
        DataSet ds;
        DataTable dtCustomer;

        public DataTable getCustomerList()
        {
            //Lấy toàn bộ dữ liệu từ bảng tblMatHang
            String sql = "Select * from Customer";

            //tạo đối tượng DataSet
            ds = new DataSet();

            //Khởi tạo đối tượng DataAdapter và cung cấp vào câu lệnh SQL và đối tượng Connection
            adapter = new SqlDataAdapter(sql, connection);

            //Dùng phương thức Fill của DataAdapter để đổ dữ liệu từ DataSource tới DataSet
            adapter.Fill(ds, "customerList");

            //Tạo DataTable thu kết quả từ bảng
            dtCustomer = ds.Tables["customerList"];

            return dtCustomer;
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

        public void updateCustomerList()
        {
            SqlCommandBuilder cmdBld = new SqlCommandBuilder(adapter);
            if (dtCustomer.GetChanges() != null)
            {
                adapter.Update(dtCustomer);
            }
        }
    }
}
