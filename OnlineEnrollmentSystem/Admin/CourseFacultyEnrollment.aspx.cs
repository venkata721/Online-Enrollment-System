using OnlineEnrollmentSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineEnrollmentSystem.Admin
{
    public partial class CourseFacultyEnrollment : System.Web.UI.Page
    {
        ONLINEENROLLMENTEntities db = new ONLINEENROLLMENTEntities();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Label lblMenu = this.Master.FindControl("lblMenuItem") as Label;
                lblMenu.Text = "Faculty Enrollment";

                LoadAllCourseEnrolls();
                LoadAllCourses();
                LoadAllFaculties();
            }
        }

        private void LoadAllCourseEnrolls()
        {
            try
            {
                List<CourseFacultyEnrollTransaction> lstCourseFacultyEnroll = db.CourseFacultyEnrollTransactions.Where(aa => aa.CF_AYN == "Y").ToList();

                gvCourseEnroll.DataSource = lstCourseFacultyEnroll;
                gvCourseEnroll.DataBind();
            }
            catch (Exception ee)
            {

            }
        }

        private void LoadAllCourses()
        {
            try
            {
                List<CourseMaster> lstCourses = db.CourseMasters.Where(aa => aa.C_AYN == "Y").ToList();

                ddlCourse.DataSource = lstCourses;
                ddlCourse.DataValueField = "C_ID";
                ddlCourse.DataTextField = "C_NAME";
                ddlCourse.DataBind();
                ddlCourse.Items.Insert(0, new ListItem("---- Select -----", string.Empty));
            }
            catch (Exception ee)
            {

            }
        }

        private void LoadAllFaculties()
        {
            try
            {
                List<FacultyMaster> lstFaculty = db.FacultyMasters.Where(aa => aa.F_AYN == "Y").ToList();

                ddlFaclty.DataSource = lstFaculty;
                ddlFaclty.DataValueField = "F_ID";
                ddlFaclty.DataTextField = "F_NAME";
                ddlFaclty.DataBind();
                ddlFaclty.Items.Insert(0, new ListItem("---- Select -----", string.Empty));
            }
            catch (Exception ee)
            {

            }
        }

        protected void btnEnroll_Click(object sender, EventArgs e)
        {
            try
            {
                int iCourseId = Convert.ToInt32(ddlCourse.SelectedItem.Value);
                int iFacultyId = Convert.ToInt32(ddlFaclty.SelectedItem.Value);

                CourseFacultyEnrollTransaction objCheck = db.CourseFacultyEnrollTransactions.Where(aa => aa.CF_AYN == "Y" && aa.CF_COURSE_ID == iCourseId && aa.CF_FACULTY_ID == iFacultyId).FirstOrDefault();
              
                if (objCheck != null)
                {
                    lblErrMsg.Text = ddlFaclty.SelectedItem.Text + " is already enroll to " + ddlCourse.SelectedItem.Text;
                }
                else
                {
                    CourseFacultyEnrollTransaction objNewCF = new CourseFacultyEnrollTransaction();

                    objNewCF.CF_COURSE_ID = iCourseId;
                    objNewCF.CF_COURSE_NAME = ddlCourse.SelectedItem.Text;
                    objNewCF.CF_FACULTY_ID = iFacultyId;
                    objNewCF.CF_FACULTY_NAME = ddlFaclty.SelectedItem.Text;
                    objNewCF.CF_ENROLLDATE = DateTime.Today;
                    objNewCF.CF_ENROLLBY = "admin";

                    objNewCF.CF_AYN = "Y";
                    objNewCF.CDATE = DateTime.Now.ToString("yyyyMMddHHmmss");
                    objNewCF.CUSER = "admin";

                    db.CourseFacultyEnrollTransactions.Add(objNewCF);
                    db.SaveChanges();

                    LoadAllCourseEnrolls();
                    LoadAllCourses();
                    LoadAllFaculties();
                    lblErrMsg.Text = "";
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
                LoadAllCourseEnrolls();
                LoadAllCourses();
                LoadAllFaculties();
                lblErrMsg.Text = "";
            }
            catch (Exception ee)
            {

            }
        }
    }
}