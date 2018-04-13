
namespace SiteEA.AppCode.BRL
{
    public class BRLNota : DAL.DALNota
    {
        public BRLNota()
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

            campos += " IdLoja,";
            valores += " @IdLoja,";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@IdLoja", this.IdLoja));

            campos += " IdIndustria,";
            valores += " @IdIndustria,";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@IdIndustria", this.IdIndustria));

            campos += " Numero,";
            valores += " @Numero,";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@Numero", this.Numero));

            campos += " Valor,";
            valores += " @Valor,";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@Valor", this.Valor));

            campos += " Parcelas,";
            valores += " @Parcelas,";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@Parcelas", this.Parcelas));

            campos += " Natureza,";
            valores += " @Natureza,";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@Natureza", this.Natureza));

            campos += " ValorTotalNota,";
            valores += " @ValorTotalNota,";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@ValorTotalNota", this.ValorTotalNota));

            campos += " ValorTotalProduto,";
            valores += " @ValorTotalProduto,";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@ValorTotalProduto", this.ValorTotalProduto));

            campos += " DataChegada)";
            valores += " @DataChegada);";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@DataChegada", this.DataChegada));

            base.execIncluir(campos + valores, arrParametros);
            this.Id = this.getId();
        }

        public void Alterar()
        {
            arrParametros = new System.Collections.Generic.List<System.Data.SqlClient.SqlParameter>();
            string query = "set dateformat dmy update " + Tabela + " set ";

            query += " IdUsuario = @IdUsuario,";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@IdUsuario", this.IdUsuario));

            query += " IdLoja = @IdLoja,";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@IdLoja", this.IdLoja));

            query += " IdIndustria = @IdIndustria,";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@IdIndustria", this.IdIndustria));

            query += " Numero = @Numero,";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@Numero", this.Numero));

            query += " Valor = @Valor,";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@Valor", this.Valor));

            query += " Parcelas = @Parcelas,";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@Parcelas", this.Parcelas));

            query += " Natureza = @Natureza,";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@Natureza", this.Natureza));

            query += " ValorTotalNota = @ValorTotalNota,";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@ValorTotalNota", this.ValorTotalNota));

            query += " ValorTotalProduto = @ValorTotalProduto,";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@ValorTotalProduto", this.ValorTotalProduto));

            query += " DataChegada = @DataChegada";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@DataChegada", this.DataChegada));

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
            this.IdLoja = DMFramework.TratarDado.AtribuirInt(base.getDataRow(linha)["IdLoja"]);
            this.IdIndustria = DMFramework.TratarDado.AtribuirInt(base.getDataRow(linha)["IdIndustria"]);
            this.Numero = DMFramework.TratarDado.AtribuirInt(base.getDataRow(linha)["Numero"]);
            this.Valor = DMFramework.TratarDado.AtribuirDecimal(base.getDataRow(linha)["Valor"]);
            this.Parcelas = DMFramework.TratarDado.AtribuirByte(base.getDataRow(linha)["Parcelas"]);
            this.Natureza = DMFramework.TratarDado.AtribuirString(base.getDataRow(linha)["Natureza"]);
            this.ValorTotalNota = DMFramework.TratarDado.AtribuirDecimal(base.getDataRow(linha)["ValorTotalNota"]);
            this.ValorTotalProduto = DMFramework.TratarDado.AtribuirDecimal(base.getDataRow(linha)["ValorTotalProduto"]);
            this.DataChegada = DMFramework.TratarDado.AtribuirDateTime(base.getDataRow(linha)["DataChegada"]);
        }
    }
}