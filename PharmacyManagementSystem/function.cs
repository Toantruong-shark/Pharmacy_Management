using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
namespace PharmacyManagementSystem
{
    class function
    {
        protected SqlConnection getConnection()
        {
            /*SqlConnection conn = new SqlConnection();

            conn.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ASUS\\Documents\\phamarcy.mdf;Integrated Security=True;Connect Timeout=30";
            return conn;*/
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-AnhToan\SQLSERVERTOAN;AttachDbFilename=""C:\Program Files\Microsoft SQL Server\MSSQL16.SQLSERVERTOAN\MSSQL\DATA\phamarcy.mdf"";Integrated Security=True;");
            return con;
        }
        public DataSet getData(String query)
        {
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection= con;
            cmd.CommandText= query;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public void setData(String query, String msg)
        {
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection= con;
            con.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show(msg,"Information",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }
    }
}
