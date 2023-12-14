using BlazorServerSQLite.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerSQLite.Controllers
{
    [Route("[controller]/[action]")]
    public class TeacherContactsController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IConfiguration _configuration;
        public TeacherContactsController(ApplicationDbContext context,
        UserManager<ApplicationUser> userManager,
        IConfiguration configuration)
        {
            this.context = context;
            this.userManager = userManager;
            _configuration = configuration;
        }
        public async Task<ActionResult<List<string>>> GetContactedTeachers(string Id)
        {
            var result = await context.TeacherContacts.ToListAsync();
            result = result.Where(x => x.UserId == Id).ToList();
            return result.Select(x => x.TeacherId).ToList();
        }
    }
}
