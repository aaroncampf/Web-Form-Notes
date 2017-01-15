<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Companies.aspx.cs" Inherits="Learn_Web_Forms.Views.Companies" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
<%
    var db = new Learn_Web_Forms.Database.Database();
%>
    <%-- <%= get.SomeString() %>--%>
    <table>
        <tr>
            <th>Name</th>
            <th>Address</th>
            <th>City</th>
            <th>State</th>
            <th>Zip</th>
            <th>Phone</th>
            <th></th>
        </tr>
        <%
            foreach (var item in db.Companies) {
                Response.Write("<tr>");
                Response.Write($"<td>{item.Name}</td>");
                Response.Write($"<td>{item.Address}</td>");
                Response.Write($"<td>{item.City}</td>");
                Response.Write($"<td>{item.State}</td>");
                Response.Write($"<td>{item.Zip}</td>");
                Response.Write($"<td>{item.Phone}</td>");
                Response.Write($"<td><a href='/Contacts/?id={item.ID}'>Contacts</a></td>");
                 Response.Write("</tr>");
            }
        %>
    </table>
</asp:Content>
