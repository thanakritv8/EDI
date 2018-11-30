<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeFile="APCForcastMonthImport.aspx.cs" Inherits="Pages_APCForcastMonthImport"  Title="APC Forecast Month Import" %>
<%@ Register Src="../Controls/SA_APCForcastTemplate.ascx" TagName="SA_APCForcastTemplate"  TagPrefix="uc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">APC Forecast Month Import</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="row"><uc:SA_APCForcastTemplate ID="c100" runat="server"></uc:SA_APCForcastTemplate></div>
  <div data-flow="row">
    <div id="view1" runat="server"></div>
    <aquarium:DataViewExtender id="view1Extender" runat="server" TargetControlID="view1" Controller="APCForcastMonthImport" view="grid1" ShowInSummary="True" ShowViewSelector="False" ShowModalForms="True" />
  </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SideBarPlaceHolder" runat="Server">
  <div class="TaskBox About">
    <div class="Inner">
      <div class="Header">About</div>
      <div class="Value">This page allows apc forcast month import management.</div>
    </div>
  </div>
</asp:Content>