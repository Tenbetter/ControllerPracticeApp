using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ControllerPracticeApp.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PracticeController : ControllerBase
    {
        [Route("Ping")]
        public string Ping()
        {
            return "pong";
        }

         [Route("About")]
        public string About()
        {
            return "About stuff";
        }


    }
}