<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeFile="HATCForcastMonthExcelImport.aspx.cs" Inherits="Pages_HATCForcastMonthExcelImport"  Title="HATC Forcast Month Excel Import" %>
<%@ Register Src="../Controls/HATCForcastMonthExcelTemplate.ascx" TagName="HATCForcastMonthExcelTemplate"  TagPrefix="uc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">HATC Forcast Month Excel Import</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="NewRow"><uc:HATCForcastMonthExcelTemplate ID="c100" runat="server"></uc:HATCForcastMonthExcelTemplate></div>
  <div data-flow="NewRow">
    <div id="view1" runat="server"></div>
    <aquarium:DataViewExtender id="view1Extender" runat="server" TargetControlID="view1" Controller="HATCForcastMonthExcelImport" view="grid1" ShowInSummary="True" ShowModalForms="True" />
  </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SideBarPlaceHolder" runat="Server">
  <div class="TaskBox About">
    <div class="Inner">
      <div class="Header">About</div>
      <div class="Value">This page allows hatc forcast month excel import management.</div>
    </div>
  </div>
</asp:Content>