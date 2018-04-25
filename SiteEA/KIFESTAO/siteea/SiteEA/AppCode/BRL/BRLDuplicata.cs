
namespace SiteEA.AppCode.BRL
{
    public class BRLDuplicata : DAL.DALDuplicata
    {
        public BRLDuplicata()
        {
        }

        public void Incluir()
        {
            arrParametros = new System.Collections.Generic.List<System.Data.SqlClient.SqlParameter>();

            string campos = "set dateformat dmy insert into " + Tabela + " (";
            string valores = "values (";

            campos += " IdNota,";
            valores += " @IdNota,";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@IdNota", this.IdNota));

            campos += " IdLoja,";
            valores += " @IdLoja,";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@IdLoja", this.IdLoja));

            campos += " IdUsuario,";
            valores += " @IdUsuario,";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@IdUsuario", this.IdUsuario));

            campos += " Valor,";
            valores += " @Valor,";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@Valor", this.Valor));

            campos += " Parcela,";
            valores += " @Parcela,";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@Parcela", this.Parcela));

            campos += " FoiBanco,";
            valores += " @FoiBanco,";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@FoiBanco", this.FoiBanco));

            campos += " Status,";
            valores += " @Status,";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@Status", this.Status));

            campos += " DataVencimento,";
            valores += " @DataVencimento,";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@DataVencimento", this.DataVencimento));

            campos += " DataPagamento,";
            valores += " @DataPagamento,";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@DataPagamento", this.DataPagamento));

            campos += " ValorPago,";
            valores += " @ValorPago,";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@ValorPago", this.ValorPago));

            campos += " Desconto,";
            valores += " @Desconto,";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@Desconto", this.Desconto));

            campos += " Acrescimo,";
            valores += " @Acrescimo,";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@Acrescimo", this.Acrescimo));

            campos += " MotivoAlteracao)";
            valores += " @MotivoAlteracao);";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@MotivoAlteracao", this.MotivoAlteracao));

            base.execIncluir(campos + valores, arrParametros);
            this.Id = this.getId();
        }

        public void Alterar()
        {
            arrParametros = new System.Collections.Generic.List<System.Data.SqlClient.SqlParameter>();
            string query = "set dateformat dmy update " + Tabela + " set ";

            query += " IdNota = @IdNota,";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@IdNota", this.IdNota));

            query += " IdLoja = @IdLoja,";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@IdLoja", this.IdLoja));

            query += " IdUsuario = @IdUsuario,";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@IdUsuario", this.IdUsuario));

            query += " Valor = @Valor,";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@Valor", this.Valor));

            query += " Parcela = @Parcela,";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@Parcela", this.Parcela));

            query += " FoiBanco = @FoiBanco,";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@FoiBanco", this.FoiBanco));

            query += " Status = @Status,";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@Status", this.Status));

            query += " DataVencimento = @DataVencimento,";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@DataVencimento", this.DataVencimento));

            query += " DataPagamento = @DataPagamento,";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@DataPagamento", this.DataPagamento));

            query += " ValorPago = @ValorPago,";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@ValorPago", this.ValorPago));

            query += " Desconto = @Desconto,";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@Desconto", this.Desconto));

            query += " Acrescimo = @Acrescimo,";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@Acrescimo", this.Acrescimo));

            query += " MotivoAlteracao = @MotivoAlteracao";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@MotivoAlteracao", this.MotivoAlteracao));

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
            this.IdNota = DMFramework.TratarDado.AtribuirInt(base.getDataRow(linha)["IdNota"]);
            this.IdLoja = DMFramework.TratarDado.AtribuirInt(base.getDataRow(linha)["IdLoja"]);
            this.IdUsuario = DMFramework.TratarDado.AtribuirInt(base.getDataRow(linha)["IdUsuario"]);
            this.Valor = DMFramework.TratarDado.AtribuirDecimal(base.getDataRow(linha)["Valor"]);
            this.Parcela = DMFramework.TratarDado.AtribuirByte(base.getDataRow(linha)["Parcela"]);
            this.FoiBanco = bool.Parse(DMFramework.TratarDado.AtribuirString(base.getDataRow(linha)["FoiBanco"]));
            this.Status = DMFramework.TratarDado.AtribuirByte(base.getDataRow(linha)["Status"]);
            this.DataVencimento = DMFramework.TratarDado.AtribuirDateTime(base.getDataRow(linha)["DataVencimento"]);
            this.DataPagamento = DMFramework.TratarDado.AtribuirDateTime(base.getDataRow(linha)["DataPagamento"]);
            this.ValorPago = DMFramework.TratarDado.AtribuirDecimal(base.getDataRow(linha)["ValorPago"]);
            this.Desconto = DMFramework.TratarDado.AtribuirDecimal(base.getDataRow(linha)["Desconto"]);
            this.Acrescimo = DMFramework.TratarDado.AtribuirDecimal(base.getDataRow(linha)["Acrescimo"]);
            this.MotivoAlteracao = DMFramework.TratarDado.AtribuirString(base.getDataRow(linha)["MotivoAlteracao"]);
        }
    }
}