
namespace SiteEA.AppCode.DAL
{
    public class DALIndustria : AppCode.Conexao.ConexaoSQLServer
    {
        public DALIndustria()
        {
            Tabela = "Industria";
        }
        private int _Id;

        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        private string _RazaoSocial;

        public string RazaoSocial
        {
            get { return _RazaoSocial; }
            set { _RazaoSocial = value; }
        }

        private string _NomeFantasia;

        public string NomeFantasia
        {
            get { return _NomeFantasia; }
            set { _NomeFantasia = value; }
        }

        private string _NomeEquivalente;

        public string NomeEquivalente
        {
            get { return _NomeEquivalente; }
            set { _NomeEquivalente = value; }
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

        private byte _Lucro;

        public byte Lucro
        {
            get { return _Lucro; }
            set { _Lucro = value; }
        }

        private byte _Ipi;

        public byte Ipi
        {
            get { return _Ipi; }
            set { _Ipi = value; }
        }

        private byte _Frete;

        public byte Frete
        {
            get { return _Frete; }
            set { _Frete = value; }
        }

    }
}