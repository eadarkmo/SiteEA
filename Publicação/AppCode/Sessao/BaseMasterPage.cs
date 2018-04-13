
namespace SiteEA.AppCode.Sessao
{
    public class BaseMasterPage : System.Web.UI.MasterPage
    {
        public BaseMasterPage()
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

        public void LimparSessao()
        {
            if (Sessao == null) { Sessao = new BasePadrao(); }
        }

        /// <summary>
        /// Verifica se existe uma sessao ativa, se não redireciona o usuario para o local correto com a mensagem de erro
        /// </summary>
        public void validaUsuarioESessao()
        {
            if (Sessao == null)
                Response.Redirect("~/PainelADM/Usuario/Login.aspx");
            else if (Sessao.usuario == null)
                Response.Redirect("~/PainelADM/Usuario/Login.aspx");
        }
    }
}