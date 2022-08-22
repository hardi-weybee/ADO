<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="info.aspx.cs" Inherits="webFormDemo.info" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 150px;
        }
        .auto-style3 {
            width: 250px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="name" runat="server" Text="Name"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="nameID"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="address" runat="server" Text="Address"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="addressID"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="number" runat="server" Text="Contact No"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="numberID"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2"></td>
                    <td>
                        <asp:Button runat="server" ID="submitID" OnClick="submitID_Click" Text="Submit" />
                    </td>
                </tr>
            </table>
        </div>

        <div>
            <asp:Label ID="text" runat="server"></asp:Label>
        </div>
    </form>
    <table class="auto-style1">
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="Label1" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="Label4" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="Label2" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="Label5" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="Label3" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="Label6" runat="server"></asp:Label>
                </td>
            </tr>
     </table>
</body>
</html>
