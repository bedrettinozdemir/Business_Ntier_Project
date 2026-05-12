using Business_Layer.Concrete;
using Data_Access.EntityFramework;
using Entity_Layer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Business_Ntier_Project.Controllers
{
    public class ProductController : Controller
    {
        ProductManager pm = new ProductManager(new EFProductDal());
        public IActionResult Index()
        {
            
            var values = pm.TGetlist();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddProduct() 
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddProduct(Product p) 
        {
           
            pm.TInsert(p);
            return RedirectToAction("Index");
                
        }

        public IActionResult DeleteProduct(int id) 
        {
            var values = pm.TGetById(id);
            pm.TDelete(values);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateProduct(int id) 
        {
            var values = pm.TGetById(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateProduct(Product p) 
        {
            pm.TUpdate(p);
            return RedirectToAction("Index");
        }


    }
}
