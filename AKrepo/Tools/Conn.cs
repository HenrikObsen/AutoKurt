using System.Data.SqlClient;

namespace AKrepo
{
    public static class Conn
    {
        private static SqlConnection _Con = new SqlConnection("server=194.255.108.50;database=dbAutoKurt;uid=AutoKurt;pwd=eG8rYyC3;MultipleActiveResultSets=True");
    
        public static SqlConnection CreateConnection()
        {
            var cn = _Con;
            cn.Open();
            return cn;
        }
    }
}


