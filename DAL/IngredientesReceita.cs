using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class IngredientesReceita
    {
        private int _ingredientereceitaid;
        private Ingrediente _ingrediente;
        private UnidadeMedida _unidademedida;
        private int _quantidade;


        public int IngredineteReceitaID { get => _ingredientereceitaid; set => _ingredientereceitaid = value; }
        public Ingrediente Ingrediente { get => _ingrediente; set => _ingrediente = value; }
        public UnidadeMedida UnidadeMedida { get => _unidademedida; set => _unidademedida = value; }
        public int Quantidade { get => _quantidade; set => _quantidade = value; }

        public IngredientesReceita()
        {
        }

        public static DataTable Ingredientes_da_Receita(string recid)
        {
            SqlConnection cn = new SqlConnection
            {
                ConnectionString = DAL.Properties.Settings.Default.cnSQL
            };
            try
            {
                SqlCommand cmd_Ing_Receita = new SqlCommand
                {
                    Connection = cn,
                    CommandText = "Fornece_lista_ing",
                    CommandType = CommandType.StoredProcedure
                };
                cmd_Ing_Receita.Parameters.AddWithValue("@Recid", recid);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd_Ing_Receita;

                DataTable dti = new DataTable();
                dti.Clear();
                da.Fill(dti);

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
    }
}
