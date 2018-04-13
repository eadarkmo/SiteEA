
namespace SiteEA.AppCode.Sessao
{
    public class BasePage : System.Web.UI.Page
    {
        public BasePage()
        {
            //
            // TODO: Add constructor logic here
            //
        }


        public BasePadrao Sessao
        {
            get { return (BasePadrao)Session["sessaoAtiva"]; }
            set { Session["sessaoAtiva"] = value; }
        }

        /// <summary>
        /// Limpa a sessao
        /// </summary>
        public void limparSessao()
        {
            if (Sessao == null) { Sessao = new BasePadrao(); }
        }

        /// <summary>
        /// Verifica se existe uma sessao ativa, se não redireciona o usuario para o local correto com a mensagem de erro
        /// </summary>
        public void validaUsuarioESessao()
        {
            validaUsuarioESessao((int)AppCode.Funcao.Enumerados.Erro.SessaoExpirada);
        }

        /// <summary>
        /// Verifica se existe uma sessao ativa, se não redireciona o usuario para o local correto com a mensagem de erro enviada
        /// </summary>
        public void validaUsuarioESessao(int iErro)
        {
            if (Sessao == null)
                Response.Redirect(recuperarLinkErro(iErro));
            else if (Sessao.usuario == null)
                Response.Redirect(recuperarLinkErro(iErro));
        }

        /// <summary>
        /// Recupera o link para erro verificando se o usuario esta logado ou nao, passando o erro desejado
        /// </summary>
        /// <param name="iErro"></param>
        /// <returns></returns>
        public string recuperarLinkErro(int iErro)
        {
            string retorno = "";
            if (Sessao == null)
                retorno = "/Default.aspx?er=" + iErro;
            else if (Sessao.usuario == null)
                retorno = "/Default.aspx?er=" + iErro;
            else
                retorno = "/Painel/Default.aspx?er=" + iErro;
            return retorno;
        }
    }
}