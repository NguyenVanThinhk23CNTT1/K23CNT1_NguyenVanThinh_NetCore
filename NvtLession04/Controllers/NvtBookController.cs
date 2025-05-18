using Microsoft.AspNetCore.Mvc;
using NvtLession04.Models;

namespace NvtLession04.Controllers
{
    public class NvtBookController : Controller
    {

        private List<NvtBook> nvtBooks = new List<NvtBook>
{
                new NvtBook
                {
                    NvtId = "B001",
                    NvtTitle = "Clean Code",
                    NvtDescription = "A Handbook of Agile Software Craftsmanship",
                    NvtImage = "/images/book-1.jpg",
                    NvtPrice = "25.99",
                    NvtPage = "464"
                },
                new NvtBook
                {
                    NvtId = "B002",
                    NvtTitle = "The Pragmatic Programmer",
                    NvtDescription = "Your Journey To Mastery",
                    NvtImage = "/images/book-2.jpg",
                    NvtPrice = "30.99",
                    NvtPage = "352"
                },
                new NvtBook
                {
                    NvtId = "B003",
                    NvtTitle = "You Don't Know JS",
                    NvtDescription = "An in-depth look into JavaScript concepts",
                    NvtImage = "/images/book-3.jpg",
                    NvtPrice = "19.99",
                    NvtPage = "278"
                },
                new NvtBook
                {
                    NvtId = "B004",
                    NvtTitle = "Design Patterns",
                    NvtDescription = "Elements of Reusable Object-Oriented Software",
                    NvtImage = "/images/book-4.jpg",
                    NvtPrice = "40.99",
                    NvtPage = "395"
                },
                new NvtBook
                {
                    NvtId = "B005",
                    NvtTitle = "Introduction to Algorithms",
                    NvtDescription = "A comprehensive guide to algorithms",
                    NvtImage = "/images/book-5.jpg",
                    NvtPrice = "60.99",
                    NvtPage = "1312"
                }
    };





        // Get: /NvtBook/NvtIndex => Lấy tất cả các cuốn sách
        public IActionResult NvtIndex()
        {
            // Đưa dữ liệu lên view
            return View(nvtBooks);
        }


        // Get: /NvtBook/NvtCreate
        public IActionResult NvtCreate()
        {
            NvtBook nvtBook = new NvtBook();            
            return View(nvtBook);
        }


        // POST: /NvtBook/NvtCreateSubbmit
        public IActionResult NvtCreateSubbmit()
        {
            // ....
            return RedirectToAction("NvtIndex");
        }

        // Get: /NvtBook/NvtCreate
        public IActionResult NvtEdit(string id)
        {
            return View();
        }

        // POST: /NvtBook/NvtEditSubbmit
        public IActionResult NvtEditSubbmit()
        {
            // ...
            return RedirectToAction("NvtIndex");
        }
    }
}
