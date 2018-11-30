<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeFile="SDT08.aspx.cs" Inherits="Pages_SDT08"  Title="T08" %>
<%@ Register Src="../Controls/SDT08Template.ascx" TagName="SDT08Template"  TagPrefix="uc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">T08</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="row"><uc:SDT08Template ID="control1" runat="server"></uc:SDT08Template></div>
</asp:Content>