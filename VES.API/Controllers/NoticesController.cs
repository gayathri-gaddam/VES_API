using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using VES.API.Models.DTO;
using VES.API.Types.Interfaces;

namespace VES.API.Controllers
{
    [ApiController]
    [Route("/api/v1/notices")]
    public class NoticesController : Controller
    {
        private readonly INoticeService _noticeService;
        private readonly IDbAccess _dbAccess;

        public NoticesController(INoticeService _noticeService,IDbAccess dbAccess)
        {
            this._noticeService = _noticeService;  
            this._dbAccess = dbAccess;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllNotices([FromQuery] long? entryId, [FromQuery] long? noticeId, [FromQuery] long? accountNo)
        {
            try
            {
                /* List<NoticeDTO> notices = await _noticeService.GetAllNotices(entryId, noticeId, accountNo);*/
                List<NoticesDTO> notices = await _dbAccess.GetNoticesByLimit();
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
