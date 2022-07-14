using System;


namespace pmub
{
    public static class Constants
    {
        //Distance MYSQL
        #region MYSQL CONNECTION STRING
        public static string connectionString = "server='localhost'; port='8080'; user='root'; password=''; database='pmub_bd';";

        #endregion
        #region MYSQL SELECT ALL QUERY
        public static string selectAllQuery = "select * from USERS order by timestamp desc";

        #endregion
        #region MYSQL INSERT COMMAND
        public static string insertUsers = "insert into users(User, UsersName, UsersPrenoms, UsersTel, UsersPass) values(user, userName, userPrenoms, userTel, userPass)";

        #endregion
        #region SELECT USER QUERY

        public static string selectUser = "select IdUsers, User, UsersPass where User=user and UsersPass = userPass";
        #endregion
    }
}
