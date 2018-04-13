using System;

namespace SiteEA.PainelADM.Usuario
{
    public partial class Default : AppCode.Sessao.BasePage
    {
        protected void Page_PreInit(object sender, EventArgs e)
        {
            try
            {
                if (base.Sessao.usuario.Nivel < (int)AppCode.Funcao.Enumerados.UsuarioTipo.Administrador)
                    Response.Redirect("/PainelADM/Default.aspx?e=" + (int)AppCode.Funcao.Enumerados.Erro.Permissao);
            }
            catch (Exception )
            {
                Response.Redirect("/PainelADM/Default.aspx?e=" + (int)AppCode.Funcao.Enumerados.Erro.SessaoExpirada);
            }
        }

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
            divCampos.Visible = false;
            divPesquisa.Visible = true;

            execPopularDrops();
            execPopularGrid();
            execLimparCampos();

        }

        private void execPopularGrid()
        {
            AppCode.MNL.MNLUsuario lclUsuario = new AppCode.MNL.MNLUsuario();
            lclUsuario.SelecaoPadrao(txtFiltroNome.Text,txtFiltroUsuario.Text, int.Parse(drpFiltroLoja.SelectedValue), byte.Parse(drpFiltroNivel.SelectedValue), byte.Parse(drpFiltroStatus.SelectedValue));
            System.Data.DataView dtvPadrao = lclUsuario.getDataView();
            grdUsuario.DataSource = dtvPadrao;
            grdUsuario.DataBind();
        }

        private void execLimparCampos()
        {
            txtFiltroNome.Text = "";
            txtFiltroUsuario.Text = "";

            DMFramework.Utilitario.FindValue(drpFiltroNivel, (int)AppCode.Funcao.Enumerados.UsuarioTipo.Usuario_Avançado);
            DMFramework.Utilitario.FindValue(drpFiltroStatus, (int)AppCode.Funcao.Enumerados.UsuarioStatus.Ativo);

            lblId.Text = "0";
            txtNome.Text = "";
            txtUsuario.Text = "";
            txtSenha.Text = "";
            txtConfirmacaoSenha.Text = "";

            DMFramework.Utilitario.FindValue(drpNivel, (int)AppCode.Funcao.Enumerados.UsuarioTipo.Usuario_Avançado);
            DMFramework.Utilitario.FindValue(drpNivel, (int)AppCode.Funcao.Enumerados.UsuarioStatus.Ativo);

            divErro.InnerText = "";
        }

        private void execPopularDrops()
        {
            DMFramework.Utilitario.PopularDropDownList(drpStatus, typeof(AppCode.Funcao.Enumerados.UsuarioStatus), (int)AppCode.Funcao.Enumerados.UsuarioStatus.Ativo, false, false, false, false);
            DMFramework.Utilitario.PopularDropDownList(drpNivel, typeof(AppCode.Funcao.Enumerados.UsuarioTipo), (int)AppCode.Funcao.Enumerados.UsuarioTipo.Usuario_Avançado, false, false, false, false);

            DMFramework.Utilitario.PopularDropDownList(drpFiltroStatus, typeof(AppCode.Funcao.Enumerados.UsuarioStatus), (int)AppCode.Funcao.Enumerados.UsuarioStatus.Ativo, false, true, false, false);
            DMFramework.Utilitario.PopularDropDownList(drpFiltroNivel, typeof(AppCode.Funcao.Enumerados.UsuarioTipo), (int)AppCode.Funcao.Enumerados.UsuarioTipo.Usuario_Avançado, false, true, false, false);

            AppCode.MNL.MNLLoja lclLoja = new AppCode.MNL.MNLLoja();
            lclLoja.SelecaoPadrao();
            DMFramework.Utilitario.PopularDropDownList(drpLoja, lclLoja.getDataTable(), "NomeFantasia", "Id", "-1", true, false, false);
            DMFramework.Utilitario.PopularDropDownList(drpFiltroLoja, lclLoja.getDataTable(), "NomeFantasia", "Id", "-1", false, false, true);
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                execValidarCampos();
                execSalvar();
            }
            catch (Exception ex)
            {
                divErro.InnerText = "Erro: " + ex.Message;
            }
        }

        private void execSalvar()
        {
            AppCode.MNL.MNLUsuario lclUsuario = new AppCode.MNL.MNLUsuario();
            lclUsuario.Id = int.Parse(lblId.Text);
            lclUsuario.Nome = txtFiltroNome.Text;
            lclUsuario.Usuario = txtUsuario.Text;
            lclUsuario.Senha = DMFramework.TratarDado.Codificar(txtSenha.Text);
            lclUsuario.IdLoja = int.Parse(drpLoja.SelectedValue);
            lclUsuario.Nivel = byte.Parse(drpNivel.SelectedValue);
            lclUsuario.Status = byte.Parse(drpStatus.SelectedValue);
            if (lclUsuario.Id > 0)
                lclUsuario.Alterar();
            else
                lclUsuario.Incluir();
        }

        private void execValidarCampos()
        {
            if (string.IsNullOrEmpty(txtNome.Text))
                throw new Exception("Informe o Nome.");
            if (string.IsNullOrEmpty(txtUsuario.Text))
                throw new Exception("Informe o Nome de Usuario.");
            if (string.IsNullOrEmpty(txtSenha.Text))
                throw new Exception("Informe a Senha.");
            if (txtSenha.Text.Contains(" "))
                throw new Exception("A senha não deve conter espaço em branco.");
            if (txtSenha.Text.Length < 4)
                throw new Exception("A Senha deve conter no minimo 4 caracteres.");
            if (!txtSenha.Text.Equals(txtConfirmacaoSenha.Text))
                throw new Exception("As senhas informadas devem ser iguais.");
            if (int.Parse(drpNivel.SelectedValue) < (int)AppCode.Funcao.Enumerados.UsuarioTipo.Administrador)
                if (drpLoja.SelectedItem.Text.Equals("Selecione"))
                    throw new Exception("Informe a Loja a qual o usuario faz parte.");
        }

        protected void btnNovo_Click(object sender, EventArgs e)
        {
            try
            {
                divCampos.Visible = true;
                divPesquisa.Visible = false;
            }
            catch (Exception ex)
            {
                divErro.InnerText = "Erro: " + ex.Message;
            }
        }

        protected void btnVoltar_Click(object sender, EventArgs e)
        {
            try
            {
                divCampos.Visible = false;
                divPesquisa.Visible = true;
            }
            catch (Exception ex)
            {
                divErro.InnerText = "Erro: " + ex.Message;
            }
        }

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                divErro.InnerText = "Erro: " + ex.Message;
            }
        }

        private void execPopularCampos()
        {

        }

        protected void grdUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                divErro.InnerText = "Erro: " + ex.Message;
            }
        }
    }
}