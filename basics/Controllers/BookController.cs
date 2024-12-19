using basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace basics.Controllers;

public class BookController : Controller 
{
   public IActionResult Index () 
   {
        var book = new Book();
        book.Id = 1;
        book.Title = "Lord Of The Rings";
        return View(book);
   }

public IActionResult Detail (int? id) 
   {
        if (id == null) {
          // return RedirectToAction("Book","List");  
          return Redirect("/book/list");
        }
        var getBook = Repository.GetById(id);
        return View(getBook);
   }

public IActionResult List () 
   {

       return View("BookList", Repository.Books);
   } 


}