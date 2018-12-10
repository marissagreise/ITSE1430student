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

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult My()
        {
            EventCriteria ec = default(EventCriteria);
            ec.IncludePublic = true;
            ec.IncludePrivate = true;

            var events = DatabaseFactory.Database.GetAll(ec);

            return View(events.Select(e => new EventModel(e))
                .Where(e => e.EndDate > DateTime.Now)
                .OrderBy(e=> e.StartDate));

        }

        [HttpGet]
        public ActionResult Public()
        {
            EventCriteria ec = default(EventCriteria);
            ec.IncludePrivate = false;
            ec.IncludePublic = true;
            var events = DatabaseFactory.Database.GetAll(ec);
            return View(events.Select(e => new EventModel(e))
               .Where(e => e.EndDate > DateTime.Now)
               .OrderBy(e => e.StartDate));
        }

        [HttpGet]
        public ActionResult Details( int id )
        {
            var item = DatabaseFactory.Database.Get(id);

            return View(new EventModel(item));
        }


        [HttpGet]
        public ActionResult Create()
        {
            var model = new EventModel();
            model.StartDate = DateTime.Now;
            model.EndDate = DateTime.Now;
            return View(model);
        }
        [HttpPost]
        public ActionResult Create( EventModel model )
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var item = model.ToDomain();

                    DatabaseFactory.Database.Add(item);
                    if (item.IsPublic)
                        return RedirectToAction("Public");
                    else
                        return RedirectToAction("My");

                } catch (Exception e)
                {
                    ModelState.AddModelError("", e.Message);
                };
            };

            return View(model);
        }

        [HttpGet]
        public ActionResult Edit( int id )
        {
            var item = DatabaseFactory.Database.Get(id);

            return View(new EventModel(item));
        }

        [HttpPost]
        public ActionResult Edit( EventModel model )
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var item = model.ToDomain();
                    DatabaseFactory.Database.Update(item.Id, item);
                                        
                    if( item == null)
                        return HttpNotFound();

                    if(item.IsPublic)
                        return RedirectToAction("Public");
                    else
                        return RedirectToAction("My");
                } catch (Exception e)
                {
                    ModelState.AddModelError("", e.Message);
                };
            };

            return View(model);
        }

        [HttpGet]
        public ActionResult Delete( int id )
        {
            var item = DatabaseFactory.Database.Get(id);
       
            return View(new EventModel(item));
        }

        [HttpPost]
        public ActionResult Delete( EventModel model )
        {
            try
            {             
                var existing = DatabaseFactory.Database.Get(model.Id);

                if (existing == null)
                    return HttpNotFound();

                DatabaseFactory.Database.Remove(existing.Id);

                if (model.IsPublic)
                    return RedirectToAction("Public");
                else
                    return RedirectToAction("My");
            } catch (Exception e)
            {
                ModelState.AddModelError("", e.Message);
                return View(model);
            };
        }
    }
}
