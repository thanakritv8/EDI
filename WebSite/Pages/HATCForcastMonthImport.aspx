<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeFile="HATCForcastMonthImport.aspx.cs" Inherits="Pages_HATCForcastMonthImport"  Title="HATC Forecast Month Import" %>
<%@ Register Src="../Controls/HATCForcastMonthTemplate.ascx" TagName="HATCForcastMonthTemplate"  TagPrefix="uc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">HATC Forecast Month Import</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="row"><uc:HATCForcastMonthTemplate ID="c100" runat="server"></uc:HATCForcastMonthTemplate></div>
  <div data-flow="row">
    <div id="view1" runat="server"></div>
    <aquarium:DataViewExtender id="view1Extender" runat="server" TargetControlID="view1" Controller="HATCForcastMonthImport" view="grid1" ShowInSummary="True" ShowViewSelector="False" ShowModalForms="True" />
  </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SideBarPlaceHolder" runat="Server">
  <div class="TaskBox About">
    <div class="Inner">
      <div class="Header">About</div>
      <div class="Value">This page allows hatc forcast month import management.</div>
    </div>
  </div>
</asp:Content>