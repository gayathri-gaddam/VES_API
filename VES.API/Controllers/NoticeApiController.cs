﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VES.API.Data;
using VES.API.Models.Domain;
using VES.API.Models.DTO;

namespace VES.API.Controllers
{
    [ApiController]
    [Route("/api/v1/notices")]
    public class NoticeApiController : Controller
    {
        private readonly VESDbContext _noticeContext;
        private readonly IMapper _mapper;
        public NoticeApiController(VESDbContext noticeCotext, IMapper mapper)
        {
            _noticeContext = noticeCotext;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllEmployees([FromQuery] long entryId=0, [FromQuery] long noticeId=0 , [FromQuery] long accountNo = 0)
        {
            try
            {
                if (entryId != 0 || noticeId != 0 || accountNo != 0)
                {
                    var notices = this._noticeContext.Notices.Where(notice => notice.entryId.ToString().Contains(entryId.ToString()));
                    if (notices != null)
                    {
                        return Ok(notices.Select(notice => _mapper.Map<NoticeDto>(notice)));
                    }
                    else
                    {
                        return StatusCode(StatusCodes.Status204NoContent, "Notices not found");
                    }
                }
                else
                {

                    var notices = await this._noticeContext.Notices.ToListAsync();
                    if (notices != null)
                    {
                        return Ok(notices.Select(notice => _mapper.Map<NoticeDto>(notice)));
                    }
                    else
                    {
                        return StatusCode(StatusCodes.Status204NoContent, "Notices not found");
                    }

                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
            
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateEmployee([FromRoute] int id, [FromBody] Notice noticeModel)
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

        }

    }
}
