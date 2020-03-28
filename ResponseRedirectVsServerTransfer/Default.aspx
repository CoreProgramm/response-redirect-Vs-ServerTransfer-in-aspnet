<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ResponseRedirectVsServerTransfer.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript">
        function SetTarget() {
            document.forms[0].target = "_blank";
        }
</script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" Text="ResponseRedirect" OnClick="Button1_Click" OnClientClick="SetTarget();"  />
            <asp:Button ID="Button2" runat="server" Text="ServerTransfer" OnClick="Button2_Click" OnClientClick="SetTarget();"  />
            <asp:Button ID="Button3" runat="server" Text="Open New Tab" OnClick="Button3_Click" />
        </div>
    </form>
</body>
</html>
