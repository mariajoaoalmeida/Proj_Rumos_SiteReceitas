using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Comentario
    {
        private int _id;
        private string _user;
        private string _texto;
        private Receita _receita;

        public int ID { get => _id; set => _id = value; }
        public string Texto { get => _texto; set => _texto = value; }
        public Receita Receita { get => _receita; set => _receita = value; }
        public string User { get => _user; set => _user = value; }

        public Comentario()
        {

        }
        public static string Insere_Comentario(string comentario, int recid, string userid)
        {

            SqlConnection cn = new SqlConnection
            {
                ConnectionString = DAL.Properties.Settings.Default.cnSQL
            };

            try
            {
                SqlCommand cmdInsere_comt = new SqlCommand
                {
                    Connection = cn,
                    CommandText = "InserirComentario",
                    CommandType = CommandType.StoredProcedure
                };
                cmdInsere_comt.Parameters.AddWithValue("@comentario", comentario);
                cmdInsere_comt.Parameters.AddWithValue("@userId", userid);
                cmdInsere_comt.Parameters.AddWithValue("@ReceitaId", recid);
                cn.Open();
                cmdInsere_comt.ExecuteNonQuery();
                return "Comentário inserido com sucesso. Obrigada";
            }
            catch (Exception)
            {
                return "Algo correu mal, tenta de novo.";
            }
            finally
            {
                cn.Close();
            }

        }
        public static DataTable Comentarios_por_recid(int recid)
        {
            SqlConnection cn = new SqlConnection
            {
                ConnectionString = DAL.Properties.Settings.Default.cnSQL
            };

            try
            {
                SqlCommand cmdReceita = new SqlCommand
                {
                    Connection = cn,
                    CommandText = "Lista_Comentarios",
                    CommandType = CommandType.StoredProcedure
                };
                cmdReceita.Parameters.AddWithValue("@Recid", recid);
                cn.Open();
                DataTable dt = new DataTable();

                dt.Load(cmdReceita.ExecuteReader());
                return dt;
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
