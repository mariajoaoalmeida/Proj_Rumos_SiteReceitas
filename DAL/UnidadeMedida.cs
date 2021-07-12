using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UnidadeMedida
    {
        private int _unidademedidaid;
        private string _unidade;

        public int IngredienteId { get => _unidademedidaid; set => _unidademedidaid = value; }
        public string Ingredientenome { get => _unidade; set => _unidade = value; }

        public UnidadeMedida()
        {
        }
        public static List<string> UnidadesMedida()

        {
            SqlConnection cn = new SqlConnection
            {
                ConnectionString = DAL.Properties.Settings.Default.cnSQL
            };
            try
            {
                SqlCommand cmdListaUnidades = new SqlCommand
                {
                    Connection = cn,
                    CommandText = "Lista_UnidadesMedida",
                    CommandType = CommandType.StoredProcedure
                };
                cn.Open();
                SqlDataReader reader = cmdListaUnidades.ExecuteReader();

                List<string> unidades = new List<string>();
                while (reader.Read())
                {
                    string unid = reader["Unidade"].ToString();
                    unidades.Add(unid);
                }
                return unidades;
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
