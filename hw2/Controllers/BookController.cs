using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class BookController : ControllerBase{
    private static List<Book> books = new(){};
    [HttpGet]
    public ActionResult<List<Book>> Get(){
        return Ok(books);
    }
    [HttpPost]
    public ActionResult<Book> addNew(Book b)
    {
        books.Add(b);
        return Ok(b);
    }
}