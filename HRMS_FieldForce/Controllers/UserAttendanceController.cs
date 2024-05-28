﻿using HRMS_FieldForce.Models;
using HRMS_FieldForce.Models.DBcontext;
using HRMS_FieldForce.Models.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace HRMS_FieldForce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserAttendanceController : ControllerBase
    {
        private readonly UserDBContext _UserDBContext;

        public UserAttendanceController(UserDBContext userDBContext)
        {
            _UserDBContext = userDBContext;
        }

        [HttpGet]
        [Authorize(Roles = "User")]
        public async Task<ActionResult<IEnumerable<UserAttendance>>> GetUserAttendance()
        {
            string id = GetCurrentUser().UserID;
            var userDetail = await _UserDBContext.UserAttendances.SingleOrDefaultAsync(user => user.UserId == id);
            if (userDetail is null)
            {
                return NotFound($"Attendance with UserId {id} not found.");
            }
            return Ok(userDetail);
        }

        [HttpPost]
        [Authorize(Roles = "User")]
        public async Task<ActionResult<UserAttendance>> MarkUserAttendance(UserAttendanceDTO request)
        {
            var UserIDfromJWT = GetCurrentUser();

            var UserAttendance = new UserAttendance
            {
                UserId = UserIDfromJWT.UserID,
                day = DateTime.Now.DayOfWeek.ToString(),
                checkIn = request.checkIn,
                checkOut = request.checkOut
            };
            _UserDBContext.UserAttendances.Add(UserAttendance);
            await _UserDBContext.SaveChangesAsync();
            return Ok(UserAttendance);
        }

        private CurrentUserJWT GetCurrentUser()
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;
            if (identity != null)
            {
                var userClaims = identity.Claims;
                return new CurrentUserJWT
                {
                    UserID = userClaims.FirstOrDefault(o => o.Type == ClaimTypes.Name)?.Value,
                    CompanyEmail = userClaims.FirstOrDefault(o => o.Type == ClaimTypes.Email)?.Value,
                    Role = userClaims.FirstOrDefault(o => o.Type == ClaimTypes.Role)?.Value
                };
            }
            return null;
        }

    }
}
