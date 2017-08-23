<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmservices.aspx.cs" Inherits="OnlineEnrollmentSystem.frmservices" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <title>Services</title>
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
                <a class="navbar-brand" href="home.aspx"><img src="images/ucmo.jpg" height="30px" /></a>
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
                    <li class="active">Services</li>
                </ol>
            </div>
        </div>
        <div class="row">
            <div class="col-lg-12">
                <img class="img-responsive" src="images/services.png" alt="">
            </div>
        </div>
        <div class="row">
            <div class="col-lg-12">
                <h2 class="page-header">Service Tabs</h2>
            </div>
            <div class="col-lg-12">
                <ul id="myTab" class="nav nav-tabs nav-justified">
                    <li class="active"><a href="#service-one" data-toggle="tab"><i class="fa fa-tree"></i> Admin</a>
                    </li>
                    <li class=""><a href="#service-two" data-toggle="tab"><i class="fa fa-car"></i> User</a>
                    </li>
                    <li class=""><a href="#service-three" data-toggle="tab"><i class="fa fa-support"></i> Employee</a>
                    </li>
                </ul>
                <div id="myTabContent" class="tab-content">
                    <div class="tab-pane fade active in" id="service-one">
                        <h4>Admin</h4>
                        <ul>
                            <li>View Branches/Departments/Employees/Notices</li>
                            <li>Adding new Branch</li>
                            <li>Adding new Department</li>
                            <li>Adding new Employee</li>
                            <li>Post Notices</li>
                        </ul>
                    </div>
                    <div class="tab-pane fade" id="service-two">
                        <h4>Faculty</h4>
                         <ul>
                            <li>View Course List</li>
                            <li>Edit Profile</li> 
                        </ul>
                    </div>
                    <div class="tab-pane fade" id="service-three">
                        <h4>Student</h4>
                        <ul>
                            <li>View Course List</li>
                            <li>Edit Profile</li>                             
                        </ul>
                    </div>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-lg-12">
                <h2 class="page-header">Our Services</h2>
            <p>Consultation site for employee and manager plays a typical role and acts like a link between Units of an Organization usually a corporate company. The main objective of “cnsultation site for employee and manager” is to introduce computerized system in a widely spread organization which can be used as a resource for private network, in order to fulfill the basic needs of an Organization like Information sharing, Communication, Document Viewing as well as sharing. This also helps to provide an easy and fast interface for the employees of an Organization to perform their tasks quickly and efficiently. By providing this entirely private network the information regarding the Organization can be fetched from any corner of the world in a highly secured manner.</p>
            <p>After analyzing the requirements of the task to be performed, the next step is to analyze the problem and understand its context. The first activity in the phase is studying the existing system and other is to understand the requirements and domain of the new system. Both the activities are equally important, but the first activity serves as a basis of giving the functional specifications and then successful design of the proposed system. Understanding the properties and requirements of a new system is more difficult and requires creative thinking and understanding of existing running system is also difficult, improper understanding of present system can lead diversion from solution.</p>
            
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
