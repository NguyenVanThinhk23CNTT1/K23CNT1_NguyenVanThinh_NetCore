using Microsoft.AspNetCore.Mvc;
using NvtLab06.Models;
using System.Collections.Generic;
using System.Linq;

namespace NvtLab06.Controllers
{
    public class NvtEmployeeController : Controller
    {
        // Danh sách nhân viên lưu tạm
        public static List<NvtEmployee> employees = new List<NvtEmployee>
        {
            new NvtEmployee { NvtId = "NV01", NvtName = "Nguyễn Văn An", NvtBirthDay = "1990-01-15", NvtEmail = "an.nguyen@example.com", NvtPhone = "0912345678", NvtSalary = "15000000", NvtStatus = "Đang làm việc" },
            new NvtEmployee { NvtId = "NV02", NvtName = "Trần Thị Bình", NvtBirthDay = "1992-05-10", NvtEmail = "binh.tran@example.com", NvtPhone = "0987654321", NvtSalary = "16000000", NvtStatus = "Nghỉ thai sản" },
            new NvtEmployee { NvtId = "NV03", NvtName = "Lê Văn Cường", NvtBirthDay = "1988-09-25", NvtEmail = "cuong.le@example.com", NvtPhone = "0909123456", NvtSalary = "17000000", NvtStatus = "Đang làm việc" },
            new NvtEmployee { NvtId = "NV04", NvtName = "Phạm Thị Dung", NvtBirthDay = "1995-12-30", NvtEmail = "dung.pham@example.com", NvtPhone = "0934567890", NvtSalary = "14000000", NvtStatus = "Đã nghỉ việc" },
            new NvtEmployee { NvtId = "NV05", NvtName = "Nguyễn Văn Thịnh", NvtBirthDay = "2005-04-16", NvtEmail = "thinhvannguyen113@gmail.com", NvtPhone = "0343841426", NvtSalary = "90000$", NvtStatus = "Đang làm việc" }
        };

        public IActionResult Index()
        {
            return View(employees);
        }

        [HttpGet]
        public IActionResult NvtCreate()
        {
            return View();
        }

        [HttpPost]
        public IActionResult NvtCreateSubmit(NvtEmployee newEmp)
        {
            if (ModelState.IsValid)
            {
                employees.Add(newEmp);
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult NvtEdit(string id)
        {
            var emp = employees.FirstOrDefault(e => e.NvtId == id);
            if (emp == null) return NotFound();
            return View(emp);
        }

        [HttpPost]
        public IActionResult NvtEditSubmit(NvtEmployee editedEmp)
        {
            var emp = employees.FirstOrDefault(e => e.NvtId == editedEmp.NvtId);
            if (emp != null)
            {
                emp.NvtName = editedEmp.NvtName;
                emp.NvtBirthDay = editedEmp.NvtBirthDay;
                emp.NvtEmail = editedEmp.NvtEmail;
                emp.NvtPhone = editedEmp.NvtPhone;
                emp.NvtSalary = editedEmp.NvtSalary;
                emp.NvtStatus = editedEmp.NvtStatus;
            }
            return RedirectToAction("Index");
        }

        public IActionResult NvtDelete(string id)
        {
            var emp = employees.FirstOrDefault(e => e.NvtId == id);
            if (emp != null)
            {
                employees.Remove(emp);
            }
            return RedirectToAction("Index");
        }
    }
}
