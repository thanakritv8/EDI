<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeFile="TSMOrderImport.aspx.cs" Inherits="Pages_TSMOrderImport"  Title="TSM Order" %>
<%@ Register Src="../Controls/TSMOrderTemplate.ascx" TagName="TSMOrderTemplate"  TagPrefix="uc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">TSM Order</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="row"><uc:TSMOrderTemplate ID="c100" runat="server"></uc:TSMOrderTemplate></div>
  <div data-flow="row">
    <div id="view1" runat="server"></div>
    <aquarium:DataViewExtender id="view1Extender" runat="server" TargetControlID="view1" Controller="TSMOrderImport" view="grid1" ShowInSummary="True" SelectionMode="Multiple" ShowViewSelector="False" ShowModalForms="True" ShowRowNumber="True" />
  </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SideBarPlaceHolder" runat="Server">
  <div class="TaskBox About">
    <div class="Inner">
      <div class="Header">About</div>
      <div class="Value">This page allows tsm order import management.</div>
    </div>
  </div>
</asp:Content>