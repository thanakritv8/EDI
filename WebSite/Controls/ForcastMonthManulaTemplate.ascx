<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ForcastMonthManulaTemplate.ascx.cs"
    Inherits="Controls_ForcastMonthManulaTemplate" %>
<script type="text/javascript">
    function pageLoad() {
        document.getElementById('<%=txtCustCode.ClientID%>').focus();
        document.getElementById('<%=lbMsg.ClientID%>').innerHTML = "";
    } 
</script>
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
            <asp:Label ID="Label13" runat="server" Text="Customer :"></asp:Label>
        </td>
        <td colspan="5">
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
            <asp:Label ID="Label3" runat="server" Text="Delivery Date (ddMMyy)"></asp:Label>
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
            <asp:TextBox ID="txtUnit" runat="server" BackColor="White"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtPlngPeriod" runat="server" BackColor="White"></asp:TextBox>
        </td>
    </tr>
</table>
<script type="text/javascript">
    document.onkeydown = function () {
        if (event.keyCode == 13) {
            var CustCode = document.getElementById('<%=txtCustCode.ClientID%>');
            // Validate CustCode
            var pageUrl = '<%=ResolveUrl("~/Services/WebService.asmx")%>';
            $.ajax({
                type: "POST",
                url: pageUrl + "/Customer_Validate",
                data: "{CustCode:'" + CustCode.value + "'}",
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (response) {
                    if (response.d == "0") {
                        document.getElementById('<%=txtCustCode.ClientID%>').focus();
                        document.getElementById('<%=lbMsg.ClientID%>').innerHTML = "Invalid Customer Code";
                        document.getElementById('<%=txtCustCode.ClientID%>').value = "";
                    }
                    else {
                        DataKeyIn();
                    }
                },
                error: function (response) {
                    alert(response.status + " " + response.statusText);

                }
            });



            event.preventDefault();
            return false;
        }
    }

    function ClearData() {

        document.getElementById('<%=txtLocation.ClientID%>').value = "";
        document.getElementById('<%=txtMatCode.ClientID%>').value = "";
        document.getElementById('<%=txtPartDevision.ClientID%>').value = "";
        document.getElementById('<%=txtCustPO.ClientID%>').value = "";
        document.getElementById('<%=txtKey1.ClientID%>').value = "";
        document.getElementById('<%=txtKey2.ClientID%>').value = "";
        document.getElementById('<%=txtKey3.ClientID%>').value = "";
        document.getElementById('<%=txtReliability.ClientID%>').value = "";
        document.getElementById('<%=txtDeliveryDate.ClientID%>').value = "";
        document.getElementById('<%=txtQty.ClientID%>').value = "";
        document.getElementById('<%=txtUnit.ClientID%>').value = "";
        document.getElementById('<%=txtPlngPeriod.ClientID%>').value = "";
    }

    function DataKeyIn() {
        document.getElementById('<%=lbMsg.ClientID%>').innerHTML = "";
        // Delivery Dest
        var DeliveryDest = document.getElementById('<%=txtLocation.ClientID%>');
        if (DeliveryDest.value == "") {
            document.getElementById('<%=txtLocation.ClientID%>').focus();
        } else {
            // MatCode
            var MatCode = document.getElementById('<%=txtMatCode.ClientID%>');
            if (MatCode.value == "") {
                document.getElementById('<%=txtMatCode.ClientID%>').focus();
            } else {
                // Part Devision
                var PartDevision = document.getElementById('<%=txtPartDevision.ClientID%>');
                if (PartDevision.value == "") {
                    document.getElementById('<%=txtPartDevision.ClientID%>').focus();
                } else {
                    // Cust PO
                    var CustPO = document.getElementById('<%=txtCustPO.ClientID%>');
                    if (CustPO.value == "") {
                        document.getElementById('<%=txtCustPO.ClientID%>').focus();
                    } else {
                        // Key1
                        var Key1 = document.getElementById('<%=txtKey1.ClientID%>');
                        if (Key1.value == "") {
                            document.getElementById('<%=txtKey1.ClientID%>').focus();
                        } else {
                            // Key2
                            var Key2 = document.getElementById('<%=txtKey2.ClientID%>');
                            if (Key2.value == "") {
                                document.getElementById('<%=txtKey2.ClientID%>').focus();
                            } else {
                                // Key3
                                var Key3 = document.getElementById('<%=txtKey3.ClientID%>');
                                if (Key3.value == "") {
                                    document.getElementById('<%=txtKey3.ClientID%>').focus();
                                } else {
                                    // Reliability
                                    var Reliability = document.getElementById('<%=txtReliability.ClientID%>')
                                    if (Reliability.value == "") {
                                        document.getElementById('<%=txtReliability.ClientID%>').focus();
                                    } else {
                                        // Delivery Date  ddMMyy
                                        var DeliveryDate = document.getElementById('<%=txtDeliveryDate.ClientID%>');
                                        if (DeliveryDate.value == "") {
                                            document.getElementById('<%=txtDeliveryDate.ClientID%>').focus();
                                        } else {
                                            // Quantity
                                            var Quantity = document.getElementById('<%=txtQty.ClientID%>');
                                            if (Quantity.value == "") {
                                                document.getElementById('<%=txtQty.ClientID%>').focus();
                                            } else {
                                            InsertData();
                                                document.getElementById('<%=txtLocation.ClientID%>').focus();
                                                ClearData();
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }

    function InsertData() {

    }    
</script>
