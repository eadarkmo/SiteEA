<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Login.ascx.cs" Inherits="SiteEA.PainelADM.WUC.Login" %>
Usuario:
<asp:TextBox ID="txtUsuario" runat="server" MaxLength="20" />
Senha:
<asp:TextBox ID="txtSenha" runat="server" TextMode="Password" />
<asp:Button ID="btnLogar" runat="server" Text="Entrar" OnClick="btnLogar_Click" />
<asp:LinkButton ID="lnkRecuperar" runat="server" Text="Recuperar Senha" PostBackUrl="/PainelADM/Usuario/Recuperar.aspx" ForeColor="White" />
<div id="divErro" runat="server">
</div>
