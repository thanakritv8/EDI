<%@ Control Language="C#" AutoEventWireup="true" CodeFile="OrderManualTemplate.ascx.cs"
    Inherits="Controls_OrderManualTemplate" %>
<style type="text/css">
    .style1
    {
        width: 80px;
    }
    .style2
    {
        width: 147px;
    }
    .style3
    {
        width: 115px;
    }
    .style4
    {
        width: 137px;
    }
    .style5
    {
        width: 138px;
    }
</style>
<table style="width: 77%;">
<tr>
<td>
    <asp:Label ID="Label13" runat="server" Text="Customer :"></asp:Label></td>
<td colspan ="5">
            <asp:TextBox ID="txtCustCode" runat="server" BackColor="#FFFF99"></asp:TextBox>
             &nbsp;&nbsp;
             <asp:Label ID="lbMsg" runat="server" Text="Msg" ForeColor="Red"></asp:Label>
        </td>
</tr>
<tr>
    <td>
         
        <asp:Label ID="Label7" runat="server" Text="Delivery Dest."></asp:Label>
         
        </td>
        <td>
           
            <asp:Label ID="Label8" runat="server" Text="Cust MatCode"></asp:Label>
           
        </td>
        <td>
           
            <asp:Label ID="Label9" runat="server" Text="Part Devision"></asp:Label>
           
        </td>
        <td class="style4">
            
            <asp:Label ID="Label10" runat="server" Text="Cust PO"></asp:Label>
            
        </td>
        <td class="style5">
           
            <asp:Label ID="Label11" runat="server" Text="Key1"></asp:Label>
           
        </td>
        <td>
            
            <asp:Label ID="Label12" runat="server" Text="Key2"></asp:Label>
            
        </td>
        </tr>
   
    <tr>
        <td class="style1">
            <asp:TextBox ID="txtLocation" runat="server" BackColor="#FFFF99"></asp:TextBox>
        </td>
        <td class="style2">
            <asp:TextBox ID="txtMatCode" runat="server" BackColor="#FFFF99"></asp:TextBox>
        </td>
        <td class="style3">
            <asp:TextBox ID="txtPartDevision" runat="server" BackColor="#FFFF99"></asp:TextBox>
        </td>
        <td class="style4">
            <asp:TextBox ID="txtCustPO" runat="server" BackColor="#FFFF99"></asp:TextBox>
        </td>
        <td class="style5">
            <asp:TextBox ID="txtKey1" runat="server" BackColor="#FFFF99"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtKey2" runat="server" BackColor="#FFFF99"></asp:TextBox>
        </td>
       
    </tr>
    <tr>
    <td>
         
        <asp:Label ID="Label1" runat="server" Text="Key3"></asp:Label>
         
        </td>
        <td>
           
            <asp:Label ID="Label2" runat="server" Text="Reliability Devision"></asp:Label>
           
        </td>
        <td>
           
            <asp:Label ID="Label3" runat="server" Text="Delivery Date"></asp:Label>
           
        </td>
        <td class="style4">
            
            <asp:Label ID="Label4" runat="server" Text="Quantity"></asp:Label>
            
        </td>
        <td class="style5">
           
            <asp:Label ID="Label5" runat="server" Text="Unit"></asp:Label>
           
        </td>
        <td>
            
            <asp:Label ID="Label6" runat="server" Text="Plng Period"></asp:Label>
            
        </td>
        </tr>
    <tr>
     <td>
            <asp:TextBox ID="txtKey3" runat="server" BackColor="#FFFF99"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtReliability" runat="server" BackColor="#FFFF99"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtDeliveryDate" runat="server" BackColor="#FFFF99"></asp:TextBox>
        </td>
        <td class="style4">
            <asp:TextBox ID="txtQty" runat="server" BackColor="#FFFF99"></asp:TextBox>
        </td>
        <td class="style5">
            <asp:TextBox ID="txtUnit" runat="server" BackColor="#FFFF99"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtPlngPeriod" runat="server" BackColor="#FFFF99"></asp:TextBox>
        </td>
    </tr>
    
</table>
