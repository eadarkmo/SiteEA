
namespace SiteEA.AppCode.Sessao
{
    public class BaseWUC : System.Web.UI.UserControl
    {
        public BaseWUC()
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
    }
}