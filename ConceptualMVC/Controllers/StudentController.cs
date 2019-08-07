using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using ConceptualMVC.Models;

namespace ConceptualMVC.Controllers
{
    public class StudentController : Controller
    {
        IList<Student> studentList = new List<Student>(){
            new Student() { StudentId = 1, StudentName = "John", Age = 18 } ,
            new Student() { StudentId = 2, StudentName = "Steve",  Age = 21 } ,
            new Student() { StudentId = 3, StudentName = "Bill",  Age = 25 } ,
            new Student() { StudentId = 4, StudentName = "Ram" , Age = 20 } ,
            new Student() { StudentId = 5, StudentName = "Ron" , Age = 31 } ,
            new Student() { StudentId = 4, StudentName = "Chris" , Age = 17 } ,
            new Student() { StudentId = 4, StudentName = "Rob" , Age = 19 }
        };

        // GET: Student
        public ActionResult  Index()
        {
           
            // Get the students from the database in the real application

            return View(studentList);
        }

        public ActionResult Edit(int id)
        {
            //Get the student from studentList sample collection for demo purpose.
            //Get the student from the database in the real application

            var std = studentList.Where(s => s.StudentId == id).FirstOrDefault();

            return View(std);
        }

        [HttpPost]
        public ActionResult Edit(Student std)
        {
            if (ModelState.IsValid)
            {
                //write code to update student
                ModelState.AddModelError(string.Empty, "Student Name already exists.");
                return RedirectToAction("Index");
            }
            
            return View(std);
        }
    }
}