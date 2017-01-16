<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Note.aspx.cs" Inherits="Learn_Web_Forms.Views.WebForm1" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
	<ol class="breadcrumb">
		<li><a href="/">Home</a></li>
		<li><a href="/Companies">Companies</a></li>
		<li class="active"><%: company.Name %></li>
	</ol>

	<div class="jumbotron">
		<h1><%: company.Name %></h1>
	</div>



</asp:Content>