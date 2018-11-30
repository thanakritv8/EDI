<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeFile="TSMForcastMonthImport.aspx.cs" Inherits="Pages_TSMForcastMonthImport"  Title="TSM Forecast Month Import" %>
<%@ Register Src="../Controls/SA_TSMForcastTemplate.ascx" TagName="SA_TSMForcastTemplate"  TagPrefix="uc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">TSM Forecast Month Import</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="row"><uc:SA_TSMForcastTemplate ID="c100" runat="server"></uc:SA_TSMForcastTemplate></div>
  <div data-flow="row">
    <div id="view1" runat="server"></div>
    <aquarium:DataViewExtender id="view1Extender" runat="server" TargetControlID="view1" Controller="TSMForcastMonthImport" view="grid1" ShowInSummary="True" ShowViewSelector="False" ShowModalForms="True" />
  </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SideBarPlaceHolder" runat="Server">
  <div class="TaskBox About">
    <div class="Inner">
      <div class="Header">About</div>
      <div class="Value">This page allows tsm forcast month import management.</div>
    </div>
  </div>
</asp:Content>