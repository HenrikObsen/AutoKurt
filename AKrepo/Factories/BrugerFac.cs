using System;
using System.Data.SqlClient;
using AKrepo;

public class BrugerFac : AutoFac<Bruger>
{
    public Bruger LogIn(string email, string adgangskode)
    {

        using (var cmd = new SqlCommand("SELECT * FROM Bruger WHERE Email=@Email AND Adgangskode=@Adgangskode", Conn.CreateConnection()))
        {
            cmd.Parameters.AddWithValue("@Email", email);
            cmd.Parameters.AddWithValue("@Adgangskode", adgangskode);

            var mapper = new Mapper<Bruger>();
            var r = cmd.ExecuteReader();
            Bruger per = new Bruger();

            if (r.Read())
            {
                per = mapper.Map(r);
            }

            r.Close();
            cmd.Connection.Close();
            return per;

        }
    }

    public bool UserExists(string email)
    {
        using (var cmd = new SqlCommand("SELECT * FROM Bruger WHERE Email=@email", Conn.CreateConnection()))
        {
            cmd.Parameters.AddWithValue("@email", email);

            bool res = false;
            var r = cmd.ExecuteReader();

            if (r.Read())
            {
                res = true;
            }

            r.Close();
            cmd.Connection.Close();
            return res;
        }
    }

    private static Random rnd = new Random();
    public string GeneratePassword(int antal)
    {

        string strKey = "a b c d e f g h i j k l m n o p q r s t u v x y z 1 2 3 4 5 6 7 8 9 A B C D E F G H I J K L M N O P Q R S T U V X Y Z";

        string[] arrKey = { };
        string strPassword = "";

        arrKey = strKey.Split(' ');

        int intMax = arrKey.Length;
        int intMin = 0;

        for (int i = 0; i < antal; i++)
        {
            strPassword += arrKey[rnd.Next(intMin, intMax)];

        }
        string strKeyRev = "";
        foreach (string ch in arrKey)
        {
            strKeyRev += ch + " " + strKeyRev;
        }

        return strPassword;
    }
}

