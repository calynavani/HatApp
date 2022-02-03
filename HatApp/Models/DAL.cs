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
            string sql = $"select * from users where id ={id}";       

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
            string sql = $"select * from hats where id ={id}";          

            using (var connect = new MySqlConnection(Secret.Connection))
            {
                connect.Open();
                List<Hats> h = connect.Query<Hats>(sql).ToList();
                connect.Close();

                return h;
            };

        }

        public void DeleteHat(int id)
        {
            string sql = $"delete from hat where id ={id}";
            using (var connect = new MySqlConnection(Secret.Connection))
            {
                connect.Open();
                connect.Query<Hats>(sql);
                connect.Close();
            }
        }

        public void UpdateUser(Users u)
        {
            string sql = $"update users set firstname='{u.FirstName}', lastname='{u.LastName}' where id ={u.Id} ";
            using (var connect = new MySqlConnection(Secret.Connection))
            {
                connect.Open();
                connect.Query<Hats>(sql);
                connect.Close();
            }
        }

        public void UpdateHat(Hats h)
        {
            string sql = $"update hats set type='{h.Type}', material='{h.Material}', color='{h.Color}', images='{h.Images}', facts='{h.Facts}' where id ={h.Id} ";
            using (var connect = new MySqlConnection(Secret.Connection))
            {
                connect.Open();
                connect.Query<Hats>(sql);
                connect.Close();
            }
        }


        public List<MyHats> GetMyHat(int id)
        {
            string sql = $"select * from myhats where id ={id}";

            using (var connect = new MySqlConnection(Secret.Connection))
            {
                connect.Open();
                List<MyHats> h = connect.Query<MyHats>(sql).ToList();
                connect.Close();

                return h;
            };

        }

        public List<MyHats> GetAllMyHats()
        {
            string sql = $"select * from myhats";

            using (var connect = new MySqlConnection(Secret.Connection))
            {
                connect.Open();
                List<MyHats> h = connect.Query<MyHats>(sql).ToList();
                connect.Close();

                return h;
            };

        }
        public void DeleteMyHat(int id)
        {
            string sql = $"delete from myhats where id ={id}";
            using (var connect = new MySqlConnection(Secret.Connection))
            {
                connect.Open();
                connect.Query<MyHats>(sql);
                connect.Close();
            }
        }
        public void AddMyHats(int userid, int hatid)
        {
            string sql = $"insert into myhats values (0,{userid},{hatid})";

            using (var connect = new MySqlConnection(Secret.Connection))
            {
                connect.Open();
                connect.Query<MyHats>(sql);
                connect.Close();

              
            };

        }


    }
}
