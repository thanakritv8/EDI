<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeFile="TYMForcastMonthImport.aspx.cs" Inherits="Pages_TYMForcastMonthImport"  Title="TYM Forecast Month Import" %>
<%@ Register Src="../Controls/TYMForcastMonthTemplate.ascx" TagName="TYMForcastMonthTemplate"  TagPrefix="uc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">TYM Forecast Month Import</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="row"><uc:TYMForcastMonthTemplate ID="c100" runat="server"></uc:TYMForcastMonthTemplate></div>
  <div data-flow="row">
    <div id="view1" runat="server"></div>
    <aquarium:DataViewExtender id="view1Extender" runat="server" TargetControlID="view1" Controller="TYMForcastMonthImport" view="grid1" ShowInSummary="True" ShowModalForms="True" />
  </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SideBarPlaceHolder" runat="Server">
  <div class="TaskBox About">
    <div class="Inner">
      <div class="Header">About</div>
      <div class="Value">This page allows tym forcast month import management.</div>
    </div>
  </div>
</asp:Content>