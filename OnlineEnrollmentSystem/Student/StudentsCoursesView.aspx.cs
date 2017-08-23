using OnlineEnrollmentSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineEnrollmentSystem.Student
{
    public partial class StudentsCoursesView : System.Web.UI.Page
    {
        ONLINEENROLLMENTEntities db = new ONLINEENROLLMENTEntities();
        User objUser = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Label lblMenu = this.Master.FindControl("lblMenuItem") as Label;
                lblMenu.Text = "Assign Courses List";

                objUser = (User)Session["LoginUser"];
                LoadCourses();
            }
        }

        private void LoadCourses()
        {
            try
            {
                StudentMaster objSM = db.StudentMasters.Where(aa => aa.S_AYN == "Y" && aa.S_USERNAME == objUser.U_USERNAME).FirstOrDefault();

                if (objSM != null)
                {
                    List<StudentEnrollCourseTran> lstStudentCourses = db.StudentEnrollCourseTrans.Where(aa => aa.SEC_AYN == "Y" && aa.SEC_STUDENT_ID == objSM.S_ID).ToList();

                    gvCourses.DataSource = lstStudentCourses;
                    gvCourses.DataBind();
                }
            }
            catch (Exception ee)
            {

            }
        }
    }
}