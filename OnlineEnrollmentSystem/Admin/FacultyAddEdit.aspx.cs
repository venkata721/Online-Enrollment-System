using OnlineEnrollmentSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineEnrollmentSystem.Admin
{
    public partial class FacultyAddEdit : System.Web.UI.Page
    {
        ONLINEENROLLMENTEntities db = new ONLINEENROLLMENTEntities();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Label lblMenu = this.Master.FindControl("lblMenuItem") as Label;
                lblMenu.Text = "Faculty Add";
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                FacultyMaster objFacultyCheck = db.FacultyMasters.Where(aa => aa.F_AYN == "Y" && aa.F_USERNAME == txtUserName.Text.Trim()).FirstOrDefault();

                if (objFacultyCheck != null)
                {
                    lblErrMsg.Text = "Username already exits, Please try another name";
                }
                else
                {
                    FacultyMaster objNewFaclty = new FacultyMaster();

                    objNewFaclty.F_USERNAME = txtUserName.Text.Trim();
                    objNewFaclty.F_PWD = txtPwd.Text.Trim();
                    objNewFaclty.F_NAME = txtFacltyName.Text.Trim();
                    objNewFaclty.F_DESCRIPTION = txtDescription.Text.Trim();
                    objNewFaclty.F_EMAIL = txtEmail.Text.Trim();
                    objNewFaclty.F_PHNUM = txtPhNum.Text.Trim();
                    objNewFaclty.F_ADDRESS = txtAddress.Text.Trim();

                    objNewFaclty.F_AYN = "Y";
                    objNewFaclty.CDATE = DateTime.Now.ToString("yyyyMMddHHmmss");
                    objNewFaclty.CUSER = "admin";

                    db.FacultyMasters.Add(objNewFaclty);

                    User objUser = new Models.User();

                    objUser.U_USERNAME = txtUserName.Text.Trim();
                    objUser.U_PASSWORD = txtPwd.Text.Trim();
                    objUser.U_FIRSTNAME = txtFacltyName.Text.Trim();
                    objUser.U_LASTNAME = txtDescription.Text.Trim();
                    objUser.U_EMAIL = txtEmail.Text.Trim();
                    objUser.U_PHNUM = txtPhNum.Text.Trim();
                    objUser.U_ADDRESS = txtAddress.Text.Trim();
                    objUser.U_ROLE_ID = 2;
                    objUser.U_ROLE_NAME = "Faculty";
                     
                    objUser.U_ISACTIVE = "Y";
                    objUser.CDATE = DateTime.Now.ToString("yyyyMMddHHmmss");
                    objUser.CUSER = "admin";

                    db.Users.Add(objUser);

                    db.SaveChanges();
                    Response.Redirect("~/Admin/FacultyList.aspx");
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
                txtFacltyName.Text = "";
                txtDescription.Text = "";
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