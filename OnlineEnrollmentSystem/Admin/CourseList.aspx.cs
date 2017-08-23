using OnlineEnrollmentSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineEnrollmentSystem.Admin
{
    public partial class CourseList : System.Web.UI.Page
    {
        ONLINEENROLLMENTEntities db = new ONLINEENROLLMENTEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Label lblMenu = this.Master.FindControl("lblMenuItem") as Label;
                lblMenu.Text = "Course List";

                LoadAllCourses();
            }
        }

        private void LoadAllCourses()
        {
            try
            {
                List<CourseMaster> lstCourses = db.CourseMasters.Where(aa => aa.C_AYN == "Y").ToList();

                gvCourses.DataSource = lstCourses;
                gvCourses.DataBind();
            }
            catch (Exception ee)
            {

            }
        }

        protected void btnAddCourse_Click(object sender, EventArgs e)
        {
            try
            {
                Session["CourseId"] = null;
                Response.Redirect("~/Admin/CourseAddEdit.aspx");
            }
            catch (Exception ee)
            {

            }
        }

        protected void gvCourses_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            try
            {
                gvCourses.EditIndex = -1;
                LoadAllCourses();
            }
            catch (Exception ee)
            {

            }
        }

        protected void gvCourses_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                GridViewRow row = (GridViewRow)gvCourses.Rows[e.RowIndex];
                Label lblCourseId = (Label)row.FindControl("lblCourseId");

                int iCourseId = Convert.ToInt32(lblCourseId);
                CourseMaster objDeleteCourse = db.CourseMasters.Where(aa => aa.C_AYN == "Y" && aa.C_ID == iCourseId).SingleOrDefault();

                if (objDeleteCourse != null)
                {
                    objDeleteCourse.C_AYN = "N";
                    objDeleteCourse.MDATE = DateTime.Now.ToString("yyyyMMddHHmmss");
                    objDeleteCourse.MUSER = "admin";

                    db.SaveChanges();
                    LoadAllCourses();
                }
            }
            catch (Exception ee)
            {

            }
        }

        protected void gvCourses_RowEditing(object sender, GridViewEditEventArgs e)
        {
            try
            {
                GridViewRow row = (GridViewRow)gvCourses.Rows[e.NewEditIndex];
                Label lblCourseId = (Label)row.FindControl("lblCourseId");

                int iCourseId = Convert.ToInt32(lblCourseId.Text);

                Session["CourseId"] = iCourseId;
                Response.Redirect("~/Admin/CourseAddEdit.aspx");
                //gvCourses.EditIndex = e.NewEditIndex;

                //LoadAllCourses();
            }
            catch (Exception ee)
            {

            }
        }
    }
}