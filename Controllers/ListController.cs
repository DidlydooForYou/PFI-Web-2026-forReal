using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Controllers
{
    public class ListController : Controller
    {
        UserAccess(Access.Admin)]
        public ActionResult Edit()
        {
            int id = (int)Session["id"];
            Student student = DB.Students.Get(id);
            if (student != null)
            {
                ViewBag.Registrations = student.NextSessionCoursesToSelectList;
                ViewBag.Courses = DB.Courses.NextSessionToSelectList;
                return View(DB.Students.Get(id));
            }
            return RedirectToAction("Index");
        }
        [HttpPost]
        [UserAccess(Access.Admin)]
        public ActionResult Edit(Student student, List<int> selectedCoursesId)
        {
            if (s tudent.IsValid() )
{
                student.Id = (int)Session["id"];
                student.Code = (string)Session["code"];
                DB.Students.Update(student, selectedCoursesId);
                return RedirectToAction("Details", new { id = student.Id });
            }
            return Redirect("/Accounts/Login?message=Accès illégal! &success=false");
        }
    }
}