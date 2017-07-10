using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication12.Models;

namespace WebApplication12.Controllers
{
    public class StudentAccountController : Controller
    {
        private McqsDatabaseEntities db = new McqsDatabaseEntities();
        int s_id = 1;
        public ActionResult Index()
        {
            /*entry in db.Takes on test.test_id equals entry.test_id*/
            var query = from test in db.Tests
                        join teacher in db.Teachers on test.t_id equals teacher.t_id
                        join student in db.Students on teacher.t_id equals student.t_id 
                        join entry in (from entry in db.Takes 
                            where entry.s_id != s_id
                            select entry) on test.test_id equals entry.test_id
                        where student.s_id == s_id 
                        select test;
            return View(query.ToList());
        }
        public ActionResult Results()
        {
            var query = from result in db.Takes
                        join test in db.Tests on result.test_id equals test.test_id
                        where result.s_id == s_id
                        select test;
            var query1 = from result in db.Takes
                         where result.s_id == s_id
                         select result;
            StudentTestResultViewModel vm = new StudentTestResultViewModel();
            vm.tests = query.ToList();
            vm.Takes = query1.ToList();
            return View(vm);
        }
        public ActionResult TakeTest()
        {
            return View();
        }
	}
}