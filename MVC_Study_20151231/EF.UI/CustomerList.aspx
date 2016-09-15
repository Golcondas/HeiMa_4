<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomerList.aspx.cs" Inherits="EF.UI.CustomerList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        #tbList {
            border: 1px;
            width: 400px;
            margin: 20px auto;
            border-collapse: collapse;
        }
            #tbList td,#tbList th {
                border: 1px solid #0094ff;
                padding: 2px;
            }
    </style>
</head>
<body>
    <div>
        <table id="tbList">
            <tr>
                <th>ID</th>
                <th>用户Code</th>
                <th>用户名称</th>
            </tr>
            <asp:Repeater ID="rptCustomerList" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%#Eval("iKHID") %></td>
                        <td><%#Eval("vKHCode") %></td>
                        <td><%#Eval("nKHMC") %></td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </table>
    </div>
    <textarea id="bbb"></textarea>
</body>
</html>
