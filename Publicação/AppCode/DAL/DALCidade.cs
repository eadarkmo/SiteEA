
namespace SiteEA.AppCode.DAL
{
    public class DALCidade : AppCode.Conexao.ConexaoSQLServer
    {
        public DALCidade()
        {
            Tabela = "Cidade";
        }
        private int _Id;

        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        private byte _Uf;

        public byte Uf
        {
            get { return _Uf; }
            set { _Uf = value; }
        }

        private string _Nome;

        public string Nome
        {
            get { return _Nome; }
            set { _Nome = value; }
        }

    }
}