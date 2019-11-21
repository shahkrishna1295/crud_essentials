using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HTTP5101_School_System
{
    public partial class ListClasses : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            //resets the result set window
            classes_result.InnerHtml = "";
            string query = "select * from classes";
            string searchkey = "";

            if (Page.IsPostBack)
            {
                //WARNING: This technique is vulnerable to SQL injections
                //read more about SQL injections
                //https://www.csoonline.com/article/3257429/what-is-sql-injection-how-sqli-attacks-work-and-how-to-prevent-them.html
                //we will learn to defend against these attacks next semester
                searchkey = class_search.Text;
            }
            if (searchkey != "")
            {
                query += " WHERE CLASSCODE like '%" + searchkey + "%' ";
                query += " or CLASSNAME like '%" + searchkey + "%' ";
                query += " or TEACHERID like '%" + searchkey + "%' ";
            }
            sql_debugger.InnerHtml = query;
            
            var db = new SCHOOLDB();
            classes_result.InnerHtml += "<div id=\"add_button\"><a href=\"AddClass.aspx\"></a></div>";
            List<Dictionary<String, String>> rs = db.List_Query(query);
            foreach (Dictionary<String, String> row in rs)
            {
                classes_result.InnerHtml += "<div class=\"listitem\">";

                string classid = row["CLASSID"];
                classes_result.InnerHtml += "<div class=\"col6\">" + classid + "</div>";

                string classcode = row["CLASSCODE"];
                classes_result.InnerHtml += "<div class=\"col6\">" + classcode + "</div>";

                string teacherid = row["TEACHERID"];
                classes_result.InnerHtml += "<div class=\"col6\">" + teacherid + "</div>";

                string startdate = row["STARTDATE"];
                classes_result.InnerHtml += "<div class=\"col6\">" + startdate + "</div>";

                string finishdate = row["FINISHDATE"];
                classes_result.InnerHtml += "<div class=\"col6\">" + finishdate + "</div>";

                string classname = row["CLASSNAME"];
                classes_result.InnerHtml += "<div class=\"col6last\">" + classname + "</div>";

                classes_result.InnerHtml += "</div>";
            }
        }
    }
}