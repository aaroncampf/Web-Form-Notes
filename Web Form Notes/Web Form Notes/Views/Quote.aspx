<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Quote.aspx.cs" Inherits="Learn_Web_Forms.Views.Quote" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <ol class="breadcrumb">
        <li><a href="/">Home</a></li>
        <li><a href="/Companies">Companies</a></li>
        <li><a href="/Company/<%: note.Contact.Company.ID %>"><%:note.Contact.Company.Name %></a></li>
        <li class="active"><%: note.Title %></li>
    </ol>

</asp:Content>