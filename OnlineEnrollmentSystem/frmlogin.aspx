<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmlogin.aspx.cs" Inherits="OnlineEnrollmentSystem.frmlogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
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
                    <li class="active">Login</li>
                </ol>
            </div>
        </div>
        <div class="row">
            <div class="col-md-8">
                <div id="carousel-example-generic" class="carousel slide" data-ride="carousel">
                    <ol class="carousel-indicators">
                        <li data-target="#carousel-example-generic" data-slide-to="0" class="active"></li>
                        <li data-target="#carousel-example-generic" data-slide-to="1"></li>
                        <li data-target="#carousel-example-generic" data-slide-to="2"></li>
                    </ol>
                    <div class="carousel-inner">
                        <div class="item active">
                            <img class="img-responsive" src="images/homepage.jpg" style="width: 700px; height: 600px">
                        </div>
                        <div class="item">
                            <img class="img-responsive" src="images/studentloginbg.jpg" style="width: 700px; height: 600px">
                        </div>
                        <div class="item">
                            <img class="img-responsive" src="images/bgimg.jpg" style="width: 700px; height: 600px">
                        </div>
                    </div>
                    <a class="left carousel-control" href="#carousel-example-generic" data-slide="prev">
                        <span class="glyphicon glyphicon-chevron-left"></span>
                    </a>
                    <a class="right carousel-control" href="#carousel-example-generic" data-slide="next">
                        <span class="glyphicon glyphicon-chevron-right"></span>
                    </a>
                </div>
            </div>
            <div class="col-md-4">
             <form id="form1" runat="server">
					<p><h2>Log In</h2></p>
                        <div class="form-group">
						<label>User Name</label>
                            <asp:TextBox ID="emailTextBox" runat="server" placeholder="Enter UserName" class="form-control"></asp:TextBox>
					    </div>	
                        <div class="form-group">
						<label>Password:</label>
                            <asp:TextBox ID="passwordTextBox" runat="server" placeholder="Enter Password " class="form-control" TextMode="Password"></asp:TextBox>
					    </div>
					    <asp:Button ID="submitButton" runat="server" class="btn btn-lg btn-info" Text="Submit" OnClick="submitButton_Click" />
					    <br />
                        <asp:Label ID="errorLabel" runat="server" Text=""></asp:Label>
					    <div class="form-group">
						    <label>New Faculty <a href="frmfacultyregister.aspx">Click Here</a> to register</label>
					    </div>
                        <div class="form-group">
						    <label>New Student <a href="frmstudentregister.aspx">Click Here</a> to register</label>
					    </div>	
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

</body>

</html>
