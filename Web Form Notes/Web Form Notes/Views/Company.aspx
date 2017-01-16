<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Company.aspx.cs" Inherits="Learn_Web_Forms.Views.Company" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
	<ol class="breadcrumb">
		<li><a href="/">Home</a></li>
		<li><a href="/Companies">Companies</a></li>
		<li class="active"><%: company.Name %></li>
	</ol>

	<div class="jumbotron">
		<h1><%: company.Name %></h1>
	</div>

	<div class="container" style="width:200px; float:left;">
		<div class="form-group">
			<label for="txtName">Name</label>
			<asp:TextBox runat="server" ID="txtName" class="form-control" OnTextChanged="txtName_TextChanged" AutoPostBack="True"></asp:TextBox>
		</div>
		<div class="form-group">
			<label for="txtAddress">Address</label>
			<asp:TextBox runat="server" ID="txtAddress" class="form-control" AutoPostBack="True" OnTextChanged="txtAddress_TextChanged"></asp:TextBox>
		</div>
		<div class="form-group">
			<label for="txtCity">City</label>
			<asp:TextBox runat="server" ID="txtCity" class="form-control" AutoPostBack="True" OnTextChanged="txtCity_TextChanged"></asp:TextBox>
		</div>
		<div class="form-group">
			<label for="txtState">State</label>
			<asp:TextBox runat="server" ID="txtState" class="form-control" AutoPostBack="True" OnTextChanged="txtState_TextChanged"></asp:TextBox>
		</div>
		<div class="form-group">
			<label for="txtZip">Zip</label>
			<asp:TextBox runat="server" ID="txtZip" class="form-control" AutoPostBack="True" OnTextChanged="txtZip_TextChanged"></asp:TextBox>
		</div>
		<div class="form-group">
			<label for="txtPhone">Phone</label>
			<asp:TextBox runat="server" ID="txtPhone" class="form-control" AutoPostBack="True" OnTextChanged="txtPhone_TextChanged"></asp:TextBox>
		</div>
	</div>

	<table class="table">
		<caption>Contacts</caption>
		<tr>
			<th>Name</th>
			<th>Position</th>
			<th>Phone</th>
			<th>Email</th>
			<th>Details</th>
			<th></th>
		</tr>
		<tr>
			<% foreach (var Contact in company.Contacts) { %>
			<td><%: Contact.Name %></td>
			<td><%: Contact.Position %></td>
			<td><%: Contact.Phone %></td>
			<td><%: Contact.Email %></td>
			<td><%: Contact.Details %></td>
			<td><a href="/Contact/<%: Contact.ID %>">Edit</a></td>
			<% } %>
		</tr>
	</table>

</asp:Content>
