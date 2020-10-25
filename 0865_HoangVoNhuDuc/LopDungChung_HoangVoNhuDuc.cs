using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0865_HoangVoNhuDuc
{
    class LopDungChung_HoangVoNhuDuc
    {
        SqlCommand cmd;
        SqlDataAdapter dataAdapter;
        IDataReader reader;
        DataTable dataTable;
        bool check = false;
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\0865_HoangVoNhuDuc\0865_HoangVoNhuDuc\0865_HoangVoNhuDuc.mdf;Integrated Security=True";
     
        public LopDungChung_HoangVoNhuDuc() { }

        public SqlConnection GetConnection()
        {
            /**Sumarry:
             * get connection string
             */
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;
            return connection;
        }

        public void openConnection(SqlConnection conn)
        {
            /**Sumarry:
             * open connection
             */
            if (conn.State == ConnectionState.Closed)
                conn.Open();
        }

        public void closeConnection(SqlConnection conn)
        {
            /**Sumarry:
             * close connection
             */
            if (conn.State == ConnectionState.Open)
                conn.Close();
        }
        public DataTable GetAllKHoa()
        {
            using (SqlConnection conn = GetConnection())
            {
                dataTable = new DataTable();
                    openConnection(conn);
                    cmd = new SqlCommand("spgetKHoa", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    reader = cmd.ExecuteReader();
                    if (reader != null)
                        dataTable.Load(reader);
                    closeConnection(conn);
                    return dataTable;
             
            }
        }

        public DataTable GetAllSinhVien()
        {
            using (SqlConnection conn = GetConnection())
            {
                dataTable = new DataTable();
                openConnection(conn);
                cmd = new SqlCommand("spgetSV", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                reader = cmd.ExecuteReader();
                if (reader != null)
                    dataTable.Load(reader);
                closeConnection(conn);
                return dataTable;

            }
        }

        public DataTable ExecuteQuery(string sql)
        {
            /**Sumarry:
             * Execute select query
             */
            dataAdapter = new SqlDataAdapter(sql, GetConnection());
            dataAdapter.Fill(dataTable);
            return dataTable;
        }



        public bool ExecuteUpdate(string sql)
        {
            /**Sumarry:
             * Execute update query
             * Execute insert query
             * Execute delete query
             */
            using (SqlConnection conn = GetConnection())
            {
                openConnection(conn);
                cmd = new SqlCommand(sql, conn);
                check = cmd.ExecuteNonQuery() == 1 ? true : false;
                closeConnection(conn);
            }
            return check;
        }
    }
}
