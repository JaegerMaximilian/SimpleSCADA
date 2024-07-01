using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SimpleSCADA_Controller;
using SimpleSCADA_SharedResources;

namespace SimpleScada.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OEEController : ControllerBase
    {

        [HttpGet( "GetOEE")]
        public IActionResult GetOEE()
        {
            OEEManager oeeManager = new OEEManager();
            OEE oeeFromDb = oeeManager.GetLatestOEE();

            if (oeeFromDb != null)
            {
                return Ok(oeeFromDb);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpGet("GetOEEfromWeek")]
        public IActionResult GetOEEfromWeek()
        {
            OEEManager oeeManager = new OEEManager();
            List<OEE> oeeFromWeek = oeeManager.GetOEEfromWeek();

            if (oeeFromWeek != null)
            {
                return Ok(oeeFromWeek);
            }
            else
            {
                return BadRequest();
            }
        }

    }
}
