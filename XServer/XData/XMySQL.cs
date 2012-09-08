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

    }
}
