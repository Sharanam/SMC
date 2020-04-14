using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Shivam
{
    public partial class Dashboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserName"].ToString() == "Unknown User")
            {
                Server.Transfer("WebForm1.aspx");
            }
            if (!IsPostBack)
                ViewState["Current"] = 0;
            lblQId.Text = Global.Quiz.Rows[Int32.Parse(ViewState["Current"].ToString())]["Id"].ToString();
            lblQustion.Text = Global.Quiz.Rows[Int32.Parse(ViewState["Current"].ToString())]["Question"].ToString();
            lstAnswers.Items[0].Text = Global.Quiz.Rows[Int32.Parse(ViewState["Current"].ToString())]["A"].ToString();
            lstAnswers.Items[1].Text = Global.Quiz.Rows[Int32.Parse(ViewState["Current"].ToString())]["B"].ToString();
            lstAnswers.Items[2].Text = Global.Quiz.Rows[Int32.Parse(ViewState["Current"].ToString())]["C"].ToString();
        }

        protected void btnGo_Click(object sender, EventArgs e)
        {
            switch (lstAnswers.SelectedIndex)
            {
                case 0: if(Global.Quiz.Rows[(int)ViewState["Current"]]["Right"].ToString() == "A") { Session["CurrentScore"] = (int)Session["CurrentScore"] + 1; }
                    break;
                case 1:
                    if (Global.Quiz.Rows[(int)ViewState["Current"]]["Right"].ToString() == "B") { Session["CurrentScore"] = (int)Session["CurrentScore"] + 1; }
                    break;
                case 2:
                    if (Global.Quiz.Rows[(int)ViewState["Current"]]["Right"].ToString() == "C") { Session["CurrentScore"] = (int)Session["CurrentScore"] + 1; }
                    break;
            }
            if ((int)ViewState["Current"] < Global.Quiz.Rows.Count+1)
            {
                ViewState["Current"] = (int)ViewState["Current"] + 1;
            }
            else
            {
                Server.Transfer("Final.aspx");
            }
        }
    }
}