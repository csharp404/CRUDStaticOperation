using Microsoft.AspNetCore.Mvc;
using school.Models;

namespace school.Controllers
{
    public class StudentController : Controller
    {
        static List<StudentModel> students = new List<StudentModel>();
        
        public ActionResult Index (){



            if (students.Count() == 0)
            {
            students.Add(new StudentModel { Id = 1, Name = "test2", Age = 26, CourseName = "Science" });
                students.Add(new StudentModel { Id = 2, Name = "test2", Age = 26, CourseName = "Science" });
                students.Add(new StudentModel { Id = 3, Name = "test2", Age = 26, CourseName = "Science" });
            }

            return View(students);

        }

        [HttpGet]
        public ActionResult Create() { 
        return View();
        }
        [HttpPost]
        public ActionResult Create(StudentModel s)
        {
            s.Id = students[students.Count() - 1].Id+1;
            students.Add(s);
           return RedirectToAction("Index");
           
        }


        [HttpGet]
        public ActionResult edit(int id) {
            StudentModel student = students.Find(s => s.Id == id);
            return View(student);
        } 

        [HttpPost]
        public ActionResult edit(StudentModel s)
        {
            for (int i = 0; i < students.Count(); i++)
            {
                if (s.Id == students[i].Id)
                {
                    students[i] = s;
                    break;  
                }
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            for (int i = 0; i < students.Count(); i++)
            {
                if(id == students[i].Id)
                {
                    students.RemoveAt(i);
                }
            }

          
            return RedirectToAction("Index");
        }






    }
}
