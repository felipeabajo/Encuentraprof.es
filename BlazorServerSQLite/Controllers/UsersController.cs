using BlazorServerSQLite.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Security.Claims;
using static System.Net.WebRequestMethods;

[Microsoft.AspNetCore.Mvc.RouteAttribute("[controller]/[action]")]
public class UsersController : Controller
{
    private readonly ApplicationDbContext context;
    private readonly UserManager<ApplicationUser> userManager;
    public UsersController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
    {
        this.context = context;
        this.userManager = userManager;
    }


    // [HttpGet]
    
    public async Task<ActionResult<ApplicationUser>> GetUser([FromBody] string Id)
    {
        return await userManager.Users.FirstOrDefaultAsync(x => x.Id == Id);
    }
    public async Task<ActionResult<List<ApplicationUser>>> GetApplicationUsers()
    {
        var result = userManager.Users.ToList();
        return result;
    }
    public async Task<ActionResult<List<string>>> GetUsersIds()
    {

        var result = await context.Users.ToListAsync();
        return result.Select(x => x.Id).ToList();
    }
    public async Task<ActionResult<List<ApplicationUser>>> GetTeachers()
    {
        string rolTeacherId = context.Roles.ToList().Where(x => x.Name == "Teacher").Select(x => x.Id).FirstOrDefault();
        if (rolTeacherId == null)
            return new List<ApplicationUser>();
        List<string> listTeacherIds = context.UserRoles.ToList().Where(x => x.RoleId == rolTeacherId).ToList().Select(x => x.UserId).ToList();
        var users = await userManager.Users.Where(x => listTeacherIds.Any(y => x.Id == y)).ToListAsync();
        return users;
    }
    public async Task<ActionResult<List<ApplicationUser>>> GetTeachersWithPublicProfile()
    {
        string rolTeacherId = context.Roles.ToList().Where(x => x.Name == "Teacher").
            Select(x => x.Id).FirstOrDefault();
        if (rolTeacherId == null)
            return new List<ApplicationUser>();
        List<string> listTeacherIds = context.UserRoles.ToList().Where(x => x.RoleId == rolTeacherId)
            .ToList().Select(x => x.UserId).ToList();
        var users = await userManager.Users.Where(x => listTeacherIds.Any(y => x.Id == y)).
            Where(x => x.PublicProfile == true).ToListAsync();
        return users;
    }
    public async Task<IActionResult> GetProfileUser()
    {
        var dd = HttpContext.User;
        var userId = User.FindFirstValue(ClaimTypes.NameIdentifier); // will give the user's userId
        var userName = User.FindFirstValue(ClaimTypes.Name); // will give the user's userName
        // For ASP.NET Core >= 5.0
        var userEmail = User.FindFirstValue(ClaimTypes.Email); // will give the user's Email
        return null;
    }
    public async Task<IActionResult> UpdateUser([FromBody] ApplicationUser user)
    {
        userManager.UpdateAsync(user);
        return null;
    }

    public async Task<IActionResult> UpdateUserContext([FromBody] ApplicationUser user)
    {
        context.Users.Update(user);
        await context.SaveChangesAsync();
        return null;
    }
}