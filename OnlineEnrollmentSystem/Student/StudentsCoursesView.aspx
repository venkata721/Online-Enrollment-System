<%@ Page Title="" Language="C#" MasterPageFile="~/Student/StudentSiteMaster.Master" AutoEventWireup="true" CodeBehind="StudentsCoursesView.aspx.cs" Inherits="OnlineEnrollmentSystem.Student.StudentsCoursesView" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:GridView ID="gvCourses" runat="server" class="table" AutoGenerateColumns="False" HeaderStyle-BackColor="#3AC0F2" HeaderStyle-ForeColor="White" RowStyle-BackColor="#A1DCF2" AlternatingRowStyle-BackColor="White" RowStyle-ForeColor="#3A3A3A" AllowPaging="true" PageSize="10">
        <Columns>
            <asp:TemplateField HeaderText="CourseId" Visible="false">
                <ItemTemplate>
                    <asp:Label ID="lblCourseId" runat="server" Text='<%#Eval("SEC_COURSE_ID") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Course Name">
                <ItemTemplate>
                    <%#Eval("SEC_COURSE_NAME") %>
                </ItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Fee">
                <ItemTemplate>
                    <%#Eval("SEC_COURSE_PRICE") %>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Date">
                <ItemTemplate>
                    <%#Eval("SEC_ENROLLDATE") %>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
</asp:Content>
