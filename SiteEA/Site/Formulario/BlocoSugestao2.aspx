<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BlocoSugestao2.aspx.cs"
    Inherits="SiteEA.Site.Formulario.BlocoSugestao2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        .divPrincipal
        {
            width: 400px;
            height: 410px;
            border-style: double;
            border-radius: 6px;
            border-width: 5px solid;
            border-color: #000000;
            color:#000;
        }
        .divLogo
        {
            color: #000080;
            font-family: Rockwell, Consolas, "Courier New" , Courier, monospace;
            font-size: 20px;
            font-weight: bold;
            padding: 8px 8px 8px 8px;
            text-align: center;
            <%--text-shadow: 2px 2px 5px #FFF;--%>
        }
        .divTipo
        {
            font-size: 20px;
            text-align: center;
            padding: 5px 5px 5px 5px;
        }
        .divCabecalho
        {
            border-style: double;
            border-radius: 6px;
            border-width: 5px solid;
            border-color: #000000;
            color: #00000;
            padding: 0px 10px 50px 10px;
            font-size: 12px;
        }
        .divTelefone
        {
            padding: 5px 5px 5px 5px;
            float:right;
        }
        .divData
        {
            padding: 5px 5px 5px 5px;
            float:left;
        }
        .divNome
        {
            padding: 5px 5px 5px 5px;
            float:left;
        }
        .divMensagem
        {
            width: 100%;
            height: 100%;
            color:#000;
        }
        .tipoFundo
        {
            background-color:#FFF;
            color:#000;
            padding:2px 2px 2px 2px;
            border-radius: 8px;
        }
        hr
        {
            margin-top: 25px;
            width:95%;
            text-align:center;
        }
        .divAgradecimento
        {
            font-size: 10px;
            text-align:center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="divPrincipal">
        <div class="divCabecalho">
            <div class="divLogo">
                Embalagens Avenida
            </div>
            <div class="divTipo">
                <asp:CheckBox ID="chbCritica" runat="server" Text="Crítica" />
                <asp:CheckBox ID="chbElogio" runat="server" Text="Elogio" />
                <asp:CheckBox ID="chbSugestão" runat="server" Text="Sugestão" />
            </div>
            <div class="divData">
                Data:
                <asp:Label runat="server" ID="lblData" class="tipoFundo" Text="____ /____ /________" />
            </div>
            <div class="divTelefone">
                Tel:
                <asp:Label runat="server" ID="lblTelefone" class="tipoFundo" Text="(____) __________ - ________" />
            </div>
            <div class="divNome">
                Nome:
                <asp:Label runat="server" ID="lblNome" class="tipoFundo" Text="______________________________________________________" />
            </div>
        </div>
        <div class="divMensagem">
            <hr size="1" color="#000" />
            <hr size="1" color="#000" />
            <hr size="1" color="#000" />
            <hr size="1" color="#000" />
            <hr size="1" color="#000" />
            <hr size="1" color="#000" />
            <hr size="1" color="#000" />
            <hr size="1" color="#000" />
            <hr size="1" color="#000" />
            <hr size="1" color="#000" />
            <div class="divAgradecimento">
                Obrigado por participar!</div>
        </div>
    </div>
    </form>
</body>
</html>
