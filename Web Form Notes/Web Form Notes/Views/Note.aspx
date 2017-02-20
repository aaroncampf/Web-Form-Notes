<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Note.aspx.cs" Inherits="Learn_Web_Forms.Views.WebForm1" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <ol class="breadcrumb">
        <li><a href="/">Home</a></li>
        <li><a href="/Companies">Companies</a></li>
        <li><a href="/Company/<%: note.Contact.Company.ID %>"><%:note.Contact.Company.Name %></a></li>
        <li><a href="/Contact/<%: note.Contact.ID %>"><%:note.Contact.Name %></a></li>
        <li class="active"><%: note.Title %></li>
    </ol>

    <div class="jumbotron">
        <h1><%: note.Title %></h1>
    </div>

    <div class="container" style="width: 200px; float: left;">
        <div class="form-group">
            <label for="txtTitle">Title</label>
            <asp:TextBox runat="server" ID="txtTitle" class="form-control" AutoPostBack="True" OnTextChanged="txtTitle_TextChanged"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="txtCreated">Created</label>
            <asp:TextBox runat="server" ID="txtCreated" class="form-control" AutoPostBack="True" OnTextChanged="txtCreated_TextChanged"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="txtText">Text</label>
            <asp:TextBox runat="server" ID="txtText" class="form-control" AutoPostBack="True" OnTextChanged="txtText_TextChanged"></asp:TextBox>
        </div>
        <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClientClick="PageMethods.btnDelete_Click(); return false;" OnClick="btnDelete_Click" />
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <asp:Button ID="Button1" runat="server" Text="Your Text" OnClick="btnDelete_Click" />
            </ContentTemplate>
        </asp:UpdatePanel>
    </div>

</asp:Content>
