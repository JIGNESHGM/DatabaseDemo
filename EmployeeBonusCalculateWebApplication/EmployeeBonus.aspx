<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmployeeBonus.aspx.cs" Inherits="EmployeeBonusCalculateWebApplication.EmployeeBonus" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="padding-right: 10px;">
            <asp:Label ID="lblName" AssociatedControlID="txtName" Text="Name" runat="server" />&nbsp;
            <asp:TextBox ID="txtName" runat="server" />            
            <asp:Label ID="lblNameError" ControlToValidate="txtName" Text="*" ForeColor="Red" runat="server" />
        </div>
        <div style="padding-right: 10px;">
            <asp:Label ID="lblSalary" AssociatedControlID="txtSalary" Text="Salary" runat="server" />&nbsp;
            <asp:TextBox ID="txtSalary" runat="server" />
            <asp:Label ID="lblSalaryError" ControlToValidate="txtSalary" Text="*" ForeColor="Red" runat="server" />
        </div>
        <div style="padding-right: 10px;">
            <asp:Label ID="lblBonus" Text="Bonus" runat="server" AssociatedControlID="txtBonus"/>&nbsp;
            <asp:TextBox ID="txtBonus" ReadOnly="true" runat="server" />
        </div>
        <div style="padding-right: 10px;">
            <asp:Label ID="lblNetSalary" Text="Net Salary" runat="server" AssociatedControlID="txtNetSalary"/>&nbsp;
            <asp:TextBox ID="txtNetSalary" ReadOnly="true" runat="server" />
        </div>
        <div style="padding-right:10px;">
            <asp:Button ID="btnResult" Text="Result" runat="server" OnClick="btnResult_Click" />
        </div>
    </form>
</body>
</html>