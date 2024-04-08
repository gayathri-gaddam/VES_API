using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VES.API.Data;
using VES.API.Models.Domain;
using VES.API.Models.DTO;

namespace VES.API.Controllers
{
    [Route("api/v1/pastDues")]
    [ApiController]

    public class PastDueController : ControllerBase
    {
        private readonly VESDbContext dbContext;
        private readonly IMapper _mapper;
        public PastDueController(VESDbContext dbContext, IMapper mapper)
        {
            this.dbContext = dbContext;
            this._mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetPastDues([FromQuery] long? entryId, [FromQuery] long? inoiceId, [FromQuery] long? accountNo)
        {
            try
            {
                
                if (entryId != null)
                {
                    List<PastDue> pastDues = this.dbContext.PastDues.Where(pastDue => pastDue.EntryId.ToString().Contains(entryId.ToString())).ToList();
                    if (pastDues != null && pastDues.Count > 0)
                    {
                        return Ok(pastDues.Select(notice => _mapper.Map<NoticeDto>(notice)));
                    }
                    else
                    {
                        return StatusCode(StatusCodes.Status404NotFound, "Past Dues not found");
                    }
                }
                else
                {

                    var pastDues = await this.dbContext.PastDues.ToListAsync();
                    if (pastDues != null)
                    {
                        return Ok(pastDues.Select(pastDue => _mapper.Map<PastDueDto>(pastDue)));
                    }
                    else
                    {
                        return StatusCode(StatusCodes.Status204NoContent, "Past Dues not found");
                    }

                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }

        }


        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] UpdatePBDto updatedto)
        {
            var item = dbContext.PastDues.FirstOrDefault(x => x.EntryId == id);
            if (item == null)
            {
                return NotFound();
            }

            // Map UpdatePBDto to PastDue object using AutoMapper
            _mapper.Map(updatedto, item);

            dbContext.SaveChanges();

            var updatedItems = _mapper.Map<PastDueDto>(item);

            return Ok(updatedItems);
        }
    }
}


