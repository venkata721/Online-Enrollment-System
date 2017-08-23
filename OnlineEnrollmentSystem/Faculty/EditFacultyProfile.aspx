<%@ Page Title="" Language="C#" MasterPageFile="~/Faculty/FacultySiteMaster.Master" AutoEventWireup="true" CodeBehind="EditFacultyProfile.aspx.cs" Inherits="OnlineEnrollmentSystem.Faculty.EditFacultyProfile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-sm-12 col-md-12 col-lg-12">
            <asp:Label ID="lblLoginUser" runat="server" Visible="false"></asp:Label>

            <div class="form-group">
                <label>FirstName</label>
                <asp:TextBox ID="txtFirstName" runat="server" placeholder="Enter FirstName" class="form-control" required></asp:TextBox>
            </div>
            <div class="form-group">
                <label>LastName</label>
                <asp:TextBox ID="txtLastName" runat="server" placeholder="Enter LastName" class="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <label>Email</label>
                <asp:TextBox ID="txtEmail" runat="server" placeholder="Enter Email" TextMode="Email" class="form-control" required></asp:TextBox>
            </div>
            <div class="form-group">
                <label>Phone Number</label>
                <asp:TextBox ID="txtPhNum" runat="server" placeholder="Enter Phone Number" class="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <label>Address</label>
                <asp:TextBox ID="txtAddress" runat="server" placeholder="Enter Address" class="form-control"></asp:TextBox>
            </div>

            <asp:Button ID="submitButton" runat="server" class="btn btn-lg btn-info" Text="Submit" OnClick="submitButton_Click" />
            &nbsp;&nbsp;&nbsp;<asp:Button ID="clearButton" runat="server" class="btn btn-lg btn-info" Text="Clear" OnClick="clearButton_Click" />

            <br />
            <asp:Label ID="lblResult" runat="server" Text=""></asp:Label>
        </div>
    </div>
</asp:Content>
