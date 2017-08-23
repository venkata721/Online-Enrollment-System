using OnlineEnrollmentSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineEnrollmentSystem.Student
{
    public partial class frmEditStudentProfile : System.Web.UI.Page
    {
        ONLINEENROLLMENTEntities db = new ONLINEENROLLMENTEntities();
        String strLoginUser = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Label lblMenu = this.Master.FindControl("lblMenuItem") as Label;
                lblMenu.Text = "Edit Profile";

                var LoginUser = (User)Session["LoginUser"];
                strLoginUser = LoginUser.U_USERNAME;
                LoadPioltDetails(LoginUser);
            }
        }

        private void LoadPioltDetails(User objViewUser)
        {
            try
            {
                txtFirstName.Text = objViewUser.U_FIRSTNAME;
                txtLastName.Text = objViewUser.U_LASTNAME;
                txtEmail.Text = objViewUser.U_EMAIL;
                txtPhNum.Text = objViewUser.U_PHNUM;
                txtAddress.Text = objViewUser.U_ADDRESS;

                lblLoginUser.Text = objViewUser.U_ID.ToString();
            }
            catch (Exception ee)
            {

            }
        }

        protected void submitButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblLoginUser.Text.Trim().Length > 0)
                {
                    int iUserid = Convert.ToInt32(lblLoginUser.Text.Trim());
                    User objUpdateUser = db.Users.Where(aa => aa.U_ID == iUserid && aa.U_ISACTIVE == "Y").SingleOrDefault();

                    if (objUpdateUser != null)
                    {
                        objUpdateUser.U_FIRSTNAME = txtFirstName.Text;
                        objUpdateUser.U_LASTNAME = txtLastName.Text;
                        objUpdateUser.U_EMAIL = txtEmail.Text;
                        objUpdateUser.U_PHNUM = txtPhNum.Text;
                        objUpdateUser.U_ADDRESS = txtAddress.Text;

                        objUpdateUser.MUSER = strLoginUser;
                        objUpdateUser.MDATE = DateTime.Now.ToString("yyyyMMddHHmmss");

                        StudentMaster objUpdateStudent = db.StudentMasters.Where(aa => aa.S_USERNAME == objUpdateUser.U_USERNAME && aa.S_AYN == "Y").SingleOrDefault();

                        objUpdateStudent.S_NAME = txtFirstName.Text.Trim();
                        objUpdateStudent.S_DESCRIPTION = txtLastName.Text.Trim();                        
                        objUpdateStudent.S_EMAIL = txtEmail.Text.Trim();
                        objUpdateStudent.S_PHNUM = txtPhNum.Text.Trim();
                        objUpdateStudent.S_ADDRESS = txtAddress.Text.Trim();

                        db.SaveChanges();

                        txtFirstName.Text = "";
                        txtLastName.Text = "";
                        txtEmail.Text = "";
                        txtPhNum.Text = "";
                        txtAddress.Text = "";
                        lblResult.Text = "Profile updated successfully";

                        Session["LoginUser"] = objUpdateUser;
                    }

                }

                /*
                  txtFirstName.Text = objViewUser.U_FIRSTNAME;
                txtLastName.Text = objViewUser.U_LASTNAME;
                txtEmail.Text = objViewUser.U_EMAIL;
                txtPhNum.Text = objViewUser.U_PHNUM;
                txtAddress.Text = objViewUser.U_ADDRESS;

                lblLoginUser.Text =
                 */
            }
            catch (Exception ee)
            {
                lblResult.Text = "";
            }
        }

        protected void clearButton_Click(object sender, EventArgs e)
        {
            try
            {
                txtFirstName.Text = "";
                txtLastName.Text = "";
                txtEmail.Text = "";
                txtPhNum.Text = "";
                txtAddress.Text = "";
                lblResult.Text = "";

            }
            catch (Exception ee)
            {

            }
        }
    }
}