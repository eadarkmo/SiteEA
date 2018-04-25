using System;
using System.Data;
using System.Data.SqlClient;

namespace SiteEA.AppCode.Conexao
{
    public class ConexaoSQLServer : System.Web.UI.Page
    {
        #region Padrao
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string tabela;
        protected string Tabela
        {
            get { return tabela; }
            set { tabela = value; }
        }

        protected DataSet ds = new DataSet();

        private System.Collections.Generic.List<System.Data.SqlClient.SqlParameter> ArrParametros;

        public System.Collections.Generic.List<System.Data.SqlClient.SqlParameter> arrParametros
        {
            get { return ArrParametros; }
            set { ArrParametros = value; }
        }

        SqlConnection _connection;
        SqlCommand cmd;

        public System.Data.DataSet getDataSet()
        {
            return this.ds;
        }

        public System.Data.DataTable getDataTable()
        {
            return this.ds.Tables[Tabela];
        }

        public System.Data.DataView getDataView()
        {
            if (this.ds.Tables[Tabela] == null)
            {
                return null;
            }
            else
            {
                return this.ds.Tables[Tabela].DefaultView;
            }
        }

        public System.Data.DataRow getDataRow(int Linha)
        {
            return this.ds.Tables[Tabela].Rows[Linha];
        }

        public int getId()
        {
            return Id;
        }

        private void criaConexao(string sDataBase)
        {
            try
            {
                string sUsuario = AppCode.Funcao.Utilitarios.PegarParametroCodificado("UsuarioSQLSERVER");
                string sSenha = AppCode.Funcao.Utilitarios.PegarParametroCodificado("SenhaSQLSERVER");
                string sServidor = AppCode.Funcao.Utilitarios.PegarParametroCodificado("ServidorSQLSERVER");
                if (sDataBase.Equals(""))
                    sDataBase = AppCode.Funcao.Utilitarios.PegarParametroCodificado("DataBaseSQLSERVER");
                string sCon = "Data Source=" + sServidor + ";database=" + sDataBase + ";User ID=" + sUsuario + ";Password=" + sSenha;
                _connection = new SqlConnection(sCon);
            }
            catch (Exception)
            {
                throw new Exception("Erro ao criar conexao com o Banco de dados. Contate o ADM.");
            }
            try
            {
                cmd = new SqlCommand();
                cmd.Connection = _connection;
            }
            catch (Exception)
            {
                //throw new Exception("Erro na cmd: " + ex.Message);
                throw new Exception("Erro ao executar comando no Banco de dados. Contate o ADM.");
            }
        }
        #endregion

        #region Valores Parametrizados List<SqlParameter>

        #region Passando DataBase

        private void execExecuteNonQuery(string sQuery, System.Collections.Generic.List<SqlParameter> arrParametros, string sDataBase)
        {
            criaConexao(sDataBase);
            _connection.Open();
            cmd.CommandText = sQuery;
            foreach (SqlParameter parametro in arrParametros)
            {
                cmd.Parameters.Add(parametro);
            }
            try
            {
                int iLinhasAfetadas = cmd.ExecuteNonQuery();
                _connection.Close();
            }
            catch (Exception)
            {
                throw new Exception("Erro ao executar comando no Banco de dados. Contate o ADM.");
            }
        }

        protected void PreencheTabela(string sQuery, System.Collections.Generic.List<System.Data.SqlClient.SqlParameter> arrParametros, string sDataBase)
        {
            ds.Clear();
            ds.Reset();
            ds.Tables.Clear();
            criaConexao(sDataBase);
            _connection.Open();

            SqlDataAdapter adapter = new SqlDataAdapter();

            adapter.SelectCommand = new SqlCommand(sQuery, _connection);

            foreach (SqlParameter parametro in arrParametros)
            {
                adapter.SelectCommand.Parameters.Add(parametro);
            }
            try
            {
                adapter.Fill(ds, tabela);
                adapter.Dispose();
                _connection.Close();
            }
            catch (Exception)
            {
                throw new Exception("Erro ao executar comando no Banco de dados. Contate o ADM.");
            }
        }

        protected void execIncluir(string sQuery, System.Collections.Generic.List<System.Data.SqlClient.SqlParameter> arrParametros, string sDataBase)
        {
            ds.Clear();
            ds.Reset();
            ds.Tables.Clear();
            criaConexao(sDataBase);
            _connection.Open();

            SqlDataAdapter adapter = new SqlDataAdapter();

            adapter.SelectCommand = new SqlCommand(sQuery + " select @@identity as 'IdDoRegistro'", _connection);

            foreach (SqlParameter parametro in arrParametros)
            {
                adapter.SelectCommand.Parameters.Add(parametro);
            }
            try
            {
                adapter.Fill(ds, "retorno");

                foreach (System.Data.DataTable lclDataTable in ds.Tables)
                {
                    if (lclDataTable.TableName == "retorno")
                    {
                        foreach (System.Data.DataRow lclDataRow in lclDataTable.Rows)
                        {
                            if (lclDataRow["IdDoRegistro"] != System.DBNull.Value)
                            {
                                Id = Convert.ToInt32(lclDataRow["IdDoRegistro"]);
                            }
                        }
                    }
                }

                adapter.Dispose();
            }
            catch (Exception)
            {
                throw new Exception("Erro ao executar comando no Banco de dados. Contate o ADM.");
            }
            _connection.Close();
        }

        protected void execAlterar(string sQuery, System.Collections.Generic.List<System.Data.SqlClient.SqlParameter> arrParametros, string sDataBase)
        {
            execExecuteNonQuery(sQuery, arrParametros, sDataBase);
        }

        protected void execExcluir(string sQuery, System.Collections.Generic.List<System.Data.SqlClient.SqlParameter> arrParametros, string sDataBase)
        {
            execExecuteNonQuery(sQuery, arrParametros, sDataBase);
        }
        #endregion

        #region Sem Passar DataBase
        protected void PreencheTabela(string sQuery, System.Collections.Generic.List<System.Data.SqlClient.SqlParameter> arrParametros)
        {
            PreencheTabela(sQuery, arrParametros, "");
        }

        protected void execIncluir(string sQuery, System.Collections.Generic.List<System.Data.SqlClient.SqlParameter> arrParametros)
        {
            execIncluir(sQuery, arrParametros, "");
        }

        protected void execAlterar(string sQuery, System.Collections.Generic.List<System.Data.SqlClient.SqlParameter> arrParametros)
        {
            execExecuteNonQuery(sQuery, arrParametros, "");
        }

        protected void execExcluir(string sQuery, System.Collections.Generic.List<System.Data.SqlClient.SqlParameter> arrParametros)
        {
            execExecuteNonQuery(sQuery, arrParametros, "");
        }
        #endregion

        #endregion

        #region Valores Parametrizados ArrayList

        #region Passando DataBase
        private void execExecuteNonQuery(string sQuery, System.Collections.ArrayList arrParametros, string sDataBase)
        {
            criaConexao(sDataBase);
            _connection.Open();
            cmd.CommandText = sQuery;
            foreach (string parametro in arrParametros)
            {
                if (parametro.Contains("@"))
                {
                    string[] sParametro = parametro.Split(new char[] { '&' });
                    string parametroValor = "";
                    string parametroNome = "";
                    if (sParametro.Length > 1)
                    {
                        foreach (string param in sParametro)
                        {
                            if (param.StartsWith("@"))
                                parametroNome = param;
                            else
                                parametroValor += param;
                        }
                        cmd.Parameters.AddWithValue(parametroNome, parametroValor);
                    }
                }
            }
            try
            {
                int iLinhasAfetadas = cmd.ExecuteNonQuery();
                _connection.Close();
            }
            catch (Exception)
            {
                throw new Exception("Erro ao executar comando no Banco de dados. Contate o ADM.");
            }
        }

        public void execIncluir(string sQuery, System.Collections.ArrayList arrParametros, string sDataBase)
        {
            execExecuteNonQuery(sQuery, arrParametros, sDataBase);
        }

        public void execAlterar(string sQuery, System.Collections.ArrayList arrParametros, string sDataBase)
        {
            execExecuteNonQuery(sQuery, arrParametros, sDataBase);
        }

        public void execExcluir(string sQuery, System.Collections.ArrayList arrParametros, string sDataBase)
        {
            execExecuteNonQuery(sQuery, arrParametros, sDataBase);
        }

        protected void PreencheTabela(string ComandoSelect, System.Collections.ArrayList arrParametros, string sDataBase)
        {
            try
            {
                ds.Clear();
                ds.Reset();
                ds.Tables.Clear();
                criaConexao(sDataBase);
                _connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(ComandoSelect, _connection);

                foreach (string parametro in arrParametros)
                {
                    if (parametro.Contains("@"))
                    {
                        string[] sParametro = parametro.Split(new char[] { '&' });
                        string parametroValor = "";
                        string parametroNome = "";
                        if (sParametro.Length > 1)
                        {
                            foreach (string param in sParametro)
                            {
                                if (param.StartsWith("@"))
                                    parametroNome = param;
                                else
                                    parametroValor += param;
                            }
                            adapter.SelectCommand.Parameters.AddWithValue(parametroNome, parametroValor);
                        }
                    }
                }
                try
                {
                    adapter.Fill(ds, Tabela);
                    adapter.Dispose();
                    _connection.Close();
                }
                catch (Exception)
                {
                    throw new Exception("Erro ao executar comando no Banco de dados. Contate o ADM.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro em PreencheTabela(string)" + ex.Message);
            }
        }
        #endregion

        #region Sem Passar DataBase
        public void execIncluir(string sQuery, System.Collections.ArrayList arrParametros)
        {
            execExecuteNonQuery(sQuery, arrParametros, "");
        }

        public void execAlterar(string sQuery, System.Collections.ArrayList arrParametros)
        {
            execExecuteNonQuery(sQuery, arrParametros, "");
        }

        public void execExcluir(string sQuery, System.Collections.ArrayList arrParametros)
        {
            execExecuteNonQuery(sQuery, arrParametros, "");
        }

        protected void PreencheTabela(string ComandoSelect, System.Collections.ArrayList arrParametros)
        {
            PreencheTabela(ComandoSelect, arrParametros, "");
        }
        #endregion

        #endregion

        #region Valores sem Parametrizar

        #region Passando DataBase
        public void execIncluir(string sQuery, string sDataBase)
        {
            System.Collections.Generic.List<System.Data.SqlClient.SqlParameter> arrParametros = new System.Collections.Generic.List<SqlParameter>();
            execIncluir(sQuery, arrParametros, sDataBase);
        }

        public void execAlterar(string sQuery, string sDataBase)
        {
            System.Collections.Generic.List<System.Data.SqlClient.SqlParameter> arrParametros = new System.Collections.Generic.List<SqlParameter>();
            execAlterar(sQuery, arrParametros, sDataBase);
        }

        public void execExcluir(string sQuery, string sDataBase)
        {
            System.Collections.Generic.List<System.Data.SqlClient.SqlParameter> arrParametros = new System.Collections.Generic.List<SqlParameter>();
            execExcluir(sQuery, arrParametros, sDataBase);
        }

        protected void PreencheTabela(string sQuery, string sDataBase)
        {
            System.Collections.Generic.List<System.Data.SqlClient.SqlParameter> arrParametros = new System.Collections.Generic.List<SqlParameter>();
            PreencheTabela(sQuery, arrParametros, sDataBase);
        }
        #endregion

        #region Sem Passar DataBase
        public void execIncluir(string sQuery)
        {
            System.Collections.Generic.List<System.Data.SqlClient.SqlParameter> arrParametros = new System.Collections.Generic.List<SqlParameter>();
            execIncluir(sQuery, arrParametros, "");
        }

        public void execAlterar(string sQuery)
        {
            System.Collections.Generic.List<System.Data.SqlClient.SqlParameter> arrParametros = new System.Collections.Generic.List<SqlParameter>();
            execAlterar(sQuery, arrParametros, "");
        }

        public void execExcluir(string sQuery)
        {
            System.Collections.Generic.List<System.Data.SqlClient.SqlParameter> arrParametros = new System.Collections.Generic.List<SqlParameter>();
            execExcluir(sQuery, arrParametros, "");
        }

        protected void PreencheTabela(string sQuery)
        {
            System.Collections.Generic.List<System.Data.SqlClient.SqlParameter> arrParametros = new System.Collections.Generic.List<SqlParameter>();
            PreencheTabela(sQuery, arrParametros, "");
        }
        #endregion

        #endregion
    }
}