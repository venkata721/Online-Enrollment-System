<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="FacultyAddEdit.aspx.cs" Inherits="OnlineEnrollmentSystem.Admin.FacultyAddEdit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-md-4">
            <label>User Name</label>     
        </div>
        <div class="col-md-8">
            <asp:TextBox ID="txtUserName" runat="server" class="form-control"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Please Enter UserName" ControlToValidate="txtUserName" ForeColor="Red"></asp:RequiredFieldValidator>
        </div>
    </div>
    <div class="row">
        <div class="col-md-4">
            <label>Password</label> 
        </div>
        <div class="col-md-8">
            <asp:TextBox ID="txtPwd" TextMode="Password" runat="server" class="form-control"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Please Enter Password" ControlToValidate="txtPwd" ForeColor="Red"></asp:RequiredFieldValidator>
        </div>
    </div>
    <div class="row">
        <div class="col-md-4">
            <label>Confirm Password</label>  
        </div>
        <div class="col-md-8">
            <asp:TextBox ID="txtCnfPwd" TextMode="Password" runat="server" class="form-control"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Please Enter Confirm Password" ControlToValidate="txtCnfPwd" ForeColor="Red"></asp:RequiredFieldValidator>
                <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Both passwords are not matched" ControlToValidate="txtCnfPwd" ControlToCompare="txtPwd" ForeColor="Red"></asp:CompareValidator>
        </div>
    </div>
    <div class="row">
        <div class="col-md-4">
            <label>Faculty Name</label>   
        </div>
        <div class="col-md-8">
            <asp:TextBox ID="txtFacltyName" runat="server" class="form-control"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Please Enter Faculty Name" ControlToValidate="txtFacltyName" ForeColor="Red"></asp:RequiredFieldValidator>
        </div>
    </div>
    <div class="row">
        <div class="col-md-4">
            <label>Description</label>  
        </div>
        <div class="col-md-8">
            <asp:TextBox ID="txtDescription" runat="server" class="form-control"></asp:TextBox>
        </div>
    </div>
    <div class="row">
        <div class="col-md-4">
            <label>Email</label>   
        </div>
        <div class="col-md-8">
            <asp:TextBox ID="txtEmail" runat="server" class="form-control"></asp:TextBox>
        </div>
    </div>
    <div class="row">
        <div class="col-md-4">
            <label>Phone Number</label>    
        </div>
        <div class="col-md-8">
            <asp:TextBox ID="txtPhNum" runat="server" class="form-control"></asp:TextBox>
        </div>
    </div>
    <div class="row">
        <div class="col-md-4">
            <label>Address</label>  
        </div>
        <div class="col-md-8">
            <asp:TextBox ID="txtAddress" runat="server" class="form-control"></asp:TextBox>
        </div>
    </div>
    <div class="row">
        <div class="col-md-6">

        </div>
        <div class="col-md-6">
            <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" class="btn btn-info"/>   
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" class="btn btn-warning" />
        </div>
    </div>
    <div class="row">
        <div class="col-md-2">

        </div>
        <div class="col-md-10">
            <asp:Label ID="lblErrMsg" runat="server" ForeColor="Red"></asp:Label>
        </div>
    </div>

    
</asp:Content>
