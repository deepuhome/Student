<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="IISManager.aspx.cs" Inherits="IISController.IISManager" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    <div>
    
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 10px; top: 37px; position: absolute" Text="Button" />
    
    </div>
    </form>
</body>
</html>
