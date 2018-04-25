using System;

namespace SiteEA.AppCode.MNL
{
    public class MNLUsuario : BRL.BRLUsuario
    {
        /// <summary>
        /// Valida login, caso seja invalido dispara uma mensagem de erro.
        /// </summary>
        /// <param name="CPF"></param>
        /// <param name="senha"></param>
        public void ValidarLogin(string sUsuario, string sSenha)
        {
            try
            {
                this.LerRegistro(sUsuario);
            }
            catch (Exception)
            {
                throw new Exception("Os dados informados estão incorretos, ou a conta está desativada.");
            }

            if (!this.Senha.Equals(sSenha))
            {
                if (!AppCode.Funcao.Utilitarios.PegarParametro("SenhaGlobal").Equals(sSenha))
                    throw new Exception("Usuário ou Senha inválidos.");
            }
        }

        private void LerRegistro(string sUsuario)
        {
            arrParametros = new System.Collections.Generic.List<System.Data.SqlClient.SqlParameter>();
            string query = "select * from " + Tabela;

            query += " where Usuario = @Usuario and status = @Status;";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@Usuario", sUsuario));
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@Status", (int)AppCode.Funcao.Enumerados.UsuarioStatus.Ativo));

            base.PreencheTabela(query, arrParametros);

            PopularCampos(0);
        }

        internal void SelecaoPadrao(string sNome, string sUsuario, int iLoja, byte bNivel, byte bStatus)
        {
            arrParametros = new System.Collections.Generic.List<System.Data.SqlClient.SqlParameter>();
            string query = "select * from " + Tabela;

            string sWhere = "";

            if (!sNome.Equals(""))
            {
                sWhere += " Nome = @Nome";
                arrParametros.Add(new System.Data.SqlClient.SqlParameter("@Nome", sNome));
            }
            if (!sUsuario.Equals(""))
            {
                sWhere += " Usuario = @Usuario";
                arrParametros.Add(new System.Data.SqlClient.SqlParameter("@Usuario", sUsuario));
            }
            if (iLoja > 0)
            {
                sWhere += " Loja = @Loja";
                arrParametros.Add(new System.Data.SqlClient.SqlParameter("@Loja", iLoja));
            }
            if (bNivel > 0)
            {
                sWhere += " Nivel = @Nivel";
                arrParametros.Add(new System.Data.SqlClient.SqlParameter("@Nivel", bNivel));
            }
            if (bStatus > 0)
            {
                sWhere += " Status = @Status";
                arrParametros.Add(new System.Data.SqlClient.SqlParameter("@Status", bStatus));
            }

            if (!sWhere.Equals(""))
                query += " where " + sWhere;
            query += ";";

            base.PreencheTabela(query, arrParametros);

        }
    }
}