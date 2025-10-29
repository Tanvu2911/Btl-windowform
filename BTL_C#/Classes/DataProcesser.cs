using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_C_.Classes
{
    internal class DataProcesser
    {

        string strconnection = "Data source=.\\SQLEXPRESS;Database=QLThuVien;Integrated Security=True";
        SqlConnection SqlConnection = null;
        public void KetNoiCSDL()
        {
            try
            {
                SqlConnection = new SqlConnection(strconnection);
                if (SqlConnection.State != ConnectionState.Open)
                {
                    SqlConnection.Open();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi kết nối: " + ex.Message);
            }
        }
        public void DongKetNoiCSDL()
        {
            if (SqlConnection.State != ConnectionState.Closed)
            {
                SqlConnection.Close();
            }
        }

        public DataTable DocBang(string sql)
        {
            DataTable dt = new DataTable();
            KetNoiCSDL();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql, SqlConnection);
            sqlDataAdapter.Fill(dt);
            return dt;

        }


        public void CapNhatDuLieu(string sql)
        {
            KetNoiCSDL();
            SqlCommand cmd = new SqlCommand(sql, SqlConnection);
            cmd.ExecuteNonQuery();
            DongKetNoiCSDL();
        }

        public object ExecuteScalar(string sql)
        {
            object result = null;
            try
            {
                KetNoiCSDL();
                SqlCommand cmd = new SqlCommand(sql, SqlConnection);
                result = cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi ExecuteScalar: " + ex.Message);
            }
            finally
            {
                DongKetNoiCSDL();
            }
            return result;
        }
    }
}
