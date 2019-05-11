﻿using DoctorRecommendationProject.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DoctorRecommendationProject.Controllers
{
    public class HospitalController : Controller
    {
        HospitalRepository ur = new HospitalRepository();
        // GET: Hospital
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult HospitalList()
        {
            var list = ur.List();
            return Json(list, JsonRequestBehavior.AllowGet);
        }


            // GET: Hospital/Details/5
            public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Hospital/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Hospital/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Hospital/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Hospital/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Hospital/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Hospital/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
