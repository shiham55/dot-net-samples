using System.Web.Mvc;
using DotNetSamples.Data;
using DotNetSamples.Entities;

namespace QuotesWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            using (UnitOfWork _uow = new UnitOfWork())
            {
                Quotes quote = _uow.QuotesRepository.GetActiveRandomQuote();

                ViewBag.Quotes = _uow.QuotesRepository.Get();                
            }
            return View();
        }
    }
}