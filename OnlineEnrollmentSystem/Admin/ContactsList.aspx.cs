using OnlineEnrollmentSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineEnrollmentSystem.Admin
{
    public partial class ContactsList : System.Web.UI.Page
    {
        ONLINEENROLLMENTEntities db = new ONLINEENROLLMENTEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    Label lblMenu = this.Master.FindControl("lblMenuItem") as Label;
                    lblMenu.Text = "Contacts List";
                    LoadAllContactMessages();
                }
            }
            catch (Exception ee)
            {

            }
        }

        private void LoadAllContactMessages()
        {
            try
            {
                List<ContactMaster> lstCM = db.ContactMasters.Where(aa => aa.CM_IsActive == "Y").ToList();

                gvContacts.DataSource = lstCM;
                gvContacts.DataBind();
            }
            catch (Exception ee)
            {

            }
        }

        protected void gvContacts_RowEditing(object sender, GridViewEditEventArgs e)
        {
            try
            {
                gvContacts.EditIndex = e.NewEditIndex;
                LoadAllContactMessages();
            }
            catch (Exception ee)
            {

            }
        }

        protected void gvContacts_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            try
            {
                gvContacts.EditIndex = -1;
                LoadAllContactMessages();
            }
            catch (Exception ee)
            {

            }
        }

        protected void gvContacts_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            try
            {
                GridViewRow row = (GridViewRow)gvContacts.Rows[e.RowIndex];
                Label lblCntMsgId = (Label)row.FindControl("lblContactMsgId");
                TextBox txtReplayMsg = (TextBox)row.FindControl("txtReplay");

                int iContactMsg = Convert.ToInt32(lblCntMsgId.Text);
                var LoginUser = (User)Session["LoginUser"];
                string strLoginUser = LoginUser.U_USERNAME;

                ContactMaster objUpdateCM = db.ContactMasters.Where(aa => aa.CM_ID == iContactMsg && aa.CM_IsActive == "Y").SingleOrDefault();

                if (objUpdateCM != null)
                {
                    objUpdateCM.CM_AdminMessage = txtReplayMsg.Text;
                    objUpdateCM.ReplayDate = DateTime.Now;
                    objUpdateCM.MUSER = strLoginUser;
                    objUpdateCM.MDATE = DateTime.Now.ToString("yyyyMMddHHmmss");

                    db.SaveChanges();

                    var userMailID = "venkataanvesh721@gmail.com";
                    var mailPassword = "Anvesh@1234";
                    var subject = "Reg: ESMS Contact form";
                    var message = "Hi " + objUpdateCM.CM_FullName + " , " + txtReplayMsg.Text;
                    SmtpClient sc = new SmtpClient("smtp.gmail.com", 25);
                    NetworkCredential nc = new NetworkCredential(userMailID, mailPassword);
                    MailMessage mm = new MailMessage(userMailID, objUpdateCM.CM_Email, subject, message);
                    sc.EnableSsl = true;
                    sc.Credentials = nc;
                    sc.Send(mm);

                    gvContacts.EditIndex = -1;
                    LoadAllContactMessages();
                }
                else
                {

                }
            }
            catch (Exception ee)
            {

            }
        }
    }
}