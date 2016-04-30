<%@ Page Title="Account Confirmation" Language="C#" MasterPageFile="~/common/UI/ShopMaster/Site.Master" AutoEventWireup="true" CodeBehind="Confirm.aspx.cs" Inherits="Shop.DotNetSamples.WebFormsAccount.Confirm" Async="true" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <h2><%: Title %>.</h2>

    <div>
        <asp:PlaceHolder runat="server" ID="status" ViewStateMode="Disabled">
            <p><%: StatusMessage %></p>
        </asp:PlaceHolder>
    </div>
</asp:Content>
