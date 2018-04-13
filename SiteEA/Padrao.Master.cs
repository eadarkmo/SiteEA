using System;

namespace SiteEA
{
    public partial class Padrao : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (AppCode.Funcao.Utilitarios.PegarParametro("LoginAtivo") != null)
                if (AppCode.Funcao.Utilitarios.PegarParametro("LoginAtivo").Equals("0"))
                    divLogin.Visible = false;
        }
    }
}