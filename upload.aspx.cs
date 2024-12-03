using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Data;
public partial class src_html_upload : System.Web.UI.Page
{
    Database D = new Database();
    public DataTable T = new DataTable();
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (!Page.IsPostBack)
            {
               
                T = (DataTable)Session["login"];
                lblStduentName.Text = T.Rows[0][1].ToString();


                D.RunQuery("select DivNo ,DivName from Division where DivNo=" + T.Rows[0][5].ToString() + "");
               
                    dblsearchofdiv.Items.Clear();
                    dblsearchofdiv.DataSource = D.tbl;
                    dblsearchofdiv.DataValueField = "DivNo";
                    dblsearchofdiv.DataTextField = "DivName";
                    dblsearchofdiv.DataBind();
                }
            D.RunQuery("select Sub_ID ,Sub_Name from Subject  where DivNo=" + T.Rows[0][5].ToString() + " and LevelCode=" + T.Rows[0][4].ToString() + "");
                    if (D.tbl.Rows.Count >= 1)
                    {
                    dblsearchofsubj.Items.Clear();
                    dblsearchofsubj.DataSource = D.tbl;
                    dblsearchofsubj.DataValueField = "Sub_ID";
                    dblsearchofsubj.DataTextField = "Sub_Name";
                    dblsearchofsubj.DataBind();
                    }
                    D.RunQuery("select SheetNo ,Sheet_Tittle from Sheet");
                    if (D.tbl.Rows.Count >= 1)
                    {
                    dblsearchofsheet.Items.Clear();
                    dblsearchofsheet.DataSource = D.tbl;
                    dblsearchofsheet.DataValueField = "SheetNo";
                    dblsearchofsheet.DataTextField = "Sheet_Tittle";
                    dblsearchofsheet.DataBind();
                    }
               
            
           
        }
        catch (Exception)
        {
            ;
        }
    }

    protected void dblsearchofdiv_SelectedIndexChanged(object sender, EventArgs e)
    {
  
    }
    protected void Button_info_Click(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (FileUpload1.HasFile)
        {
            try
            {
                string filename =Path.GetFileName(FileUpload1.FileName);
                FileUpload1.SaveAs(Server.MapPath("~/File/~") + filename);
                Label1.Text = "File Uploaded Successfully";
            }
            catch (Exception ex)
            {
                Label1.Text = "Some Error Found While uploaded";
                    }
        }
    }
}