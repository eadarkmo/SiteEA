
namespace SiteEA.AppCode.DAL
{
    public class DALTelefone : AppCode.Conexao.ConexaoSQLServer
    {
        public DALTelefone()
        {
            Tabela = "Telefone";
        }
        private int _Id;

        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        private int _IdEntidade;

        public int IdEntidade
        {
            get { return _IdEntidade; }
            set { _IdEntidade = value; }
        }

        private byte _Entidade;

        public byte Entidade
        {
            get { return _Entidade; }
            set { _Entidade = value; }
        }

        private byte _DDD;

        public byte DDD
        {
            get { return _DDD; }
            set { _DDD = value; }
        }

        private char _Telefone;

        public char Telefone
        {
            get { return _Telefone; }
            set { _Telefone = value; }
        }

        private string _Descricao;

        public string Descricao
        {
            get { return _Descricao; }
            set { _Descricao = value; }
        }

        private string _Contato;

        public string Contato
        {
            get { return _Contato; }
            set { _Contato = value; }
        }

    }
}