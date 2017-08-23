using OnlineEnrollmentSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineEnrollmentSystem.Faculty
{
    public partial class frmChangePassword : System.Web.UI.Page
    {
        ONLINEENROLLMENTEntities db = new ONLINEENROLLMENTEntities();
        String strLoginUser = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Label lblMenu = this.Master.FindControl("lblMenuItem") as Label;
                lblMenu.Text = "Change Password";

                var LoginUser = (User)Session["LoginUser"];
                strLoginUser = LoginUser.U_USERNAME;
                LoadPioltDetails(LoginUser);
            }
        }

        private void LoadPioltDetails(User objViewUser)
        {
            try
            {
                lblOldPwd.Text = objViewUser.U_PASSWORD;
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
                        if (objUpdateUser.U_PASSWORD == txtOldPwd.Text)
                        {
                            objUpdateUser.U_PASSWORD = txtPwd.Text.Trim();

                            objUpdateUser.MUSER = strLoginUser;
                            objUpdateUser.MDATE = DateTime.Now.ToString("yyyyMMddHHmmss");

                            var objFaculty = db.FacultyMasters.Where(aa => aa.F_AYN == "Y").SingleOrDefault();
                            objFaculty.F_PWD = txtPwd.Text.Trim();

                            objFaculty.MUSER = strLoginUser;
                            objFaculty.MDATE = DateTime.Now.ToString("yyyyMMddHHmmss");


                            db.SaveChanges();

                            txtPwd.Text = "";
                            txtOldPwd.Text = "";
                            txtCnfmPwd.Text = "";
                            lblResult.Text = "Password change successfully";

                            Session["LoginUser"] = objUpdateUser;
                        }
                        else
                        {
                            lblResult.Text = "Old password not matched";
                        }
                    }
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
                lblOldPwd.Text = "";
                //lblLoginUser.Text = "";
                txtOldPwd.Text = "";
                txtPwd.Text = "";
                txtCnfmPwd.Text = "";
            }
            catch (Exception ee)
            {

            }
        }
    }
}