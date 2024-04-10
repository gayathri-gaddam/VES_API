
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using VES.API.Models.DTO;
using VES.API.Types.Interfaces;

namespace VES.API.Controllers
{
    [Route("api/v1/pastDues")]
    [ApiController]

    public class PastDueController : Controller
    {
        private readonly IPastDueService _pastDueService;
        public PastDueController(IPastDueService _pastDueService)
        {
            this._pastDueService = _pastDueService;
        }

        [HttpGet]
        public async Task<IActionResult> GetPastDues([FromQuery] long? entryId, [FromQuery] long? invoiceId, [FromQuery] long? accountNo)
        {
            try
            {
              List<PastDueDto> pastDues=await _pastDueService.GetPastDues(entryId, invoiceId, accountNo);
                if(pastDues!=null && pastDues.Count > 0)
                {
                    return Ok(pastDues);
                }
                else
                {
                    return NotFound("Past DUes not found with given filter");
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }

        }


        [HttpPatch("{id}")]
        public async Task<IActionResult> UpdatePastDue([FromRoute]int id, [FromBody] JsonPatchDocument pastDueModel)
        {
            try
            {
                bool result = await _pastDueService.UpdatePastDue(id, pastDueModel);
                if(result)
                {
                    return Ok("Past Due successfully updated");
                }
                else
                {
                    return NotFound("Past Dues Not Found");
                }
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}


