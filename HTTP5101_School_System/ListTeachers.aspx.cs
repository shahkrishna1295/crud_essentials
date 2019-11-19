using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HTTP5101_School_System
{
    public partial class ListTeachers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            teachers_result.InnerHtml = "";
            string searchkey = "";
            if (Page.IsPostBack)
            {
                searchkey = teacher_search.Text;
            }
            string query = "select * from teachers";

            if (searchkey != "")
            {
                query += " WHERE TEACHERFNAME like '%" + searchkey + "%' ";
                query += " or TEACHERLNAME like '%" + searchkey + "%' ";
                query += " or EMPLOYEENUMBER like '%" + searchkey + "%' ";
            }
            var db = new SCHOOLDB();
            List<Dictionary<String, String>> rs = db.List_Query(query);
            foreach (Dictionary<String, String> row in rs)
            {
                teachers_result.InnerHtml += "<div class=\"listitem\">";

                string teacherfirstname = row["TEACHERFNAME"];
                teachers_result.InnerHtml += "<div class=\"col6\">" + teacherfirstname + "</div>";

                string teacherlastname = row["TEACHERLNAME"];
                teachers_result.InnerHtml += "<div class=\"col6\">" + teacherlastname + "</div>";

                string teachernumber = row["EMPLOYEENUMBER"];
                teachers_result.InnerHtml += "<div class=\"col6\">" + teachernumber + "</div>";

                string hiredate = row["HIREDATE"];
                teachers_result.InnerHtml += "<div class=\"col6\">" + hiredate + "</div>";

                string salary = row["SALARY"];
                teachers_result.InnerHtml += "<div class=\"col6\">" + salary + "</div>";

                teachers_result.InnerHtml += "<div class=\"col6last\"><a href=\"EditTeacher.aspx?teacherid=" +row["TEACHERID"] + "\"> <button type=\"button\">Edit</button></a></div>";
                teachers_result.InnerHtml += "</div>";
            }


        }
    }
}
