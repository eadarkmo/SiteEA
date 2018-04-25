<%@ Page Language="C#" MasterPageFile="~/Padrao.Master" AutoEventWireup="true" CodeBehind="Contato.aspx.cs"
    Inherits="SiteEA.Site.Contato" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ctHead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ctBody" runat="server">
    <div class="divContato">
        <div>
            Telefone: (61) 3354-2077
            <br />
            Endereço: CNG 05 Lote 09 Loja 01 - Taguatinga Norte - DF
        </div>
        <br />
        <br />
        <br />
        <div>
            <table>
                <tr>
                    <td>
                        Nome:
                    </td>
                    <td>
                        <asp:TextBox ID="txtNome" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td>
                    </td>
                </tr>
                <tr>
                    <td>
                        Assunto:
                    </td>
                    <td>
                        <asp:TextBox ID="txtAssunto" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td>
                    </td>
                </tr>
                <tr>
                    <td>
                        Telefone:
                    </td>
                    <td>
                        <asp:TextBox ID="txtTelefone" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td>
                    </td>
                </tr>
                <tr>
                    <td>
                        Email:
                    </td>
                    <td>
                        <asp:TextBox ID="txtEmail" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td>
                    </td>
                </tr>
                <tr>
                    <td>
                        Mensagem:
                    </td>
                    <td>
                        <asp:TextBox ID="txtMensagem" TextMode="MultiLine" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td>
                    </td>
                    <td>
                        <asp:Button ID="btnEnviar" runat="server" Text="Enviar" OnClick="btnEnviar_Click" />
                    </td>
                </tr>
            </table>
        </div>
        <div id="divErro" runat="server">
        </div>
    </div>
</asp:Content>
