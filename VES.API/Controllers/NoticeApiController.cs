using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using VES.API.Models.Domain;
using VES.API.Models.DTO;
using VES.API.Types.Interfaces;

namespace VES.API.Controllers
{
    [ApiController]
    [Route("/api/v1/notices")]
    public class NoticeApiController : Controller
    {
        private readonly INoticeService _noticeService;
        
        public NoticeApiController(INoticeService _noticeService)
        {
            this._noticeService = _noticeService;  
        }

        [HttpGet]
        public async Task<IActionResult> GetAllNotices([FromQuery] long? entryId, [FromQuery] long? noticeId, [FromQuery] long? accountNo)
        {
            try
            {
                List<NoticeDto> notices = await _noticeService.GetAllNotices(entryId, noticeId, accountNo);
                if (notices != null && notices.Count>0)
                {
                    return Ok(notices);
                }
                else
                {
                    return NotFound("Notices not found with given filter");
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }    

        }

        [HttpPatch("{id}")]
        public async Task<IActionResult> UpdateNotice([FromRoute] int id, [FromBody] JsonPatchDocument noticeModel)
        {
            try
            {
                bool result =await _noticeService.UpdateNotice(id, noticeModel);
                if (result)
                {
                    return Ok("Notice successfully updated");
                }
                else
                {
                    return NotFound("Notices not found");
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

    }
}
