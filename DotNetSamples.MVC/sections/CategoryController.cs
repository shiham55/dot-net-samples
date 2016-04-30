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
    public class CategoryController : Controller
    {
        //private ShopAdminContext db = new ShopAdminContext();
		private CategoryService _categoryService = new CategoryService();
		
		// GET: Category
        public ActionResult Index()
        {
			IEnumerable<Category> primaryCategories =  _categoryService.GetCategoriesByType( CategoryType.Primary );
            return View( primaryCategories );
        }

        // GET: Category/Details/5
        public ActionResult Details(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //Category category = db.Categories.Find(id);

			Category category = _categoryService.GetById(id);
			
            if (category == null)
            {
                return HttpNotFound();
            }
            return View(category);
        }

        // GET: Category/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Category/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,name,url_key,meta_title,meta_keywords,meta_description,order,type")] Category category)
        {
            if (ModelState.IsValid)
            {
				_categoryService.Insert(category);

                return RedirectToAction("Index");
            }

            return View(category);
        }

        // GET: Category/Edit/5
        public ActionResult Edit(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //Category category = db.Categories.Find(id);
			Category category = _categoryService.GetById(id);
            if (category == null)
            {
                return HttpNotFound();
            }
            return View(category);
        }

        // POST: Category/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,name,url_key,meta_title,meta_keywords,meta_description,order,type")] Category category)
        {
            if (ModelState.IsValid)
            {
				//db.Entry(category).State = EntityState.Modified;
				//db.SaveChanges();

				//_categoryService.ServiceContext.

                return RedirectToAction("Index");
            }
            return View(category);
        }

        // GET: Category/Delete/5
        public ActionResult Delete(int? id)
		{
		//	if (id == null)
		//	{
		//		return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
		//	}
		//	Category category = db.Categories.Find(id);
		//	if (category == null)
		//	{
		//		return HttpNotFound();
		//	}
		//	return View(category);
				return View();
        }

        // POST: Category/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            //Category category = _categoryService.GetById(id);
            _categoryService.Delete(id);

            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
			//if (disposing)
			//{
			//	db.Dispose();
			//}
			//base.Dispose(disposing);
        }
    }
}
