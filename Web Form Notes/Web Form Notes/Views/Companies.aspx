<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Companies.aspx.cs" Inherits="Learn_Web_Forms.Views.Companies" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
	<ol class="breadcrumb">
		<li><a href="/">Home</a></li>
		<li class="active">Companies</li>
	</ol>

	<div class="jumbotron">
		<h1>Companies</h1>
	</div>
	<asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DataObjectTypeName="Learn_Web_Forms.Database.Company" DeleteMethod="DeleteCompany" InsertMethod="AddCompany" SelectMethod="GetAllCompanies" TypeName="Learn_Web_Forms.Database.Company" UpdateMethod="UpdateCompany"></asp:ObjectDataSource>

	<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1">
		<Columns>
			<asp:BoundField DataField="ID" HeaderText="ID" SortExpression="ID" />
			<asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
			<asp:BoundField DataField="Address" HeaderText="Address" SortExpression="Address" />
			<asp:BoundField DataField="City" HeaderText="City" SortExpression="City" />
			<asp:BoundField DataField="State" HeaderText="State" SortExpression="State" />
			<asp:BoundField DataField="Zip" HeaderText="Zip" SortExpression="Zip" />
			<asp:BoundField DataField="Phone" HeaderText="Phone" SortExpression="Phone" />
			<asp:hyperlinkfield Text="Details" DataNavigateUrlFields="ID" DataNavigateUrlFormatString="/Company/{0}" />
			<asp:hyperlinkfield Text="Contacts" DataNavigateUrlFields="ID" DataNavigateUrlFormatString="/Contacts/{0}" />
			<asp:hyperlinkfield Text="Quotes" DataNavigateUrlFields="ID" DataNavigateUrlFormatString="/Quotes/{0}" />
		</Columns>
	</asp:GridView>
</asp:Content>
