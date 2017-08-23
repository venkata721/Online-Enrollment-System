using OnlineEnrollmentSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineEnrollmentSystem.Admin
{
    public partial class CourseAddEdit : System.Web.UI.Page
    {
        ONLINEENROLLMENTEntities db = new ONLINEENROLLMENTEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Label lblMenu = this.Master.FindControl("lblMenuItem") as Label;
                lblMenu.Text = "Course Add";

                if (Session["CourseId"] != null)
                {
                    txtCourseId.Text = Session["CourseId"].ToString();
                    bindTextboxes(txtCourseId.Text);
                }
                
            }
        }

        private void bindTextboxes(string strCourseId)
        {
            try
            {
                if (strCourseId != null)
                {
                    int iCourseId = Convert.ToInt32(strCourseId);

                    CourseMaster objEditCourse = db.CourseMasters.Where(aa => aa.C_AYN == "Y" && aa.C_ID == iCourseId).FirstOrDefault();

                    if (objEditCourse != null)
                    {
                        txtCourseName.Text = objEditCourse.C_NAME;
                        txtDuration.Text = objEditCourse.C_DURATION;
                        txtFee.Text = objEditCourse.C_FEE.ToString();
                        txtStartDate.Text = objEditCourse.C_STARTDATE.ToString();
                        txtEndDate.Text = objEditCourse.C_ENDDATE.ToString();
                        
                        Session["CourseId"] = null;
                    }
                }
            }
            catch (Exception ee)
            {

            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCourseId.Text.Trim().Length>0 && txtCourseId.Text != null)
                {
                    int iCouserId = Convert.ToInt32(txtCourseId.Text.Trim());

                    CourseMaster objEditCourse = db.CourseMasters.Where(aa => aa.C_AYN == "Y" && aa.C_ID == iCouserId).SingleOrDefault();

                    if (objEditCourse != null)
                    {
                        objEditCourse.C_NAME = txtCourseName.Text.Trim();
                        objEditCourse.C_DURATION = txtDuration.Text.Trim();
                        objEditCourse.C_FEE = Convert.ToInt32(txtFee.Text.Trim());
                        objEditCourse.C_STARTDATE = Convert.ToDateTime(txtStartDate.Text.Trim());
                        objEditCourse.C_ENDDATE = Convert.ToDateTime(txtEndDate.Text.Trim());

                        objEditCourse.MDATE = DateTime.Now.ToString("yyyyMMddHHmmss");
                        objEditCourse.MUSER = "admin";

                        db.SaveChanges();

                        Response.Redirect("~/Admin/CourseList.aspx");
                    }
                }
                else
                {
                    CourseMaster objCheckCourse = db.CourseMasters.Where(aa => aa.C_AYN == "Y" && aa.C_NAME == txtCourseName.Text.Trim()).FirstOrDefault();

                    if (objCheckCourse != null)
                    {
                        lblErrMsg.Text = "Course name already exits, Please try another course name";
                    }
                    else
                    {
                        CourseMaster objNewCourse = new CourseMaster();

                        objNewCourse.C_NAME = txtCourseName.Text.Trim();
                        objNewCourse.C_DURATION = txtDuration.Text.Trim();
                        objNewCourse.C_FEE = Convert.ToInt32(txtFee.Text.Trim());
                        objNewCourse.C_STARTDATE = Convert.ToDateTime(txtStartDate.Text.Trim());
                        objNewCourse.C_ENDDATE = Convert.ToDateTime(txtEndDate.Text.Trim());

                        objNewCourse.C_AYN = "Y";
                        objNewCourse.CDATE = DateTime.Now.ToString("yyyyMMddHHmmss");
                        objNewCourse.CUSER = "admin";

                        db.CourseMasters.Add(objNewCourse);
                        db.SaveChanges();

                        Response.Redirect("~/Admin/CourseList.aspx");
                    }
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
                txtCourseName.Text = "";
                txtDuration.Text = "";
                txtFee.Text = "";
                txtStartDate.Text = DateTime.Now.ToString("yyyy-MMM-dd");
                txtEndDate.Text = DateTime.Now.ToString("yyyy-MMM-dd");
                lblErrMsg.Text = "";
            }
            catch (Exception ee)
            {

            }
        }
    }
}