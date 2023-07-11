using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.TagHelpers.Cache;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace APItraining.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShipPartsController : ControllerBase
    {
        [HttpGet]
        public ActionResult GetParts()
        {
            string[] parts = { "Flux capacitor", "Inertial damper", "Impulse nacelle" };

            if (parts.Any())
                return NotFound();
            return Ok(parts);
        }

        [HttpPost]
        public ActionResult AddParts()
        {

        }

        [HttpUpdate]
        public ActionResult UpdateParts()
        {

        }

        [HttpDelete]
        public ActionResult DeleteParts()
        {

        }



    }
}
