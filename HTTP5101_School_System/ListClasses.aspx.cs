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
            string query = "select * from classes";

            var db = new SCHOOLDB();
            List<Dictionary<String, String>> rs = db.List_Query(query);
            foreach (Dictionary<String, String> row in rs)
            {
                classes_result.InnerHtml += "<div class=\"listitem\">";

                string classcode = row["CLASSCODE"];
                classes_result.InnerHtml += "<div class=\"col4\">" + classcode + "</div>";

                string startdate = row["STARTDATE"];
                classes_result.InnerHtml += "<div class=\"col4\">" + startdate + "</div>";

                string finishdate = row["FINISHDATE"];
                classes_result.InnerHtml += "<div class=\"col4\">" + finishdate + "</div>";

                string classname = row["CLASSNAME"];
                classes_result.InnerHtml += "<div class=\"col4last\">" + classname + "</div>";

                classes_result.InnerHtml += "</div>";
            }
        }
    }
}