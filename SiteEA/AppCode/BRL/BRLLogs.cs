
namespace SiteEA.AppCode.BRL
{
    public class BRLLogs : DAL.DALLogs
    {
        public BRLLogs()
        {
        }

        public void Incluir()
        {
            arrParametros = new System.Collections.Generic.List<System.Data.SqlClient.SqlParameter>();

            string campos = "set dateformat dmy insert into " + Tabela + " (";
            string valores = "values (";

            campos += " IdUsuario,";
            valores += " @IdUsuario,";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@IdUsuario", this.IdUsuario));

            campos += " IdOperacao,";
            valores += " @IdOperacao,";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@IdOperacao", this.IdOperacao));

            campos += " IdArea,";
            valores += " @IdArea,";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@IdArea", this.IdArea));

            campos += " Data,";
            valores += " @Data,";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@Data", this.Data));

            campos += " Descricao)";
            valores += " @Descricao);";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@Descricao", this.Descricao));

            base.execIncluir(campos + valores, arrParametros);
            this.Id = this.getId();
        }

        public void Alterar()
        {
            arrParametros = new System.Collections.Generic.List<System.Data.SqlClient.SqlParameter>();
            string query = "set dateformat dmy update " + Tabela + " set ";

            query += " IdUsuario = @IdUsuario,";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@IdUsuario", this.IdUsuario));

            query += " IdOperacao = @IdOperacao,";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@IdOperacao", this.IdOperacao));

            query += " IdArea = @IdArea,";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@IdArea", this.IdArea));

            query += " Data = @Data,";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@Data", this.Data));

            query += " Descricao = @Descricao";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@Descricao", this.Descricao));

            query += " where Id = @Id;";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@Id", this.Id));

            base.execAlterar(query, arrParametros);
        }

        public void Excluir()
        {
            arrParametros = new System.Collections.Generic.List<System.Data.SqlClient.SqlParameter>();
            string query = "set dateformat dmy delete from " + Tabela + " where";
            query += " Id = @Id;";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@Id", this.Id));

            base.execExcluir(query, arrParametros);
        }

        public void SelecaoPadrao()
        {
            string query = "set dateformat dmy select * from " + Tabela + ";";
            base.PreencheTabela(query);
        }

        public void LerRegistro(int iId)
        {
            arrParametros = new System.Collections.Generic.List<System.Data.SqlClient.SqlParameter>();
            string query = "set dateformat dmy select * from " + Tabela;

            query += " where Id = @Id;";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@Id", iId));

            base.PreencheTabela(query, arrParametros);
            PopularCampos(0);
        }

        public void PopularCampos(int linha)
        {
            this.Id = DMFramework.TratarDado.AtribuirInt(base.getDataRow(linha)["Id"]);
            this.IdUsuario = DMFramework.TratarDado.AtribuirInt(base.getDataRow(linha)["IdUsuario"]);
            this.IdOperacao = DMFramework.TratarDado.AtribuirInt(base.getDataRow(linha)["IdOperacao"]);
            this.IdArea = DMFramework.TratarDado.AtribuirInt(base.getDataRow(linha)["IdArea"]);
            this.Data = DMFramework.TratarDado.AtribuirDateTime(base.getDataRow(linha)["Data"]);
            this.Descricao = DMFramework.TratarDado.AtribuirString(base.getDataRow(linha)["Descricao"]);
        }
    }
}