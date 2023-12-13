using BlazorServerSQLite.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerSQLite.Controllers
{
    [Route("[controller]/[action]")]
    public class TeacherSavingsController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IConfiguration _configuration;
        public TeacherSavingsController(ApplicationDbContext context,
    UserManager<ApplicationUser> userManager,
    IConfiguration configuration)
        {
            this.context = context;
            this.userManager = userManager;
            _configuration = configuration;
        }
        public async Task<ActionResult> Add([FromBody] TeacherSaving liking)
        {
            try
            {
                await context.AddAsync(liking);
            }
            catch (Exception ex)
            {

            }
            await context.SaveChangesAsync();
            return new CreatedAtRouteResult("GetTeacherSaving", new { id = liking.Id }, liking);
        }
        public async Task<ActionResult<List<string>>> GetSavedTeachers(string Id)
        {
            var result = await context.TeacherSavings.ToListAsync();
            result = result.Where(x => x.UserId == Id).ToList();
            return result.Select(x => x.TeacherId).ToList();
        }
        public async Task<ActionResult<List<TeacherSaving>>> List(string Id)
        {
            var result = await context.TeacherSavings.ToListAsync();
            result = result.Where(x => x.UserId == Id).ToList();
            return result;
        }
        public async Task<ActionResult> Delete([FromBody] TeacherSaving liking)
        {
            context.Remove(liking);
            await context.SaveChangesAsync();
            return null;
        }
    }
}
