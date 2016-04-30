<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/common/UI/ShopMaster/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DotNetSamples.WebForms.Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <%--<asp:label runat="server" id="lblText"></asp:label>
    <br />
    <asp:hyperlink id="hlNext" runat="server">Next</asp:hyperlink>
    <asp:hyperlink id="hlPrevious" runat="server">Previous</asp:hyperlink>

    <hr />

        <p>categories</p>
    <p>Primary: <%= this.PrimaryCategory %></p>
    <p>Secondary: <%= this.SecondaryCategory %></p>

    <hr />--%>

    <asp:label id="lblError" runat="server"></asp:label>

        <div class="cols">
            <div class="col">
                <ul id="categoryList" runat="server" style="list-style-type: none;"></ul>
            </div>
        </div>
    
</asp:Content>
