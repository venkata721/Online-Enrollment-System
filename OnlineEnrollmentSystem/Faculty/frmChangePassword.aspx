<%@ Page Title="" Language="C#" MasterPageFile="~/Faculty/FacultySiteMaster.Master" AutoEventWireup="true" CodeBehind="frmChangePassword.aspx.cs" Inherits="OnlineEnrollmentSystem.Faculty.frmChangePassword" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <div class="row">
        <div class="col-sm-12 col-md-12 col-lg-12">
            <asp:Label ID="lblLoginUser" runat="server" Visible="false"></asp:Label>
            <asp:Label ID="lblOldPwd" runat="server" Visible="false"></asp:Label>
            <div class="form-group">
                <label>Old Password</label>
                <asp:TextBox ID="txtOldPwd" runat="server" placeholder="Enter Old Password " class="form-control" TextMode="Password" required></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Please Enter Old Password" ControlToValidate="txtOldPwd" ForeColor="Red"></asp:RequiredFieldValidator>
            </div>
            <div class="form-group">
                <label>Current Password</label>
                <asp:TextBox ID="txtPwd" runat="server" placeholder="Enter Current Password " class="form-control" TextMode="Password" required></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Please Enter Current Password" ControlToValidate="txtPwd" ForeColor="Red"></asp:RequiredFieldValidator>
            </div>
            <div class="form-group">
                <label>Confirm Password</label>
                <asp:TextBox ID="txtCnfmPwd" runat="server" placeholder="Enter Confirm Password " class="form-control" TextMode="Password" required></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Please Enter Confirm Password" ControlToValidate="txtCnfmPwd" ForeColor="Red"></asp:RequiredFieldValidator>
                <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Both passwords are not matched" ControlToCompare="txtPwd" ControlToValidate="txtCnfmPwd" ForeColor="Red"></asp:CompareValidator>
            </div>
            <asp:Button ID="submitButton" runat="server" class="btn btn-lg btn-info" Text="Submit" OnClick="submitButton_Click" />
                    &nbsp;&nbsp;&nbsp;<asp:Button ID="clearButton" runat="server" class="btn btn-lg btn-info" Text="Clear" OnClick="clearButton_Click" />
             
            <br />
                    <asp:Label ID="lblResult" runat="server" Text=""></asp:Label>       
        </div>
    </div>
</asp:Content>
