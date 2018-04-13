<%@ Page Title="" Language="C#" MasterPageFile="~/PainelADM/ADM.Master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="SiteEA.PainelADM.Default" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ctHead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ctBody" runat="server">
    <asp:UpdatePanel ID="updGeral" runat="server">
        <ContentTemplate>
            <div id="divErro" runat="server">
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
