using BlazorServerSQLite.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting.Server.Features;
using Microsoft.AspNetCore.Hosting.Server;
using Newtonsoft.Json;
using System.Security.Claims;
using static System.Net.WebRequestMethods;
using Microsoft.AspNetCore.Components;


[Microsoft.AspNetCore.Mvc.Route("[controller]/[action]")]
    public class TeacherProfileRequestController : Controller
    {
    private readonly ApplicationDbContext context;
    private readonly UserManager<ApplicationUser> userManager;
    private readonly IConfiguration _configuration;

    public TeacherProfileRequestController(ApplicationDbContext context,
        UserManager<ApplicationUser> userManager, IConfiguration configuration)
    {
        this.context = context;
        this.userManager = userManager;
        _configuration = configuration;
    }
    public async Task<ActionResult<TeacherProfileRequest>> GetTeacherProfileRequest(string id)
    {
        return await context.TeacherProfileRequests.FirstOrDefaultAsync(x => x.Id == id);
    }
    public async Task<ActionResult> Add([FromBody] TeacherProfileRequest teacherProfileRequest)
    {
        var list = GetTeacherProfileRequestsByTeacherId(teacherProfileRequest.UserId);
        foreach (var item in list)
        {
            if(item.TypeOfField == teacherProfileRequest.TypeOfField)
            {
                switch (item.TeacherProfileRequestState)
                {
                    case "Pending":
                        item.TeacherProfileRequestState = "Cancelled";
                        UpdateTeacherProfileRequest(item);
                        break;
                }
            }
        }
        try
        {
            await context.AddAsync(teacherProfileRequest);
        }
        catch (Exception ex)
        {
            throw;
        }
        await context.SaveChangesAsync();
        return new CreatedAtRouteResult("GetTeacherProfileRequest", new { id = teacherProfileRequest.Id }, teacherProfileRequest);
    }
    public async Task<ActionResult<List<TeacherProfileRequest>>> GetTeacherProfileRequests()
    {
        var result = await context.TeacherProfileRequests.ToListAsync();
        return result;
    }


    public async Task<ActionResult<TeacherProfileRequest>> GetApprovedTeacherProfileRequestByTeacherId(string id)
    {
        var result = context.TeacherProfileRequests.Where(x => x.UserId == id).
            Where(x => x.TeacherProfileRequestState == "Approved").
            FirstOrDefault();
        if (result == null)
        {
            return new TeacherProfileRequest();
        }
        else
        {
            return result;
        }
    }
    public List<TeacherProfileRequest> GetTeacherProfileRequestsByTeacherId(string Id)
    {
        var result = context.TeacherProfileRequests.ToList();
        result = result.Where(x => x.UserId == Id).ToList();
        return result;
    }
    public async Task<ActionResult<List<TeacherProfileRequest>>> GetTeacherProfileRequestsByTeacherIdAsync([FromBody] string Id)
    {
        var result = await context.TeacherProfileRequests.Where(x => x.UserId == Id).ToListAsync();
        return result;
    }
    public async Task<ActionResult<TeacherProfileRequest>> GetOneTeacherProfileRequestByTeacherId(string Id) /*[FromBody] */
    {
        var result = context.TeacherProfileRequests.Where(x => x.UserId == Id).FirstOrDefault();
        if (result == null)
        {
            return new TeacherProfileRequest();
        }
        else
        {
            return result;
        }
    }
    public async Task<ActionResult<TeacherProfileRequest>> GetOnePendingTeacherProfileRequestByTeacherId(string id)
    {
        var result = context.TeacherProfileRequests.Where(x => x.UserId == id).
            Where(x => x.TeacherProfileRequestState == "Pending").
            FirstOrDefault();
        if (result == null)
        {
            return new TeacherProfileRequest();
        }
        else
        {
            return result;
        }
    }
    public async Task<IActionResult> UpdateTeacherProfileRequest(TeacherProfileRequest teacherProfileRequest) //[FromBody] 
    {
        context.TeacherProfileRequests.Update(teacherProfileRequest);
        await context.SaveChangesAsync();
        return null;
    }

    public async Task<IActionResult> ApproveTeacherProfileRequest([FromBody] TeacherProfileRequest teacherProfileRequest)
    {
        teacherProfileRequest.TeacherProfileRequestState = "Approved";
        context.TeacherProfileRequests.Update(teacherProfileRequest);
        await context.SaveChangesAsync();
        return null;
    }

    //public async Task<IActionResult> OverrideApprovedTeacherProfileRequest([FromBody] string userId)
    //{
    //    List<TeacherProfileRequest> list = context.TeacherProfileRequests.Where(x => x.UserId == userId).
    //        Where(x => x.TeacherProfileRequestState == "Approved").ToList();
    //    foreach (var listItem in list)
    //    {
    //        listItem.TeacherProfileRequestState = "Overriden";
    //        context.TeacherProfileRequests.Update(listItem);
    //    }
    //    await context.SaveChangesAsync();
    //    return null;
    //}


    public async Task<IActionResult> OverrideApprovedTeacherProfileRequest([FromBody] TeacherProfileRequestViewModel viewModel)
    {
        List<TeacherProfileRequest> list = context.TeacherProfileRequests.Where(x => x.UserId == viewModel.userId).
            Where(x => x.TeacherProfileRequestState == "Approved").Where(x => x.TypeOfField == viewModel.typeOfField).ToList();
        foreach (var listItem in list)
        {
            listItem.TeacherProfileRequestState = "Overriden";
            context.TeacherProfileRequests.Update(listItem);
        }
        await context.SaveChangesAsync();
        return null;
    }

    public class TeacherProfileRequestViewModel
    {
        public string userId { get; set; }
        public string typeOfField { get; set;}

        public TeacherProfileRequestViewModel(string userId, string typeOfField)
        {
            this.userId = userId;
            this.typeOfField = typeOfField;
        }
    }
}
