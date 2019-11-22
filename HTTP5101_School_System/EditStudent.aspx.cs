using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HTTP5101_School_System
{
    public partial class EditStudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                Page.Validate();
                if (Page.IsValid)
                {
                    string student_record = Request.QueryString["studentid"];
                    var database = new SCHOOLDB();
                    string student_firstname = student_fname.Text;
                    string student_lastname = student_lname.Text;
                    string student_id_number = student_number.Text;
                    string student_enrollement_date = enrollment_date.Text;
                    string query = "update students set studentfname = \"" + student_firstname + "\" , studentlname = \"" +
                        student_lastname + "\", studentnumber =\"" + student_id_number + "\", enrolmentdate =\"" + student_enrollement_date + "\" where studentid = \"" + student_record + "\"";
                    database.PerformCRUD(query);
                    Response.Redirect("ListStudents.aspx");
                }
            }
            bool valid = true;
            string studentid = Request.QueryString["studentid"];
            if (String.IsNullOrEmpty(studentid)) valid = false;

            if (valid)
            {
                var db = new SCHOOLDB();
                Dictionary<String, String> student_record = db.FindStudent(Int32.Parse(studentid));

                if (student_record.Count > 0)
                {
                    student_fname.Text = student_record["STUDENTFNAME"];
                    student_lname.Text = student_record["STUDENTLNAME"];
                    student_number.Text = student_record["STUDENTNUMBER"];
                    enrollment_date.Text = "2019/11/22";
                }
                else
                {
                    valid = false;
                }
            }

            if (!valid)
            {
                student.InnerHtml = "There was an error finding that student!.";
            }
        }

        //public void Update_Student(object sender, EventArgs e)
        //{
        //    if (Page.IsPostBack)
        //    {
        //        string student_record = Request.QueryString["studentid"];
        //        var database = new SCHOOLDB();
        //        string student_firstname = student_fname.Text;
        //        string student_lastname = student_lname.Text;
        //        string student_id_number = student_number.Text;
        //        string student_enrollement_date = enrollment_date.Text;
        //        string query = "update students set studentfname = \"" + student_firstname + "\" , studentlname = \"" +
        //            student_lastname + "\", studentnumber =\"" + student_id_number + "\", enrolmentdate =\"" + student_enrollement_date + "\" where studentid = \"" + student_record + "\"";
        //        database.PerformCRUD(query);
        //        Response.Redirect("ListStudents.aspx");
        //    }
        //}
    }
}