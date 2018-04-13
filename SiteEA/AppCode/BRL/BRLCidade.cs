
namespace SiteEA.AppCode.BRL
{
    public class BRLCidade : DAL.DALCidade
    {
        public BRLCidade()
        {
        }

        public void Incluir()
        {
            arrParametros = new System.Collections.Generic.List<System.Data.SqlClient.SqlParameter>();

            string campos = "insert into " + Tabela + " (";
            string valores = "values (";

            campos += " Uf,";
            valores += " @Uf,";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@Uf", this.Uf));

            campos += " Nome)";
            valores += " @Nome);";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@Nome", this.Nome));

            base.execIncluir(campos + valores, arrParametros);
            this.Id = this.getId();
        }

        public void Alterar()
        {
            arrParametros = new System.Collections.Generic.List<System.Data.SqlClient.SqlParameter>();
            string query = "update " + Tabela + " set ";

            query += " Uf = @Uf,";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@Uf", this.Uf));

            query += " Nome = @Nome";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@Nome", this.Nome));

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
            this.Uf = DMFramework.TratarDado.AtribuirByte(base.getDataRow(linha)["Uf"]);
            this.Nome = DMFramework.TratarDado.AtribuirString(base.getDataRow(linha)["Nome"]);
        }
    }
}