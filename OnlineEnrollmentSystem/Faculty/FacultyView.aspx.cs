using OnlineEnrollmentSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineEnrollmentSystem.Faculty
{
    public partial class FacultyView : System.Web.UI.Page
    {
        ONLINEENROLLMENTEntities db = new ONLINEENROLLMENTEntities();
        FacultyMaster objLoginFaculty = null;
        User objLoginUser = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //objLoginFaculty = (FacultyMaster)Session["LoginUser"];
                objLoginUser = (User)Session["LoginUser"];
                LoadAllLoginFaculty();
                
            }
        }

        private void LoadAllLoginFaculty()
        {
            try
            {
                objLoginFaculty = db.FacultyMasters.Where(aa => aa.F_AYN == "Y" && aa.F_USERNAME == objLoginUser.U_USERNAME).FirstOrDefault();
                LoadAllFacultyCourses();
            }
            catch (Exception ee)
            {

            }
        }

        private void LoadAllFacultyCourses()
        {
            try
            {
                List<CourseFacultyEnrollTransaction> lstEnroll = db.CourseFacultyEnrollTransactions.Where(aa => aa.CF_AYN == "Y" && aa.CF_FACULTY_ID == objLoginFaculty.F_ID).ToList();

                gvFacultyCourses.DataSource = lstEnroll;
                gvFacultyCourses.DataBind();
            }
            catch (Exception ee)
            {

            }
        }
    }
}