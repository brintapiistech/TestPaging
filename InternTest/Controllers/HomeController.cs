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
        //ProductClassDataContext productClassDataContext = new ProductClassDataContext();
        BigdataDataContext Emploeedatacontext = new BigdataDataContext();
        IEnumerable <Employee> GetAllProducts(int pageNo)
        {
            //var products = from x in productClassDataContext.Products select x;
            //var countProduct = products.Count();
            var employees = from y in Emploeedatacontext.Employees select y;
            var Countlemployee = employees.Count();
            //var numberOfData = fetchedDataCount > 1000 ? Convert.ToInt32((fetchedDataCount / 510)) : 25;
            //int numberOfProduct = 0;
            int numberofemployee = 0;
            //if(countProduct > 1000)
            //{
            //    numberOfProduct = 50;
            //}
            //else
            //{
            //    numberOfProduct = 10;
            //}
            //var index = emp.Skip((pageNo - 1) * numberOfData).Take(numberOfData);

            var n = Countlemployee > 1000 ? numberofemployee = 50 : 20;
            var index = employees.Skip((pageNo - 1) * n).Take(n);
            ViewBag.Totalpage = Math.Ceiling(Countlemployee / Convert.ToSingle(n));

            return index;

        }
        public ActionResult Index(int id = 1)
        {
            var getProduct = GetAllProducts(id);
            return View(getProduct);
        }
        public ActionResult About()
        {
            int I = 0;

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}