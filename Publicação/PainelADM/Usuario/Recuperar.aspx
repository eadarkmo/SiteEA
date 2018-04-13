<%@ Page Title="" Language="C#" MasterPageFile="~/PainelADM/ADM.Master" AutoEventWireup="true"
    CodeBehind="Recuperar.aspx.cs" Inherits="SiteEA.PainelADM.Usuario.Recuperar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ctHead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ctBody" runat="server">
    <asp:UpdatePanel ID="updGeral" runat="server">
        <ContentTemplate>
            <div id="divPrincipal" runat="server">
                <div class="divTitulo">
                    Recuperar senha</div>
                <div>
                    Usuario:
                    <asp:TextBox ID="txtUsuario" runat="server" MaxLength="15" />
                    <br /><br />
                    <asp:Button ID="btnRecuperar" runat="server" Text="Recuperar" OnClick="btnRecuperar_Click" />
                    <br /><br />
                    <asp:LinkButton ID="btnVoltar" runat="server" Text="Voltar" OnClick="btnVoltar_Click" />
                </div>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
