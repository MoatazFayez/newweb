using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class src_html_Add_Sheet : System.Web.UI.Page
{
    Database D = new Database();
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (!Page.IsPostBack)
            {
                D.RunQuery("select SheetNo ,Sheet_Tittle from Sheet");
                if (D.tbl.Rows.Count >= 1)
                {
                    ddlsheet.Items.Clear();
                    ddlsheet.DataSource = D.tbl;
                    ddlsheet.DataValueField = "SheetNo";
                    ddlsheet.DataTextField = "Sheet_Tittle";
                    ddlsheet.DataBind();

                      D.RunQuery("select Sub_ID ,Sub_Name from Subject");

                      ddlsubj.Items.Clear();
                      ddlsubj.DataSource = D.tbl;
                      ddlsubj.DataValueField = "Sub_ID";
                      ddlsubj.DataTextField = "Sub_Name";
                      ddlsubj.DataBind();

                    D.RunQuery("select SheetNo ,Sheet_Tittle from Sheet");


                }


            }
            else
            {
                ;
            }
        }
        catch (Exception)
        {
            ;
        }
    
    }
    protected void ImageButton_Click(object sender, ImageClickEventArgs e)
    {
        MyCalendar.Visible = true;
    }
    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        txtcalstar.Text = MyCalendar.SelectedDate.ToShortDateString();
        MyCalendar.Visible = false;
    }
    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {

    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        Calendar1.Visible = true;

    }
    protected void Calendar1_SelectionChanged1(object sender, EventArgs e)
    {
        txtcalend.Text = Calendar1.SelectedDate.ToShortDateString();
        Calendar1.Visible = false;
    }

    protected void btnadded_Click(object sender, EventArgs e)
    {
        try
        {
            string Msg;
            Msg = D.RunDML("insert into Subject_Sheet values(" + ddlsheet.SelectedValue + ","+ddlsubj.SelectedValue + "," + txtdegree.Text + "," + txtcalstar.Text + "," + txtcalend.Text + ", N'" + txtnotes.Text + "')");
            if (Msg == "ok")
            {
                lblmsg.Text = "Done";
            }
            else 
            {
                lblmsg.Text = Msg;
            }

        }
        catch (Exception)
        {
            
            ;
        }
    }
    protected void btnadd_Click(object sender, EventArgs e)
    {
        txtdegree.Text = "";
        txtcalstar.Text = "";
        txtcalend.Text = "";
        txtnotes.Text = "";
    }
    protected void ddlsubj_SelectedIndexChanged(object sender, EventArgs e)
    {
    //    try
    //    {
    //        if (!Page.IsPostBack)
    //        {
    //            ;
    //        }
    //            D.RunQuery("select * From Subject_Sheet where SheetNo="+ddlsubj.SelectedValue+"");
    //            if(D.tbl.Rows.Count>=1);
    //            {
    //                txtdegree.Text=D.tbl.Rows[0][0].ToString();
    //                txtcalstar.Text=D.tbl.Rows[0][0].ToString();
    //                txtcalend.Text=D.tbl.Rows[0][0].ToString();
    //                txtnotes.Text=D.tbl.Rows[0][0].ToString();
    //        }
    //    }
    //    catch (Exception)
    //    {
            
    //        ;
    //    }
    //}
}protected void  btnselecte_Click(object sender, EventArgs e)
{
      try
        {
            if (!Page.IsPostBack)
            {
                ;
            }
                D.RunQuery("select * From Subject_Sheet where SheetNo="+ddlsubj.SelectedValue+"");
                if(D.tbl.Rows.Count>=1);
                {
                    ddlsheet.SelectedValue=D.tbl.Rows[0][0].ToString();
                    ddlsubj.SelectedValue=D.tbl.Rows[0][1].ToString();
                    txtdegree.Text=D.tbl.Rows[0][2].ToString();
                    txtcalstar.Text=D.tbl.Rows[0][3].ToString();
                    txtcalend.Text = D.tbl.Rows[0][4].ToString();
                    txtnotes.Text = D.tbl.Rows[0][5].ToString();
            }
        }
        catch (Exception)
        {
            
            ;
        }
    }
    protected void btnupdate_Click(object sender, EventArgs e)
    {

    }
}
