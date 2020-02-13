<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="aspnetassignment.aspx.cs" Inherits="WebApplication8.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" style="background-color: #FFFFFF">
        <div>
            <asp:Label ID="fname" runat="server" Text="First Name"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" Height="18px" style="margin-left: 115px" Width="182px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="fn" runat="server" ErrorMessage="fname is must" ControlToValidate="TextBox1" ForeColor="Red">*</asp:RequiredFieldValidator>
        </div>
        <br />
        <asp:Label ID="ag" runat="server" Text="Age"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox2" runat="server" style="margin-left: 58px" Width="183px"></asp:TextBox>
&nbsp;<asp:CompareValidator ID="CompareValidator5" runat="server" ControlToValidate="TextBox2" ErrorMessage="above 16" ForeColor="Red" Operator="GreaterThanEqual" Type="Integer" ValueToCompare="16">*</asp:CompareValidator>
        <p>
            <asp:Label ID="ln" runat="server" Text="Login Name"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox3" runat="server" style="margin-left: 54px" Width="188px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="llname" runat="server" ErrorMessage=" login name is mandatory" ControlToValidate="TextBox3" ForeColor="Red">*</asp:RequiredFieldValidator>
        </p>
        <p>
            <asp:Label ID="pwd" runat="server" Text="Password"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox4" runat="server" style="margin-left: 56px" Width="185px" TextMode="Password"></asp:TextBox>
            <asp:RequiredFieldValidator ID="pwdd" runat="server" ErrorMessage="pwd must" ControlToValidate="TextBox4" ForeColor="Red">*</asp:RequiredFieldValidator>
        </p>
        <p>
            <asp:Label ID="cpwd" runat="server" Text="Confirm Password"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox5" runat="server" style="margin-left: 56px" Width="180px" TextMode="Password"></asp:TextBox>
            <asp:CompareValidator ID="CompareValidator3" runat="server" ControlToCompare="TextBox4" ControlToValidate="TextBox5" ErrorMessage="pwd must be same" ForeColor="Red">*</asp:CompareValidator>
        </p>
        <p style="background-color: #FFFFFF">
            <asp:Label ID="exp" runat="server" Text="Experience"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox6" runat="server" style="margin-left: 53px" Width="186px"></asp:TextBox>
            <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="TextBox6" ErrorMessage="betw 3 to 12" ForeColor="Red" MaximumValue="12" MinimumValue="3" Type="Integer">*</asp:RangeValidator>
        </p>
        <p>
            <asp:Label ID="sal" runat="server" Text="Salary Expected"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox7" runat="server" style="margin-left: 54px" Width="185px"></asp:TextBox>
            <asp:CompareValidator ID="CompareValidator6" runat="server" ControlToValidate="TextBox7" ErrorMessage="below 400000" ForeColor="Red" Operator="LessThanEqual" Type="Integer" ValueToCompare="400000">*</asp:CompareValidator>
        </p>
        <asp:Button ID="anu" runat="server" OnClick="anu_Click" Text="Add New User" />
        <asp:Button ID="can" runat="server" Text="Cancel" />
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
    </form>
    </body>
</html>
