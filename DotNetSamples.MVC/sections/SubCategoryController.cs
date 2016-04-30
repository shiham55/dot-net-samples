using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Shop.DomainObject;
using Shop.Service;

namespace Shop.Admin.sections
{
    public class SubCategoryController : Controller
    {
        private ShopAdminContext db = new ShopAdminContext();

		CategoryService _categoryService = new CategoryService();

        // GET: SubCategory
        public ActionResult Index( int pid )
        {
            return View( _categoryService.GetSecondaryCategoriesByParentId( pid ) );
        }

        // GET: SubCategory/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Category category = db.Categories.Find(id);
            if (category == null)
            {
                return HttpNotFound();
            }
            return View(category);
        }

        // GET: SubCategory/Create
        public ActionResult Create(int pid )
        {
			ViewBag.parentcategoryId = pid;
			return View();
        }

        // POST: SubCategory/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,name,url_key,meta_title,meta_keywords,meta_description,order,type")] Category category, int pid)
        {
			Category parentcategory = _categoryService.GetById(pid);

            if (ModelState.IsValid)
            {
				if (parentcategory != null)
				{
					category.ParentCategory = parentcategory; 
				}


				_categoryService.Insert(category);

                return RedirectToAction("Index", new {pid = pid} );
            }

            return View(category);
        }

        // GET: SubCategory/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Category category = db.Categories.Find(id);
            if (category == null)
            {
                return HttpNotFound();
            }
            return View(category);
        }

        // POST: SubCategory/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,name,url_key,meta_title,meta_keywords,meta_description,order,type")] Category category)
        {
            if (ModelState.IsValid)
            {
                db.Entry(category).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(category);
        }

        // GET: SubCategory/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Category category = db.Categories.Find(id);
            if (category == null)
            {
                return HttpNotFound();
            }
            return View(category);
        }

        // POST: SubCategory/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
             Category category = _categoryService.GetById(id);
            _categoryService.Delete(category);

            return RedirectToAction("Category/Index");
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
