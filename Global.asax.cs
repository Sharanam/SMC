using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.Data;
using System.Data.SqlClient;

namespace Shivam
{
    public class Global : System.Web.HttpApplication
    {
        public static DataTable Quiz;

        protected void Application_Start(object sender, EventArgs e)
        {
            SqlConnection QuizCN = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ashok\Documents\SharanamWeb.mdf;Integrated Security=True;Connect Timeout=30");
            Global.Quiz = new DataTable();
            try
            {
                using (QuizCN)
                {
                    SqlDataAdapter adp = new SqlDataAdapter("Select * from QuizData", QuizCN);
                    adp.Fill(Global.Quiz);
                }
            }
            catch(Exception ex) { Response.Write(@"<script>alert('Error"+ex.Message+"')</script>"); }
            finally { QuizCN.Close(); }
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            Session["UserName"] = "Unknown User";
            Session["MaxScore"] = 0;
            Session["CurrentScore"] = 0;
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {
            Response.Write("<script>alert('Bye Bye');</script>");
            Server.Transfer("WebForm1.aspx");
        }

        protected void Session_End(object sender, EventArgs e)
        {
        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}