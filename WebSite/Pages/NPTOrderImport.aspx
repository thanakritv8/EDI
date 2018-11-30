<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeFile="NPTOrderImport.aspx.cs" Inherits="Pages_NPTOrderImport"  Title="NPT Order" %>
<%@ Register Src="../Controls/NPTOrderTemplate.ascx" TagName="NPTOrderTemplate"  TagPrefix="uc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">NPT Order</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="row"><uc:NPTOrderTemplate ID="control1" runat="server"></uc:NPTOrderTemplate></div>
  <div data-flow="row">
    <div id="view1" runat="server"></div>
    <aquarium:DataViewExtender id="view1Extender" runat="server" TargetControlID="view1" Controller="NPTOrderImport" view="grid1" ShowInSummary="True" ShowModalForms="True" />
  </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SideBarPlaceHolder" runat="Server">
  <div class="TaskBox About">
    <div class="Inner">
      <div class="Header">About</div>
      <div class="Value">This page allows npt order import management.</div>
    </div>
  </div>
</asp:Content>