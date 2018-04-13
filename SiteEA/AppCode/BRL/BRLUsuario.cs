
namespace SiteEA.AppCode.BRL
{
    public class BRLUsuario : DAL.DALUsuario
    {
        public BRLUsuario()
        {
        }

        public void Incluir()
        {
            arrParametros = new System.Collections.Generic.List<System.Data.SqlClient.SqlParameter>();

            string campos = "insert into " + Tabela + " (";
            string valores = "values (";

            campos += " IdLoja,";
            valores += " @IdLoja,";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@IdLoja", this.IdLoja));

            campos += " Nome,";
            valores += " @Nome,";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@Nome", this.Nome));

            campos += " Usuario,";
            valores += " @Usuario,";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@Usuario", this.Usuario));

            campos += " Senha,";
            valores += " @Senha,";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@Senha", this.Senha));

            campos += " Nivel,";
            valores += " @Nivel,";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@Nivel", this.Nivel));

            campos += " Email,";
            valores += " @Email,";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@Email", this.Email));

            campos += " Status)";
            valores += " @Status);";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@Status", this.Status));

            base.execIncluir(campos + valores, arrParametros);
            this.Id = this.getId();
        }

        public void Alterar()
        {
            arrParametros = new System.Collections.Generic.List<System.Data.SqlClient.SqlParameter>();
            string query = "update " + Tabela + " set ";

            query += " IdLoja = @IdLoja,";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@IdLoja", this.IdLoja));

            query += " Nome = @Nome,";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@Nome", this.Nome));

            query += " Usuario = @Usuario,";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@Usuario", this.Usuario));

            query += " Senha = @Senha,";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@Senha", this.Senha));

            query += " Nivel = @Nivel,";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@Nivel", this.Nivel));

            query += " Email = @Email,";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@Email", this.Email));

            query += " Status = @Status";
            arrParametros.Add(new System.Data.SqlClient.SqlParameter("@Status", this.Status));

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
            this.IdLoja = DMFramework.TratarDado.AtribuirInt(base.getDataRow(linha)["IdLoja"]);
            this.Nome = DMFramework.TratarDado.AtribuirString(base.getDataRow(linha)["Nome"]);
            this.Usuario = DMFramework.TratarDado.AtribuirString(base.getDataRow(linha)["Usuario"]);
            this.Senha = DMFramework.TratarDado.AtribuirString(base.getDataRow(linha)["Senha"]);
            this.Nivel = DMFramework.TratarDado.AtribuirByte(base.getDataRow(linha)["Nivel"]);
            this.Email = DMFramework.TratarDado.AtribuirString(base.getDataRow(linha)["Email"]);
            this.Status = DMFramework.TratarDado.AtribuirByte(base.getDataRow(linha)["Status"]);
        }
    }
}