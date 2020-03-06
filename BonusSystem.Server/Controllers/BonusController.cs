using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BonusSystem.Server.Services;
using Microsoft.AspNetCore.Mvc;

namespace BonusSystem.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BonusController : ControllerBase
    {
        readonly ICustomerRepository _repo;
        public BonusController(ICustomerRepository repo)
        {
            _repo = repo;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }
    }
}
