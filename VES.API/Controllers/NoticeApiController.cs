using Microsoft.AspNetCore.Mvc;
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
                if (notices != null)
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

        /*[HttpPatch("{id}")]
        public async Task<IActionResult> UpdateNotice([FromRoute] int id, [FromBody] JsonPatchDocument noticeModel)
        {
            try
            {
                var notice = await _noticeContext.Notices.FindAsync(id);
                if (notice != null)
                {
                    notice.remarks = noticeModel.remarks;
                    notice.changeReason = noticeModel.changeReason;
                    notice.resolutionStatus = noticeModel.resolutionStatus;
                    await _noticeContext.SaveChangesAsync();
                    return Ok(_mapper.Map<NoticeDto>(notice));
                }
                return StatusCode(StatusCodes.Status204NoContent, $"Notice with {id} not found");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }

        }*/

    }
}
