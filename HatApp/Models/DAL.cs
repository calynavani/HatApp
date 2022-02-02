using Dapper;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;


namespace HatApp
{
    public class DAL
    {

        public List<Hats> AllHats()
        {
            string sql = $"select * from hats";

            using (var connect = new MySqlConnection(Secret.Connection))
            {
                connect.Open();
                List<Hats> h = connect.Query<Hats>(sql).ToList();
                connect.Close();

                return h;
            };

        }

        public List<Users> AllUser()
        {
            string sql = $"select * from users";

            using (var connect = new MySqlConnection(Secret.Connection))
            {
                connect.Open();
                List<Users> u = connect.Query<Users>(sql).ToList();
                connect.Close();

                return u;
            };


        }

        public void DeleteUser(int id)
        {
            string sql = $"delete from users where id ={id}";
            using (var connect = new MySqlConnection(Secret.Connection))
            {
                connect.Open();
                connect.Query<Users>(sql);
                connect.Close();
            }
        }

        public List<Users> GetUser(int id)
        {
            string sql = $"select * from users where id ={id})";

            using (var connect = new MySqlConnection(Secret.Connection))
            {
                connect.Open();
                List<Users> u = connect.Query<Users>(sql).ToList();
                connect.Close();

                return u;
            };

        }


        public List<Hats> GetHats(int id)
        {
            string sql = $"select * from hats where id ={id})";

            using (var connect = new MySqlConnection(Secret.Connection))
            {
                connect.Open();
                List<Hats> h = connect.Query<Hats>(sql).ToList();
                connect.Close();

                return h;
            };

        }


    }
}
