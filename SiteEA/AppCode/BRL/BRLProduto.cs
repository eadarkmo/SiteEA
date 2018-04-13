
namespace SiteEA.AppCode.BRL
{
    public class BRLProduto : DAL.DALProduto
    {
        public BRLProduto()
        {
        }

        public void Incluir()
        {
            arrParametros = new System.Collections.Generic.List<System.Data.SqlClient.SqlParameter>();

            string campos = "set dateformat dmy insert into " + Tabela + " (";
            string valores = "values (";

            campos += " IdIndustria,";
            valores += " @IdIndustria,";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@IdIndustria", this.IdIndustria));

            campos += " IdUsuario,";
            valores += " @IdUsuario,";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@IdUsuario", this.IdUsuario));

            campos += " IdUltimanota,";
            valores += " @IdUltimanota,";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@IdUltimanota", this.IdUltimanota));

            campos += " CodigoBarras,";
            valores += " @CodigoBarras,";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@CodigoBarras", this.CodigoBarras));

            campos += " CodigoProduto,";
            valores += " @CodigoProduto,";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@CodigoProduto", this.CodigoProduto));

            campos += " Nome,";
            valores += " @Nome,";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@Nome", this.Nome));

            campos += " PrecoCusto,";
            valores += " @PrecoCusto,";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@PrecoCusto", this.PrecoCusto));

            campos += " PrecoVenda,";
            valores += " @PrecoVenda,";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@PrecoVenda", this.PrecoVenda));

            campos += " Quantidade,";
            valores += " @Quantidade,";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@Quantidade", this.Quantidade));

            campos += " IPI,";
            valores += " @IPI,";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@IPI", this.IPI));

            campos += " ICMS,";
            valores += " @ICMS,";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@ICMS", this.ICMS));

            campos += " Lucro,";
            valores += " @Lucro,";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@Lucro", this.Lucro));

            campos += " UltimaAlteracao)";
            valores += " @UltimaAlteracao);";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@UltimaAlteracao", this.UltimaAlteracao));

            base.execIncluir(campos + valores, arrParametros);
            this.Id = this.getId();
        }

        public void Alterar()
        {
            arrParametros = new System.Collections.Generic.List<System.Data.SqlClient.SqlParameter>();
            string query = "set dateformat dmy update " + Tabela + " set ";

            query += " IdIndustria = @IdIndustria,";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@IdIndustria", this.IdIndustria));

            query += " IdUsuario = @IdUsuario,";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@IdUsuario", this.IdUsuario));

            query += " IdUltimanota = @IdUltimanota,";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@IdUltimanota", this.IdUltimanota));

            query += " CodigoBarras = @CodigoBarras,";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@CodigoBarras", this.CodigoBarras));

            query += " CodigoProduto = @CodigoProduto,";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@CodigoProduto", this.CodigoProduto));

            query += " Nome = @Nome,";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@Nome", this.Nome));

            query += " PrecoCusto = @PrecoCusto,";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@PrecoCusto", this.PrecoCusto));

            query += " PrecoVenda = @PrecoVenda,";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@PrecoVenda", this.PrecoVenda));

            query += " Quantidade = @Quantidade,";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@Quantidade", this.Quantidade));

            query += " IPI = @IPI,";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@IPI", this.IPI));

            query += " ICMS = @ICMS,";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@ICMS", this.ICMS));

            query += " Lucro = @Lucro,";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@Lucro", this.Lucro));

            query += " UltimaAlteracao = @UltimaAlteracao";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@UltimaAlteracao", this.UltimaAlteracao));

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
            this.IdIndustria = DMFramework.TratarDado.AtribuirInt(base.getDataRow(linha)["IdIndustria"]);
            this.IdUsuario = DMFramework.TratarDado.AtribuirInt(base.getDataRow(linha)["IdUsuario"]);
            this.IdUltimanota = DMFramework.TratarDado.AtribuirInt(base.getDataRow(linha)["IdUltimanota"]);
            this.CodigoBarras = DMFramework.TratarDado.AtribuirString(base.getDataRow(linha)["CodigoBarras"]);
            this.CodigoProduto = DMFramework.TratarDado.AtribuirInt(base.getDataRow(linha)["CodigoProduto"]);
            this.Nome = DMFramework.TratarDado.AtribuirString(base.getDataRow(linha)["Nome"]);
            this.PrecoCusto = DMFramework.TratarDado.AtribuirDecimal(base.getDataRow(linha)["PrecoCusto"]);
            this.PrecoVenda = DMFramework.TratarDado.AtribuirDecimal(base.getDataRow(linha)["PrecoVenda"]);
            this.Quantidade = DMFramework.TratarDado.AtribuirInt(base.getDataRow(linha)["Quantidade"]);
            this.IPI = DMFramework.TratarDado.AtribuirByte(base.getDataRow(linha)["IPI"]);
            this.ICMS = DMFramework.TratarDado.AtribuirByte(base.getDataRow(linha)["ICMS"]);
            this.Lucro = DMFramework.TratarDado.AtribuirByte(base.getDataRow(linha)["Lucro"]);
            this.UltimaAlteracao = DMFramework.TratarDado.AtribuirDateTime(base.getDataRow(linha)["UltimaAlteracao"]);
        }
    }
}