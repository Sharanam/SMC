using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace Shivam
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void LogIn_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ashok\Documents\SharanamWeb.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                //SqlCommand cmd = new SqlCommand("select * from USerDetails where Id='" + txtUser.Text + "';",cn);
                DataTable dt = new DataTable();
                SqlDataAdapter adp = new SqlDataAdapter("select * from USerDetails where Id='" + txtUser.Text + "';", cn);
                adp.Fill(dt);
                if (dt != null && dt.Rows.Count>0)
                {
                    if (dt.Rows[0]["Password"].ToString().Trim() == txtPswd.Text.ToString().Trim())
                    {
                        Session["UserName"] = dt.Rows[0]["Id"];
                        Session["MaxScore"] = (int)dt.Rows[0]["Score"];
                        Response.Redirect("Dashboard.aspx");
                    }
                    else Response.Write("<script>alert('Do it again, Password isnt correct.');</script>");
                }
                else
                {
                    Response.Write("<script>alert('Dt is equal to null');</script>");
                }
            }

        }
    }
}