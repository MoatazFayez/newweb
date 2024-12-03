using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
public partial class src_html_login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    Database D = new Database();
    public DataTable tlogin = new DataTable();
    protected void btnlogin_Click(object sender, EventArgs e)
    {


        try
        {
            if (rbllog.SelectedItem.Text=="Employee")
            {
                tlogin = D.RunQuery("select Email,Password from Employee Where Email=N'" + txtemail.Text + "'and Password=N'" + txtpassword.Text + "'");
                if (D.tbl.Rows.Count >= 1)
                {
                    Session["login"] = null;
                    Session["login"] = tlogin;
                    Response.Redirect("~/src/html/Add Sheet.aspx");
                

                }
                else
                {
                    lblmsg.Text = "Email or Password incorrect";
                }

            }
            else if (rbllog.SelectedItem.Text == "Student")
            {
                tlogin = D.RunQuery("select * from Student Where Email=N'" + txtemail.Text + "'and password=N'" + txtpassword.Text + "'");
                if (D.tbl.Rows.Count >= 1)
                {
                    Session["login"] = null;
                    Session["login"] = tlogin;
                    Response.Redirect("~/src/html/upload.aspx");
                  

                }
                else
                {
                    lblmsg.Text = "Email or password in correct";
                }

            }
            else
            {
                lblmsg.Text = "choose type login Manger or Guest";
            }

        }
        catch (Exception)
        {

            ;
        }

        //try
        //{
        //    D.RunQuery("select Email,Password from Student Where Email=N'"+txtemail.Text+"'and password=N'"+txtpassword.Text+"'");
        //    D.RunQuery("select Email,Password from Employee Where Email=N'"+txtemail.Text+"'and password=N'"+txtpassword.Text +"'");
        //    if (D.tbl.Rows.Count >= 1)
        //    {
        //        Response.Redirect("upload.aspx");
        //        Response.Redirect("Add Sheet.aspx");
        //    }
        //    else
        //    {
        //        lblmsg.Text ="inncorect Email or Password";
        //    }
        //}
        //catch (Exception)
        //{
            
        //    throw;
        //}
    }
    protected void rbllog_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}