using Microsoft.AspNetCore.Mvc;
using NvtLession07.Models;
using System.Collections.Generic;
using System.Linq;

namespace NvtLession07.Controllers
{
    public class NvtEmployeeController : Controller
    {
        // Dữ liệu tĩnh 5 nhân viên
        private static List<NvtEmployee> employees = new List<NvtEmployee>()
        {
            new NvtEmployee { NvtId = 1, NvtName = "Nguyen Van A", NvtBirthDay = "1990-01-01", Email = "a@example.com", NvtPhone = "0123456789" },
            new NvtEmployee { NvtId = 2, NvtName = "Tran Thi B", NvtBirthDay = "1992-02-02", Email = "b@example.com", NvtPhone = "0987654321" },
            new NvtEmployee { NvtId = 3, NvtName = "Le Van C", NvtBirthDay = "1988-03-03", Email = "c@example.com", NvtPhone = "0912345678" },
            new NvtEmployee { NvtId = 4, NvtName = "Pham Thi D", NvtBirthDay = "1995-04-04", Email = "d@example.com", NvtPhone = "0999888777" },
            new NvtEmployee { NvtId = 5, NvtName = "Hoang Van E", NvtBirthDay = "1991-05-05", Email = "e@example.com", NvtPhone = "0900777666" }
        };

        // GET: NvtIndex
        public IActionResult NvtIndex()
        {
            return View(employees);
        }

        // GET: NvtDetails
        public IActionResult NvtDetails(int id)
        {
            var emp = employees.FirstOrDefault(e => e.NvtId == id);
            if (emp == null)
            {
                return NotFound();
            }
            return View(emp);
        }

        // GET: NvtCreate
        public IActionResult NvtCreate()
        {
            return View();
        }

        // POST: NvtCreate
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult NvtCreate(NvtEmployee employee)
        {
            if (ModelState.IsValid)
            {
                employee.NvtId = employees.Max(e => e.NvtId) + 1;
                employees.Add(employee);
                return RedirectToAction(nameof(NvtIndex));
            }
            return View(employee);
        }

        // GET: NvtEdit
        public IActionResult NvtEdit(int id)
        {
            var emp = employees.FirstOrDefault(e => e.NvtId == id);
            if (emp == null)
            {
                return NotFound();
            }
            return View(emp);
        }

        // POST: NvtEdit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult NvtEdit(int id, NvtEmployee employee)
        {
            if (id != employee.NvtId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var existingEmp = employees.FirstOrDefault(e => e.NvtId == id);
                if (existingEmp != null)
                {
                    existingEmp.NvtName = employee.NvtName;
                    existingEmp.NvtBirthDay = employee.NvtBirthDay;
                    existingEmp.Email = employee.Email;
                    existingEmp.NvtPhone = employee.NvtPhone;
                }
                return RedirectToAction(nameof(NvtIndex));
            }
            return View(employee);
        }

        // GET: NvtDelete
        public IActionResult NvtDelete(int id)
        {
            var emp = employees.FirstOrDefault(e => e.NvtId == id);
            if (emp == null)
            {
                return NotFound();
            }
            return View(emp);
        }

        // POST: NvtDelete
        [HttpPost, ActionName("NvtDelete")]
        [ValidateAntiForgeryToken]
        public IActionResult NvtDeleteConfirmed(int id)
        {
            var emp = employees.FirstOrDefault(e => e.NvtId == id);
            if (emp != null)
            {
                employees.Remove(emp);
            }
            return RedirectToAction(nameof(NvtIndex));
        }
    }
}
