<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPage.master" CodeFile="LogIn.aspx.cs" Inherits="LogIn" %>

<%@ MasterType VirtualPath="~/MasterPage.master" %>

<asp:Content ID="ContentArea1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" >

    You can use jdoe or jsmith with password to enter<br />
    <table style="width: 385px">
        <tr>
            <td>
                User Name:

            </td>
            <td>
                <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
            </td>
        </tr>
         <tr>
            <td>
               Password:

            </td>
            <td>
                <asp:TextBox ID="txtPassword"  runat="server" TextMode="Password"></asp:TextBox>
            </td>
        </tr>
         <tr>
            <td colspan="2">
                <asp:Button ID="Button1" runat="server" Text="Login" Width="72px" PostBackUrl="~/UserAccountDetails.aspx"/>
                <asp:Button ID="Button2" runat="server" Text="Create Account" PostBackUrl="~/UserAccountDetails.aspx" />
            </td>
           
        </tr>
    </table>

</asp:Content>