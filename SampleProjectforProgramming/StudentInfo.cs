using System;
using System.Data;
using System.Data.SqlClient;

namespace SampleProjectforProgramming
{
    internal class StudentInfo
    {
        SqlConnection strcon;
        string ConnStr;
        SqlCommand cmd;
       // SqlDataAdapter da;
        DataTable dt;

        public StudentInfo()
        {
            ConnStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\John Rhey Tamares\source\repos\SampleProjectforProgramming\SampleProjectforProgramming\DbStudent.mdf"";Integrated Security=True";
            strcon = new SqlConnection(ConnStr);
            strcon.Open();
        }

        public int CUDcmd(string sql)
        {
            cmd = new SqlCommand(sql, strcon);
            return cmd.ExecuteNonQuery();
        }

        public DataTable SelectCmd(string sql, params SqlParameter[] parameters)
        {
            dt = new DataTable();
            using (SqlCommand cmd = new SqlCommand(sql, strcon))
            {
                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters);
                }
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
            }
            return dt;
        }
    }
}
