<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmfacultyregister.aspx.cs" Inherits="OnlineEnrollmentSystem.frmfacultyregister" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8">
    <title>Registration</title>
    <link href="css/bootstrap.css" rel="stylesheet">
    <link href="css/styles.css" rel="stylesheet">
    <link href="font-awesome/css/font-awesome.min.css" rel="stylesheet" type="text/css">
</head>
<body>
    <nav class="navbar navbar-inverse navbar-fixed-top" role="navigation">
        <div class="container">
            <div class="navbar-header">
                <button type="button" class="navbar-toggle" data-toggle="collapse" data-target="#bs-example-navbar-collapse-1">
                    <span class="sr-only">Toggle navigation</span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>
                <a class="navbar-brand" href="home.aspx">
                    <img src="images/ucmo.jpg" height="30px" alt="Flight Tracking System" /></a>
            </div>
            <div class="collapse navbar-collapse" id="bs-example-navbar-collapse-1">
                <ul class="nav navbar-nav navbar-right">
                    <li>
                        <a href="frmhome.aspx">Home</a>
                    </li>
                    <li>
                        <a href="frmservices.aspx">Services</a>
                    </li>
                    <li>
                        <a href="frmlogin.aspx">Login</a>
                    </li>
                    <li>
                        <a href="frmcontact.aspx">Contact</a>
                    </li>
                </ul>
            </div>
        </div>
    </nav>
    <div class="container">
        <div class="row">
            <div class="col-lg-12">
                <%--<h1 class="page-header">New User Registration
                </h1>--%>
                <ol class="breadcrumb">
                    <li><a href="home.aspx">Home</a>
                    </li>
                    <li class="active">New Faculty Registration</li>
                </ol>
            </div>
        </div>
        <div class="row">
            <form id="form1" runat="server">
                <div class="col-sm-12">
                    <div class="form-group">
                        <label>UserName</label>
                        <asp:TextBox ID="txtUserName" runat="server" placeholder="Enter UserName" class="form-control" required></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Please enter UserName" ControlToValidate="txtUserName" ForeColor="Red"></asp:RequiredFieldValidator>
                    </div>
                    <div class="form-group">
                        <label>Password</label>
                        <asp:TextBox ID="txtPwd" runat="server" placeholder="Enter Password " class="form-control" TextMode="Password" required></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Please enter Password" ControlToValidate="txtPwd" ForeColor="Red"></asp:RequiredFieldValidator>
                    </div>
                    <div class="form-group">
                        <label>Confirm Password</label>
                        <asp:TextBox ID="txtCnfmPwd" runat="server" placeholder="Enter Confirm Password " class="form-control" TextMode="Password" required></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Please enter Confirm Password" ControlToValidate="txtCnfmPwd" ForeColor="Red"></asp:RequiredFieldValidator>
                        <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Both passwords are not matched" ControlToCompare="txtPwd" ControlToValidate="txtCnfmPwd"  ForeColor="Red"></asp:CompareValidator>
                    </div>
                    <div class="form-group">
                        <label>FirstName</label>
                        <asp:TextBox ID="txtFirstName" runat="server" placeholder="Enter FirstName" class="form-control" required></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label>LastName</label>
                        <asp:TextBox ID="txtLastName" runat="server" placeholder="Enter LastName" class="form-control" ></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label>Email</label>
                        <asp:TextBox ID="txtEmail" runat="server" placeholder="Enter Email" TextMode="Email" class="form-control" required></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label>Phone Number</label>
                        <asp:TextBox ID="txtPhNum" runat="server" placeholder="Enter Phone Number" class="form-control" ></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label>Address</label>
                        <asp:TextBox ID="txtAddress" runat="server" placeholder="Enter Address" class="form-control" ></asp:TextBox>
                    </div>

                    <asp:Button ID="submitButton" runat="server" class="btn btn-lg btn-info" Text="Submit" OnClick="submitButton_Click" />
                    &nbsp;&nbsp;&nbsp;<asp:Button ID="clearButton" runat="server" class="btn btn-lg btn-info" Text="Clear" OnClick="clearButton_Click" />
                    <br />
                    <asp:Label ID="resultLabel" runat="server" Text=""></asp:Label>
                </div>
            </form>
        </div>
        
    </div>
    <div >
        <footer>
            <div class="row" style="background-color: black;color: white;text-align: right;">
                <div class="col-lg-12">
                    <p>Copyright &copy; 2017 Online Enrollment System</p>
                </div>
            </div>
        </footer>
    </div>
    <script src="js/jquery.js"></script>
    <script src="js/bootstrap.min.js"></script>

</body>

</html>
