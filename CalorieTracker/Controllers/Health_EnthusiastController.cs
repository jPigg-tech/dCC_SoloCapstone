﻿using CalorieTracker.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CalorieTracker.Controllers
{
    public class Health_EnthusiastController : Controller
    {
        private readonly ApplicationDbContext _context;

        public Health_EnthusiastController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: HomeController1
        public ActionResult Index()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var healthEnthusiast = _context.Health_Enthusiasts.Where(c => c.IdentityUserId ==
            userId).SingleOrDefault();
            if (healthEnthusiast == null)
            {
                return RedirectToAction(nameof(Create));
            }
            //var employerJobs = _context.Jobs.Where(c => c.EmployerId == employer.EmpId).ToList();
            //ViewBag.Id = employer.EmpId;
            //if (employerJobs.Count == 0)
            //{
            //    return RedirectToAction("CreateJob", new { id = employer.EmpId });
            //}
            //return View(employerJobs);
            return View();
        }

        // GET: HomeController1/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var healthEnthusiast = _context.Health_Enthusiasts.SingleOrDefault(m => m.Id == id);
            return View(healthEnthusiast);
        }

        // GET: HomeController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HomeController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HomeController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HomeController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HomeController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HomeController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
