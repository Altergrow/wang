using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace SQL
{
    class DB
    {
        public string strCon = @"Data Source=.;Initial Catalog=Tiku;Integrated Security=True";
        public SqlConnection sqlcon = new SqlConnection();
        public SqlDataAdapter sda = new SqlDataAdapter();
        public DataSet ds = new DataSet();
        public DataTable dt = new DataTable();
       public string number1;
       public string operation;
       public string number2;
       public int i;
        public void dbcon()//链接数据库
        {
            try
            {
                sqlcon = new SqlConnection(strCon);
            }
            catch (Exception e)
            {
                MessageBox.Show("数据库连接失败请重新链接：" + e.ToString());
            }

 
        }
        public void del(string sltstr)//删除所有题
        {
            dbcon();
            sqlcon.Open();
            SqlCommand sqlcom = new SqlCommand(sltstr, sqlcon);
            sqlcom.ExecuteNonQuery();
            MessageBox.Show("删除成功，请继续编题！");
            
        }
        public void dbinser(string inster)//插入数据存题
        {
            sqlcon = new SqlConnection(strCon);
            sqlcon.Open();
            SqlCommand sqlcom=new SqlCommand(inster ,sqlcon);
            try
            {
                int a = sqlcom.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("保存成功！");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("保存失败！" + e.ToString());
            }

        }
        public void Reader(string sltstr)//读题的方法
        {
            sqlcon = new SqlConnection(strCon);
            sqlcon.Open();
            SqlCommand sqlcom = new SqlCommand(sltstr, sqlcon);
            sda = new SqlDataAdapter(sqlcom);
            sda.Fill(ds);
            dt=ds.Tables[0];
            if (i <dt.Rows.Count)
            {
                number1 = dt.Rows[i][0].ToString().Trim();
                operation = dt.Rows[i][1].ToString().Trim();
                number2 = dt.Rows[i][2].ToString().Trim();
                if (i == (dt.Rows.Count - 1))
                {
                    MessageBox.Show("你的题做完了，去休息吧！一会我们继续！");
                }
 
            }
            i++;
 
        }

    }
}
