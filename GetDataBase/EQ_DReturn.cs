﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetDataBase
{
    public class EQ_DReturn
    {
        /// <summary>
        /// 把股票数据组装成字典
        /// </summary>
        /// <returns></returns>
        public static Dictionary<string, SortedList<string, List<string>>> GetEQ_DReturn()
        {
            #region 读取股票赋权系数数据
            string sql = "select Tdate,Symbol,Exchange,DType,R,LTDR,SECode from EQ_DReturn with(nolock) where tdate > 20130101";
            string DBLink = "data source=192.168.100.123;initial catalog =FCDB;user id=read;password=read;connect timeout=120;pooling=true;max pool size=512;min pool size=1";
            string SqlLitePath = "Data Source=E:\\临时测试程序\\GetDBData\\DataBase.db3;Pooling=true;FailIfMissing=false";
            Dictionary<string, SortedList<string, List<string>>> listnew = getdatago1(sql, DBLink);
            Console.WriteLine("Finish Get");
            //插入
            insertDB(listnew, SqlLitePath);
            #endregion
            return listnew;
        }



        /// <summary>
        /// 从数据库读取股票数据
        /// SqlLite使用
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="dbcon"></param>
        /// <returns></returns>
        public static Dictionary<string, SortedList<string, List<string>>> getdatago1(string sql, string dbcon)
        {
            SqlConnection conn = null;
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr = null;

            try
            {
                conn = new SqlConnection(dbcon);
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.CommandTimeout = 1200;
                conn.Open();
                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                //conn.Close();
            }
            List<string> liststr = new List<string>();
            Dictionary<string, SortedList<string, List<string>>> ListDic = new Dictionary<string, SortedList<string, List<string>>>();
            while (dr.Read())
            {
                //string str = "";
                liststr = new List<string>();
                //股票一共23个字段，组成一行数据
                for (int i = 0; i < 7; i++)
                {
                    liststr.Add(Convert.ToString(dr[i]));
                }

                if (!ListDic.ContainsKey(dr[1].ToString()))
                {
                    SortedList<string, List<string>> sort = new SortedList<string, List<string>>();
                    //用日期作为内层排序Key
                    sort.Add(dr[0].ToString(), liststr);
                    //用股票代码作为外层Key
                    ListDic[dr[1].ToString()] = sort;
                }
                else
                {
                    ListDic[dr[1].ToString()][dr[0].ToString()] = liststr;
                }
            }
            return ListDic;
        }


        public static void insertDB(Dictionary<string, SortedList<string, List<string>>> listnew, string DBLINK)
        {
            SqliteAccess sqlite = new SqliteAccess("xiaxie");
            //SqliteAccess sqlite = new SqliteAccess("C:\\Users\\ysjsfw\\Desktop\\DataBase3.db3");
            //string DBLINK = @"Data Source=E:\\临时测试程序\\GetDBData\\DataBase.db3;Pooling=true;FailIfMissing=false";
            //string DBLINK = @"Data Source=C:\\Users\\ysjsfw\\Desktop\\DataBase.db3;Pooling=true;FailIfMissing=false";
            StringBuilder stblist = new StringBuilder();
            int count = 0;//当前批次数量
            int countFinish = 0;//已完成数量
            List<string> list = new List<string>();
            string strinsert = @"INSERT INTO EQ_DReturn
                            (Tdate,Symbol,Exchange,DType,R,LTDR,SECode
                            )
                            VALUES({0})";
            string temp = "";
            //代码索引
            foreach (var sort in listnew)
            {
                //日期索引
                foreach (var item in sort.Value)
                {
                    //拼接字段
                    foreach (var i in item.Value)
                    {
                        temp += "'" + Convert.ToString(i) + "',";
                    }
                    temp = temp.Substring(0, temp.Length - 1);
                    list.Add(string.Format(strinsert, temp));
                    temp = "";
                    count++;
                    //5000个一批次插入
                    if (count == 5000)
                    {
                        sqlite.insertQuick(DBLINK, list);
                        list = new List<string>();
                        count = 0;
                        countFinish += 5000;
                        Console.WriteLine(countFinish.ToString());
                    }
                }
            }
            Console.WriteLine("countFinish:" + countFinish.ToString());
            Console.WriteLine("count:" + count.ToString());

            //不足5000批次插入
            if (list.Count > 0)
            {
                sqlite.insertQuick(DBLINK, list);
            }
        }
    }
}
