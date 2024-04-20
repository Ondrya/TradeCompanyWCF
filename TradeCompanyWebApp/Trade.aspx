<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Trade.aspx.cs" Inherits="TradeCompanyWebApp.Trade" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView
                ID="GridView1"
                runat="server"
                AutoGenerateSelectButton="True"
                AutoGenerateColumns="False"
                OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
                DataKeyNames="Id">
                <Columns>
                    <asp:BoundField DataField="Id" HeaderText="Номер" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
                    <asp:BoundField DataField="Name" HeaderText="Имя" SortExpression="Name" />
                    <asp:BoundField DataField="Surname" HeaderText="Фамилия" SortExpression="Surname" />
                    <asp:BoundField DataField="BirthYear" HeaderText="Год рождения" SortExpression="BirthYear" />
                </Columns>
                <SelectedRowStyle BackColor="Yellow" />
            </asp:GridView>
        </div>
        <asp:Panel ID="Panel1" runat="server" Visible="False">
            <br />
            <asp:Label ID="Label1" runat="server" Text="Заказы выбранного покупателя"></asp:Label>
            <br />
            <asp:GridView ID="GridView2" runat="server" AutoGenerateSelectButton="True" AutoGenerateColumns="false">
                <Columns>
                    <asp:BoundField DataField="Id" HeaderText="Номер" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
                    <asp:BoundField DataField="Title" HeaderText="Название товара" SortExpression="Title" />
                    <asp:BoundField DataField="CustomerId" HeaderText="Номер заказчика" SortExpression="CustomerId" ReadOnly="True" />
                    <asp:BoundField DataField="Price" HeaderText="Цена" SortExpression="Price" />
                    <asp:BoundField DataField="Quantity" HeaderText="Кол-во" SortExpression="Quantity" />
                </Columns>
                <SelectedRowStyle BackColor="Yellow" />
            </asp:GridView>
        </asp:Panel>
    </form>
</body>
</html>
