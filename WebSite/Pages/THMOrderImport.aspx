<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeFile="THMOrderImport.aspx.cs" Inherits="Pages_THMOrderImport"  Title="THM Order Import" %>
<%@ Register Src="../Controls/THMOrderTemplate.ascx" TagName="THMOrderTemplate"  TagPrefix="uc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">THM Order Import</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="row"><uc:THMOrderTemplate ID="c100" runat="server"></uc:THMOrderTemplate></div>
  <div data-flow="row">
    <div id="view1" runat="server"></div>
    <aquarium:DataViewExtender id="view1Extender" runat="server" TargetControlID="view1" Controller="THMOrderImport" view="grid1" ShowInSummary="True" SelectionMode="Multiple" ShowViewSelector="False" ShowModalForms="True" ShowRowNumber="True" />
  </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SideBarPlaceHolder" runat="Server">
  <div class="TaskBox About">
    <div class="Inner">
      <div class="Header">About</div>
      <div class="Value">This page allows thm order import management.</div>
    </div>
  </div>
</asp:Content>