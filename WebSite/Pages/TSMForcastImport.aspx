<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeFile="TSMForcastImport.aspx.cs" Inherits="Pages_TSMForcastImport"  Title="TSMForcast Import" %>
<%@ Register Src="../Controls/TSMForcastTemplate.ascx" TagName="TSMForcastTemplate"  TagPrefix="uc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">TSMForcast Import</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="row"><uc:TSMForcastTemplate ID="control1" runat="server"></uc:TSMForcastTemplate></div>
  <div data-flow="row">
    <div id="view1" runat="server"></div>
    <aquarium:DataViewExtender id="view1Extender" runat="server" TargetControlID="view1" Controller="TSMForcastImport" view="" />
  </div>
</asp:Content>