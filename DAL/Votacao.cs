using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Votacao
    {
        private int _votacaoId;
        private string _userId;
        private Receita _receitaId;
        private int _valorId;


        public int VotacaoID { get => _votacaoId; set => _votacaoId = value; }
        public string UserID { get => _userId; set => _userId = value; }
        public Receita Receita { get => _receitaId; set => _receitaId = value; }
        public int ValorID { get => _valorId; set => _valorId = value; }


        public Votacao()
        {
        }
        public static double Voto_por_recid(int recid)
        {
            SqlConnection cn = new SqlConnection
            {
                ConnectionString = DAL.Properties.Settings.Default.cnSQL
            };
            try
            {
                SqlCommand cmdvoto = new SqlCommand
                {
                    Connection = cn,
                    CommandText = "Votacao_Receita",
                    CommandType = CommandType.StoredProcedure
                };
                cmdvoto.Parameters.AddWithValue("@Recid", recid);
                var parameter = new SqlParameter();
                parameter.ParameterName = "@ReturnCode";
                parameter.Direction = ParameterDirection.ReturnValue;
                cmdvoto.Parameters.Add(parameter);

                cn.Open();


                cmdvoto.ExecuteReader();
                var value = parameter.Value;
                cn.Close();
                double voto = Convert.ToDouble(value);
                return voto;
            }

            catch (Exception)
            {
                return 0;
            }
            finally
            {
                cn.Close();
            }
        }

        public static string Insere_Voto(int voto, string userid, int recid)
        {

            SqlConnection cn = new SqlConnection
            {
                ConnectionString = DAL.Properties.Settings.Default.cnSQL
            };
            //try
            //{
                SqlCommand cmd = new SqlCommand
                {
                    Connection = cn,
                    CommandText = "Inserir_Voto",
                    CommandType = CommandType.StoredProcedure
                };
                cn.Open();
                cmd.Parameters.AddWithValue("@voto", voto);
                cmd.Parameters.AddWithValue("@userid", userid);
                cmd.Parameters.AddWithValue("@recid", recid);

                cmd.ExecuteNonQuery();

                cn.Close();
                string d = "ok";
                return d;
                
            //}

            //catch (Exception)
            //{
            //    return null;
            //}
            //finally
            //{
                
            //}
        }

        public static List<string> Filtra_Voto(int recid)

        {
            SqlConnection cn = new SqlConnection
            {
                ConnectionString = DAL.Properties.Settings.Default.cnSQL
            };
            try
            {
                SqlCommand cmdvt = new SqlCommand
                {
                    Connection = cn,
                    CommandText = "filtra_voto",
                    CommandType = CommandType.StoredProcedure
                };
                cn.Open();
                cmdvt.Parameters.AddWithValue("@recid", recid);
                SqlDataReader reader = cmdvt.ExecuteReader();

                List<string> utilizadores = new List<string>();
                while (reader.Read())
                {

                    string u = reader["UserId"].ToString();
                    utilizadores.Add(u);

                }
                return utilizadores;
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

        //public static DataTable testeuniq (string uid)

        //{
        //    SqlConnection cn = new SqlConnection
        //    {
        //        ConnectionString = DAL.Properties.Settings.Default.cnSQL
        //    };
        //    try
        //    {
        //        SqlCommand cmdvt = new SqlCommand
        //        {
        //            Connection = cn,
        //            CommandText = "testeuniq",
        //            CommandType = CommandType.StoredProcedure
        //        };
        //        cn.Open();
        //        cmdvt.Parameters.AddWithValue("@userid", uid);
        //        DataTable dt = new DataTable();

        //        dt.Load(cmdvt.ExecuteReader());
        //        return dt;

         
        //    }

        //    catch (Exception)
        //    {
        //        return null;
        //    }
        //    finally
        //    {
        //        cn.Close();
        //    }
        //}
    }
    }
