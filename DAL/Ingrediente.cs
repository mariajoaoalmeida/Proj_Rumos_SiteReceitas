using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Ingrediente
    {
        private int _ingredienteid;
        private string _ingredientenome;

        public int IngredienteId { get => _ingredienteid; set => _ingredienteid = value; }
        public string Ingredientenome { get => _ingredientenome; set => _ingredientenome = value; }

        public Ingrediente()
        {
        }
        public static List<string> Ingredientes()

        {
            SqlConnection cn = new SqlConnection
            {
                ConnectionString = DAL.Properties.Settings.Default.cnSQL
            };
            try
            {
                SqlCommand cmdListaTodosIng = new SqlCommand
                {
                    Connection = cn,
                    CommandText = "lista_todos_ing",
                    CommandType = CommandType.StoredProcedure
                };
                cn.Open();
                SqlDataReader reader = cmdListaTodosIng.ExecuteReader();

                List<string> ings = new List<string>();
                while (reader.Read())
                {

                    string ingrediente = reader["Nome"].ToString();
                    ings.Add(ingrediente);

                }  
                return ings;
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
        public static DataTable Lista_Todos_Ingrediente()
        {

            SqlConnection cn = new SqlConnection
            {
                ConnectionString = DAL.Properties.Settings.Default.cnSQL
            };
            try
            {
                SqlCommand cmdListaTodosIng = new SqlCommand
                {
                    Connection = cn,
                    CommandText = "lista_todos_ing",
                    CommandType = CommandType.StoredProcedure
                };
                cn.Open();
                DataTable dti = new DataTable();

                dti.Load(cmdListaTodosIng.ExecuteReader());
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

        public static string Insere_Ingrediente(string ing)
        {

            SqlConnection cn = new SqlConnection
            {
                ConnectionString = DAL.Properties.Settings.Default.cnSQL
            };

            try
            {
                SqlCommand cmdInsere_ing = new SqlCommand
                {
                    Connection = cn,
                    CommandText = "Inserir_Ingrediente",
                    CommandType = CommandType.StoredProcedure
                };
                
                cmdInsere_ing.Parameters.AddWithValue("@ingrediente", ing);
                cn.Open();
                cmdInsere_ing.ExecuteNonQuery();
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
        public static string Elimina_Ingrediente(Ingrediente ing)
        {

            SqlConnection cn = new SqlConnection
            {
                ConnectionString = DAL.Properties.Settings.Default.cnSQL
            };

            try
            {
                SqlCommand cmdElimina_ing = new SqlCommand
                {
                    Connection = cn,
                    CommandText = "Eliminar_Ingrediente",
                    CommandType = CommandType.StoredProcedure
                };
                cmdElimina_ing.Parameters.AddWithValue("@ingredienteID", ing.IngredienteId );
                cn.Open();
                cmdElimina_ing.ExecuteNonQuery();
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
