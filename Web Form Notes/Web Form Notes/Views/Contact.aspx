<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="Learn_Web_Forms.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <ol class="breadcrumb">
        <li><a href="/">Home</a></li>
        <li><a href="/Companies">Companies</a></li>
        <li><a href="/Company?id=<%: contact.Company.ID %>"><%: contact.Company.Name %></a></li>
        <li class="active"><%: contact.Name %></li>
    </ol>

    <div class="jumbotron">
        <h1><%: contact.Name %></h1>
    </div>

    <div class="container" style="width: 200px; float: left;">
        <div class="form-group">
            <label for="txtName">Name</label>
            <asp:TextBox runat="server" ID="txtName" class="form-control" AutoPostBack="True" OnTextChanged="txtName_TextChanged"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="txtPosition">Position</label>
            <asp:TextBox runat="server" ID="txtPosition" class="form-control" AutoPostBack="True" OnTextChanged="txtPosition_TextChanged"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="txtPhone">Phone</label>
            <asp:TextBox runat="server" ID="txtPhone" class="form-control" AutoPostBack="True" OnTextChanged="txtPhone_TextChanged"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="txtEmail">Email</label>
            <asp:TextBox runat="server" ID="txtEmail" class="form-control" AutoPostBack="True" OnTextChanged="txtEmail_TextChanged"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="txtDetails">Details</label>
            <asp:TextBox runat="server" ID="txtDetails" class="form-control" AutoPostBack="True" OnTextChanged="txtDetails_TextChanged"></asp:TextBox>
        </div>
    </div>

    <table class="table">
        <caption>Notes</caption>
        <tr>
            <th>Title</th>
            <th>Created</th>
            <th>Text</th>
            <th></th>
        </tr>
        <tr>
            <% foreach (var Note in contact.Notes) { %>
            <td><%: Note.Title %></td>
            <td><%: Note.Created %></td>
            <td><%: Note.Text %></td>
            <td><a href="/Note/<%: Note.ID %>">Edit</a></td>
            <% } %>
        </tr>
    </table>
</asp:Content>
