using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PancakeModel;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace PancakeAPI.Controllers
{
    [Route("api/[controller]")]
    public class PancakeController : Controller
    {
        // GET: api/pancake
        public JsonResult Get(int numPancakes = 6)
        {
            var res = new ButtermilkPancakeRecipe(numPancakes);
            return new JsonResult(res);
        }

    }
}
