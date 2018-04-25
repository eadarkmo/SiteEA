
namespace SiteEA.AppCode.BRL
{
    public class BRLLoja : DAL.DALLoja
    {
        public BRLLoja()
        {
        }

        public void Incluir()
        {
            arrParametros = new System.Collections.Generic.List<System.Data.SqlClient.SqlParameter>();

            string campos = "insert into " + Tabela + " (";
            string valores = "values (";

            campos += " NomeFantasia,";
            valores += " @NomeFantasia,";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@NomeFantasia", this.NomeFantasia));

            campos += " RazaoSocial,";
            valores += " @RazaoSocial,";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@RazaoSocial", this.RazaoSocial));

            campos += " CNPJ,";
            valores += " @CNPJ,";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@CNPJ", this.CNPJ));

            campos += " IdEndereco)";
            valores += " @IdEndereco);";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@IdEndereco", this.IdEndereco));

            base.execIncluir(campos + valores, arrParametros);
            this.Id = this.getId();
        }

        public void Alterar()
        {
            arrParametros = new System.Collections.Generic.List<System.Data.SqlClient.SqlParameter>();
            string query = "update " + Tabela + " set ";

            query += " NomeFantasia = @NomeFantasia,";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@NomeFantasia", this.NomeFantasia));

            query += " RazaoSocial = @RazaoSocial,";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@RazaoSocial", this.RazaoSocial));

            query += " CNPJ = @CNPJ,";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@CNPJ", this.CNPJ));

            query += " IdEndereco = @IdEndereco";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@IdEndereco", this.IdEndereco));

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
            this.NomeFantasia = DMFramework.TratarDado.AtribuirString(base.getDataRow(linha)["NomeFantasia"]);
            this.RazaoSocial = DMFramework.TratarDado.AtribuirString(base.getDataRow(linha)["RazaoSocial"]);
            this.CNPJ = DMFramework.TratarDado.AtribuirString(base.getDataRow(linha)["CNPJ"]);
            this.IdEndereco = DMFramework.TratarDado.AtribuirInt(base.getDataRow(linha)["IdEndereco"]);
        }
    }
}