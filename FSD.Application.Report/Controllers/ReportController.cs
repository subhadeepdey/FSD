﻿using Microsoft.AspNetCore.Mvc;

namespace FSD.Application.User.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportController : ControllerBase
    {

        public ReportController()
        {
        }

        [HttpPost]
        [Route("reports")]
        public async Task<IActionResult> GetReportList()
        {
            throw new NotImplementedException();
        }
    }
}
