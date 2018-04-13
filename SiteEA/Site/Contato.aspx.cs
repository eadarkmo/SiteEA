using System;

namespace SiteEA.Site
{
    public partial class Contato : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {

            }
        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                execValidarEnvio();
                execEnviar();
            }
            catch (Exception ex)
            {
                divErro.InnerText = "Erro: " + ex.Message;
            }
        }

        private void execEnviar()
        {
            execValidarEnvio();
            
        }

        private void execValidarEnvio()
        {
            divErro.InnerText = "";
            string erro = "";
            if (String.IsNullOrEmpty(txtEmail.Text.Trim()))
                erro = "* Escreva uma mensagem para ser enviada.";
            /*if (String.IsNullOrEmpty(txtTelefone.Text) && (String.IsNullOrEmpty(txtEmail.Text)))
                erro += "* Informe um e-mail ou numero de telefone para contato.";
            else if (!DMFramework.Validacao.IsEmailValido(txtEmail.Text) || !DMFramework.Validacao.IsNumeric(txtTelefone.Text))
                erro += "* E-mail inválido, por favor informe um e-mail válido";
            */

            if (!erro.Equals(""))
                throw new Exception(erro);

        }
    }
}