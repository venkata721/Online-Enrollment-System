using OnlineEnrollmentSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineEnrollmentSystem
{
    public partial class frmfacultyregister : System.Web.UI.Page
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
                    objUser.U_ROLE_ID = 2;
                    objUser.U_ROLE_NAME = "Faculty";

                    db.Users.Add(objUser);

                    FacultyMaster objNewFaclty = new FacultyMaster();

                    objNewFaclty.F_USERNAME = txtUserName.Text.Trim();
                    objNewFaclty.F_PWD = txtPwd.Text.Trim();
                    objNewFaclty.F_NAME = txtFirstName.Text.Trim();
                    objNewFaclty.F_DESCRIPTION = txtLastName.Text.Trim();
                    objNewFaclty.F_EMAIL = txtEmail.Text.Trim();
                    objNewFaclty.F_PHNUM = txtPhNum.Text.Trim();
                    objNewFaclty.F_ADDRESS = txtAddress.Text.Trim();

                    objNewFaclty.F_AYN = "Y";
                    objNewFaclty.CDATE = DateTime.Now.ToString("yyyyMMddHHmmss");
                    objNewFaclty.CUSER = "admin";

                    db.FacultyMasters.Add(objNewFaclty);

                    try
                    {
                        db.SaveChanges();
                    }
                    catch (DbEntityValidationException ex)
                    {
                        foreach (var eve in ex.EntityValidationErrors)
                        {
                            resultLabel.Text="Entity of type \"{0}\" in state \"{1}\" has the following validation errors:"+eve.Entry.Entity.GetType().Name+","+ eve.Entry.State;
                            foreach (var ve in eve.ValidationErrors)
                            {
                                resultLabel.Text="- Property: \"{0}\", Error: \"{1}\""+ve.PropertyName+ " , "+ ve.ErrorMessage;
                            }
                        }
                    }                   

                    Session["role"] = "2";
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