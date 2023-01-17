using System.Reflection.PortableExecutable;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

using emp;
using dal;
namespace NewMvc.Controllers;

public class EmployeeController : Controller
{
    private readonly ILogger<EmployeeController> _logger;

    public EmployeeController(ILogger<EmployeeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        List<Employee> list=DbManager.getallemp();
        ViewBag.insert=list;
        return View();
    }
    

    public IActionResult Registarion(){
        return View();
    }
    [HttpPost]
    public IActionResult  insert(Employee emp){
       
       if(!ModelState.IsValid){

               
          return View();

        }
        DbManager.insertemp(emp);
        return RedirectToAction("Index");
    }
    public IActionResult update(int eid)
    {
        Employee e=DbManager.findemp(eid);
        
        Console.WriteLine("eeeeeee"+eid);
        ViewBag.update=e;
      
        return View();
    }
    public IActionResult updatee(Employee e)
    {
        Console.WriteLine("upd 2"+e.eid);
        DbManager.updateemp(e);
        return RedirectToAction("Index");
    }
    public IActionResult delete(int ssn)
    {
        Console.WriteLine("dfghj"+ssn);
        DbManager.delemp(ssn);
        return RedirectToAction("Index");
    }
    
      public IActionResult find(int eidd)
    {
        Console.WriteLine("dfghj"+eidd);
       Employee e= DbManager.findemp(eidd);
       
        ViewBag.find=e;
        return View();
    }
 
}
