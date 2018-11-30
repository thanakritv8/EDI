<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeFile="SDT05.aspx.cs" Inherits="Pages_SDT05"  Title="T05" %>
<%@ Register Src="../Controls/SDT05Template.ascx" TagName="SDT05Template"  TagPrefix="uc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">T05</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="row"><uc:SDT05Template ID="control1" runat="server"></uc:SDT05Template></div>
</asp:Content>