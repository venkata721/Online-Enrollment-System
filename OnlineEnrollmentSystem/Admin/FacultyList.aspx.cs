using OnlineEnrollmentSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineEnrollmentSystem.Admin
{
    public partial class FacultyList : System.Web.UI.Page
    {
        ONLINEENROLLMENTEntities db = new ONLINEENROLLMENTEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Label lblMenu = this.Master.FindControl("lblMenuItem") as Label;
                lblMenu.Text = "Faculty List";

                LoadAllFaculties();
            }
        }

        private void LoadAllFaculties()
        {
            try
            {
                List<FacultyMaster> lstFaculty = db.FacultyMasters.Where(aa => aa.F_AYN == "Y").ToList();

                gvFaculty.DataSource = lstFaculty;
                gvFaculty.DataBind();
            }
            catch (Exception ee)
            {

            }
        }
    }
}