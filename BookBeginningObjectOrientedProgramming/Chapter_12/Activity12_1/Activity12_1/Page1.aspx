<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Page1.aspx.cs" Inherits="Activity12_1.Page1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 1308px;
            position: absolute;
            top: 15px;
            left: 10px;
        }
        .auto-style2 {
            width: 114px;
            height: 33px;
            position: absolute;
            top: 41px;
            left: 307px;
            z-index: 1;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 200px; z-index: 1;" class="auto-style1">
            <asp:Label ID="lblMessage" runat="server" Text="Hello Stranger"></asp:Label>
            <asp:Label ID="lblName" runat="server" Text="Enter your name:"></asp:Label>
            <asp:TextBox ID="txtName" runat="server" Text=""></asp:TextBox>
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
            <asp:RadioButtonList ID="rblFontColor" runat="server" CssClass="auto-style2" OnSelectedIndexChanged="rblFontColor_SelectedIndexChanged" style="z-index: 1">
                <asp:ListItem>Black</asp:ListItem>
                <asp:ListItem>Red</asp:ListItem>
            </asp:RadioButtonList>
        </div>
    </form>
</body>
</html>
