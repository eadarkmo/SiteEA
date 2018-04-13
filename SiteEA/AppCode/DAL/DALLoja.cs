
namespace SiteEA.AppCode.DAL
{
    public class DALLoja : AppCode.Conexao.ConexaoSQLServer
    {
        public DALLoja()
        {
            Tabela = "Loja";
        }
        private int _Id;

        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        private string _NomeFantasia;

        public string NomeFantasia
        {
            get { return _NomeFantasia; }
            set { _NomeFantasia = value; }
        }

        private string _RazaoSocial;

        public string RazaoSocial
        {
            get { return _RazaoSocial; }
            set { _RazaoSocial = value; }
        }

        private string _CNPJ;

        public string CNPJ
        {
            get { return _CNPJ; }
            set { _CNPJ = value; }
        }

        private int _IdEndereco;

        public int IdEndereco
        {
            get { return _IdEndereco; }
            set { _IdEndereco = value; }
        }

    }
}