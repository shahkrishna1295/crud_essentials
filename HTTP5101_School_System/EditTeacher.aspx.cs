using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HTTP5101_School_System
{
    public partial class EditTeacher : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                Page.Validate();
                if (Page.IsValid)
                {
                    string teacher_record = Request.QueryString["teacherid"];
                    var database = new SCHOOLDB();
                    string teacher_firstname = teacher_fname.Text;
                    string teacher_lastname = teacher_lname.Text;
                    string teacher_employee_number = employee_number.Text;
                    string teacher_hiredate = hire_date.Text;
                    DateTime dt = DateTime.ParseExact(teacher_hiredate, "yyyy-MM-dd hh:mm:ss tt",
                                           CultureInfo.InvariantCulture);
                    string teacher_salary = salary.Text;
                    string query = "update teachers set teacherfname = \"" + teacher_firstname +  "\" , teacherlname = \"" +
                        teacher_lastname + "\", employeenumber =\"" + teacher_employee_number + "\", salary =\"" + teacher_salary + "\" where teacherid = \"" + teacher_record + "\"";
                    database.PerformCRUD(query);
                }
            }
            bool valid = true;
            string teacherid = Request.QueryString["teacherid"];
            if (String.IsNullOrEmpty(teacherid)) valid = false;

            if (valid)
            {
                var db = new SCHOOLDB();
                Dictionary<String, String> teacher_record = db.FindTeacher(Int32.Parse(teacherid));

                if (teacher_record.Count > 0)
                {
                    teacher_fname.Text = teacher_record["TEACHERFNAME"];
                    teacher_lname.Text = teacher_record["TEACHERLNAME"];
                    employee_number.Text = teacher_record["EMPLOYEENUMBER"];
                    hire_date.Text = teacher_record["HIREDATE"];
                    salary.Text = teacher_record["SALARY"];
                }
                else
                {
                    valid = false;
                }
            }

            if (!valid)
            {
                teacher.InnerHtml = "There was an error finding that teacher!.";
            }
        }
    }
}