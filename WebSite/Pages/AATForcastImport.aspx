<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeFile="AATForcastImport.aspx.cs" Inherits="Pages_AATForcastImport"  Title="AAT Forecast" %>
<%@ Register Src="../Controls/AATForcastTemplate.ascx" TagName="AATForcastTemplate"  TagPrefix="uc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">AAT Forecast</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="row"><uc:AATForcastTemplate ID="control1" runat="server"></uc:AATForcastTemplate></div>
  <div data-flow="row">
    <div id="view1" runat="server"></div>
    <aquarium:DataViewExtender id="view1Extender" runat="server" TargetControlID="view1" Controller="AATForcastImport" view="grid1" ShowInSummary="True" ShowModalForms="True" />
  </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SideBarPlaceHolder" runat="Server">
  <div class="TaskBox About">
    <div class="Inner">
      <div class="Header">About</div>
      <div class="Value">This page allows aat forcast import management.</div>
    </div>
  </div>
</asp:Content>