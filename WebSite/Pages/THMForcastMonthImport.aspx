<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeFile="THMForcastMonthImport.aspx.cs" Inherits="Pages_THMForcastMonthImport"  Title="THM Forecast Month Import" %>
<%@ Register Src="../Controls/SA_THMForcastTemplate.ascx" TagName="SA_THMForcastTemplate"  TagPrefix="uc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">THM Forecast Month Import</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="row"><uc:SA_THMForcastTemplate ID="c100" runat="server"></uc:SA_THMForcastTemplate></div>
  <div data-flow="row">
    <div id="view1" runat="server"></div>
    <aquarium:DataViewExtender id="view1Extender" runat="server" TargetControlID="view1" Controller="THMForcastMonthImport" view="grid1" ShowInSummary="True" ShowViewSelector="False" ShowModalForms="True" />
  </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SideBarPlaceHolder" runat="Server">
  <div class="TaskBox About">
    <div class="Inner">
      <div class="Header">About</div>
      <div class="Value">This page allows thm forcast month import management.</div>
    </div>
  </div>
</asp:Content>