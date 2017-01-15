<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Company.aspx.cs" Inherits="Learn_Web_Forms.Views.Company" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    



    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    <asp:TextBox ID="txtName" runat="server" OnTextChanged="txtName_TextChanged" Text ="<%# Container. %>"></asp:TextBox>

    



</asp:Content>
