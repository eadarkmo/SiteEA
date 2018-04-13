using System;

namespace SiteEA.PainelADM
{
    public partial class Default : AppCode.Sessao.BasePage
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
                divErro.InnerText = "Erro: " + ex.Message;
            }
        }

        private void execInicializar()
        {

            if (Request.Params["e"] != null)
            {
                AppCode.Funcao.Utilitarios.RecuperarErro(Request.Params["e"]);
            }
        }
    }
}