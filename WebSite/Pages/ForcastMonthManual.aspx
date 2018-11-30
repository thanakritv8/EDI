<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeFile="ForcastMonthManual.aspx.cs" Inherits="Pages_ForcastMonthManual"  Title="Forecast Month Manual" %>
<%@ Register Src="../Controls/ForcastMonthManulaTemplate.ascx" TagName="ForcastMonthManulaTemplate"  TagPrefix="uc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Forecast Month Manual</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="row"><uc:ForcastMonthManulaTemplate ID="c100" runat="server"></uc:ForcastMonthManulaTemplate></div>
  <div data-flow="row">
    <div id="view1" runat="server"></div>
    <aquarium:DataViewExtender id="view1Extender" runat="server" TargetControlID="view1" Controller="ForcastMonthManual" view="grid1" ShowInSummary="True" ShowModalForms="True" />
  </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SideBarPlaceHolder" runat="Server">
  <div class="TaskBox About">
    <div class="Inner">
      <div class="Header">About</div>
      <div class="Value">This page allows forcast month manual management.</div>
    </div>
  </div>
</asp:Content>