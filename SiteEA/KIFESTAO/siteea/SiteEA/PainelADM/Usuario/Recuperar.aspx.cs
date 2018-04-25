using System;

namespace SiteEA.PainelADM.Usuario
{
    public partial class Recuperar : System.Web.UI.Page
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
            execLimparCampos();
        }

        private void execLimparCampos()
        {
            txtUsuario.Text = "";
            divErro.InnerText = "";
        }

        protected void btnRecuperar_Click(object sender, EventArgs e)
        {
            try
            {
                execRecuperarSenha();
            }
            catch (Exception ex)
            {
                divErro.InnerText = "Erro: " + ex.Message;
            }
        }

        private void execRecuperarSenha()
        {
            divErro.InnerText = "";
            execTratarDados();

            //Envia email

            // Sucesso
            execLimparCampos();
            divErro.InnerText = "Usuario recuperado com Sucesso!!";
        }

        private void execTratarDados()
        {   
            if (txtUsuario.Text.Equals(""))
                throw new Exception("Informe um nome de usuario.");

           

        }
    }
}