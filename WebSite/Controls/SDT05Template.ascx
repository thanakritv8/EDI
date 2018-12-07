<%@ Control Language="C#" AutoEventWireup="true" CodeFile="SDT05Template.ascx.cs"
    Inherits="Controls_SDT05Template" Debug="true" %>
<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=10.0.0.0, Culture=neutral, PublicKeyToken=B03F5F7F11D50A3A"
    Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>
<div>
    <link href="../Scripts/jquery-ui-1.12.1/jquery-ui.min.css" type="text/css" rel="stylesheet" />
    <table>
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Delivery Date :"></asp:Label>
            </td>
            <td>
                
                <asp:TextBox ID="TextBox1" runat="server" Text="2018-10-15" class="dateStart"></asp:TextBox>
                <%--  <act:CalendarExtender ID="TextBox1_CalendarExtender" runat="server" 
                    TargetControlID="TextBox1">
                </act:CalendarExtender>--%>
            </td>
            <td>
                To
            </td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server" Text="2018-10-24" class="dateEnd"></asp:TextBox>
                <%-- <act:CalendarExtender ID="TextBox2_CalendarExtender" runat="server" 
                    TargetControlID="TextBox2">
                </act:CalendarExtender>--%>
            </td>
            <td>
                Customer
            </td>
            <td>
                <asp:DropDownList ID="DropDownList1" runat="server" 
                    DataSourceID="SqlDataSource1" DataTextField="SoldtoParty" 
                    DataValueField="SoldtoParty">
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:ROKI_EDIConnectionString %>" 
                    SelectCommand="GetMatCode" SelectCommandType="StoredProcedure" 
                    UpdateCommand="GetMatCode" UpdateCommandType="StoredProcedure">
                </asp:SqlDataSource>
                <asp:EntityDataSource ID="EntityDataSource1" runat="server">
                </asp:EntityDataSource>
                <%-- <act:CalendarExtender ID="TextBox2_CalendarExtender" runat="server" 
                    TargetControlID="TextBox2">
                </act:CalendarExtender>--%>
            </td>
            <td>
                
                &nbsp;&nbsp;
                <asp:Button ID="btnExecute" runat="server" Text="Execute" OnClick="btnExecute_Click"
                    Style="height: 26px" />
            </td>
        </tr>
        <tr>
            <td>
            </td>
            <td>
            </td>
            <td>
            </td>
            <td>
            </td>
            <td>
            </td>
        </tr>
    </table>
</div>
<%--<div>
    <asp:UpdatePanel runat="server" ID="UpdatePanel" UpdateMode="Conditional">
        <ContentTemplate>
            <rsweb:ReportViewer ID="ReportViewer1" runat="server" Width="100%" Height="100%"
                Font-Names="Verdana" Font-Size="8pt" InteractiveDeviceInfos="(Collection)" WaitMessageFont-Names="Verdana"
                WaitMessageFont-Size="14pt">
                <LocalReport ReportPath="Reports\SDT05.rdlc">
                    <DataSources>
                        <rsweb:ReportDataSource DataSourceId="SqlDataSource1" Name="SDT05" />
                    </DataSources>
                </LocalReport>
            </rsweb:ReportViewer>
        </ContentTemplate>
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="btnExecute" EventName="Click" />
        </Triggers>
    </asp:UpdatePanel>
</div>--%>
<div>
    <asp:UpdatePanel runat="server" ID="UpdatePanel" UpdateMode="Conditional">
        <ContentTemplate>
           
            <rsweb:ReportViewer ID="ReportViewer1" runat="server" Font-Names="Verdana" Font-Size="8pt" WaitMessageFont-Names="Verdana" WaitMessageFont-Size="14pt" Width="100%">
                <LocalReport ReportPath="Reports\SDT05.rdlc">
                </LocalReport>
            </rsweb:ReportViewer>
           
        </ContentTemplate>
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="btnExecute" EventName="Click" />
        </Triggers>
    </asp:UpdatePanel>
</div>

<script type="text/javascript">
    //$(function () {
    var d = new Date();
    jQuery(document).ready(function () {
        $('.dateStart').datepicker({ dateFormat: 'yyyy-MM-dd' });
        $('.dateEnd').datepicker({ dateFormat: 'yyyy-MM-dd' });
        $('.dateStart').on('change', function () {
            var d1 = new Date(document.getElementById('<%= TextBox1.ClientID %>').value.substring(4));
            document.getElementById('<%=TextBox1.ClientID %>').value = d1.format('yyyy-MM-dd');
        });
        $('.dateEnd').on('change', function () {
            var d2 = new Date(document.getElementById('<%= TextBox2.ClientID %>').value.substring(4));
            document.getElementById('<%=TextBox2.ClientID %>').value = d2.format('yyyy-MM-dd');


        });  
 
        document.getElementById('<%=TextBox1.ClientID %>').value = d.format('yyyy-MM-dd');
        document.getElementById('<%=TextBox2.ClientID %>').value = d.format('yyyy-MM-dd');

    });
</script>
