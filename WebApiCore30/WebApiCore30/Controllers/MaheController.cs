using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApiCore30.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MaheController : ControllerBase
    {
        
        [HttpGet]
        public string Get()
        {


            return $"Harisov kontroler -> {DateTime.Now.ToString("dd-MM-yyyy")}  u  {DateTime.Now.ToString("HH:MM:SS")} ";
        }
    }
}