using System;

namespace SiteEA.AppCode.DAL
{
    public class DALProduto : AppCode.Conexao.ConexaoSQLServer
    {
        public DALProduto()
        {
            Tabela = "Produto";
        }
        private int _Id;

        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        private int _IdIndustria;

        public int IdIndustria
        {
            get { return _IdIndustria; }
            set { _IdIndustria = value; }
        }

        private int _IdUsuario;

        public int IdUsuario
        {
            get { return _IdUsuario; }
            set { _IdUsuario = value; }
        }

        private int _IdUltimanota;

        public int IdUltimanota
        {
            get { return _IdUltimanota; }
            set { _IdUltimanota = value; }
        }

        private string _CodigoBarras;

        public string CodigoBarras
        {
            get { return _CodigoBarras; }
            set { _CodigoBarras = value; }
        }

        private int _CodigoProduto;

        public int CodigoProduto
        {
            get { return _CodigoProduto; }
            set { _CodigoProduto = value; }
        }

        private string _Nome;

        public string Nome
        {
            get { return _Nome; }
            set { _Nome = value; }
        }

        private decimal _PrecoCusto;

        public decimal PrecoCusto
        {
            get { return _PrecoCusto; }
            set { _PrecoCusto = value; }
        }

        private decimal _PrecoVenda;

        public decimal PrecoVenda
        {
            get { return _PrecoVenda; }
            set { _PrecoVenda = value; }
        }

        private int _Quantidade;

        public int Quantidade
        {
            get { return _Quantidade; }
            set { _Quantidade = value; }
        }

        private byte _IPI;

        public byte IPI
        {
            get { return _IPI; }
            set { _IPI = value; }
        }

        private byte _ICMS;

        public byte ICMS
        {
            get { return _ICMS; }
            set { _ICMS = value; }
        }

        private byte _Lucro;

        public byte Lucro
        {
            get { return _Lucro; }
            set { _Lucro = value; }
        }

        private DateTime _UltimaAlteracao;

        public DateTime UltimaAlteracao
        {
            get { return _UltimaAlteracao; }
            set { _UltimaAlteracao = value; }
        }

    }
}