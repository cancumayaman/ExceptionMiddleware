using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExceptionMiddleware.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MiddlewaresController : ControllerBase
    {


        [HttpGet]
        public string Get()
        {
            
                throw new Exception("Test error");
            
          
            return "OK";
        }

    }
}
