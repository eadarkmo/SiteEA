
namespace SiteEA.AppCode.BRL
{
    public class BRLTelefone : DAL.DALTelefone
    {
        public BRLTelefone()
        {
        }

        public void Incluir()
        {
            arrParametros = new System.Collections.Generic.List<System.Data.SqlClient.SqlParameter>();

            string campos = "insert into " + Tabela + " (";
            string valores = "values (";

            campos += " IdEntidade,";
            valores += " @IdEntidade,";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@IdEntidade", this.IdEntidade));

            campos += " Entidade,";
            valores += " @Entidade,";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@Entidade", this.Entidade));

            campos += " DDD,";
            valores += " @DDD,";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@DDD", this.DDD));

            campos += " Telefone,";
            valores += " @Telefone,";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@Telefone", this.Telefone));

            campos += " Descricao,";
            valores += " @Descricao,";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@Descricao", this.Descricao));

            campos += " Contato)";
            valores += " @Contato);";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@Contato", this.Contato));

            base.execIncluir(campos + valores, arrParametros);
            this.Id = this.getId();
        }

        public void Alterar()
        {
            arrParametros = new System.Collections.Generic.List<System.Data.SqlClient.SqlParameter>();
            string query = "update " + Tabela + " set ";

            query += " IdEntidade = @IdEntidade,";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@IdEntidade", this.IdEntidade));

            query += " Entidade = @Entidade,";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@Entidade", this.Entidade));

            query += " DDD = @DDD,";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@DDD", this.DDD));

            query += " Telefone = @Telefone,";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@Telefone", this.Telefone));

            query += " Descricao = @Descricao,";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@Descricao", this.Descricao));

            query += " Contato = @Contato";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@Contato", this.Contato));

            query += " where Id = @Id;";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@Id", this.Id));

            base.execAlterar(query, arrParametros);
        }

        public void Excluir()
        {
            arrParametros = new System.Collections.Generic.List<System.Data.SqlClient.SqlParameter>();
            string query = "delete from " + Tabela + " where";
            query += " Id = @Id;";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@Id", this.Id));

            base.execExcluir(query, arrParametros);
        }

        public void SelecaoPadrao()
        {
            string query = "select * from " + Tabela + ";";
            base.PreencheTabela(query);
        }

        public void LerRegistro(int iId)
        {
            arrParametros = new System.Collections.Generic.List<System.Data.SqlClient.SqlParameter>();
            string query = "select * from " + Tabela;

            query += " where Id = @Id;";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@Id", iId));

            base.PreencheTabela(query, arrParametros);
            PopularCampos(0);
        }

        public void PopularCampos(int linha)
        {
            this.Id = DMFramework.TratarDado.AtribuirInt(base.getDataRow(linha)["Id"]);
            this.IdEntidade = DMFramework.TratarDado.AtribuirInt(base.getDataRow(linha)["IdEntidade"]);
            this.Entidade = DMFramework.TratarDado.AtribuirByte(base.getDataRow(linha)["Entidade"]);
            this.DDD = DMFramework.TratarDado.AtribuirByte(base.getDataRow(linha)["DDD"]);
            this.Telefone = DMFramework.TratarDado.AtribuirChar(base.getDataRow(linha)["Telefone"]);
            this.Descricao = DMFramework.TratarDado.AtribuirString(base.getDataRow(linha)["Descricao"]);
            this.Contato = DMFramework.TratarDado.AtribuirString(base.getDataRow(linha)["Contato"]);
        }
    }
}