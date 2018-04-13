
namespace SiteEA.AppCode.Funcao
{
    public class Utilitarios
    {
        public Utilitarios()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="NomeParametro"></param>
        /// <returns></returns>
        public static string PegarParametroCodificado(string NomeParametro)
        {
            return DMFramework.TratarDado.Decodificar(System.Configuration.ConfigurationManager.AppSettings[NomeParametro]);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="NomeParametro"></param>
        /// <returns></returns>
        public static string PegarParametro(string NomeParametro)
        {
            return System.Configuration.ConfigurationManager.AppSettings[NomeParametro];
        }

        /// <summary>
        /// Função que dispara uma mensagem de erro de acordo com o numero de erro passado por parametro
        /// </summary>
        /// <param name="sErro"></param>
        public static void RecuperarErro(string sErro)
        {
            if (DMFramework.Validacao.IsNumeric(sErro))
            {
                int iErro = int.Parse(sErro);
                switch (iErro)
                {
                    case (int)AppCode.Funcao.Enumerados.Erro.DataBase:
                        throw new System.Exception("Não foi possível estabelecer uma conexão com o banco de dados, favor entrar em contato com o Administrador do Sistema.");
                    case (int)AppCode.Funcao.Enumerados.Erro.Permissao:
                        throw new System.Exception("Usuário não possui permissão de acesso.");
                    case (int)AppCode.Funcao.Enumerados.Erro.SessaoExpirada:
                        throw new System.Exception("A sessão expirou.");
                    case (int)AppCode.Funcao.Enumerados.Erro.ErroDesconhecido:
                        throw new System.Exception("Um erro desconhecido ocorreu.");
                    case (int)AppCode.Funcao.Enumerados.Erro.ErroCritico:
                        throw new System.Exception("Um erro critico ocorreu.");
                    default:
                        throw new System.Exception("Um erro inesparado ocorreu.");
                }
            }
            else
                throw new System.Exception("Um erro inesparado ocorreu. " + sErro);
        }
    }
}