﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//make sure your final project has these
using MySql.Data.MySqlClient;
using System.Diagnostics;


namespace HTTP5101_School_System
{
    public partial class ListStudents : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /*
                An alternate way to fetch data without the SCHOOLDB.cs class
                https://dev.mysql.com/doc/connector-net/en/connector-net-tutorials-sql-command.html
            */

            //resets the result set window
            students_result.InnerHtml = "";

            string searchkey = "";
            if (Page.IsPostBack)
            {
                //WARNING: This technique is vulnerable to SQL injections
                //read more about SQL injections
                //https://www.csoonline.com/article/3257429/what-is-sql-injection-how-sqli-attacks-work-and-how-to-prevent-them.html
                //we will learn to defend against these attacks next semester
                searchkey = student_search.Text;
            }

            
            string query = "select * from STUDENTS";

            if (searchkey != "")
            {
                query += " WHERE STUDENTFNAME like '%"+searchkey+"%' ";
                query += " or STUDENTLNAME like '%"+searchkey+"%' ";
                query += " or STUDENTNUMBER like '%"+searchkey+"%' ";
            }
            //sql_debugger.InnerHtml = query;
            
            var db = new SCHOOLDB();
            
            List<Dictionary<String,String>> rs = db.List_Query(query);
            foreach(Dictionary<String,String> row in rs)
            {
                students_result.InnerHtml += "<div class=\"listitem\">";

                string studentid = row["STUDENTID"];

                string studentfirstname = row["STUDENTFNAME"];
                students_result.InnerHtml += "<div class=\"col6\"><a href=\"ShowStudent.aspx?studentid="+studentid+"\">" + studentfirstname + "</a></div>";

                string studentlastname = row["STUDENTLNAME"];
                students_result.InnerHtml += "<div class=\"col6\">" + studentlastname + "</div>";

                string studentnumber = row["STUDENTNUMBER"];
                students_result.InnerHtml += "<div class=\"col6\">" + studentnumber + "</div>";

                string enrolmentdate = row["ENROLMENTDATE"];
                students_result.InnerHtml += "<div class=\"col6\">" + enrolmentdate + "</div>";
                
               
                students_result.InnerHtml += "<div class=\"col6\"><a href=\"DelStudents.aspx?studentid=" + studentid+ "\">"+"<button type=\"button\">Delete</button></a></div>";
                students_result.InnerHtml += "<div class=\"col6last\"><a href=\"EditStudent.aspx?studentid=" + studentid + "\"> <button type=\"button\">Edit</button></a></div>";
                students_result.InnerHtml += "</div>";

            }  
        }
        protected void Add_Student(object sender, EventArgs e)
        {
            Response.Redirect("AddStudent.aspx");
        }

        protected void Edit_Student(object sender, EventArgs e)
        {
            Response.Redirect("EditStudent.aspx");
        }
    }
}