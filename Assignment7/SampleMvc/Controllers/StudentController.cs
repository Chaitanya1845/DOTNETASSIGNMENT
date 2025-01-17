﻿using SampleMvc;
using SampleMvc.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SampleMvc.data;

namespace SampleMvc.Controllers
{
    public class StudentController : Controller
    {

        public readonly ApplicationDbContext _db;

        public StudentController(ApplicationDbContext db)
        {
            _db = db;
        }

        private void PopulateSubjectsDropDownList(object selectedSubject = null)
        {
            var subjectsQuery = from s in _db.Subject
                                orderby s.Subject_Name
                                select new { SubjectID = s.SubjectID, s.Subject_Name };

            ViewBag.SubjectID = new SelectList(subjectsQuery.AsNoTracking(), "SubjectID", "Subject_Name", selectedSubject);

        }

        // public IActionResult Index()
        // {

        //     IEnumerable<Student> objList = _db.Student;
        //     return View(objList);
        // }

        public IActionResult Index(string searchString)
        {

            IEnumerable<Student> objList = _db.Student;
            // IEnumerable<StudentSubject> objList = (from std in _db.Student
            //                                        join sub in _db.Subject on std.SubjectID equals sub.SubjectID
            //                                        select new IEnumerable<StudentSubject> { std.StudentId, std.Name, std.Class, sub.Subject_Name }).ToList();
            if (!String.IsNullOrEmpty(searchString))
            {
                objList = objList.Where(s => s.Name.Contains(searchString));
                Console.WriteLine("valid");

            }
            else
            {
                Console.WriteLine("Invalid");
            }
            return View(objList);
        }


        //Get Create
        public IActionResult Create()
        {
            PopulateSubjectsDropDownList();
            return View();
        }


        [HttpPost]
        public IActionResult Create([Bind("Name,Class,SubjectID")] Student studobj)
        {
            Console.WriteLine(studobj);
            if (ModelState.IsValid)
            {
                _db.Student.Add(studobj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
                Console.WriteLine("Invalid");

            return View(studobj);
        }

        //Get Create
        [HttpGet]
        public IActionResult Edit(int id)
        {

            PopulateSubjectsDropDownList();
            var studobj = _db.Student.Find(id);
            return View(studobj);
        }


        [HttpPost]
        public IActionResult Edit(Student obj)
        {
            if (ModelState.IsValid)
            {
                _db.Student.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        //Get Delete
        public IActionResult Delete(int id)
        {

            var studobj = _db.Student.Find(id);
            return View(studobj);
        }


        [HttpPost]
        public IActionResult DeletePost(int studentid)
        {
            var studobj = _db.Student.Find(studentid);

            if (ModelState.IsValid)
            {

                _db.Student.Remove(studobj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(studobj);
        }
    }
}
