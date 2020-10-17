using InternTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebGrease.Css.Ast;

namespace InternTest.Controllers
{
    public class HomeController : Controller
    {
        ProductClassDataContext productClassDataContext = new ProductClassDataContext();
        IEnumerable <Product> GetAllProducts(int pageNo)
        {
            var products = from x in productClassDataContext.Products select x;
            var countProduct = products.Count();
            //var numberOfData = fetchedDataCount > 1000 ? Convert.ToInt32((fetchedDataCount / 510)) : 25;
            int numberOfProduct = 0;
            //if(countProduct > 1000)
            //{
            //    numberOfProduct = 50;
            //}
            //else
            //{
            //    numberOfProduct = 10;
            //}
            var n = countProduct > 1000 ? numberOfProduct = 50 : 20;
            //var index = emp.Skip((pageNo - 1) * numberOfData).Take(numberOfData);
            var index = products.Skip((pageNo - 1) * n).Take(n);
            return index;

        }
        public ActionResult Index()
        {
            var getProduct = GetAllProducts(1);
            return View(getProduct);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}