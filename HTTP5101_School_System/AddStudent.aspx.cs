using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HTTP5101_School_System
{
    public partial class AddStudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (Page.IsPostBack)
            //{

            //    string student_fname = fname_input.Text;
            //    string student_lname = lname_input.Text;
            //    string student_number = studentno_input.Text;
            //    string enrolment_date = enroldate_input.Text;
                

            //    string query = "insert into students(STUDENTFNAME, STUDENTLNAME, STUDENTNUMBER, ENROLMENTDATE) values('" + student_fname + "'," + "'" + student_lname + "'," + "'" + student_number + "'," + "'" + enrolment_date + "'," + "')";
            //    sql_debugger.InnerHtml = query;


            //    var db = new SCHOOLDB();
            //    db.PerformCRUD(query);
            //    students_result.InnerHtml += "Student Added";
            //    students_result.InnerHtml += "STUDENTFNAME : " + student_fname;
            //    students_result.InnerHtml += "STUDENTLNAME : " + student_lname;
            //    students_result.InnerHtml += "STUDENTNUMBER : " + student_number;
            //    students_result.InnerHtml += "ENROLMENTDATE : " + enrolment_date;
                    

            //}
            //else
            //{
            //    Console.WriteLine("Error");
            //}


        }

        public void Save_Student(object sender, EventArgs e)
        {
            string student_fname = fname_input.Text;
            string student_lname = lname_input.Text;
            string student_number = studentno_input.Text;
            string enrolment_date = enroldate_input.Text;
            string query = "insert into students(STUDENTFNAME, STUDENTLNAME, STUDENTNUMBER, ENROLMENTDATE) values('" + student_fname + "'," + "'" + student_lname + "'," + "'" + student_number + "'," + "'" + enrolment_date  + "')";
            var db = new SCHOOLDB();
            db.PerformCRUD(query);
            Response.Redirect("ListStudents.aspx");
        }
    }
}