<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="FiltroAgenda.ascx.cs"
    Inherits="SiteEA.PainelADM.WUC.FiltroAgenda" %>
<table>
    <tr class="tabelaCabecalho">
        <td style="width: 40px">
            Soma
        </td>
        <td style="width: 100px">
            Data
        </td>
        <td style="width: 400px">
            Empresa
        </td>
        <td style="width: 150px">
            Nota
        </td>
        <td style="width: 100px">
            Status
        </td>
        <td style="width: 100px">
            Data pagamento
        </td>
        <td style="width: 100px">
            Valor
        </td>
    </tr>
    <tr>
        <td>
            <asp:CheckBox ID="ckbPagamento1" runat="server" />
        </td>
        <td>
            10/10/2014
        </td>
        <td>
            Cromus
        </td>
        <td>
        </td>
        <td>
            Chegou
        </td>
        <td>
        </td>
        <td>
            825,38
        </td>
    </tr>
    <tr class="tabelaLinhaPintada">
        <td>
            <asp:CheckBox ID="ckbPagamento2" runat="server" />
        </td>
        <td>
            10/10/2014
        </td>
        <td>
            Copocentro
        </td>
        <td>
        </td>
        <td>
            Paga
        </td>
        <td>
            09/10/2014
        </td>
        <td>
            485,38
        </td>
    </tr>
    <tr>
        <td>
            <asp:CheckBox ID="ckbPagamento3" runat="server" />
        </td>
        <td>
            10/10/2014
        </td>
        <td>
            Copobras
        </td>
        <td>
        </td>
        <td>
            Não chegou
        </td>
        <td>
        </td>
        <td>
            485,38
        </td>
    </tr>
    <tr class="tabelaLinhaPintada">
        <td>
            <asp:CheckBox ID="CheckBox1" runat="server" />
        </td>
        <td>
            10/10/2014
        </td>
        <td>
            Copocentro
        </td>
        <td>
        </td>
        <td>
            Paga
        </td>
        <td>
            09/10/2014
        </td>
        <td>
            485,38
        </td>
    </tr>
    <tr>
        <td>
            <asp:CheckBox ID="CheckBox2" runat="server" />
        </td>
        <td>
            10/10/2014
        </td>
        <td>
            Copobras
        </td>
        <td>
        </td>
        <td>
            Não chegou
        </td>
        <td>
        </td>
        <td>
            485,38
        </td>
    </tr>
    <tr class="tabelaLinhaPintada">
        <td>
            <asp:CheckBox ID="CheckBox3" runat="server" />
        </td>
        <td>
            10/10/2014
        </td>
        <td>
            Copocentro
        </td>
        <td>
        </td>
        <td>
            Paga
        </td>
        <td>
            09/10/2014
        </td>
        <td>
            485,38
        </td>
    </tr>
    <tr>
        <td>
            <asp:CheckBox ID="CheckBox4" runat="server" />
        </td>
        <td>
            10/10/2014
        </td>
        <td>
            Copobras
        </td>
        <td>
        </td>
        <td>
            Não chegou
        </td>
        <td>
        </td>
        <td>
            485,38
        </td>
    </tr>
    <tr class="tabelaTotal">
        <td colspan="6">
            Total
        </td>
        <td>
            825,38
        </td>
    </tr>
</table>
