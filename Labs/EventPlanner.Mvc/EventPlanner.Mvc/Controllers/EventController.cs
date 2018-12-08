/*
 * Marissa Greise
 * ITSE 1430 
 * 12/5/2018
 */
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EventPlanner.Mvc.App_Start;
using EventPlanner.Mvc.Models;

namespace EventPlanner.Mvc.Controllers
{
    public class EventController : Controller
    {
        public EventController()
        {
            
        }

        [HttpGet]
        public ActionResult My()
        {
            var items = DatabaseFactory.GetEvents();

            return View(items.Select(i => new EventModel(i)));
            //return View("Index");
        }
        
        [HttpGet]
        public ActionResult Create()
        {
            var model = new EventModel();

            return View(model);
        }

        //[HttpGet]
        //public ActionResult Edit( int id )
        //{
        //    var item = _database.GetAll().FirstOrDefault(i => i.Id == id);

        //    return View(new EventModel(item));
        //}

        //[HttpPost]
        //public ActionResult Edit( EventModel model )
        //{
        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            var item = model.ToDomain();

        //            var existing = _database.GetAll()
        //                                .FirstOrDefault(i => i.Id == model.Id);
        //            _database.Edit(existing.Name, item);

        //            return RedirectToAction("Index");
        //        } catch (Exception e)
        //        {
        //            ModelState.AddModelError("", e.Message);
        //        };
        //    };

        //    return View(model);
        //}

        //[HttpPost]
        //public ActionResult Create( EventModel model )
        //{
        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            var item = model.ToDomain();

        //            _database.Add(item);

        //            return RedirectToAction("Index");
        //        } catch (Exception e)
        //        {
        //            ModelState.AddModelError("", e.Message);
        //        };
        //    };

        //    return View(model);
        //}

        //[HttpGet]
        //public ActionResult Delete( int id )
        //{
        //    var item = _database.GetAll().FirstOrDefault(i => i.Id == id);

        //    return View(new EventModel(item));
        //}

        //[HttpPost]
        //public ActionResult Delete( EventModel model )
        //{
        //    try
        //    {
        //        var existing = _database.GetAll().FirstOrDefault(i => i.Id == model.Id);
        //        if (existing == null)
        //            return HttpNotFound();

        //        _database.Remove(existing.Name);

        //        return RedirectToAction("Index");
        //    } catch (Exception e)
        //    {
        //        ModelState.AddModelError("", e.Message);
        //        return View(model);
        //    };
        //}

        private readonly IEventDatabase _eventDatabase;
    }
}
