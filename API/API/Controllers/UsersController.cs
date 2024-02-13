using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API;

[ApiController]
[Route("api/[controller]")]
public class UsersController : ControllerBase
{
    private readonly DataContext _db;

    public UsersController(DataContext db)
    {
        _db = db;
    }

    [HttpGet]
    public ActionResult<IEnumerable<AppUser>> GetUsers()
    {
        return _db.Users.ToList();
    }

    [HttpGet("{id}")]
    public ActionResult<AppUser> GetUser(int id)
    {
        return _db.Users.Find(id);
    }
}
