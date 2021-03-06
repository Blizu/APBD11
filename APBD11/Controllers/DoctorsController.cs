﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APBD11.Controllers
{
    [Route("api/doctors")]
    [ApiController]
    public class DoctorsController : ControllerBase
    {
        private readonly DoctorDbContext _context;
        public DoctorsController(DoctorDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetDoctors()
        {
            return Ok();
        }

    }
}