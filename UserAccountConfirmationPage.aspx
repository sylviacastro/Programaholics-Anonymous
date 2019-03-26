<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPage.master" CodeFile="UserAccountConfirmationPage.aspx.cs" Inherits="UserAccountConfirmationPage" %>
<%@ PreviousPageType VirtualPath="~/UserAccountDetails.aspx"%>
<%@ MasterType VirtualPath="~/MasterPage.master" %>

<asp:Content ID="ContentArea1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" >

    <h3>
        <asp:Label ID="lblConfirmation" runat="server" Text="Label"></asp:Label></h3>
    <p class="auto-style2">
        <asp:Label ID="Label1" runat="server" Font-Bold="True" ForeColor="#990033" Text="UserName: "></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblUserName" runat="server"></asp:Label>
    </p>
    <p class="auto-style2">
        <asp:Label ID="Label2" runat="server" Font-Bold="True" ForeColor="#990033" Text="City:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblCity" runat="server" width="90px"></asp:Label>
    </p>
    <p class="auto-style2">
        <asp:Label ID="Label3" runat="server" Font-Bold="True" ForeColor="#990033" Text="State:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblState" runat="server" width="90px"></asp:Label>
    </p>
    <p class="auto-style2">
        <asp:Label ID="Label4" runat="server" Font-Bold="True" ForeColor="#990033" Text="Favorite Programming Language:"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblLanguage" runat="server"></asp:Label>
    </p>
    <p class="auto-style2">
        <asp:Label ID="Label5" runat="server" Font-Bold="True" ForeColor="#990033" Text="Least Fav Programming Language:"></asp:Label>
&nbsp;&nbsp;
        <asp:Label ID="lblLeastLanguage" runat="server"></asp:Label>
    </p>
    <p class="auto-style2">
        <asp:Label ID="Label6" runat="server" Font-Bold="True" ForeColor="#990033" Text="Last Program Completion Date:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblProgDate" runat="server"></asp:Label>
    </p>
    <asp:Button ID="btnUpdateInformation" runat="server" Text="Yes" Width="67px" OnClick="btnUpdateInformation_Click" />
    &nbsp;
    <asp:Button ID="btnCancel" runat="server" Text="No" Width="66px" OnClick="btnCancel_Click" />
    </asp:Content>
<asp:Content ID="Content1" runat="server" contentplaceholderid="head">
    <style type="text/css">
        .auto-style2
        {
            text-align: left;
        }
    </style>
</asp:Content>
