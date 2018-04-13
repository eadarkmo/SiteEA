using System;

namespace SiteEA.PainelADM
{
    public partial class ADM : AppCode.Sessao.BaseMasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                    execInicializar();
            }
            catch (Exception ex)
            {

            }
        }

        private void execInicializar()
        {
            lblUsuariosLogados.Text = Session.Count.ToString();

            //Se não houver usuario logado na sessão oculta o Menu
            execVerificaLogin();

        }

        /// <summary>
        /// Verifica se há usuario logado para exibir ou ocultar o menu
        /// </summary>
        private void execVerificaLogin()
        {
            divMenu.Visible = false;
            divLogin.Visible = true;

            if (!Request.Url.LocalPath.ToLower().Equals("/paineladm/default.aspx") && !Request.Url.LocalPath.ToLower().Equals("/paineladm/usuario/recuperar.aspx"))
            {
                if (Sessao == null)
                    Response.Redirect("/PainelADM/Default.aspx");
                else if (Sessao.usuario == null)
                    Response.Redirect("/PainelADM/Default.aspx");
                else
                {
                    divLogin.Visible = false;
                    divMenu.Visible = true;
                }
            }
            else
            {
                if (Sessao != null)
                    if (Sessao.usuario != null)
                    {
                        divLogin.Visible = false;
                        divMenu.Visible = true;
                    }
            }
        }

        protected void btnSair_Click(object sender, EventArgs e)
        {
            try
            {
                if (base.Sessao != null)
                    base.Sessao.usuario = null;
                Response.Redirect("/Default.aspx");
            }
            catch (Exception ex)
            {

            }
        }
    }
}