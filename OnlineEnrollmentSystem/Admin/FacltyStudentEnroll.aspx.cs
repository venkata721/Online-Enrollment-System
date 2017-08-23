using OnlineEnrollmentSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineEnrollmentSystem.Admin
{
    public partial class FacltyStudentEnroll : System.Web.UI.Page
    {
        ONLINEENROLLMENTEntities db = new ONLINEENROLLMENTEntities();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Label lblMenu = this.Master.FindControl("lblMenuItem") as Label;
                lblMenu.Text = "Student Enrollment";

                LoadAllFacultyEnrolls();
                LoadAllFaculties();
                LoadAllStudents();
            }
        }

        private void LoadAllFacultyEnrolls()
        {
            try
            {
                List<FacultyStudentEnrollTransaction> lstFacultyStudentEnroll = db.FacultyStudentEnrollTransactions.Where(aa => aa.FS_AYN == "Y").ToList();

                gvFacultyStudEnroll.DataSource = lstFacultyStudentEnroll;
                gvFacultyStudEnroll.DataBind();
            }
            catch (Exception ee)
            {

            }
        }

        private void LoadAllStudents()
        {
            try
            {
                List<StudentMaster> lstStudents = db.StudentMasters.Where(aa => aa.S_AYN == "Y").ToList();

                ddlStudent.DataSource = lstStudents;
                ddlStudent.DataValueField = "S_ID";
                ddlStudent.DataTextField = "S_NAME";
                ddlStudent.DataBind();
                ddlStudent.Items.Insert(0, new ListItem("---- Select -----", string.Empty));
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
                int FacultyId = Convert.ToInt32(ddlFaclty.SelectedItem.Value);
                int StudentId = Convert.ToInt32(ddlStudent.SelectedItem.Value);
                FacultyStudentEnrollTransaction objCheck = db.FacultyStudentEnrollTransactions.Where(aa => aa.FS_AYN == "Y" && aa.FS_FACULTY_ID == FacultyId && aa.FS_STUDENT_ID == StudentId).FirstOrDefault();

                if (objCheck != null)
                {
                    lblErrMsg.Text = ddlStudent.SelectedItem.Text + " is already enroll to " + ddlFaclty.SelectedItem.Text;
                }
                else
                {
                    FacultyStudentEnrollTransaction objNewFacStud = new FacultyStudentEnrollTransaction();

                    objNewFacStud.FS_FACULTY_ID = FacultyId;
                    objNewFacStud.FS_FACULTY_NAME = ddlFaclty.SelectedItem.Text;
                    objNewFacStud.FS_STUDENT_ID = StudentId;
                    objNewFacStud.FS_STUDENT_NAME = ddlStudent.SelectedItem.Text;

                    objNewFacStud.FS_AYN = "Y";
                    objNewFacStud.CDATE = DateTime.Now.ToString("yyyyMMddHHmmss");
                    objNewFacStud.CUSER = "admin";

                    db.FacultyStudentEnrollTransactions.Add(objNewFacStud);
                    db.SaveChanges();

                    LoadAllFacultyEnrolls();
                    LoadAllFaculties();
                    LoadAllStudents();
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
                LoadAllFacultyEnrolls();
                LoadAllFaculties();
                LoadAllStudents();
                lblErrMsg.Text = "";
            }
            catch (Exception ee)
            {

            }
        }
    }
}