<%@ Page Title="" Language="C#" MasterPageFile="~/PainelADM/ADM.Master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="SiteEA.PainelADM.Agenda.Default" %>

<%@ Register Src="~/PainelADM/WUC/FiltroAgenda.ascx" TagName="Filtro" TagPrefix="wuc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ctHead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ctBody" runat="server">
    <div class="divTitulo">
        Agenda</div>
    <div class="divPesquisa">
        Data de:
        <asp:TextBox ID="txtFiltroDataDe" runat="server" Width="80px" />
        ate:
        <asp:TextBox ID="txtFiltroDataAte" runat="server" Width="80px" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Status:
        <asp:DropDownList ID="drpFiltroStatus" runat="server" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Pesquisa:
        <asp:TextBox ID="txtFiltro" runat="server" Width="200px" />
        <asp:Button ID="btnFiltrar" runat="server" Text="Filtrar" />
    </div>
    <div>
        <wuc:Filtro ID="wucFiltro" runat="server" />
        <asp:Button ID="btnNovo" runat="server" Text="Novo" />
    </div>
</asp:Content>
