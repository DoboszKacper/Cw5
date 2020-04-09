using Cw3.DTOs.Requests;
using Cw3.DTOs.Responses;
using Cw3.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wyklad5.Services;

namespace Cw3.Controllers
{
    [Route("api/enrollments")]
    [ApiController]

    public class EnrollmentController : ControllerBase
    {
        private IStudentDbService _service;

        public EnrollmentController(IStudentDbService service)
        {
            _service = service;
        }

        [HttpPost]
        public IActionResult EnrollStudent(EnrollStudentRequest request)
        {
            _service.EnrollStudent(request);
            var response = new EnrollStudentResponse();
     

            return Ok(response);

        }

    }
}
