using System;

namespace SiteEA.AppCode.DAL
{
    public class DALDuplicata : AppCode.Conexao.ConexaoSQLServer
    {
        public DALDuplicata()
        {
            Tabela = "Duplicata";
        }
        private int _Id;

        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        private int _IdNota;

        public int IdNota
        {
            get { return _IdNota; }
            set { _IdNota = value; }
        }

        private int _IdLoja;

        public int IdLoja
        {
            get { return _IdLoja; }
            set { _IdLoja = value; }
        }

        private int _IdUsuario;

        public int IdUsuario
        {
            get { return _IdUsuario; }
            set { _IdUsuario = value; }
        }

        private decimal _Valor;

        public decimal Valor
        {
            get { return _Valor; }
            set { _Valor = value; }
        }

        private byte _Parcela;

        public byte Parcela
        {
            get { return _Parcela; }
            set { _Parcela = value; }
        }

        private bool _FoiBanco;

        public bool FoiBanco
        {
            get { return _FoiBanco; }
            set { _FoiBanco = value; }
        }

        private byte _Status;

        public byte Status
        {
            get { return _Status; }
            set { _Status = value; }
        }

        private DateTime _DataVencimento;

        public DateTime DataVencimento
        {
            get { return _DataVencimento; }
            set { _DataVencimento = value; }
        }

        private DateTime _DataPagamento;

        public DateTime DataPagamento
        {
            get { return _DataPagamento; }
            set { _DataPagamento = value; }
        }

        private decimal _ValorPago;

        public decimal ValorPago
        {
            get { return _ValorPago; }
            set { _ValorPago = value; }
        }

        private decimal _Desconto;

        public decimal Desconto
        {
            get { return _Desconto; }
            set { _Desconto = value; }
        }

        private decimal _Acrescimo;

        public decimal Acrescimo
        {
            get { return _Acrescimo; }
            set { _Acrescimo = value; }
        }

        private string _MotivoAlteracao;

        public string MotivoAlteracao
        {
            get { return _MotivoAlteracao; }
            set { _MotivoAlteracao = value; }
        }

    }
}