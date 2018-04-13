
namespace SiteEA.AppCode.Funcao
{
    public class Enumerados
    {
        public Enumerados()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        
        public enum TipoSimNao { Nao = 0, Sim = 1 }
        public enum AgendaStatus
        {
            Pago = 1,
            Vencido = 2,
            Cancelado = 3,
            Saiu_para_banco = 4,
            Não_chegou = 5,
            Prorrogado = 6,
            Chegou = 7,
            Pendente = 8
        }
        public enum UsuarioTipo
        {
            Usuario = 1,
            Usuario_Avançado = 2,
            Administrador = 10
        }
        public enum UsuarioStatus
        {
            Ativo = 1,
            Inativo = 2,
            Deletado = 3,
            Bloqueado = 4
        }
        public enum Area
        {
            Agenda = 1,
            Industria = 2,
            Log = 3,
            Loja = 4,
            Nota = 5,
            Produto = 6,
            Telefone = 7,
            Usuario = 8
        }
        public enum Erro
        {
            DataBase = 1,
            Permissao = 2,
            SessaoExpirada = 3,
            ErroDesconhecido = 100,
            ErroInesperado = 101,
            ErroCritico = 102
        }
    }
}