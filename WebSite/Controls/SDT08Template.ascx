<%@ Control Language="C#" AutoEventWireup="true" CodeFile="SDT08Template.ascx.cs"
    Inherits="Controls_SDT08Template" %>
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
                <asp:TextBox ID="TextBox1" runat="server" Text="2017-01-15" class="date"></asp:TextBox>
              <%--  <act:CalendarExtender ID="TextBox1_CalendarExtender" runat="server" 
                    TargetControlID="TextBox1">
                </act:CalendarExtender>--%>
            </td>
            <td>
                To
            </td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server"  Text="2017-01-16" class="date"></asp:TextBox>
               <%-- <act:CalendarExtender ID="TextBox2_CalendarExtender" runat="server" 
                    TargetControlID="TextBox2">
                </act:CalendarExtender>--%>
            </td>
            <td>
                &nbsp;&nbsp;
                <asp:Button ID="btnExecute" runat="server" Text="Execute" 
                    onclick="btnExecute_Click" style="height: 26px" />
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
<div>
    <asp:UpdatePanel runat="server" ID="UpdatePanel" UpdateMode="Conditional">
        <ContentTemplate>

            <rsweb:ReportViewer ID="ReportViewer1" runat="server" Font-Names="Verdana" 
                Font-Size="8pt" WaitMessageFont-Names="Verdana" WaitMessageFont-Size="14pt" 
                Width="100%" InteractiveDeviceInfos="(Collection)">
                <LocalReport ReportPath="Reports\SDT08.rdlc">
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
     jQuery(document).ready(function () {
         $('.date').datepicker({ dateFormat: 'yy-mm-dd' });
         $('.date').on('change', function () {

         });
     });
</script>