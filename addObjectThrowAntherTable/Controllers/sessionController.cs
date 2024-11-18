using addObjectThrowAntherTable.AppContext;
using addObjectThrowAntherTable.DTOs;
using addObjectThrowAntherTable.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace addObjectThrowAntherTable.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class sessionController : ControllerBase
    {
        private readonly Appdbcontext appdbcontext_;

        public sessionController(Appdbcontext appdbcontext)
        {
            appdbcontext_ = appdbcontext;
        }
        [HttpPost]
        public IActionResult addSessionAndStudent(sessionDTO sessionDTO)
        {
            session session = new session { 
            sessionName = sessionDTO.sessionName,
            students = sessionDTO.students.Select(i=> new student { studentName = i.studentName}).ToList(),
            };
            try
            {
                appdbcontext_.sessions.Add(session);
                appdbcontext_.SaveChanges();
                return Ok();
            }
            catch (Exception ex) {return BadRequest(ex.Message); }
        }
    }
}
