<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WFStudents.aspx.cs" Inherits="WebApp.WFStudents" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" PostBackUrl="~/WFMain.aspx" Text="Main" />
            <asp:Button ID="Button2" runat="server" PostBackUrl="~/WFGroups.aspx" Text="Groups" />
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:vsstudentsConnectionString %>" DeleteCommand="DELETE FROM [Students] WHERE [IdStudent] = @IdStudent" InsertCommand="INSERT INTO [Students] ([FIO], [IdGroup]) VALUES (@FIO, @IdGroup)" SelectCommand="SELECT * FROM [Students]" UpdateCommand="UPDATE [Students] SET [FIO] = @FIO, [IdGroup] = @IdGroup WHERE [IdStudent] = @IdStudent">
                <DeleteParameters>
                    <asp:Parameter Name="IdStudent" Type="Int32" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="FIO" Type="String" />
                    <asp:Parameter Name="IdGroup" Type="Int32" />
                </InsertParameters>
                <UpdateParameters>
                    <asp:Parameter Name="FIO" Type="String" />
                    <asp:Parameter Name="IdGroup" Type="Int32" />
                    <asp:Parameter Name="IdStudent" Type="Int32" />
                </UpdateParameters>
            </asp:SqlDataSource>
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:vsstudentsConnectionString %>" SelectCommand="SELECT [IdGroup], [Name] FROM [Groups]"></asp:SqlDataSource>
        </div>
        <asp:FormView ID="FormView1" runat="server" CellPadding="4" DataKeyNames="IdStudent" DataSourceID="SqlDataSource1" DefaultMode="Insert" ForeColor="#333333" Width="176px">
            <EditItemTemplate>
                IdStudent:
                <asp:Label ID="IdStudentLabel1" runat="server" Text='<%# Eval("IdStudent") %>' />
                <br />
                FIO:
                <asp:TextBox ID="FIOTextBox" runat="server" Text='<%# Bind("FIO") %>' />
                <br />
                IdGroup:
                <asp:TextBox ID="IdGroupTextBox" runat="server" Text='<%# Bind("IdGroup") %>' />
                <br />
                <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Обновить" />
                &nbsp;<asp:LinkButton ID="UpdateCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Отмена" />
            </EditItemTemplate>
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <InsertItemTemplate>
                FIO:
                <asp:TextBox ID="FIOTextBox" runat="server" Text='<%# Bind("FIO") %>' />
                <br />
                IdGroup:
                <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource2" DataTextField="Name" DataValueField="IdGroup" SelectedValue='<%# Bind("IdGroup") %>'>
                </asp:DropDownList>
                <br />
                <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Вставка" />
                &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Отмена" />
            </InsertItemTemplate>
            <ItemTemplate>
                IdStudent:
                <asp:Label ID="IdStudentLabel" runat="server" Text='<%# Eval("IdStudent") %>' />
                <br />
                FIO:
                <asp:Label ID="FIOLabel" runat="server" Text='<%# Bind("FIO") %>' />
                <br />
                IdGroup:
                <asp:Label ID="IdGroupLabel" runat="server" Text='<%# Bind("IdGroup") %>' />
                <br />
                <asp:LinkButton ID="EditButton" runat="server" CausesValidation="False" CommandName="Edit" Text="Правка" />
                &nbsp;<asp:LinkButton ID="DeleteButton" runat="server" CausesValidation="False" CommandName="Delete" Text="Удалить" />
                &nbsp;<asp:LinkButton ID="NewButton" runat="server" CausesValidation="False" CommandName="New" Text="Создать" />
            </ItemTemplate>
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        </asp:FormView>
        <asp:GridView ID="GridView1" runat="server" AllowSorting="True" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="IdStudent" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                <asp:BoundField DataField="IdStudent" HeaderText="IdStudent" InsertVisible="False" ReadOnly="True" SortExpression="IdStudent" />
                <asp:BoundField DataField="FIO" HeaderText="FIO" SortExpression="FIO" />
                <asp:TemplateField HeaderText="IdGroup" SortExpression="IdGroup">
                    <EditItemTemplate>
                        <asp:DropDownList ID="DropDownList3" runat="server" DataSourceID="SqlDataSource2" DataTextField="Name" DataValueField="IdGroup" SelectedValue='<%# Bind("IdGroup") %>'>
                        </asp:DropDownList>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="SqlDataSource2" DataTextField="Name" DataValueField="IdGroup" SelectedValue='<%# Bind("IdGroup") %>'>
                        </asp:DropDownList>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>
    </form>
</body>
</html>
