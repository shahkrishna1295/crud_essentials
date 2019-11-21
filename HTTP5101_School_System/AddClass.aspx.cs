using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HTTP5101_School_System
{
    public partial class AddClass : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (Page.IsPostBack)
            {
                
                string add_classcode = classcode_input.Text;
                string add_teacherid = teacherid_input.Text;
                string add_startdate = startdate_input.Text;
                string add_finishdate = finishdate_input.Text;
                string add_classname = classname_input.Text;

                string query = "insert into classes(classcode, teacherid, startdate, finishdate, classname) values('" + add_classcode + "'," + "'" + add_teacherid + "'," + "'" + add_startdate + "'," + "'" + add_finishdate + "'," + "'" + add_classname + "')";
                sql_debugger.InnerHtml = query;

                if (Page.IsPostBack)
                {

                    var db = new SCHOOLDB();
                    db.PerformCRUD(query);
                    classes_result.InnerHtml += "Class Added" ;
                    classes_result.InnerHtml += "CLASSCODE : " + add_classcode;
                    classes_result.InnerHtml += "TEACHERID : " + add_teacherid;
                    classes_result.InnerHtml += "START DATE : " + add_startdate;
                    classes_result.InnerHtml += "FINISH DATE : " + add_finishdate;
                    classes_result.InnerHtml += "CLASSNAME : " + add_classname;

                    classes_result.InnerHtml += "<a href=\"ListClasses.aspx\">Back to class list</a>";
                }
                else
                {
                    Console.WriteLine("Error");
                }

            }
            
        }
    }
}