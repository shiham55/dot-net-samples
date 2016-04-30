<%@ Page Title="" Language="C#" MasterPageFile="~/common/UI/ShopMaster/Site.Master" AutoEventWireup="true" CodeBehind="test.aspx.cs" Inherits="Shop.DotNetSamples.WebFormstest" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
<%--    <asp:scriptmanager runat="server"></asp:scriptmanager>

     <asp:UpdatePanel runat="server" UpdateMode="Conditional" ID="updatePanel1">
         <ContentTemplate>--%>
            <label>From Generic GetPage</label><br/><asp:label runat="server" id="BulkyRecords"></asp:label>
            <hr/>
            <asp:hiddenfield runat="server" id="hdnCurrentPage"/>
            <hr/>
             <asp:repeater runat="server" id="rpt2">
                <ItemTemplate>
                     <%# Eval("Id") %> - <%# Eval("name") %>
                    <asp:hyperlink runat="server" id="hlEdit">Edit</asp:hyperlink>
                    <br/>
                </ItemTemplate>
            </asp:repeater>
            <asp:linkbutton runat="server" id="lbNext" >Next</asp:linkbutton>
<%--             </ContentTemplate>
         <Triggers>
             <asp:AsyncPostBackTrigger ControlID="lbNext" EventName="Click" />  
         </Triggers>
         </asp:UpdatePanel>--%>
</asp:Content>
