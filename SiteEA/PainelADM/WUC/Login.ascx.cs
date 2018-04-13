using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SiteEA.PainelADM.WUC
{
    public partial class Login : AppCode.Sessao.BaseWUC
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                //Verifica se é postback (se é a primeira vez que a pagina esta sendo carregada ou nao)
                if (!IsPostBack)
                {
                    //Se for a primeira vez que se abre a pagina, os campos são inicializados e preparados
                    execInicializar();
                }
            }
            catch (Exception ex)
            {
                divErro.Visible = true;
                divErro.InnerText = "Erro: " + ex.Message;
            }
        }

        private void execInicializar()
        {
            //Inicializa os campos do formulario
            execLimparCampos();
        }

        private void execLimparCampos()
        {
            //Limpando os dados dos campos do formulario de Login
            divErro.Visible = false;
            txtUsuario.Text = "";
            txtSenha.Text = "";
            divErro.InnerText = "";
        }

        protected void btnLogar_Click(object sender, EventArgs e)
        {
            try
            {
                //Evento chamado quando se manda logar

                //Pre-valida os dados informados antes de verificar no Banco de Dados
                execValidarLogin();
                //Função para logar
                execLogar();
            }
            catch (Exception ex)
            {
                divErro.Visible = true;
                divErro.InnerText = "Erro: " + ex.Message;
            }
        }

        private void execLogar()
        {
            //Busca e valida se os dados informados estão corretos
            AppCode.MNL.MNLUsuario usuario = new AppCode.MNL.MNLUsuario();
            usuario.ValidarLogin(txtUsuario.Text, DMFramework.TratarDado.Codificar(txtSenha.Text));

            //Iniciando a Sessão
            base.Sessao = new AppCode.Sessao.BasePadrao();
            //Enviando o usuario para sessão
            base.Sessao.usuario = usuario;

            //Redirecionando para pagina padrao após estar logado
            Response.Redirect("~/PainelADM/Default.aspx");
        }

        private void execValidarLogin()
        {
            //Limpando a area de erros caso exista
            divErro.InnerText = "";

            //Validação dos campos referente ao loggin
            if (txtSenha.Text.Contains(" "))
                throw new Exception("Retire os espaços da sua senha.");
            if (txtSenha.Text.Trim().Equals(""))
                throw new Exception("Informe a senha.");
            if (txtSenha.Text.Length > 15)
                throw new Exception("Senha muito grande.");
        }
    }
}