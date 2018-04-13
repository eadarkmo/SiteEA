using System;
namespace SiteEA.AppCode.DAL
{
    public class DALLogs : AppCode.Conexao.ConexaoSQLServer
    {
        public DALLogs()
        {
            Tabela = "Logs";
        }
        private int _Id;

        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        private int _IdUsuario;

        public int IdUsuario
        {
            get { return _IdUsuario; }
            set { _IdUsuario = value; }
        }

        private int _IdOperacao;

        public int IdOperacao
        {
            get { return _IdOperacao; }
            set { _IdOperacao = value; }
        }

        private int _IdArea;

        public int IdArea
        {
            get { return _IdArea; }
            set { _IdArea = value; }
        }

        private DateTime _Data;

        public DateTime Data
        {
            get { return _Data; }
            set { _Data = value; }
        }

        private string _Descricao;

        public string Descricao
        {
            get { return _Descricao; }
            set { _Descricao = value; }
        }

    }
}