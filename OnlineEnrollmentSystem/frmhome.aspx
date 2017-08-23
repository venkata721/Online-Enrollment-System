<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmhome.aspx.cs" Inherits="OnlineEnrollmentSystem.frmhome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <title>Home</title>
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
                <a class="navbar-brand" href="home.aspx"><img src="images/ucmo.jpg" height="30px" alt="Flight Tracking System"/></a>
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
                <h1 class="page-header">
                    Welcome to Online Enrollment site for Faculty and Student
                </h1>
            </div>
            <div class="col-md-4">
                <div class="panel panel-default">
                    <div class="panel-heading">
                        <h4><i class="fa fa-fw fa-check"></i> Admin</h4>
                    </div>
                    <div class="panel-body">
                        <p>The exercises that are done in this module are identified with the support of master records, for example, Branch expert, Department expert and Employee expert for the whole organization.</p>
                        
                    </div>
                </div>
            </div>
            <div class="col-md-4">
                <div class="panel panel-default">
                    <div class="panel-heading">
                        <h4><i class="fa fa-fw fa-check"></i> Student</h4>
                    </div>
                    <div class="panel-body">
                        <p>The exercises that are completed in this module are identified with report seeing, record sending to representatives, and archive upgrading, report deleting and meetings. He gets reports made by representatives.</p>
                    </div>
                </div>
            </div>
            <div class="col-md-4">
                <div class="panel panel-default">
                    <div class="panel-heading">
                        <h4><i class="fa fa-fw fa-check"></i> Faculty</h4>
                    </div>
                    <div class="panel-body">
                        <p>The activities that are carried out in this module are related to document viewing, document creation, document updating, document deleting and conference. He can view his profile. He can create documents and submits it to manager for any error rectification. </p>
                        
                    </div>
                </div>
            </div>
        </div>
        
        <div class="row">
            <div class="col-lg-12">
                <h2 class="page-header">Our Features</h2>
            </div>
            <div class="col-md-6">
                <p>It includes:</p>
                <ul>
                    <li>Admin can manage all the activities</li>
                    <li>Faculty activities that are carried out in this module are related to document viewing, document forwarding to employees, and document updating, document deleting and conference. </li>
                    <li>Student receives documents created by employees. Manager changes the document if there are any errors in the documents and forwards to other employees. </li>
                    
                </ul>
                <p>The primary target of “Online Enrollment System site” is to present modernized framework in a generally spread association which can be utilized as an asset for private system, with a specific end goal to satisfy the essential needs of an Organization like Information sharing, Communication, Document Viewing. </p>
            </div>
            <div class="col-md-6">
                <img class="img-responsive" src="images/home1.png" alt="">
            </div>
        </div>
        <hr>
        <div class="well">
            <div class="row">
                <div class="col-md-8">
                    <p>New Faculty/Student can register here</p>
                </div>
                <div class="col-md-4">
                    <a class="btn btn-lg btn-default btn-block" href="frmlogin.aspx">Register</a>
                </div>
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
    <script>
        $('.carousel').carousel({
            interval: 5000 //changes the speed
        })
    </script>
</body>
</html>