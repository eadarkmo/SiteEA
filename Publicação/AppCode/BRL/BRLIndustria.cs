
namespace SiteEA.AppCode.BRL
{
    public class BRLIndustria : DAL.DALIndustria
    {
        public BRLIndustria()
        {
        }

        public void Incluir()
        {
            arrParametros = new System.Collections.Generic.List<System.Data.SqlClient.SqlParameter>();

            string campos = "insert into " + Tabela + " (";
            string valores = "values (";

            campos += " RazaoSocial,";
            valores += " @RazaoSocial,";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@RazaoSocial", this.RazaoSocial));

            campos += " NomeFantasia,";
            valores += " @NomeFantasia,";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@NomeFantasia", this.NomeFantasia));

            campos += " NomeEquivalente,";
            valores += " @NomeEquivalente,";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@NomeEquivalente", this.NomeEquivalente));

            campos += " CNPJ,";
            valores += " @CNPJ,";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@CNPJ", this.CNPJ));

            campos += " IdEndereco,";
            valores += " @IdEndereco,";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@IdEndereco", this.IdEndereco));

            campos += " Lucro,";
            valores += " @Lucro,";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@Lucro", this.Lucro));

            campos += " Ipi,";
            valores += " @Ipi,";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@Ipi", this.Ipi));

            campos += " Frete)";
            valores += " @Frete);";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@Frete", this.Frete));

            base.execIncluir(campos + valores, arrParametros);
            this.Id = this.getId();
        }

        public void Alterar()
        {
            arrParametros = new System.Collections.Generic.List<System.Data.SqlClient.SqlParameter>();
            string query = "update " + Tabela + " set ";

            query += " RazaoSocial = @RazaoSocial,";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@RazaoSocial", this.RazaoSocial));

            query += " NomeFantasia = @NomeFantasia,";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@NomeFantasia", this.NomeFantasia));

            query += " NomeEquivalente = @NomeEquivalente,";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@NomeEquivalente", this.NomeEquivalente));

            query += " CNPJ = @CNPJ,";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@CNPJ", this.CNPJ));

            query += " IdEndereco = @IdEndereco,";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@IdEndereco", this.IdEndereco));

            query += " Lucro = @Lucro,";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@Lucro", this.Lucro));

            query += " Ipi = @Ipi,";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@Ipi", this.Ipi));

            query += " Frete = @Frete";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@Frete", this.Frete));

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
            this.RazaoSocial = DMFramework.TratarDado.AtribuirString(base.getDataRow(linha)["RazaoSocial"]);
            this.NomeFantasia = DMFramework.TratarDado.AtribuirString(base.getDataRow(linha)["NomeFantasia"]);
            this.NomeEquivalente = DMFramework.TratarDado.AtribuirString(base.getDataRow(linha)["NomeEquivalente"]);
            this.CNPJ = DMFramework.TratarDado.AtribuirString(base.getDataRow(linha)["CNPJ"]);
            this.IdEndereco = DMFramework.TratarDado.AtribuirInt(base.getDataRow(linha)["IdEndereco"]);
            this.Lucro = DMFramework.TratarDado.AtribuirByte(base.getDataRow(linha)["Lucro"]);
            this.Ipi = DMFramework.TratarDado.AtribuirByte(base.getDataRow(linha)["Ipi"]);
            this.Frete = DMFramework.TratarDado.AtribuirByte(base.getDataRow(linha)["Frete"]);
        }
    }
}