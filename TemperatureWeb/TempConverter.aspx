<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TempConverter.aspx.cs" Inherits="TemperatureWeb.TempConverter" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label" runat="server" Text="Input temperature to convert :"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox_input" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button_Celsius" runat="server" OnClick="Button_Celsius_Click" Text="Convert to Celsius" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button_Fahren" runat="server" OnClick="Button_Fahren_Click" Text="Convert to Fahrenhiet" />
            <br />
            <br />
            <br />
            Output :&nbsp;&nbsp;&nbsp;&nbsp; <asp:Label ID="Label_output" runat="server" Text="____________"></asp:Label>
        </div>
    </form>
</body>
</html>
