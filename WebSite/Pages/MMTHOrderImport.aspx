<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeFile="MMTHOrderImport.aspx.cs" Inherits="Pages_MMTHOrderImport"  Title="MMTH Order Import" %>
<%@ Register Src="../Controls/MMTHOrderTemplate.ascx" TagName="MMTHOrderTemplate"  TagPrefix="uc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">MMTH Order Import</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="row"><uc:MMTHOrderTemplate ID="c100" runat="server"></uc:MMTHOrderTemplate></div>
  <div data-flow="row">
    <div id="view1" runat="server"></div>
    <aquarium:DataViewExtender id="view1Extender" runat="server" TargetControlID="view1" Controller="MMTHOrderImport" view="grid1" ShowInSummary="True" SelectionMode="Multiple" ShowViewSelector="False" ShowModalForms="True" ShowRowNumber="True" />
  </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SideBarPlaceHolder" runat="Server">
  <div class="TaskBox About">
    <div class="Inner">
      <div class="Header">About</div>
      <div class="Value">This page allows mmth order import management.</div>
    </div>
  </div>
</asp:Content>