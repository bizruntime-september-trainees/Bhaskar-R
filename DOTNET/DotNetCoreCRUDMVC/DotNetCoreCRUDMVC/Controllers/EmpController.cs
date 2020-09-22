using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DotNetCoreCRUDMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace DotNetCoreCRUDMVC.Controllers
{
   
    public class EmpController : Controller
    {
        private readonly ApplicationDbContext _db;
        public EmpController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var displayData = _db.EmployeeTable.ToList();
            return View(displayData);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(NewEmpClass nec)
        {
            if(ModelState.IsValid)
            {
                _db.Add(nec);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(nec);
        }
        
        public async Task<IActionResult> Edit(int? id)
        {
            if(id==null)
            {
                return RedirectToAction("Index");
            }
            var getEmpDetails = await _db.EmployeeTable.FindAsync(id);
            return View(getEmpDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(NewEmpClass nc)
        {
            if(ModelState.IsValid)
            {
                _db.Update(nc);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(nc);
        }
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            var getEmpDetails = await _db.EmployeeTable.FindAsync(id);
            return View(getEmpDetails);
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            var getEmpDetails = await _db.EmployeeTable.FindAsync(id);
            return View(getEmpDetails);
        }
        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var getEmpDetails = await _db.EmployeeTable.FindAsync(id);
            _db.EmployeeTable.Remove(getEmpDetails);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}

