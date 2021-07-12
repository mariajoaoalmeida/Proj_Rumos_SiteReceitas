using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Categoria
    {
        private int _categoriaid;
        private string _categorianome;

        public int CategoriaId { get => _categoriaid; set => _categoriaid = value; }
        public string Categorianome { get => _categorianome; set => _categorianome = value; }

        public Categoria()
        {
        }

        public Categoria(string categorianome)
        {
            Categorianome = categorianome;
        }

        public Categoria(int categoriaId)
        {
            CategoriaId = categoriaId;
        }

        public static DataTable Lista_Todas_Categorias()
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
                    CommandText = "lista_todas_cat",
                    CommandType = CommandType.StoredProcedure
                };
                cn.Open();
                DataTable dti = new DataTable();

                dti.Load(cmdListaTodasCat.ExecuteReader());
                return dti;

            }
            catch (Exception)
            {
                return null ;
            }
            finally
            {
                cn.Close();
            }
    
        }
        public static string Insere_Categoria(string categoria)
        {

            SqlConnection cn = new SqlConnection
            {
                ConnectionString = DAL.Properties.Settings.Default.cnSQL
            };

            try
            {
                SqlCommand cmdInsere_cat = new SqlCommand
                {
                    Connection = cn,
                    CommandText = "Inserir_Categoria",
                    CommandType = CommandType.StoredProcedure
                };
                cmdInsere_cat.Parameters.AddWithValue("@Categoria", categoria);
                cn.Open();
                cmdInsere_cat.ExecuteNonQuery();
                return "Feito";
            }
            catch (Exception)
            {
                return "Asneirada!";
            }
            finally
            {
                cn.Close();
              

            }
        }
        public static string Elimina_Categoria(int categoriaID)
        {

            SqlConnection cn = new SqlConnection
            {
                ConnectionString = DAL.Properties.Settings.Default.cnSQL
            };

            try
            {
                SqlCommand cmdElimina_cat = new SqlCommand
                {
                    Connection = cn,
                    CommandText = "Eliminar_Categoria",
                    CommandType = CommandType.StoredProcedure
                };
                cmdElimina_cat.Parameters.AddWithValue("@CategoriaID", categoriaID);
                cn.Open();
                cmdElimina_cat.ExecuteNonQuery();
                return "Feito";
            }
            catch (Exception)
            {
                return "Asneirada!";
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
