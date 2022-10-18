using EmpManagementSystem.Models;
using EmpManagementSystem.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EmpManagementSystem.Controllers
{
    //6. Add employee controller
    //7. add emp folder for views
    //8. inject service
    public class EmployeeController : Controller
    {
        //CRUDRepository cRUDRepository=new CRUDRepository();
        private ICRUD cRUD;
        private IFileUploadService fileUploadService;
        public EmployeeController(ICRUD cRUD, IFileUploadService fileUploadService) // dependency injection
        {
            this.cRUD = cRUD; // get ref of CRUDRepository
            this.fileUploadService = fileUploadService;
        }
        //9. write indexmodel and logic in index method
        //10. add index view in employee folder
        [Authorize(Roles ="Employee")]
       // [Authorize(Roles ="Admin")]
        public IActionResult Index()
        {
            IndexViewModel model = new IndexViewModel();
            model.Employees = cRUD.GetEmployees();
            
            return View(model);
        }

        //11. add details action

        // by default methods are get
        [Authorize(Roles ="Admin")]
        public IActionResult Create()
        {
            Employee employee = new Employee();
            employee.Id = cRUD.GetMaxId();
            return View(employee);
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult> Create(Employee obj,IFormFile file)
        {

            if(ModelState.IsValid)
            {
               
                if(await fileUploadService.UploadFile(file))
                {
                    obj.ImageName = fileUploadService.FileName;
                    cRUD.AddEmployee(obj);
                    return RedirectToRoute(new { Action = "Index", Controller = "Employee" });
                }
                else
                {
                    ViewBag.ErrorMessage = "File Upload failed";
                    return View(obj);
                }
               // ViewBag.Message = "Employee added successfully!";
                
            }
            ViewBag.Message = "Error adding employee..";
            return View(obj);



            
          //  return View(obj);
        }
        // model binder maps the paramter id sent in the url
        [Authorize(Roles = "Employee")]
        public IActionResult Details(int? id)
        {
            var emp=cRUD.GetEmployee(id);
            if(emp==null)
            {
                return NotFound();
            }
            return View(emp);
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id)
        {
            var emp = cRUD.GetEmployee(id);
            return View(emp);
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public IActionResult Edit(Employee obj)
        {
            if(ModelState.IsValid)
            {
                cRUD.UpdateEmployee(obj);
                
                return RedirectToAction("Index");
            }
            // error in data
            ViewBag.Message = "Error editing employee..";
            return View(obj);
            
        }
        [Authorize(Roles = "Admin")]
        public IActionResult Delete(int id)
        {
            cRUD.DeleteEmployee(id);
            
         
            return RedirectToAction("Index");
        }


    }
}
