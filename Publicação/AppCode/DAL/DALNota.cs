using System;
namespace SiteEA.AppCode.DAL
{
    public class DALNota : AppCode.Conexao.ConexaoSQLServer
    {
        public DALNota()
        {
            Tabela = "Nota";
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

        private int _IdLoja;

        public int IdLoja
        {
            get { return _IdLoja; }
            set { _IdLoja = value; }
        }

        private int _IdIndustria;

        public int IdIndustria
        {
            get { return _IdIndustria; }
            set { _IdIndustria = value; }
        }

        private int _Numero;

        public int Numero
        {
            get { return _Numero; }
            set { _Numero = value; }
        }

        private decimal _Valor;

        public decimal Valor
        {
            get { return _Valor; }
            set { _Valor = value; }
        }

        private byte _Parcelas;

        public byte Parcelas
        {
            get { return _Parcelas; }
            set { _Parcelas = value; }
        }

        private string _Natureza;

        public string Natureza
        {
            get { return _Natureza; }
            set { _Natureza = value; }
        }

        private decimal _ValorTotalNota;

        public decimal ValorTotalNota
        {
            get { return _ValorTotalNota; }
            set { _ValorTotalNota = value; }
        }

        private decimal _ValorTotalProduto;

        public decimal ValorTotalProduto
        {
            get { return _ValorTotalProduto; }
            set { _ValorTotalProduto = value; }
        }

        private DateTime _DataChegada;

        public DateTime DataChegada
        {
            get { return _DataChegada; }
            set { _DataChegada = value; }
        }

    }
}