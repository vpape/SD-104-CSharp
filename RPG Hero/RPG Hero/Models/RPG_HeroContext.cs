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

    public void EditById(Hero hero)
    {
        string ConnectionString = "Server = localhost ; Database = RPGGame; Trusted_Connection = True";
        using (SqlConnection conn = new SqlConnection(ConnectionString))
        {

            conn.Open();
            SqlCommand cmd = new SqlCommand("Update hero SET health = @Health, Lvl = @Lvl, currentExp = @CurrentExp, AttackPower = @AttackPower where id = @Id", conn);
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
                ParameterName = "@CurrentExp",
                DbType = DbType.Int32,
                Value = hero.CurrentExp,

            });
            cmd.Parameters.Add(new SqlParameter
            {
                ParameterName = "@AttackPower",
                DbType = DbType.Int32,
                Value = hero.AttackPower,

            });
            cmd.Parameters.Add(new SqlParameter
            {
                ParameterName = "@Id",
                DbType = DbType.Int32,
                Value = hero.Id,

            });
            cmd.ExecuteNonQuery();
        }
    }

    public void Delete(int id)
    {
        string ConnectionString = "Server = localhost ; Database = RPGGame; Trusted_Connection = True";
        using (SqlConnection connection = new SqlConnection(ConnectionString))
        { 
            connection.Open();
            SqlCommand cmd = new SqlCommand("delete from hero where id = @id", connection);
            cmd.Parameters.Add(new SqlParameter
            {
                ParameterName = "@id",
                DbType = DbType.Int32,
                Value = id,
            });
            cmd.ExecuteNonQuery();                 

        }
    }

    public Hero GetHeroById(int id)
    {
        string ConnectionString = "Server = localhost ; Database = RPGGame; Trusted_Connection = True";
        using (SqlConnection connection = new SqlConnection(ConnectionString))
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("select * from hero where id= @id", connection);          

            cmd.Parameters.Add(new SqlParameter
            {
                ParameterName = "@id",
                DbType = DbType.Int32,
                Value = id,
            });

            Hero hero = new Hero();
            SqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {

                hero.Id = (int)dataReader["Id"];
                hero.Health = (int)dataReader["Health"];
                hero.Lvl = (int)dataReader["Lvl"];
                hero.AttackPower = (int)dataReader["AttackPower"];
                hero.CurrentExp = (int)dataReader["CurrentExp"];

            }
                return (hero);
        }
    }

    public List<Hero> ToList()
    {
        string ConnectionString = "Server = localhost ; Database = RPGGame; Trusted_Connection = True";
        using (SqlConnection connection = new SqlConnection(ConnectionString))
        {
            List<Hero> heroes = new List<Hero>();

            connection.Open();
            SqlCommand cmd = new SqlCommand("select * from hero", connection);
            SqlDataReader dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                Hero hero = new Hero();
                hero.Id = (int)dataReader["Id"];
                hero.Health = (int)dataReader["Health"];
                hero.Lvl = (int)dataReader["Lvl"];
                hero.AttackPower = (int)dataReader["AttackPower"];
                hero.CurrentExp = (int)dataReader["CurrentExp"];

                heroes.Add(hero);
            }
            return (heroes);
        }
    }

    public Hero Find(int id)
    {
        return null;
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
    /*Update Hero
     Set health = @health,
     lvl = @lvl,
     currentexp = @currentexp,
     attack = @attack
     where id = @id;
     cmd.Addparameters({
     ParameterName - @health
     Dbtype = Dbtype.Int32,
     value = hero.health)}*/

    /*Delete from Hero
     where id = 1;
     C# 
     Delete from here where id = @id
     cmd.addparameter({
     Parameter name = @id,
     Dbtype = Dbtype.int32,
     value = id*/

}
