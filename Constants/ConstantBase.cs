using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyHomePage.Constants
{
    public static class ConstantBase
    {
        /// <summary>
        /// Data Source=(SQL Server のホスト名またはIPアドレス);Initial Catalog=(接続先データベース名);
        /// </summary>
        public static string ConnectionStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\RAINA\SOURCE\REPOS\MYHOMEPAGE\MYHOMEPAGE\APP_DATA\DATABASE.MDF;Integrated Security=True";
    }
}