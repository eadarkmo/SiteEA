using System;

namespace EmbalagensAvenida
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Page_Init(object sender, EventArgs e)
        { 
            this.Master.HeaderCssClass = "header header--shaped";
        }
    }
}