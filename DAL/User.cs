using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class User
    {
        private string _userid;
        private string _usernome;
        private string _email;
        private bool _estado;

        public string UserId { get => _userid; set => _userid = value; }
        public string Usernome { get => _usernome; set => _usernome = value; }
        public string Email { get => _email; set => _email = value; }
        public bool Estado { get => _estado; set => _estado = value; }

        public User()
        {
        }

        public static DataTable Lista_Users_estado(int bit)
        {

            SqlConnection cn = new SqlConnection
            {
                ConnectionString = DAL.Properties.Settings.Default.cnSQL
            };
            try
            {
                SqlCommand cmdListaTodasCat = new SqlCommand
                {
                    Connection = cn,
                    CommandText = "User_estado",
                    CommandType = CommandType.StoredProcedure
                };
                cn.Open();
                cmdListaTodasCat.Parameters.AddWithValue("@estado", bit);
                DataTable dti = new DataTable();

                dti.Load(cmdListaTodasCat.ExecuteReader());
                return dti;
            }

            catch (Exception)
            {
                return null;
            }
            finally
            {
                cn.Close();
            }




        }
        public static string Altera_Users_estado(string nome, int bit)
        {

            SqlConnection cn = new SqlConnection
            {
                ConnectionString = DAL.Properties.Settings.Default.cnSQL
            };
            try
            {
                SqlCommand cmd = new SqlCommand
                {
                    Connection = cn,
                    CommandText = "Altera_estado_user",
                    CommandType = CommandType.StoredProcedure
                };
                cn.Open();
                cmd.Parameters.AddWithValue("@estado", bit);
                cmd.Parameters.AddWithValue("@Nome", nome);


                cmd.ExecuteReader();

              
                string d = "ok";
                return d;
            }

            catch (Exception)
            {
                return null;
            }
            finally
            {
                cn.Close();
            }

        }
    }
}
