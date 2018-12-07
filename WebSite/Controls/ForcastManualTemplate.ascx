<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ForcastManualTemplate.ascx.cs"
    Inherits="Controls_ForcastManualTemplate" %>

<script type="text/javascript">
    $(document).ready(function () {

        // ดึงไอดีรายการ input
        var idlist = [];
        $('.textboxcustom').each(function () {
            idlist.push($(this).attr('id'));
        });
        $('.textboxcustom').focus(function () {
            $('.textboxcustom').css('background-color', '#FFFF99');
            $(this).css('background-color', '#fff');
        });
        $('.textboxcustom').keydown(function (e) {
            if (e.which == 13) {
                // เป็นอันสุดท้ายหรือไม่?
                var id = $(this).attr('id');
                // ถ้าไปถึงอันสุดท้าย
                if (id == idlist[idlist.length - 1]) {
                    // บันทึกหรืออื่นๆ
                    console.log('complete');
                } else {
                    // ไปตำแหน่งถัดไป
                    console.log(id);
                    if (id == "txtCustCode") {
                        console.log(id);
                        var strCondition = $('#txtCustCode').val();
                        loadMaterial("cbPlantCode", strCondition);
                    } else if (id == "cbPlantCode") {
                        var strCondition = $('#txtCustCode').val() + ":" + $('#cbPlantCode').val();
                        loadMaterial("cbMatCode", strCondition);
                    } else if (id == "cbMatCode") {
                        var strCondition = $('#txtCustCode').val() + ":" + $('#cbPlantCode').val() + ":" + $('#cbMatCode').val();
                        loadMaterialInText(strCondition);
                    };
                    var idindex = idlist.indexOf(id);
                    if (id == "cbMatCode") {
                        $('#' + idlist[idindex + 2]).focus();
                    } else if (id == "txtCustPO") {
                        $('#' + idlist[idindex + 5]).focus();
                    } else {
                        $('#' + idlist[idindex + 1]).focus();
                    }

                }

            }
        });
    });
    function loadMaterialInText(strCondition) {
        var pageurl = '<%=ResolveUrl("~/Services/WebService.asmx")%>';
        var d = [];
        $.ajax({
            type: "POST",
            url: pageurl + "/ShowMatInText",
            data: "{strCondition:'" + strCondition + "'}",
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            async: false,
            success: function (response) {
                var d = JSON.parse(response.d);
                var mass = d[0].MassPartsIDFlag;
                var key1 = d[0].ExpansionKey1;
                var key2 = d[0].ExpansionKey2;
                var key3 = d[0].ExpansionKey3;

                $('#txtPartDevision').val(mass);
                $('#txtKey1').val(key1);
                $('#txtKey2').val(key2);
                $('#txtKey3').val(key3);
                $('#txtReliability').val("P");
                $('#txtUnit').val("ST");
                $('#txtPlngPeriod').val('D');
            }
        });
    }
    function loadMaterial(actionResult, strCondition) {
        var pageurl = '<%=ResolveUrl("~/Services/WebService.asmx")%>';
        var d = [];
        $.ajax({
            type: "POST",
            url: pageurl + "/" + actionResult,
            data: "{strCondition:'" + strCondition + "'}",
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            async: false,
            success: function (response) {
                var d = JSON.parse(response.d);
                var t = '';
                for (var i = 0; i <= d.length - 1; i++) {
                    t += '<option value="' + d[i].strItem + '">' + d[i].strItem + '</option>';
                }

                $('#' + actionResult).html(t);
            }
        });
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
    /****** ช่อง input ******/
    .textboxcustom
    {
    background-color: white;
    display: inline-block;
    border-radius: 5px;
    font-size : 18px;
    height : 30px;
    width:160px;
    padding-left:7px;
    }
    /****** ตัวหนังสือ ******/
    .headerFont
    {
     font-size:18px;
     font-weight:bold;   
    }
</style>
<table style="width: 77%;">
<tr>
        <td>
            <asp:Label ID="Label13" runat="server" Text="Customer :" class="headerFont"></asp:Label>
        </td>
        <td colspan ="5">
            <input type="text" style="background-color: #FFFF99" id="txtCustCode" class="textboxcustom"/>
            <%--<asp:TextBox ID="txtCustCode" runat="server" BackColor="#FFFF99" class="textboxcustom"></asp:TextBox>--%>
             &nbsp;&nbsp;
             <asp:Label ID="lbMsg" runat="server" Text="Msg" ForeColor="Red" class="headerFont"></asp:Label>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="Label7" runat="server" Text="Delivery Dest." class="headerFont"></asp:Label>
        </td>
        <td>
            <asp:Label ID="Label8" runat="server" Text="Cust MatCode" class="headerFont"></asp:Label>
        </td>
        <td>
            <asp:Label ID="Label9" runat="server" Text="Part Devision" class="headerFont"></asp:Label>
        </td>
        <td class="style4">
            <asp:Label ID="Label10" runat="server" Text="Cust PO" class="headerFont"></asp:Label>
        </td>
        <td class="style5">
            <asp:Label ID="Label11" runat="server" Text="Key1" class="headerFont"></asp:Label>
        </td>
        <td>
            <asp:Label ID="Label12" runat="server" Text="Key2" class="headerFont"></asp:Label>
        </td>
    </tr>
   
    <tr>
        <td class="style1">
            <select id="cbPlantCode" style="background-color: #FFFF99" class="textboxcustom"></select>
        </td>
        <td class="style2">
            <select id="cbMatCode" style="background-color: #FFFF99" class="textboxcustom"></select>
        </td>
        <td class="style3">
            <input id="txtPartDevision" type="text" style="background-color: #FFFF99" class="textboxcustom" disabled/>
        </td>
        <td class="style4">
            <input id="txtCustPO" type="text" style="background-color: #FFFF99" class="textboxcustom"/>
        </td>
        <td class="style5">
            <input id="txtKey1" type="text" style="background-color: #FFFF99" class="textboxcustom" disabled/>
        </td>
        <td>
            <input id="txtKey2" type="text" style="background-color: #FFFF99" class="textboxcustom" disabled/>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="Label1" runat="server" Text="Key3" class="headerFont"></asp:Label>
        </td>
        <td>
            <asp:Label ID="Label2" runat="server" Text="Reliability Devision" class="headerFont"></asp:Label>
        </td>
        <td>
            <asp:Label ID="Label3" runat="server" Text="Delivery Date" class="headerFont"></asp:Label>
        </td>
        <td class="style4">
            <asp:Label ID="Label4" runat="server" Text="Quantity" class="headerFont"></asp:Label>
        </td>
        <td class="style5">
            <asp:Label ID="Label5" runat="server" Text="Unit" class="headerFont"></asp:Label>
        </td>
        <td>
            <asp:Label ID="Label6" runat="server" Text="Plng Period" class="headerFont"></asp:Label>
        </td>
    </tr>
    <tr>
        <td>
            <input id="txtKey3" type="text" style="background-color: #FFFF99" class="textboxcustom" disabled/>
        </td>
        <td>
            <input id="txtReliability" type="text" style="background-color: #FFFF99" class="textboxcustom" disabled/>
        </td>
        <td>
            <input id="txtDeliveryDate" type="text" style="background-color: #FFFF99" class="textboxcustom"/>
        </td>
        <td class="style4">
            <input id="txtQty" type="text" style="background-color: #FFFF99" class="textboxcustom"/>    
        </td>
        <td class="style5">
            <input id="txtUnit" type="text" style="background-color: #FFFF99" class="textboxcustom" disabled/>
        </td>
        <td>
            <input id="txtPlngPeriod" type="text" style="background-color: #FFFF99" class="textboxcustom" disabled/>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="Label16" runat="server" Text="PlantCode" class="headerFont"></asp:Label>
        </td>
        <td>
            <asp:Label ID="Label17" runat="server" Text="AddCode" class="headerFont"></asp:Label>
        </td>
        <td>
            <asp:Label ID="Label18" runat="server" Text="Arrivaltime" class="headerFont"></asp:Label>
        </td>
        <td class="style4">
            <asp:Label ID="Label19" runat="server" Text="FromTo" class="headerFont"></asp:Label>
        </td>
    </tr>
    <tr>
        <td>
            <input id="txtPlanCode1" type="text" style="background-color: #FFFF99" class="textboxcustom"/>
        </td>
        <td>
            <input id="txtAddCode" type="text" style="background-color: #FFFF99" class="textboxcustom"/>
        </td>
        <td>
            <input id="txtArrivaltime" type="text" style="background-color: #FFFF99" class="textboxcustom"/>
        </td>
        <td class="style4">
            <input id="txtFromTo" type="text" style="background-color: #FFFF99" class="textboxcustom"/>    
        </td>
    </tr>
    
</table>
