<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeFile="IMCTOrderImport.aspx.cs" Inherits="Pages_IMCTOrderImport"  Title="IMCT Order" %>
<%@ Register Src="../Controls/IMCTOrderTemplate.ascx" TagName="IMCTOrderTemplate"  TagPrefix="uc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">IMCT Order</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="row"><uc:IMCTOrderTemplate ID="c100" runat="server"></uc:IMCTOrderTemplate></div>
  <div data-flow="row">
    <div id="view1" runat="server"></div>
    <aquarium:DataViewExtender id="view1Extender" runat="server" TargetControlID="view1" Controller="IMCTOrderImport" view="grid1" ShowInSummary="True" SelectionMode="Multiple" ShowViewSelector="False" StartCommandArgument="Administrators,SD" ShowModalForms="True" ShowRowNumber="True" />
  </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SideBarPlaceHolder" runat="Server">
  <div class="TaskBox About">
    <div class="Inner">
      <div class="Header">About</div>
      <div class="Value">This page allows imct order import management.</div>
    </div>
  </div>
</asp:Content>