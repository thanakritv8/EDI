<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeFile="MMTHForcastImport.aspx.cs" Inherits="Pages_MMTHForcastImport"  Title="MMTH Forcast Import" %>
<%@ Register Src="../Controls/MMTHForcastTemplate.ascx" TagName="MMTHForcastTemplate"  TagPrefix="uc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">MMTH Forcast Import</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="row"><uc:MMTHForcastTemplate ID="control1" runat="server"></uc:MMTHForcastTemplate></div>
  <div data-flow="row">
    <div id="view1" runat="server"></div>
    <aquarium:DataViewExtender id="view1Extender" runat="server" TargetControlID="view1" Controller="MMTHForcastImport" view="grid1" ShowInSummary="True" ShowModalForms="True" />
  </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SideBarPlaceHolder" runat="Server">
  <div class="TaskBox About">
    <div class="Inner">
      <div class="Header">About</div>
      <div class="Value">This page allows mmth forcast import management.</div>
    </div>
  </div>
</asp:Content>