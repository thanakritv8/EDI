<%@ Control Language="C#" AutoEventWireup="true" CodeFile="HATCOrderTemplate.ascx.cs"
    Inherits="Controls_HATCOrderTemplate" %>
<script type="text/javascript">
    function uploadComplete() {
        var dv = Web.DataView.find('view1Extender');
        if (dv) dv.refresh();
    }
</script>
<div>
    <act:AsyncFileUpload ID="AsyncFileUpload1" runat="server" OnUploadedComplete="AsyncFileUpload1_UploadedComplete"
        OnClientUploadComplete="uploadComplete" Style="margin-bottom: 0px" />
</div>
