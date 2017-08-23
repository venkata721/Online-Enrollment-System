<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmcontact.aspx.cs" Inherits="OnlineEnrollmentSystem.frmcontact" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Contact Us</title>
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
                <a class="navbar-brand" href="home.aspx"><img src="images/ucmo.jpg" height="30px" alt="Flight Tracking System" /></a>
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
                <ol class="breadcrumb">
                    <li><a href="home.aspx">Home</a>
                    </li>
                    <li class="active">Contact</li>
                </ol>
            </div>
        </div>
        <div class="row">
            <div class="col-md-8">
                <iframe width="100%" height="400px" frameborder="0" scrolling="no" marginheight="0" marginwidth="0" src="http://maps.google.com/maps?hl=en&amp;ie=UTF8&amp;ll=37.0625,-95.677068&amp;spn=56.506174,79.013672&amp;t=m&amp;z=4&amp;output=embed"></iframe>
            </div>
            <div class="col-md-4">
                <h3>Contact Details</h3>
                <p>
                    300 Zoll Street<br>Warrensburg, MO 64093<br>
                </p>
                <p><i class="fa fa-phone"></i> 
                    <abbr title="Phone">P</abbr>: (913) 271-7532</p>
                <p><i class="fa fa-envelope-o"></i> 
                    <abbr title="Email">E</abbr>: <a href="mailto:mxa63490@ucmo.edu">info@consultaion.com</a>
                </p>
                <p><i class="fa fa-clock-o"></i> 
                    <abbr title="Hours">H</abbr>: Monday - Friday: 9:00 AM to 5:00 PM</p>
                <ul class="list-unstyled list-inline list-social-icons">
                    <li>
                        <a href="http://facebook.com/" target="_blank"><i class="fa fa-facebook-square fa-2x"></i></a>
                    </li>
                    <li>
                        <a href="http://linkedin.com/" target="_blank"><i class="fa fa-linkedin-square fa-2x"></i></a>
                    </li>
                    <li>
                        <a href="twitter.com" target="_blank"><i class="fa fa-twitter-square fa-2x"></i></a>
                    </li>
                    
                </ul>
            </div>
        </div>
        <div class="row">
            <div class="col-md-8">
                <h3>Send us a Message</h3>
                <form id="form1" runat="server">
                    <div class="control-group form-group">
                        <div class="controls">
                            <label>Full Name:</label>
                            <asp:TextBox ID="nameTextBox" runat="server" class="form-control" required data-validation-required-message="Please enter your name."></asp:TextBox>
                            <p class="help-block"></p>
                        </div>
                    </div>
                    <div class="control-group form-group">
                        <div class="controls">
                            <label>Phone Number:</label>
                            <asp:TextBox ID="phoneTextBox" class="form-control" runat="server" required data-validation-required-message="Please enter your phone number."></asp:TextBox>
                        </div>
                    </div>
                    <div class="control-group form-group">
                        <div class="controls">
                            <label>Email Address:</label>
                            <asp:TextBox ID="emailTextBox" runat="server" class="form-control" required data-validation-required-message="Please enter your email address." TextMode="Email"></asp:TextBox>
                        </div>
                    </div>
                    <div class="control-group form-group">
                        <div class="controls">
                            <label>Message:</label>
                                <asp:TextBox ID="messageTextBox" runat="server" class="form-control" required data-validation-required-message="Please enter your message" TextMode="MultiLine"></asp:TextBox>
                        </div>
                    </div>
                    
                    <asp:Button ID="submitButton" runat="server" Text="Send Message" class="btn btn-lg btn-info" OnClick="submitButton_Click"/>
                    <asp:Label ID="resultLabel" runat="server" Text=""></asp:Label>
                </form>
            </div>
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
    <script src="js/jqBootstrapValidation.js"></script>
    <script src="js/contact_me.js"></script>

</body>

</html>