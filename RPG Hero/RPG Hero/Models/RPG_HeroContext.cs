using RPGgame;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

public class RPG_HeroContext : DbContext
{
    // You can add custom code to this file. Changes will not be overwritten.
    // 
    // If you want Entity Framework to drop and regenerate your database
    // automatically whenever you change your model schema, please use data migrations.
    // For more information refer to the documentation:
    // http://msdn.microsoft.com/en-us/data/jj591621.aspx

    public RPG_HeroContext()
    {

    }

    public List<Hero> ToList()
    {
        string ConnectionString = "Server = localhost ; Database = RPGGame; Trusted_Connection = True";

        using (SqlConnection connection = new SqlConnection(ConnectionString))
        {
            List<Hero> heroes = new List<Hero>();

            connection.Open();
            SqlCommand cmd = new SqlCommand("select * from hero", connection);
            SqlDataReader Reader = cmd.ExecuteReader();
            while (Reader.Read())
            {
                Hero hero = new Hero();
                hero.Health = (int) Reader["Health"];
                hero.Lvl = (int)Reader["Lvl"];
                hero.AttackPower = (int)Reader["AttackPower"];
                hero.CurrentExp = (int)Reader["CurrentExp"];
                heroes.Add(hero);
            }
            return (heroes);
        }
    }

    public Hero Find(int id)
    {
        return null;
    }

    public void Remove(int id)
    {

    }

    public void Add(Hero hero)
    {
        string ConnectionString = @"Server = localhost ; Database = RPGGame; Trusted_Connection = True;";

        using (SqlConnection connection = new SqlConnection(ConnectionString))
        {
            List<Hero> heroes = new List<Hero>();
            connection.Open();
            SqlCommand cmd = new SqlCommand("insert into hero values(@Health, @Lvl, @AttackPower, @CurrentExp)", connection);
            cmd.Parameters.Add(new SqlParameter
            {
                ParameterName = "@Health",
                DbType = DbType.Int32,
                Value = hero.Health,
            });
            cmd.Parameters.Add(new SqlParameter
            {
                ParameterName = "@Lvl",
                DbType = DbType.Int32,
                Value = hero.Lvl,
            });
            cmd.Parameters.Add(new SqlParameter
            {
                ParameterName = "@AttackPower",
                DbType = DbType.Int32,
                Value = hero.AttackPower,
            });
            cmd.Parameters.Add(new SqlParameter
            {
                ParameterName = "@CurrentExp",
                DbType = DbType.Int32,
                Value = hero.CurrentExp,
            });
            cmd.ExecuteNonQuery();
        }
    }

}
