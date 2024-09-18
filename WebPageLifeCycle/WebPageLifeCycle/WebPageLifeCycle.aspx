<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebPageLifeCycle.aspx.cs" Inherits="WebPageLifeCycle.WebPageLifeCycle" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtInput" runat="server"></asp:TextBox>
            <asp:Button ID="btnSubmit" runat="server" Text="submit" OnClick="btnSubmit_Click"/>
            <br />
            <asp:Label ID="lblOutput" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
