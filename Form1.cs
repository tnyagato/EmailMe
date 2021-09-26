using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmailMe
{
	public partial class Form1 : Form
	{

        public static Email email = new Email();
        public static Server server = new Server();

        public static string emailfile = "email.json";
        public static string serverFile = "server.json";

		public Form1()
		{
			InitializeComponent();

            if (File.Exists(emailfile))
            {

                email = JsonConvert.DeserializeObject<Email>(File.ReadAllText(emailfile));

                txtFrom.Text = email.from;
                txtTo.Text = email.to;
                txtSubject.Text = email.subject;
                txtBody.Text = email.body;
                cbkHTML.Checked = email.IsBodyHtml;



            }

            if (File.Exists(serverFile))
            {

                server = JsonConvert.DeserializeObject<Server>(File.ReadAllText(serverFile));
                cbkSSL.Checked = server.EnableSsl;
                txtUsername.Text = server.username;
                txtPassword.Text = server.password;
                txtPort.Text = server.port.ToString();
                txtServer.Text = server.server;
                
            }

            

        }

		private void btnSend_Click(object sender, EventArgs e)
		{

            txtResponse.Text = "";

            MailMessage mailMessage = new MailMessage();
            mailMessage.From = new MailAddress(txtFrom.Text);
            mailMessage.To.Add(txtTo.Text);
            mailMessage.Subject = txtSubject.Text;
            mailMessage.Body = txtBody.Text;
            mailMessage.IsBodyHtml = cbkHTML.Checked;


            SmtpClient smtpClient = new SmtpClient(txtServer.Text);
            smtpClient.Port = int.Parse(txtPort.Text);
            smtpClient.Credentials = new NetworkCredential(txtUsername.Text, txtPassword.Text);
            smtpClient.EnableSsl = cbkSSL.Checked;
    
            

            try
            {
                smtpClient.Send(mailMessage);
            }
            catch (Exception ex)
            {
                txtResponse.Text = ex.Message;
                return;
            }

            txtResponse.Text = "success";

            email.from = txtFrom.Text ;
            email.to = txtTo.Text;
            email.subject = txtSubject.Text;
            email.body = txtBody.Text;
            email.IsBodyHtml = cbkHTML.Checked;

            server.EnableSsl = cbkSSL.Checked ;
            server.username = txtUsername.Text;
            server.password = txtPassword.Text;
            server.port = int.Parse(txtPort.Text);
            server.server = txtServer.Text;

            File.WriteAllText(emailfile, JsonConvert.SerializeObject(email));
            File.WriteAllText(serverFile, JsonConvert.SerializeObject(server));

        }

		private void Form1_Load(object sender, EventArgs e)
		{

		}
	}

	public class Email
    {
        public Email()
        {
            from = "";
            to = "";
            subject = "";
            body = "";
            IsBodyHtml = true;
        }
        public string from { get; set; }
        public string to { get; set; }
        public string subject { get; set; }
        public string body { get; set; }
        public bool IsBodyHtml { get; set; }
    }

    public class Server
    {

        public Server()
        {
            port = 25;
            server = "";
            username = "";
            password = "";
            EnableSsl = false;
        }
        public int port { get; set; }
        public string server { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public bool EnableSsl { get; set; }

    }
}
