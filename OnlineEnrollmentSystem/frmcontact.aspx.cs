using OnlineEnrollmentSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineEnrollmentSystem
{
    public partial class frmcontact : System.Web.UI.Page
    {
        ONLINEENROLLMENTEntities db = new ONLINEENROLLMENTEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void submitButton_Click(object sender, EventArgs e)
        {
            try
            {
                ContactMaster objNewCM = new ContactMaster();
                 
                objNewCM.CM_FullName = nameTextBox.Text;
                objNewCM.CM_PhoneNumber = phoneTextBox.Text;
                objNewCM.CM_Email = emailTextBox.Text;
                objNewCM.CM_Message = messageTextBox.Text;
                objNewCM.PostDate = DateTime.Now;
                objNewCM.CDATE = DateTime.Now.ToString("yyyyMMddHHmmss");
                objNewCM.CUSER = nameTextBox.Text;
                objNewCM.CM_IsActive = "Y";               

                db.ContactMasters.Add(objNewCM);
                db.SaveChanges();

                var userMailID = "venkataanvesh721@gmail.com";
                var mailPassword = "Anvesh@1234";
                var subject = "Reg: ESMS Contact form";
                var message = "Thank you " + nameTextBox.Text + " for contacting us. our team will reach you with in 24hours time. \n Your message: " + messageTextBox.Text;
                SmtpClient sc = new SmtpClient("smtp.gmail.com", 25);
                NetworkCredential nc = new NetworkCredential(userMailID, mailPassword);
                MailMessage mm = new MailMessage(userMailID, emailTextBox.Text, subject, message);
                sc.EnableSsl = true;
                sc.Credentials = nc;
                sc.Send(mm);

                resultLabel.Text = "Thank you " + nameTextBox.Text + " for contacting us. Our team will get back to you asap.";

                ClearAllTextboxes();
            }
            catch (Exception ee)
            {
                resultLabel.Text = ee.Message;
            }
        }

        private void ClearAllTextboxes()
        {
            try
            {
                nameTextBox.Text = "";
                phoneTextBox.Text = "";
                emailTextBox.Text = "";
                messageTextBox.Text = "";
            }
            catch (Exception ee)
            {

            }
        }
    }
}