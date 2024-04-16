
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using VES.API.Models.Domain;
using VES.API.Models.DTO;
using VES.API.Types.Interfaces;

namespace VES.API.Controllers
{
    [Route("api/v1/pastDues")]
    [ApiController]

    public class PastDueController : Controller
    {
        private readonly IPastDueService _pastDueService;
        private readonly IDbAccess _dbAccess;
        public PastDueController(IPastDueService _pastDueService, IDbAccess dbAccess)
        {
            this._pastDueService = _pastDueService;
            _dbAccess = dbAccess;
        }

        [HttpGet]
        public async Task<IActionResult> GetPastDues([FromQuery] long? entryId, [FromQuery] long? invoiceId, [FromQuery] long? accountNo, [FromQuery] int? page, [FromQuery] int? pageSize)
        {
            try
            {
                if (page == null && pageSize == null)
                {
                    List<PastDueDto> pastDues = await _pastDueService.GetPastDues(entryId, invoiceId, accountNo);
                    if (pastDues != null && pastDues.Count > 0)
                    {
                        return Ok(pastDues);
                    }
                    else
                    {
                        return NotFound("Past DUes not found with given filter");
                    }
                }
                else
                {
                    List<PastDue> pastDues = _dbAccess.GetPastDuesByLimit(page, pageSize);
                    if (pastDues != null && pastDues.Count > 0)
                    {
                        return Ok(pastDues);
                    }
                    else
                    {
                        return NotFound("Past DUes not found with given filter");
                    }
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


