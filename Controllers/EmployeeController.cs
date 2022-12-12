using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TrinhQuangMinhBTH2.Models;

namespace TrinhQuangMinhBTH2.Controllers;

public class EmployeeController : Controller
{
    private readonly ApplicationDbContext _context;
    public EmployeeController(ApplicationDbContext context)
    {
        _context = context;
    }
    // GET: Employee
    public async Task<IActionResult> Index()
    {
        return View(await _context.Employee.ToListAsync());
    }
    private bool EmployeeExists(string id)
    {
        return _context.Employee.Any(e => e.EmpID == id);
    }
}
public async Task<IActionResult>Upload()
{
    return View();
}
[HttpPost]
[ValidateAntiForgeryToken]
public async Task<IActionResult>Upload(IFormFile file)
{
    if (file!=null)
    {
        string fileExtension = Path.GetExtension(file.FileName);
        if (fileExtension !=".xls" && fileExtension !="xlsx")
        {
            ModelState.AddModelError("","Plaese choose excel file to upload!");
        }
        else
        {
            //rename file when upload to server
            var fileName = DateTime.Now.ToShortTimeString() + fileExtension;
            var filePath = Path.Combine(Directory.GetCurrentDirectory() + "/Upload/Excels", fileName);
            var fileLocation = new FileInfo(filePath).ToString();
            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                //save file to server
                await file.CopyToAsync(stream);
            } 
        }
    }
    return View();
}