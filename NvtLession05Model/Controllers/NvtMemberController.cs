using Microsoft.AspNetCore.Mvc;
using NvtLession05Model.Models.DataModels;

namespace NvtLession05Model.Controllers
{
    public class NvtMemberController : Controller
    {
        // Dữ liệu giả lưu trong bộ nhớ (RAM)
        private static List<NvtMember> _nvtMembers = new List<NvtMember>
        {
            new NvtMember { NvtMemberId = Guid.NewGuid().ToString(), NvtUserName = "user1", NvtFullName = "Nguyễn Văn Lữ Bố", NvtPassword = "3333", NvtEmail = "nguyenvanlubo@gmail.com" },
            new NvtMember { NvtMemberId = Guid.NewGuid().ToString(), NvtUserName = "user2", NvtFullName = "Nguyễn Văn Thịnh", NvtPassword = "9999", NvtEmail = "nguyenvanthinh@gmail.com" }
        };

        // Hiển thị danh sách
        public IActionResult NvtGetMember()
        {
            return View(_nvtMembers);
        }

        // GET: Thêm mới
        public IActionResult Create()
        {
            return View();
        }

        // POST: Thêm mới
        [HttpPost]
        public IActionResult Create(NvtMember model)
        {
            model.NvtMemberId = Guid.NewGuid().ToString();
            _nvtMembers.Add(model);
            return RedirectToAction("NvtGetMember");
        }

        // GET: Sửa
        public IActionResult Edit(string id)
        {
            var member = _nvtMembers.FirstOrDefault(m => m.NvtMemberId == id);
            if (member == null) return NotFound();
            return View(member);
        }

        // POST: Sửa
        [HttpPost]
        public IActionResult Edit(NvtMember model)
        {
            var member = _nvtMembers.FirstOrDefault(m => m.NvtMemberId == model.NvtMemberId);
            if (member == null) return NotFound();

            member.NvtUserName = model.NvtUserName;
            member.NvtFullName = model.NvtFullName;
            member.NvtEmail = model.NvtEmail;
            member.NvtPassword = model.NvtPassword;

            return RedirectToAction("NvtGetMember");
        }

        // GET: Xoá
        public IActionResult Delete(string id)
        {
            var member = _nvtMembers.FirstOrDefault(m => m.NvtMemberId == id);
            if (member == null) return NotFound();

            _nvtMembers.Remove(member);
            return RedirectToAction("NvtGetMember");
        }
    }
}
