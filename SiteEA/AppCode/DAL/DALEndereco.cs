
namespace SiteEA.AppCode.DAL
{
    public class DALEndereco : AppCode.Conexao.ConexaoSQLServer
    {
        public DALEndereco()
        {
            Tabela = "Endereco";
        }
        private int _Id;

        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        private int _Cidade;

        public int Cidade
        {
            get { return _Cidade; }
            set { _Cidade = value; }
        }

        private string _Bairro;

        public string Bairro
        {
            get { return _Bairro; }
            set { _Bairro = value; }
        }

        private string _Endereco;

        public string Endereco
        {
            get { return _Endereco; }
            set { _Endereco = value; }
        }

        private string _Cep;

        public string Cep
        {
            get { return _Cep; }
            set { _Cep = value; }
        }

    }
}