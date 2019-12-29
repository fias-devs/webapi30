using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiCore30.Repository;

namespace WebApiCore30.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MaheController : ControllerBase
    {
        
        [HttpGet]
        public string Get()
        {
            ZaposleniciRepository zr = new ZaposleniciRepository();
            



            return $"U bazi je trenutno ->{zr.GetAll().Count()} zaposlenika";
        }
    }
}