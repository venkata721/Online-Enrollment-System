using OnlineEnrollmentSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineEnrollmentSystem.Admin
{
    public partial class StudentsList : System.Web.UI.Page
    {
        ONLINEENROLLMENTEntities db = new ONLINEENROLLMENTEntities();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Label lblMenu = this.Master.FindControl("lblMenuItem") as Label;
                lblMenu.Text = "Student List";

                LoadAllStudents();
            }
        }

        private void LoadAllStudents()
        {
            try
            {
                List<StudentMaster> lstStudents = db.StudentMasters.Where(rr => rr.S_AYN == "Y").ToList();

                gvStudent.DataSource = lstStudents;
                gvStudent.DataBind();
            }
            catch (Exception ee)
            {

            }
        }
    }
}