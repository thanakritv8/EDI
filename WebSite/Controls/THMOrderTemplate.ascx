﻿<%@ Control Language="C#" AutoEventWireup="true" CodeFile="THMOrderTemplate.ascx.cs"
    Inherits="Controls_THMOrderTemplate" %>
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