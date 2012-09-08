using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using XReactor;

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

        public LoginCode CheckLogin(string username, string password)
        {
            string tusername = "", tpassword = "";
            string sql = "SELECT * from user where user='"+username+"'";



            MySqlCommand cmd = new MySqlCommand(sql, this.myCon);

            myCon.Open();
            myRead = cmd.ExecuteReader();
            myCon.Close();
            while (myRead.Read())
            {
                tusername = myRead.GetString("username");
                tpassword = myRead.GetString("password");
            }

            if (tusername != null)
            {
                if (tpassword == password)
                {
                    return LoginCode.LOGIN_SUCCESS;
                }
            }
            else
            {
                
            }

            return LoginCode.PASSWORD_INCORRECT;

        }

    }
}
