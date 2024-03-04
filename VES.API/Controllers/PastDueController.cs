using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VES.API.Data;
using VES.API.Models.Domain;
using VES.API.Models.DTO;

namespace VES.API.Controllers
{
    [Route("api/[controller]")]
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
        public IActionResult GetAll()
        {
            // Get Data From DataBase
            var list = dbContext.PastDues.ToList();

            // Map Domain Models to DTOs using AutoMapper
            var listdto = _mapper.Map<List<PastDueDto>>(list);

            return Ok(listdto);
        }

        [HttpGet("getById/{entryId}")]
        public IActionResult GetById([FromRoute] int entryId)
        {
            var item = dbContext.PastDues.FirstOrDefault(x => x.EntryId == entryId);

            if (item == null)
            {
                return NotFound();
            }

            var pastduedto = _mapper.Map<PastDueDto>(item);

            return Ok(pastduedto);
        }

        [HttpGet("getByInvoiceId/{invoiceId}")]
        public IActionResult GetByInvoiceId([FromRoute] int invoiceId)
        {
            var items = dbContext.PastDues.FirstOrDefault(x => x.InvoiceID == invoiceId);
            if (items == null)
            {
                return NotFound();
            }

            var pastduedtos = _mapper.Map<PastDueDto>(items);

            return Ok(pastduedtos);

        }

        [HttpGet("getByAccNo/{accNo}")]
        public IActionResult GetByAccNo([FromRoute] string accNo)
        {
            var items = dbContext.PastDues.FirstOrDefault(x => x.AccountNo == accNo);
            if (items == null)
            {
                return NotFound();
            }

            var pastduedtos = _mapper.Map<PastDueDto>(items);

            return Ok(pastduedtos);

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


