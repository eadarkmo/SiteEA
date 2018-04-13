
namespace SiteEA.AppCode.DAL
{
    public class DALUsuario : AppCode.Conexao.ConexaoSQLServer
    {
        public DALUsuario()
        {
            Tabela = "Usuario";
        }
        private int _Id;

        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        private int _IdLoja;

        public int IdLoja
        {
            get { return _IdLoja; }
            set { _IdLoja = value; }
        }

        private string _Nome;

        public string Nome
        {
            get { return _Nome; }
            set { _Nome = value; }
        }

        private string _Usuario;

        public string Usuario
        {
            get { return _Usuario; }
            set { _Usuario = value; }
        }

        private string _Senha;

        public string Senha
        {
            get { return _Senha; }
            set { _Senha = value; }
        }

        private byte _Nivel;

        public byte Nivel
        {
            get { return _Nivel; }
            set { _Nivel = value; }
        }

        private string _Email;

        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }

        private byte _Status;

        public byte Status
        {
            get { return _Status; }
            set { _Status = value; }
        }

    }
}