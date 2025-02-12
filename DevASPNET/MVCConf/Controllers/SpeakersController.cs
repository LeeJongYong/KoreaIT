﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVCConf.Data;
using MVCConf.Models;

namespace MVCConf.Controllers
{
    public class SpeakersController : Controller
    {
        private MVCConfContext db = new MVCConfContext();

        // GET: Speakers
        public ActionResult Index()
        {
            var speakers = db.Speakers.Include(s => s.room);
            return View(speakers.ToList());
        }

        // GET: Speakers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Speaker speaker = db.Speakers.Find(id);
            if (speaker == null)
            {
                return HttpNotFound();
            }
            return View(speaker);
        }

        // GET: Speakers/Create
        public ActionResult Create()
        {
            ViewBag.roomId = new SelectList(db.Rooms, "roomId", "name");
            return View();
        }

        // POST: Speakers/Create
        // 초과 게시 공격으로부터 보호하려면 바인딩하려는 특정 속성을 사용하도록 설정하세요. 
        // 자세한 내용은 https://go.microsoft.com/fwlink/?LinkId=317598을(를) 참조하세요.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "speakerId,name,roomId")] Speaker speaker)
        {
            if (ModelState.IsValid)
            {
                db.Speakers.Add(speaker);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.roomId = new SelectList(db.Rooms, "roomId", "name", speaker.roomId);
            return View(speaker);
        }

        // GET: Speakers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Speaker speaker = db.Speakers.Find(id);
            if (speaker == null)
            {
                return HttpNotFound();
            }
            ViewBag.roomId = new SelectList(db.Rooms, "roomId", "name", speaker.roomId);
            return View(speaker);
        }

        // POST: Speakers/Edit/5
        // 초과 게시 공격으로부터 보호하려면 바인딩하려는 특정 속성을 사용하도록 설정하세요. 
        // 자세한 내용은 https://go.microsoft.com/fwlink/?LinkId=317598을(를) 참조하세요.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "speakerId,name,roomId")] Speaker speaker)
        {
            if (ModelState.IsValid)
            {
                db.Entry(speaker).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.roomId = new SelectList(db.Rooms, "roomId", "name", speaker.roomId);
            return View(speaker);
        }

        // GET: Speakers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Speaker speaker = db.Speakers.Find(id);
            if (speaker == null)
            {
                return HttpNotFound();
            }
            return View(speaker);
        }

        // POST: Speakers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Speaker speaker = db.Speakers.Find(id);
            db.Speakers.Remove(speaker);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
