using Microsoft.AspNetCore.Mvc;


using Lab02MVC.Models;



namespace Lab02MVC.Controllers
{
    public class NvtAccountController : Controller
    {
        public IActionResult Index()
        {
            List<Account> accounts = new List<Account>
            {
                new Account()
                {
                    Id = 1,
                    Name = "Nguyễn Văn Thịnh",
                    Email = "thinhvannguyen113@gmail.com",
                    Phone = "0986456789",
                    Address = "Hà Nội",
                    Avatar = "img/Avatar/av1.jpg",
                    Gender = "0",
                    Bio = "0",
                    Birthday = new DateTime(2005, 4, 16)
                }
            };
            ViewBag.Accounts = accounts;
            return View();
        }
        [Route("ho-so-cua-toi", Name = "profile")]
        public IActionResult NqtProfile(int id)
        {
            List<Account> accounts = new List<Account>

            {
                new Account()
                {
                    Id = 1,
                    Name = "Nguyễn Quang Tâm",
                    Email = "nguyenquangtam6666@gmail.com",
                    Address = "VN",
                    Phone = "0",
                    Avatar = "img/Avatar/01.png",
                    Bio = "0",
                    Gender = "0",
                    Birthday = DateTime.Parse("2005-06-26"),
                }

            };
            
            ViewBag.Accounts = accounts;
            return View();
        }
    }
}
