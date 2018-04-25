using System;

namespace EmbalagensAvenida
{
    public partial class SiteMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
         
        }

        public String HeaderCssClass
        {
            get { return this.Header.Attributes["class"]; }
            set { this.Header.Attributes["class"] = value; }
        }
    }
}
