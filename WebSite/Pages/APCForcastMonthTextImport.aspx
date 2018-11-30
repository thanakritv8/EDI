<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeFile="APCForcastMonthTextImport.aspx.cs" Inherits="Pages_APCForcastMonthTextImport"  Title="APC Forecast Month Text Import" %>
<%@ Register Src="../Controls/APCForcastMonthTextTemplate.ascx" TagName="APCForcastMonthTextTemplate"  TagPrefix="uc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">APC Forecast Month Text Import</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="row"><uc:APCForcastMonthTextTemplate ID="c100" runat="server"></uc:APCForcastMonthTextTemplate></div>
  <div data-flow="row">
    <div id="view1" runat="server"></div>
    <aquarium:DataViewExtender id="view1Extender" runat="server" TargetControlID="view1" Controller="APCForcastMonthTextImport" view="grid1" ShowInSummary="True" ShowModalForms="True" />
  </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SideBarPlaceHolder" runat="Server">
  <div class="TaskBox About">
    <div class="Inner">
      <div class="Header">About</div>
      <div class="Value">This page allows apc forcast month text import management.</div>
    </div>
  </div>
</asp:Content>