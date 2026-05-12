using Business_Layer.Concrete;
using Data_Access.EntityFramework;
using Entity_Layer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.Blazor;

namespace Business_Ntier_Project.Controllers
{
   public class CategoryController : Controller
    {
        CategoryManager cm = new CategoryManager(new EFCategoryDal());
        public IActionResult Index()
        {
            var values = cm.TGetlist();

            return View(values);

        }

        [HttpGet]
        public IActionResult AddCategory()
        {
           
            return View();
        }

        [HttpPost]
        public IActionResult AddCategory(Category c) 
        {
            cm.TInsert(c);
            return RedirectToAction("Index");
            
        }

        public IActionResult DeleteCategory(int id) 
        {
            var values = cm.TGetById(id);

            cm.TDelete(values);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult  UpdateCategory(int id) 
        {
            var values = cm.TGetById(id);
            return View(values);

        }

        [HttpPost]
        public IActionResult UpdateCategory (Category c) 
        {
            cm.TUpdate(c);
            return RedirectToAction("Index");
        }

    }
    
}
