<%@ Page Title="" Language="C#" MasterPageFile="~/Faculty/FacultySiteMaster.Master" AutoEventWireup="true" CodeBehind="FacultyView.aspx.cs" Inherits="OnlineEnrollmentSystem.Faculty.FacultyView" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table>
        <tr>
            <td></td>
        </tr>
        <tr>
            <td>
                <asp:GridView ID="gvFacultyCourses" class="table" runat="server" AutoGenerateColumns="False" HeaderStyle-BackColor="#3AC0F2" HeaderStyle-ForeColor="White" RowStyle-BackColor="#A1DCF2" AlternatingRowStyle-BackColor="White" RowStyle-ForeColor="#3A3A3A" AllowPaging="true" PageSize="10">
                    <Columns>
                        <asp:TemplateField HeaderText="CF_ID" Visible="false">
                            <ItemTemplate>
                                <asp:Label ID="lblCF_ID" runat="server" Text='<%#Eval("CF_ID") %>' ></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Faculty Name">
                            <ItemTemplate>
                                <%#Eval("CF_FACULTY_NAME") %>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Course Name">
                            <ItemTemplate>
                                <%#Eval("CF_COURSE_NAME") %>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="CF_FACULTY_ID" Visible="false">
                            <ItemTemplate>
                                <%#Eval("CF_FACULTY_ID") %>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="CF_COURSE_ID" Visible="false">
                            <ItemTemplate>
                                <%#Eval("CF_COURSE_ID") %>
                            </ItemTemplate>
                        </asp:TemplateField>                                          
                    </Columns>
                </asp:GridView>
            </td>
        </tr>
    </table>
</asp:Content>
