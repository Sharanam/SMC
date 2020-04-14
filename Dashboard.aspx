<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true"  CodeBehind="Dashboard.aspx.cs" Inherits="Shivam.Dashboard" %>
<asp:Content ID="Head" ContentPlaceHolderID="head" runat="server">
    <title><%="Welcome "+Session["UserName"]+" !!!" %></title>
</asp:Content>
<asp:Content ID="Questions" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table width="100%" style="border:0px"><tr><th width="15%"><h1>Quiz Types:</h1></th><th>Answer the following Questions.</th></tr>
        <tr><td>Kids</td>
            <td>

                Q.<asp:Label ID="lblQId" runat="server" Text="0"></asp:Label>
                &nbsp;<asp:Label ID="lblQustion" runat="server" Text="Description of Question"></asp:Label>
                <br />
                <asp:RadioButtonList ID="lstAnswers" runat="server">
                    <asp:ListItem>A</asp:ListItem>
                    <asp:ListItem>B</asp:ListItem>
                    <asp:ListItem>C</asp:ListItem>
                    <asp:ListItem>Don&#39;t Know</asp:ListItem>
                </asp:RadioButtonList>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="lstAnswers" Display="None" ErrorMessage="Atleast D should be selected."></asp:RequiredFieldValidator>
                <br />
                <asp:Button ID="btnGo" runat="server" Text="Next" OnClick="btnGo_Click" />
                <br />
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" DisplayMode="List" />
            </td>
        </tr>
        </table>
</asp:Content>