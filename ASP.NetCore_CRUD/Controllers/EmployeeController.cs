using ASP.NetCore_CRUD.Data;
using ASP.NetCore_CRUD.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NetCore_CRUD.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly AppDbContext _context;
        public EmployeeController(AppDbContext _context)
        {
            this._context = _context;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return View(await _context.Employees.ToListAsync());
        }

        [HttpGet]
        public  IActionResult AddOrEdit(int id = 0)
        {
            if (id == 0)
                return View(new Employee());
            else return View( _context.Employees.Find(id));
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public async Task<IActionResult> AddOrEdit([Bind("Id,EmployeeCode,FullName,Position,OfficeLocation")] Employee employee)
        {
            if (ModelState.IsValid)
            {
                if (employee.Id == 0)
                {
                    _context.Employees.Add(employee);
                }
                else
                {
                    _context.Employees.Update(employee);
                }
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(employee);
        }

     
        public async Task<IActionResult> Delete(int id)
        {
           
            _context.Employees.Remove(await _context.Employees.FindAsync(id));
            await _context.SaveChangesAsync();
            return  RedirectToAction(nameof(Index));
        }
    }
}
