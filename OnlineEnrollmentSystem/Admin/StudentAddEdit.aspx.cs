using OnlineEnrollmentSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineEnrollmentSystem.Admin
{
    public partial class StudentAddEdit : System.Web.UI.Page
    {
        ONLINEENROLLMENTEntities db = new ONLINEENROLLMENTEntities();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Label lblMenu = this.Master.FindControl("lblMenuItem") as Label;
                lblMenu.Text = "Student Add";
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                StudentMaster objStudentCheck = db.StudentMasters.Where(aa => aa.S_AYN == "Y" && aa.S_USERNAME == txtUserName.Text.Trim()).FirstOrDefault();

                if (objStudentCheck != null)
                {
                    lblErrMsg.Text = "User name already exits, Please try another name";
                }
                else
                {
                    StudentMaster objNewStudent = new StudentMaster();

                    objNewStudent.S_USERNAME = txtUserName.Text.Trim();
                    objNewStudent.S_PWD = txtPwd.Text.Trim();
                    objNewStudent.S_NAME = txtStudentName.Text.Trim();
                    objNewStudent.S_DESCRIPTION = txtDescription.Text.Trim();
                    objNewStudent.S_QUALIFICATION = txtQualification.Text.Trim();
                    objNewStudent.S_EMAIL = txtEmail.Text.Trim();
                    objNewStudent.S_PHNUM = txtPhNum.Text.Trim();
                    objNewStudent.S_ADDRESS = txtAddress.Text.Trim();

                    objNewStudent.S_AYN = "Y";
                    objNewStudent.CDATE = DateTime.Now.ToString("yyyyMMddHHmmss");
                    objNewStudent.CUSER = "admin";

                    db.StudentMasters.Add(objNewStudent);

                    User objUser = new Models.User();

                    objUser.U_USERNAME = txtUserName.Text.Trim();
                    objUser.U_PASSWORD = txtPwd.Text.Trim();
                    objUser.U_FIRSTNAME = txtStudentName.Text.Trim();
                    objUser.U_LASTNAME = txtDescription.Text.Trim();
                    objUser.U_EMAIL = txtEmail.Text.Trim();
                    objUser.U_PHNUM = txtPhNum.Text.Trim();
                    objUser.U_ADDRESS = txtAddress.Text.Trim();
                    objUser.U_ROLE_ID = 3;
                    objUser.U_ROLE_NAME = "Student";

                    objUser.U_ISACTIVE = "Y";
                    objUser.CDATE = DateTime.Now.ToString("yyyyMMddHHmmss");
                    objUser.CUSER = "admin";

                    db.Users.Add(objUser);

                    db.SaveChanges();

                    Response.Redirect("~/Admin/StudentsList.aspx");
                }
            }
            catch (Exception ee)
            {

            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                txtUserName.Text = "";
                txtPwd.Text = "";
                txtStudentName.Text = "";
                txtDescription.Text = "";
                txtQualification.Text = "";
                txtEmail.Text = "";
                txtPhNum.Text = "";
                txtAddress.Text = "";
                lblErrMsg.Text = "";
            }
            catch (Exception ee)
            {

            }
        }
    }
}