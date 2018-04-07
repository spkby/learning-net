<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WFMain.aspx.cs" Inherits="WebApp.WFMain" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" PostBackUrl="~/WFSubjects.aspx" Text="Subjects" />
            <asp:Button ID="Button2" runat="server" PostBackUrl="~/WFStudents.aspx" Text="Students" />
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:vsstudentsConnectionString %>" DeleteCommand="DELETE FROM [Exams] WHERE [IdExam] = @IdExam" InsertCommand="INSERT INTO [Exams] ([IdStudent], [IdSubject], [DateExam], [ExamValue]) VALUES (@IdStudent, @IdSubject, @DateExam, @ExamValue)" SelectCommand="SELECT [IdExam], [IdStudent], [IdSubject], [DateExam], [ExamValue] FROM [Exams]" UpdateCommand="UPDATE [Exams] SET [IdStudent] = @IdStudent, [IdSubject] = @IdSubject, [DateExam] = @DateExam, [ExamValue] = @ExamValue WHERE [IdExam] = @IdExam">
                <DeleteParameters>
                    <asp:Parameter Name="IdExam" Type="Int32" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="IdStudent" Type="Int32" />
                    <asp:Parameter Name="IdSubject" Type="Int32" />
                    <asp:Parameter Name="DateExam" Type="DateTime" />
                    <asp:Parameter Name="ExamValue" Type="Int32" />
                </InsertParameters>
                <UpdateParameters>
                    <asp:Parameter Name="IdStudent" Type="Int32" />
                    <asp:Parameter Name="IdSubject" Type="Int32" />
                    <asp:Parameter Name="DateExam" Type="DateTime" />
                    <asp:Parameter Name="ExamValue" Type="Int32" />
                    <asp:Parameter Name="IdExam" Type="Int32" />
                </UpdateParameters>
            </asp:SqlDataSource>
            <asp:Button ID="Button3" runat="server" PostBackUrl="~/WFAdo.aspx" Text="Button" />
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:vsstudentsConnectionString %>" SelectCommand="SELECT [IdStudent], [FIO] FROM [Students]"></asp:SqlDataSource>
            <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:vsstudentsConnectionString %>" SelectCommand="SELECT [IdSubject], [Name] FROM [Subjects]"></asp:SqlDataSource>
            <asp:FormView ID="FormView1" runat="server" CellPadding="4" DataKeyNames="IdExam" DataSourceID="SqlDataSource1" DefaultMode="Insert" ForeColor="#333333" Width="547px">
                <EditItemTemplate>
                    IdExam:
                    <asp:Label ID="IdExamLabel1" runat="server" Text='<%# Eval("IdExam") %>' />
                    <br />
                    IdStudent:
                    <asp:TextBox ID="IdStudentTextBox" runat="server" Text='<%# Bind("IdStudent") %>' />
                    <br />
                    IdSubject:
                    <asp:TextBox ID="IdSubjectTextBox" runat="server" Text='<%# Bind("IdSubject") %>' />
                    <br />
                    DateExam:
                    <asp:TextBox ID="DateExamTextBox" runat="server" Text='<%# Bind("DateExam") %>' />
                    <br />
                    ExamValue:
                    <asp:TextBox ID="ExamValueTextBox" runat="server" Text='<%# Bind("ExamValue") %>' />
                    <br />
                    <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Обновить" />
                    &nbsp;<asp:LinkButton ID="UpdateCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Отмена" />
                </EditItemTemplate>
                <EditRowStyle BackColor="#999999" />
                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <InsertItemTemplate>
                    IdStudent:
                    <asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="SqlDataSource2" DataTextField="FIO" DataValueField="IdStudent" SelectedValue='<%# Bind("IdStudent") %>'>
                    </asp:DropDownList>
                    &nbsp;IdSubject:
                    <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource3" DataTextField="Name" DataValueField="IdSubject" SelectedValue='<%# Bind("IdSubject") %>'>
                    </asp:DropDownList>
                    <br />
                    <br />
                    DateExam:
                    <asp:TextBox ID="DateExamTextBox" runat="server" Text='<%# Bind("DateExam") %>' />
                    &nbsp; ExamValue:
                    <asp:TextBox ID="ExamValueTextBox" runat="server" Text='<%# Bind("ExamValue") %>' />
                    <br />
                    <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Вставка" />
                    &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Отмена" />
                </InsertItemTemplate>
                <ItemTemplate>
                    IdExam:
                    <asp:Label ID="IdExamLabel" runat="server" Text='<%# Eval("IdExam") %>' />
                    <br />
                    IdStudent:
                    <asp:Label ID="IdStudentLabel" runat="server" Text='<%# Bind("IdStudent") %>' />
                    <br />
                    IdSubject:
                    <asp:Label ID="IdSubjectLabel" runat="server" Text='<%# Bind("IdSubject") %>' />
                    <br />
                    DateExam:
                    <asp:Label ID="DateExamLabel" runat="server" Text='<%# Bind("DateExam") %>' />
                    <br />
                    ExamValue:
                    <asp:Label ID="ExamValueLabel" runat="server" Text='<%# Bind("ExamValue") %>' />
                    <br />
                    <asp:LinkButton ID="EditButton" runat="server" CausesValidation="False" CommandName="Edit" Text="Правка" />
                    &nbsp;<asp:LinkButton ID="DeleteButton" runat="server" CausesValidation="False" CommandName="Delete" Text="Удалить" />
                    &nbsp;<asp:LinkButton ID="NewButton" runat="server" CausesValidation="False" CommandName="New" Text="Создать" />
                </ItemTemplate>
                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            </asp:FormView>
            <asp:GridView ID="GridView1" runat="server" AllowSorting="True" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="IdExam" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None">
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <Columns>
                    <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                    <asp:BoundField DataField="IdExam" HeaderText="IdExam" InsertVisible="False" ReadOnly="True" SortExpression="IdExam" />
                    <asp:TemplateField HeaderText="IdStudent" SortExpression="IdStudent">
                        <EditItemTemplate>
                            <asp:DropDownList ID="DropDownList5" runat="server" DataSourceID="SqlDataSource2" DataTextField="FIO" DataValueField="IdStudent" SelectedValue='<%# Bind("IdStudent") %>'>
                            </asp:DropDownList>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:DropDownList ID="DropDownList3" runat="server" DataSourceID="SqlDataSource2" DataTextField="FIO" DataValueField="IdStudent" SelectedValue='<%# Bind("IdStudent") %>'>
                            </asp:DropDownList>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="IdSubject" SortExpression="IdSubject">
                        <EditItemTemplate>
                            <asp:DropDownList ID="DropDownList6" runat="server" DataSourceID="SqlDataSource3" DataTextField="Name" DataValueField="IdSubject" SelectedValue='<%# Bind("IdSubject") %>'>
                            </asp:DropDownList>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:DropDownList ID="DropDownList4" runat="server" DataSourceID="SqlDataSource3" DataTextField="Name" DataValueField="IdSubject" SelectedValue='<%# Bind("IdSubject") %>'>
                            </asp:DropDownList>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="DateExam" HeaderText="DateExam" SortExpression="DateExam" />
                    <asp:BoundField DataField="ExamValue" HeaderText="ExamValue" SortExpression="ExamValue" />
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
        </div>
    </form>
</body>
</html>

