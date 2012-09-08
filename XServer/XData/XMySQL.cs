using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace XServer.XData
{
    class XMySQL
    {
        protected string nConnectStr =
            "SERVER=localhost;"
           +"USER=root;"
           +"PASSWORD=;"
           +"DATABASE=test";
        MySqlDataReader myRead;
        MySqlConnection myCon;


        public XMySQL()
        {
            myCon = new MySqlConnection(nConnectStr);
        }

        public bool CheckLogin(string username, string password)
        {
            string tusername = "", tpassword = "";
            string sql = "SELECT * from user where user='"+username+"'";

            MySqlCommand cmd = new MySqlCommand(sql, this.myCon);

            myRead = cmd.ExecuteReader();

            while (myRead.Read())
            {
                tusername = myRead.GetString("username");
                tpassword = myRead.GetString("password");
            }

            if (tusername != null)
            {
                if (tpassword == password)
                {
                    return true;
                }
            }
            else
            {
                
            }

            return false;

        }

    }
}
