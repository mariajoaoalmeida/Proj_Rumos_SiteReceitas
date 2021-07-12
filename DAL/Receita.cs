using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public class Receita
    {
        private int _receitaid;
        private Categoria _categoria;
        private User _utilizadorid;
        private string _nome;
        private int _numdoses;
        private string _preparacao;
        private string _tempoprep;
        private Dificuldade _graudificuldadeid;
        private bool _aprovada;



        public int ReceitaID { get => _receitaid; set => _receitaid = value; }
        public Categoria Categoria { get => _categoria; set => _categoria = value; }
        public User UtilizadorID { get => _utilizadorid; set => _utilizadorid = value; }
        public string NomeReceita { get => _nome; set => _nome = value; }
        public int NumDoses { get => _numdoses; set => _numdoses = value; }
        public string Preparacao { get => _preparacao; set => _preparacao = value; }
        public string TempoPrep { get => _tempoprep; set => _tempoprep = value; }
        public Dificuldade Dificuldade { get => _graudificuldadeid; set => _graudificuldadeid = value; }
        public bool Aprovada { get => _aprovada; set => _aprovada = value; }


        public Receita()
        {
        }

        public Receita(int receitaID, Categoria categoria, User utilizadorID, string nomeReceita, int numDoses, string preparacao, string tempoPrep, Dificuldade dificuldade, bool aprovada)
        {
            ReceitaID = receitaID;
            Categoria = categoria;
            UtilizadorID = utilizadorID;
            NomeReceita = nomeReceita;
            NumDoses = numDoses;
            Preparacao = preparacao;
            TempoPrep = tempoPrep;
            Dificuldade = dificuldade;
            Aprovada = aprovada;
        }

        public static DataTable Rec_por_nome(string palavra_no_nome)
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
                    CommandText = "Procura_nome",
                    CommandType = CommandType.StoredProcedure
                };
                cmdReceita.Parameters.AddWithValue("@palavra", palavra_no_nome);
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
        public static DataTable Rec_por_categoria(string palavra_categoria)
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
                    CommandText = "Procura_categoria",
                    CommandType = CommandType.StoredProcedure
                };
                cmdReceita.Parameters.AddWithValue("@palavra", palavra_categoria);
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
        public static DataTable Rec_por_ingrediente(string palavra_ingrediente)
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
                    CommandText = "Procura_ingrediente",
                    CommandType = CommandType.StoredProcedure
                };
                cmdReceita.Parameters.AddWithValue("@palavra", palavra_ingrediente);
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
        public static DataTable Rec_nao_validadas()
        {
            SqlConnection cn = new SqlConnection
            {
                ConnectionString = DAL.Properties.Settings.Default.cnSQL
            };
            try
            {
                SqlCommand cmdReceita_nval = new SqlCommand
                {
                    Connection = cn,
                    CommandText = "Procura_rec_nvalidada",
                    CommandType = CommandType.StoredProcedure
                };

                cn.Open();
                DataTable dt = new DataTable();

                dt.Load(cmdReceita_nval.ExecuteReader());
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

        public static DataTable Todas_receitas()
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
                    CommandText = "Todas_Rec_Aprovadas_ficha",
                    CommandType = CommandType.StoredProcedure
                };
                cn.Open();

                DataTable dti = new DataTable();

                dti.Load(cmd.ExecuteReader());
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
        public static DataTable Receitas_Favoritas(string userid)
        {
            SqlConnection cn = new SqlConnection
            {
                ConnectionString = DAL.Properties.Settings.Default.cnSQL
            };

            try
            {
                SqlCommand cmdLista_Fav = new SqlCommand
                {
                    Connection = cn,
                    CommandText = "Lista_Receitas_Favoritas",
                    CommandType = CommandType.StoredProcedure
                };
                cmdLista_Fav.Parameters.AddWithValue("@userid", userid);
                cn.Open();
                DataTable dt = new DataTable();

                dt.Load(cmdLista_Fav.ExecuteReader());
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

        public static DataTable Rec_por_recid(string recid)
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
                    CommandText = "Detalhe_Receita_PorId",
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
        public static string Recid_por_nome(string nome)
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
                    CommandText = "Recid_Nome",
                    CommandType = CommandType.StoredProcedure
                };
                cmdReceita.Parameters.AddWithValue("@Nome", nome);
                cn.Open();
                DataTable dt = new DataTable();

                dt.Load(cmdReceita.ExecuteReader());



                string Recid = dt.Rows[0]["Recid"].ToString();
                return Recid;
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
        public static string Recid_por_tudo(string palavra)
        {
            SqlConnection cn = new SqlConnection
            {
                ConnectionString = DAL.Properties.Settings.Default.cnSQL
            };
            SqlCommand cmdReceita = new SqlCommand
            {
                Connection = cn,
                CommandText = "Procura_Tudo",
                CommandType = CommandType.StoredProcedure
            };
            try
            {
                cmdReceita.Parameters.AddWithValue("@palavra", palavra);
                cn.Open();
                DataTable dt = new DataTable();

                dt.Load(cmdReceita.ExecuteReader());
                string Recid = dt.Rows[0]["Recid"].ToString();
                return Recid;
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
        public static int Insere_Receita(DataTable dti, string[] parte1, byte[] bytes)
        {
            SqlConnection cn = new SqlConnection
            {
                ConnectionString = DAL.Properties.Settings.Default.cnSQL
            };

            SqlCommand cmd1 = new SqlCommand
            {
                Connection = cn,
                CommandText = "Insere_Receita",
                CommandType = CommandType.StoredProcedure
            };
            SqlCommand cmd2 = new SqlCommand
            {
                Connection = cn,
                CommandText = "Insere_lista_ing",
                CommandType = CommandType.StoredProcedure
            };

            cn.Open();


            SqlTransaction trns = cn.BeginTransaction();
            cmd1.Transaction = trns;
            cmd2.Transaction = trns;


            try
            {

                cmd1.Parameters.AddWithValue("@CategoriaID_ex", parte1[1]);
                cmd1.Parameters.AddWithValue("@UserId_ex", parte1[5]);
                cmd1.Parameters.AddWithValue("@Nome", parte1[0]);
                cmd1.Parameters.AddWithValue("@GrauDificuldadeID_ex", parte1[3]);
                cmd1.Parameters.AddWithValue("@NumDoses", Convert.ToInt32(parte1[2]));
                cmd1.Parameters.AddWithValue("@Preparacao", parte1[6]);
                cmd1.Parameters.AddWithValue("@TempoPrep", parte1[4]);
                cmd1.Parameters.AddWithValue("@Aprovada", Convert.ToInt32(parte1[7]));
                cmd1.Parameters.AddWithValue("@Foto", bytes);
                cmd1.ExecuteNonQuery();






                for (int i = 0; i <= dti.Rows.Count - 1; i++)
                {
                    cmd2.Parameters.AddWithValue("@IngredienteNome", dti.Rows[i]["Ingredientes"].ToString());

                    cmd2.Parameters.AddWithValue("@Quantidade", dti.Rows[i]["Quantidade"].ToString());
                    cmd2.Parameters.AddWithValue("@UnidadeMedida_nome", dti.Rows[i]["Unidade"].ToString());

                    cmd2.ExecuteNonQuery();
                    cmd2.Parameters.Clear();

                };
            
            trns.Commit();
                return 1;
            }
            catch (Exception)

            {
                trns.Rollback();
                return 0;
            }
            finally

            {
                cn.Close();
                
            }
              
             
        }
        public static string Update_Receita(DataGridView dgv, int Recid, string[] parte1)
        {
            SqlConnection cn = new SqlConnection
            {
                ConnectionString = DAL.Properties.Settings.Default.cnSQL
            };

            SqlCommand cmd1 = new SqlCommand
            {
                Connection = cn,
                CommandText = "Update_lista_ing",
                CommandType = CommandType.StoredProcedure
            };
            SqlCommand cmd2 = new SqlCommand
            {
                Connection = cn,
                CommandText = "Update_Receita",
                CommandType = CommandType.StoredProcedure
            };

            cn.Open();


            SqlTransaction trns = cn.BeginTransaction();
            cmd1.Transaction = trns;
            cmd2.Transaction = trns;

            try
            {
                for (int i = 0; i <= dgv.Rows.Count - 1; i++)
                {
                    cmd1.Parameters.AddWithValue("@IngReceitaID", dgv.Rows[i].Cells[0].Value);
                    cmd1.Parameters.AddWithValue("@IngredienteNome", dgv.Rows[i].Cells[2].Value);
                    cmd1.Parameters.AddWithValue("@Quantidade", dgv.Rows[i].Cells[3].Value);
                    cmd1.Parameters.AddWithValue("@UnidadeMedidaID", dgv.Rows[i].Cells[4].Value);
                    cmd1.Parameters.AddWithValue("@Recid", Recid);
                    cmd1.ExecuteNonQuery();
                    cmd1.Parameters.Clear();

                };



                cmd2.Parameters.AddWithValue("@Recid", Recid);
                cmd2.Parameters.AddWithValue("@CategoriaID_ex", parte1[1]);
                cmd2.Parameters.AddWithValue("@UserId_ex", parte1[5]);
                cmd2.Parameters.AddWithValue("@Nome", parte1[0]);
                cmd2.Parameters.AddWithValue("@GrauDificuldadeID_ex", parte1[3]);
                cmd2.Parameters.AddWithValue("@NumDoses", Convert.ToInt32(parte1[2]));
                cmd2.Parameters.AddWithValue("@Preparacao", parte1[6]);
                cmd2.Parameters.AddWithValue("@TempoPrep", parte1[4]);
                cmd2.Parameters.AddWithValue("@Aprovada", Convert.ToInt32(parte1[7]));

                cmd2.ExecuteNonQuery();

                trns.Commit();
                return "Update feito com sucesso!";
            }

            catch (Exception)

            {
                trns.Rollback();
                return "Algo correu mal, Update falhou!";
            }
            finally

            {
                cn.Close();
            }

        }

        public static List<string> NomesRec()

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
                    CommandText = "lista_todos_nomes_receitas",
                    CommandType = CommandType.StoredProcedure
                };
                cn.Open();
                SqlDataReader reader = cmdListaTodosIng.ExecuteReader();

                List<string> nomes = new List<string>();
                while (reader.Read())
                {

                    string nome = reader["Nome"].ToString();
                    nomes.Add(nome);

                }
                return nomes;
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

        public static string Adiciona_Favoritas(int recid, string userid)
        {

            SqlConnection cn = new SqlConnection
            {
                ConnectionString = DAL.Properties.Settings.Default.cnSQL
            };

            try
            {
                SqlCommand cmd_rf = new SqlCommand
                {
                    Connection = cn,
                    CommandText = "Adiciona_favoritas",
                    CommandType = CommandType.StoredProcedure
                };
           
                cmd_rf.Parameters.AddWithValue("@userId", userid);
                cmd_rf.Parameters.AddWithValue("@ReceitaId", recid);
                cn.Open();
                cmd_rf.ExecuteNonQuery();
                return "Receita favorita com sucesso. Obrigada";
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






    }
}
