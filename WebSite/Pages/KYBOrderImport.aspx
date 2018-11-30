<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeFile="KYBOrderImport.aspx.cs" Inherits="Pages_KYBOrderImport"  Title="KYB Order" %>
<%@ Register Src="../Controls/KYBOrderTemplate.ascx" TagName="KYBOrderTemplate"  TagPrefix="uc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">KYB Order</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="row"><uc:KYBOrderTemplate ID="c100" runat="server"></uc:KYBOrderTemplate></div>
  <div data-flow="row">
    <div id="view1" runat="server"></div>
    <aquarium:DataViewExtender id="view1Extender" runat="server" TargetControlID="view1" Controller="KYBOrderImport" view="grid1" ShowInSummary="True" SelectionMode="Multiple" ShowViewSelector="False" ShowModalForms="True" ShowRowNumber="True" />
  </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SideBarPlaceHolder" runat="Server">
  <div class="TaskBox About">
    <div class="Inner">
      <div class="Header">About</div>
      <div class="Value">This page allows kyb order import management.</div>
    </div>
  </div>
</asp:Content>