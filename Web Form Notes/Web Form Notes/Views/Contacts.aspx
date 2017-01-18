<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contacts.aspx.cs" Inherits="Learn_Web_Forms.Views.Contacts" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <%
    var db = new Learn_Web_Forms.Database.Database();
    int ID;
    if (int.TryParse(Request.QueryString["id"], out ID)) {
        db.Companies.Find(ID);
    }
    %>
    <%-- <%= get.SomeString() %>--%>
    <table class="table">
        <tr>
            <th>Name</th>
            <th>Address</th>
            <th>Position</th>
            <th>Phone</th>
            <th>Details</th>
            <th></th>
        </tr>
        <tr>
            <%
              foreach (var item in db.Companies.Find(ID)?.Contacts) {
                  Response.Write($"<td>{item.Name}</td>");
                  Response.Write($"<td>{item.Position}</td>");
                  Response.Write($"<td>{item.Phone}</td>");
                  Response.Write($"<td>{item.Details}</td>");
                Response.Write($"<td><a href='/Notes/?id={item.ID}'>Notes</a></td>");
              }
            %>
        </tr>
    </table>
</asp:Content>
    