﻿<%@ Control Language="C#" AutoEventWireup="true" CodeFile="SA_APCForcastTemplate.ascx.cs"
    Inherits="Controls_SA_APCForcastTemplate" %>
<script type="text/javascript">
    function uploadComplete() {
        var dv = Web.DataView.find('view1Extender');
        if (dv) dv.refresh();
    }
</script>
<%--<asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>--%>
        <act:AsyncFileUpload ID="AsyncFileUpload1" runat="server" OnUploadedComplete="AsyncFileUpload1_UploadedComplete"
            OnClientUploadComplete="uploadComplete" Style="margin-bottom: 0px" />
<%--    </ContentTemplate>
</asp:UpdatePanel>--%>
