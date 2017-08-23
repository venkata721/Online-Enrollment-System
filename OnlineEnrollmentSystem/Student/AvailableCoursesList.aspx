<%@ Page Title="" Language="C#" MasterPageFile="~/Student/StudentSiteMaster.Master" AutoEventWireup="true" CodeBehind="AvailableCoursesList.aspx.cs" Inherits="OnlineEnrollmentSystem.Student.AvailableCoursesList" %>

<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js"></script>
    <script type="text/javascript">
        $("[id*=chkHeader]").live("click", function () {
            var chkHeader = $(this);
            var grid = $(this).closest("table"); 
            $("input[type=checkbox]", grid).each(function () {
                if (chkHeader.is(":checked")) {                    
                    $(this).attr("checked", "checked");
                    $("td", $(this).closest("tr")).addClass("selected");
                } else {
                    $(this).removeAttr("checked");
                    $("td", $(this).closest("tr")).removeClass("selected");
                }
            });
        });
        $("[id*=chkRow]").live("click", function () {
            var grid = $(this).closest("table");
            var chkHeader = $("[id*=chkHeader]", grid);
            if (!$(this).is(":checked")) {
                $("td", $(this).closest("tr")).removeClass("selected");
                chkHeader.removeAttr("checked");
            } else {
                $("td", $(this).closest("tr")).addClass("selected");
                if ($("[id*=chkRow]", grid).length == $("[id*=chkRow]:checked", grid).length) {
                    chkHeader.attr("checked", "checked");
                }
            }
        });
</script>
    <table>
        <tr>
            <td>
                Total Fee
            </td>
            <td>
                <asp:Label ID="lblFee" runat="server"></asp:Label>
            </td>
            <td>
                <asp:Button ID="btnEnroll" runat="server" Text="Enroll" OnClick="btnEnroll_Click"/>
            </td>
        </tr>
        <tr>
            <td colspan="3">
                <asp:GridView ID="gvCourses" runat="server" class="table" AutoGenerateColumns="False" HeaderStyle-BackColor="#3AC0F2" HeaderStyle-ForeColor="White" RowStyle-BackColor="#A1DCF2" AlternatingRowStyle-BackColor="White" RowStyle-ForeColor="#3A3A3A" AllowPaging="true" PageSize="10">
                    <Columns>
                        <asp:TemplateField HeaderText="CourseId" Visible="false">
                            <ItemTemplate>
                                <asp:Label ID="lblCourseId" runat="server" Text='<%#Eval("C_ID") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Course Name">
                            <ItemTemplate>
                                <%#Eval("C_NAME") %>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Description">
                            <ItemTemplate>
                                <%#Eval("C_DESCRIPTION") %>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Price">
                            <ItemTemplate>
                                <asp:Label ID="lblCourseFee" runat="server" Text='<%#Eval("C_FEE") %>'></asp:Label>                                
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Duration">
                            <ItemTemplate>
                                <%#Eval("C_DURATION") %>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField>
                            <HeaderTemplate>
                                <asp:CheckBox ID="chkHeader" runat="server" AutoPostBack="true"/>
                            </HeaderTemplate>
                            <ItemTemplate>
                                <asp:CheckBox ID="chkRow" runat="server" AutoPostBack="true"/>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </td>
        </tr>
    </table>
    
</asp:Content>
