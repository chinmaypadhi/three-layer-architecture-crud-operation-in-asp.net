<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="three_layer_architecture_in_asp.net.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style3 {
            width: 219px;
        }
        .auto-style4 {
            text-align: left;
        }
        .auto-style5 {
            background-color: #00FF00;
        }
        .auto-style6 {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style4" colspan="2">
                    <div class="auto-style6">
                        <span class="auto-style5">REGISTRATION FORM</div>
                    <asp:HiddenField ID="HiddenField1" runat="server" />
                    <div class="auto-style4">
        INSERT<br />
        ..................</span></div>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">enter the name:</td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server" ></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">enter the city:</td>
                <td>
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="insert" />
                </td>
            </tr>
        </table>
        DISPLAY<br />
        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="display" />
        <br />
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        <br />
        DELETE LAT ENTERED ITEM<br />
        .............<br />
        <asp:Button ID="Button2" runat="server" Text="Delete" OnClick="Button2_Click" />
        <br />
        <br />
        <br />
        UPDATE LAST ENTERED ITEM<br />
        .......................................................<br />
        <br />
        enter the name:<asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
        <br />
        enter the dob<asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Button3" runat="server" Text="update" OnClick="Button3_Click" />
        <br />
        <br />
        SEARCH<br />
        ..................<br />
        enter the idname here<br />
        <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button5" runat="server" Text="search" Height="26px" OnClick="Button5_Click" />
        <br />
        <br />
    </form>
</body>
</html>
