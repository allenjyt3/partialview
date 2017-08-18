using PartialViewEmp040817.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace PartialViewEmp040817.Controllers
{
    public class EmpController : Controller
    {
        // GET: Emp
        public ActionResult Index()
        {
            List<EmployeeModel> emplist1 = GetEmployeesList();

            return View(emplist1);
        }


        public List<EmployeeModel> GetEmployeesList()
        {
            SqlConnection con = new SqlConnection("Data Source=SUYPC194; Initial Catalog=School;Integrated Security=true");
            con.Open();
            SqlDataAdapter ad = new SqlDataAdapter("select * from tbl_Employees", con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            List<EmployeeModel> emplist = new List<EmployeeModel>();
            foreach(DataRow dr in dt.Rows)
            {
                EmployeeModel model = new EmployeeModel();
                model.EmpId = Convert.ToInt32(dr["Empid"]);
                model.EmpName = Convert.ToString(dr["Empid"]);
                model.Address = Convert.ToString(dr["Address"]);
                model.Salary = Convert.ToDecimal(dr["Salary"]);
                emplist.Add(model);

            }
           
            return emplist;
          
        } 

        public ActionResult GetEmployees()
        {
            
            List<EmployeeModel> emplist1 = GetEmployeesList();
          // throw new Exception("THIS IS ERROR");
            return PartialView("EmpDisplay", emplist1);

        }
      
    }
}