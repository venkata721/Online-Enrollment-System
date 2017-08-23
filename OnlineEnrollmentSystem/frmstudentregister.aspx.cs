using OnlineEnrollmentSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineEnrollmentSystem
{
    public partial class frmstudentregister : System.Web.UI.Page
    {
        ONLINEENROLLMENTEntities db = new ONLINEENROLLMENTEntities();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submitButton_Click(object sender, EventArgs e)
        {
            try
            {
                var objCheckUser = db.Users.Where(aa => aa.U_ISACTIVE == "Y" && aa.U_USERNAME == txtUserName.Text.Trim()).FirstOrDefault();

                if (objCheckUser == null)
                {
                    User objUser = new User();

                    objUser.U_USERNAME = txtUserName.Text.Trim();
                    objUser.U_PASSWORD = txtPwd.Text.Trim();
                    objUser.U_FIRSTNAME = txtFirstName.Text.Trim();
                    objUser.U_LASTNAME = txtLastName.Text.Trim();
                    objUser.U_EMAIL = txtEmail.Text.Trim();
                    objUser.U_PHNUM = txtPhNum.Text.Trim();
                    objUser.U_ADDRESS = txtAddress.Text.Trim();
                    objUser.U_ISACTIVE = "Y";
                    objUser.CUSER = txtUserName.Text.Trim();
                    objUser.CDATE = DateTime.Now.ToString("yyyyMMddHHmmss");
                    objUser.U_ROLE_ID = 3;
                    objUser.U_ROLE_NAME = "Student";

                    db.Users.Add(objUser);

                    StudentMaster objNewStudent = new StudentMaster();

                    objNewStudent.S_USERNAME = txtUserName.Text.Trim();
                    objNewStudent.S_PWD = txtPwd.Text.Trim();
                    objNewStudent.S_NAME = txtFirstName.Text.Trim();
                    objNewStudent.S_DESCRIPTION = txtLastName.Text.Trim(); 
                    objNewStudent.S_EMAIL = txtEmail.Text.Trim();
                    objNewStudent.S_PHNUM = txtPhNum.Text.Trim();
                    objNewStudent.S_ADDRESS = txtAddress.Text.Trim();

                    objNewStudent.S_AYN = "Y";
                    objNewStudent.CDATE = DateTime.Now.ToString("yyyyMMddHHmmss");
                    objNewStudent.CUSER = txtUserName.Text.Trim();

                    db.StudentMasters.Add(objNewStudent);
                    db.SaveChanges();

                    Session["role"] = "3";
                    Response.Redirect("~/frmlogin.aspx");
                }
                else
                {
                    resultLabel.Text = "Username already exits....! Please try some other username";
                    txtUserName.Focus();
                }
            }
            catch (Exception ee)
            {

            }
        }

        protected void clearButton_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ee)
            {

            }
        }
    }
}