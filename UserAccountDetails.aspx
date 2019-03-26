<%@ Page Language="C#"  AutoEventWireup="true" MasterPageFile="~/MasterPage.master" CodeFile="UserAccountDetails.aspx.cs" Inherits="UserAccountDetails" %>
<%@ PreviousPageType VirtualPath="~/LogIn.aspx" %>

<%@ MasterType VirtualPath="~/MasterPage.master" %>

<asp:Content ID="ContentArea1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" >

    <h2 style="color:blueviolet">User Account Details</h2>
    <p style="color:blueviolet">&nbsp;</p>
    <p style="color:blueviolet">Users: jsmith, jdoe, jtorres, pday, scastro</p>
    <table style="width: 412px; margin-bottom: 0px;">
        <tr>
            <td class="auto-style3">
              
                <asp:Label ID="lblFindUser" runat="server" Text="Find User" CssClass="auto-style1" Font-Bold="True"></asp:Label></td>
           
            <td class="auto-style4">
                <asp:TextBox ID="txtFindUser" runat="server" Width="200px"></asp:TextBox>
                <asp:Button ID="btnFindUser" runat="server" Text="Find User" OnClick="btnFindUser_Click" />
            </td>
        </tr>
    </table>
    <hr />
    <table>
        
        <tr>
            <td>UserName</td>
            <td>
                <asp:Label ID="lblUserName" runat="server" Text=""></asp:Label></td>
        </tr>
        <tr>
            <td class="auto-style2">City</td>
            <td class="auto-style2">
                <asp:TextBox ID="txtCity" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>State</td>
            <td>
                <asp:TextBox ID="txtState" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Favorite Programming Language</td>
            <td>
                <asp:TextBox ID="txtLanguage" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Least Favorite Programming Language</td>
            <td>
                <asp:TextBox ID="txtLeastLanguage" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Date Last Program was completed</td>
            <td>
                <asp:TextBox ID="txtDateLastProgram" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2"><br />
                <asp:GridView ID="grdApplications" runat="server" HeaderStyle-BackColor="#6666FF" HeaderStyle-ForeColor="White">
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td>
                </td>
            <td>
                <asp:Button ID="btnUpdate" runat="server" Text="Update"  PostBackUrl="~/UserAccountConfirmationPage.aspx" />
                <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />
            <asp:Button ID="btnExport" runat="server" Text="Export" OnClick="btnExport_Click" /></td>
        </tr>
    </table>

    </asp:Content>
<asp:Content ID="Content1" runat="server" contentplaceholderid="head">
    <style type="text/css">
        .auto-style2
        {
            height: 26px;
        }
        .auto-style3
        {
            width: 74px;
            height: 66px;
        }
        .auto-style4
        {
            height: 66px;
        }
    </style>
</asp:Content>
