using OnlineEnrollmentSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineEnrollmentSystem
{
    public partial class frmlogin : System.Web.UI.Page
    {
        ONLINEENROLLMENTEntities db = new ONLINEENROLLMENTEntities();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submitButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValid)
                {
                    var objCheckUser = db.Users.Where(aa => aa.U_ISACTIVE == "Y" && aa.U_USERNAME == emailTextBox.Text.Trim() && aa.U_PASSWORD == passwordTextBox.Text.Trim()).FirstOrDefault();

                    if (objCheckUser != null)
                    {
                        Session["LoginUser"] = objCheckUser;
                        Session["role"] = objCheckUser.U_ROLE_ID.ToString();

                        if (objCheckUser.U_ROLE_ID == 1)
                        {
                            Response.Redirect("~\\Admin\\CourseList.aspx");
                        }
                        else if (objCheckUser.U_ROLE_ID == 2)
                        {
                            Response.Redirect("~/Faculty/FacultyView.aspx");
                        }
                        else if (objCheckUser.U_ROLE_ID == 3)
                        {
                            Response.Redirect("~/Student/AvailableCoursesList.aspx");
                        }
                    }
                    else
                    { 
                        errorLabel.Text = "Invalid UserName or Password";
                        errorLabel.Visible = true;
                    }
                }
            }
            catch (Exception ee)
            {

            }
        }
    }
}