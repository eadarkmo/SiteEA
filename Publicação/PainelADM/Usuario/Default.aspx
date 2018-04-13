<%@  Language="C#" MasterPageFile="~/PainelADM/ADM.Master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="SiteEA.PainelADM.Usuario.Default" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ctHead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ctBody" runat="server">
    <asp:UpdatePanel ID="updGeral" runat="server">
        <ContentTemplate>
            <div id="divPrincipal" runat="server">
                <div class="divTitulo">
                    Cadastro Usuario</div>
                <div id="divPesquisa" runat="server">
                    Nome:
                    <asp:TextBox ID="txtFiltroNome" runat="server" MaxLength="50" placeholder="Busca por Nome" /><br />
                    Usuario:
                    <asp:TextBox ID="txtFiltroUsuario" runat="server" MaxLength="15" placeholder="Busca por usuario" /><br />
                    Loja:
                    <asp:DropDownList ID="drpFiltroLoja" runat="server" />
                    Nivel:
                    <asp:DropDownList ID="drpFiltroNivel" runat="server" />
                    Status:
                    <asp:DropDownList ID="drpFiltroStatus" runat="server" />
                    <asp:Button ID="btnFiltrar" runat="server" Text="Buscar" OnClick="btnFiltrar_Click" />
                    <asp:GridView ID="grdUsuario" runat="server" AllowSorting="False" AutoGenerateColumns="false"
                        AutoGenerateSelectButton="true" Width="100%" OnSelectedIndexChanged="grdUsuario_SelectedIndexChanged">
                        <Columns>
                            <asp:BoundField DataField="Nome" HeaderText="Nome" />
                            <asp:BoundField DataField="Usuario" HeaderText="Usuario" />
                        </Columns>
                    </asp:GridView>
                    <asp:Button ID="btnNovo" runat="server" Text="Novo" OnClick="btnNovo_Click" />
                </div>
                <div id="divCampos" runat="server">
                    <asp:Label ID="lblId" runat="server" Visible="false" />
                    Nome:
                    <asp:TextBox ID="txtNome" runat="server" MaxLength="50" /><br />
                    Usuario:
                    <asp:TextBox ID="txtUsuario" runat="server" MaxLength="15" /><br />
                    Senha:
                    <asp:TextBox ID="txtSenha" runat="server" MaxLength="15" TextMode="Password" /><br />
                    Confirmação de senha:
                    <asp:TextBox ID="txtConfirmacaoSenha" runat="server" MaxLength="15" TextMode="Password" /><br />
                    Loja:
                    <asp:DropDownList ID="drpLoja" runat="server" />
                    <br />
                    Nivel:
                    <asp:DropDownList ID="drpNivel" runat="server" />
                    <br />
                    Status:
                    <asp:DropDownList ID="drpStatus" runat="server" />
                    <br />
                    <asp:Button ID="btnSalvar" runat="server" Text="Salvar" OnClick="btnSalvar_Click" />
                    <asp:Button ID="btnVoltar" runat="server" Text="Voltar" OnClick="btnVoltar_Click" />
                </div>
                <div id="divErro" runat="server">
                </div>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
