<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="CourseAddEdit.aspx.cs" Inherits="OnlineEnrollmentSystem.Admin.CourseAddEdit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
  
  

    <script type="text/javascript">
        $(function () {
            $("[id$=txtStartDate]").datepicker({
                format: 'yyyy-MMM-dd',
                showOn: 'button',
                buttonImageOnly: true,
                buttonImage: 'http://jqueryui.com/resources/demos/datepicker/images/calendar.gif'
            });

            $("[id$=txtEndDate]").datepicker({
                format: 'yyyy-MMM-dd',
                showOn: 'button',
                buttonImageOnly: true,
                buttonImage: 'http://jqueryui.com/resources/demos/datepicker/images/calendar.gif'
            });
        });
    </script>

    <div class="row">
        <div class="col-md-4">
            <label>Course Name</label>
        </div>
        <div class="col-md-8">
            <asp:TextBox ID="txtCourseName" runat="server" class="form-control"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Please Enter CourseName" ControlToValidate="txtCourseName" ForeColor="Red"></asp:RequiredFieldValidator>
        </div>
    </div>
    <div class="row">
        <div class="col-md-4">
            <label>Duration</label>
        </div>
        <div class="col-md-8">
            <asp:TextBox ID="txtDuration" runat="server" class="form-control"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Please Enter Duration" ControlToValidate="txtDuration" ForeColor="Red"></asp:RequiredFieldValidator>
        </div>
    </div>
    <div class="row">
        <div class="col-md-4">
            <label>Fee</label>
        </div>
        <div class="col-md-8">
            <asp:TextBox ID="txtFee" runat="server" class="form-control"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Please Enter Fee" ControlToValidate="txtFee" ForeColor="Red"></asp:RequiredFieldValidator>
        </div>
        
    </div>
    <div class="row">
        <div class="col-md-4">
            <label>Start Date</label>
        </div>
        <div class="col-md-8">
            <asp:TextBox ID="txtStartDate" runat="server" class="form-control"></asp:TextBox>
        </div>
    </div>
    <div class="row">
        <div class="col-md-4">
            <label>End Date</label>
        </div>
        <div class="col-md-8">
            <asp:TextBox ID="txtEndDate" runat="server" class="form-control"></asp:TextBox>
        </div>
        <div class="row">
            <div class="col-md-6">
            </div>
            <div class="col-md-6">
                <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" class="btn btn-lg btn-info" />
                &nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" class="btn btn-lg btn-warning" />
            </div>
        </div>
        <br />
        <asp:Label ID="lblErrMsg" runat="server" ForeColor="Red"></asp:Label>
    </div>

    <table>
        <tr>
            <td colspan="3">
                <asp:TextBox ID="txtCourseId" runat="server" class="form-control" Visible="false"></asp:TextBox>
            </td>
        </tr>
    </table>
</asp:Content>
