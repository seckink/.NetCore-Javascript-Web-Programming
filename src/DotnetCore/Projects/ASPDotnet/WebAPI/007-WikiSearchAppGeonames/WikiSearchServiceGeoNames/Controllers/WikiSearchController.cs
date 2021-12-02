﻿using CSD.WikiSearchApp.Geonames;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSD.WikiSearchApp.Controllers
{       
    [Route("api/[controller]")]
    public class WikiSearchController : ControllerBase
    {
        [HttpGet("place")]
        public Task<IActionResult> FindPlaceInfo(string q, int maxRows)
        {
            throw new NotImplementedException("FindPlaceInfo");
        }
    }
}