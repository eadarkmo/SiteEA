
namespace SiteEA.AppCode.BRL
{
    public class BRLEndereco : DAL.DALEndereco
    {
        public BRLEndereco()
        {
        }

        public void Incluir()
        {
            arrParametros = new System.Collections.Generic.List<System.Data.SqlClient.SqlParameter>();

            string campos = "insert into " + Tabela + " (";
            string valores = "values (";

            campos += " Cidade,";
            valores += " @Cidade,";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@Cidade", this.Cidade));

            campos += " Bairro,";
            valores += " @Bairro,";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@Bairro", this.Bairro));

            campos += " Endereco,";
            valores += " @Endereco,";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@Endereco", this.Endereco));

            campos += " Cep)";
            valores += " @Cep);";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@Cep", this.Cep));

            base.execIncluir(campos + valores, arrParametros);
            this.Id = this.getId();
        }

        public void Alterar()
        {
            arrParametros = new System.Collections.Generic.List<System.Data.SqlClient.SqlParameter>();
            string query = "update " + Tabela + " set ";

            query += " Cidade = @Cidade,";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@Cidade", this.Cidade));

            query += " Bairro = @Bairro,";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@Bairro", this.Bairro));

            query += " Endereco = @Endereco,";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@Endereco", this.Endereco));

            query += " Cep = @Cep";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@Cep", this.Cep));

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
            this.Cidade = DMFramework.TratarDado.AtribuirInt(base.getDataRow(linha)["Cidade"]);
            this.Bairro = DMFramework.TratarDado.AtribuirString(base.getDataRow(linha)["Bairro"]);
            this.Endereco = DMFramework.TratarDado.AtribuirString(base.getDataRow(linha)["Endereco"]);
            this.Cep = DMFramework.TratarDado.AtribuirString(base.getDataRow(linha)["Cep"]);
        }
    }
}