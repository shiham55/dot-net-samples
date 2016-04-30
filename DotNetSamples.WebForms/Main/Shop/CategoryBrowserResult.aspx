<%@ Page Title="" Language="C#" MasterPageFile="~/common/UI/ShopMaster/Site.Master" AutoEventWireup="true" CodeBehind="CategoryBrowserResult.aspx.cs" Inherits="Shop.DotNetSamples.WebFormsMain.Shop.CategoryBrowserResult" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>categories</p>
    <p>Primary: <%= this.PrimaryCategory %></p>
    <p>Secondary: <%= this.SecondaryCategory %></p>
</asp:Content>
