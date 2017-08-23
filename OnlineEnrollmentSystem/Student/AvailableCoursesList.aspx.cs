using OnlineEnrollmentSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineEnrollmentSystem.Student
{
    public partial class AvailableCoursesList : System.Web.UI.Page
    {
        ONLINEENROLLMENTEntities db = new ONLINEENROLLMENTEntities();
        User objUser = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Label lblMenu = this.Master.FindControl("lblMenuItem") as Label;
                lblMenu.Text = "Courses List";

                objUser = (User)Session["LoginUser"];
                LoadAllCourses();
                
            }
        }
       
       
        private void LoadAllCourses()
        {
            try
            {
                StudentMaster objSM = db.StudentMasters.Where(aa => aa.S_AYN == "Y" && aa.S_USERNAME == objUser.U_USERNAME).FirstOrDefault();
                List<CourseMaster> lstCourses = db.CourseMasters.Where(aa => aa.C_AYN == "Y").ToList();
                List<StudentEnrollCourseTran> lstStudentCourses = db.StudentEnrollCourseTrans.Where(aa => aa.SEC_AYN == "Y" && aa.SEC_STUDENT_ID == objSM.S_ID).ToList();
                foreach (var SECT in lstStudentCourses)
                {
                    for (int i = lstCourses.Count() - 1; i >= 0;i-- )
                    {
                        if (SECT.SEC_COURSE_ID == lstCourses[i].C_ID)
                        {
                            lstCourses.RemoveAt(i);
                        }
                    }
                }

                gvCourses.DataSource = lstCourses;
                gvCourses.DataBind();
            }
            catch (Exception ee)
            {

            }
        }

        protected void btnEnroll_Click(object sender, EventArgs e)
        {
            try
            {
                objUser = (User)Session["LoginUser"];
                StudentMaster objSM = db.StudentMasters.Where(aa => aa.S_AYN == "Y" && aa.S_USERNAME == objUser.U_USERNAME).FirstOrDefault();
                foreach (GridViewRow  row in gvCourses.Rows)
                {
                    Label lblCourseId = (Label)row.FindControl("lblCourseId");
                    CheckBox cbEnroll = (CheckBox)row.FindControl("chkRow");

                    if (cbEnroll.Checked)
                    {
                        int iCourseId = Convert.ToInt32(lblCourseId.Text);

                        CourseMaster objCouseMaster = db.CourseMasters.Where(aa => aa.C_ID == iCourseId && aa.C_AYN == "Y").FirstOrDefault();

                        StudentEnrollCourseTran objSMCEnroll = new StudentEnrollCourseTran();

                        objSMCEnroll.SEC_COURSE_ID = objCouseMaster.C_ID;
                        objSMCEnroll.SEC_COURSE_NAME = objCouseMaster.C_NAME;
                        objSMCEnroll.SEC_COURSE_PRICE = objCouseMaster.C_FEE;
                        objSMCEnroll.SEC_STUDENT_ID = objSM.S_ID;
                        objSMCEnroll.SEC_STUDENT_NAME = objSM.S_NAME;
                        objSMCEnroll.SEC_ENROLLBY = objUser.U_USERNAME;
                        objSMCEnroll.SEC_ENROLLDATE = DateTime.Now;

                        objSMCEnroll.CDATE = DateTime.Now.ToString("yyyyMMddHHmmss");
                        objSMCEnroll.CUSER = objUser.U_USERNAME;
                        objSMCEnroll.SEC_AYN = "Y";

                        db.StudentEnrollCourseTrans.Add(objSMCEnroll);
                    }
                }

                db.SaveChanges();
                Response.Redirect("~/Student/StudentsCoursesView.aspx");

            }
            catch (Exception ee)
            {

            }
        }
    }
}