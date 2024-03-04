using AutoMapper;

using Microsoft.AspNetCore.Mvc;

using VES.API.Data;
using VES.API.Models.DTO;

namespace VES.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class LFMngmentController : ControllerBase
    {
        private readonly VESDbContext dbContext;
        private readonly IMapper _mapper;

        public LFMngmentController(VESDbContext dbContext, IMapper mapper)
        {
            this.dbContext = dbContext;
            _mapper = mapper;
        }

        [HttpGet("/GetAll")]
        public IActionResult GetAll()
        {
            //Get Data From Database - Domain Models
            var tblLFMngment = dbContext.LFManagment.ToList();

            // Map Domain Models to DTOs using AutoMapper
            var tblLFMngmentDto = _mapper.Map<List<LFMngmentDto>>(tblLFMngment);

            // Return DTO
            return Ok(tblLFMngmentDto);
        }

        [HttpGet("getById/{id}")]
        public IActionResult GetById([FromRoute] int id)
        {
            // Get LFMngment Domain from Database
            var item = dbContext.LFManagment.FirstOrDefault(x => x.Id == id);

            if (item == null)
            {
                return NotFound();
            }

            //Map LFmngment Domain Model to LFmngment DTO using AutoMapper
            var lfmngmentdto = _mapper.Map<LFMngmentDto>(item);

            return Ok(lfmngmentdto);
        }

        [HttpGet("getByName/{name}")]
        public IActionResult GetByName([FromRoute] string name)
        {
            // Get LFMngment Domain from Database
            var item = dbContext.LFManagment.FirstOrDefault(item => item.Name == name);

            if (item == null)
            {
                return NotFound();
            }

            //Map LFmngment Domain Model to LFmngment DTO using AutoMapper
            var lfmngmentdto = _mapper.Map<LFMngmentDto>(item);

            return Ok(lfmngmentdto);
        }

        
        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] AddNewEntryDto addNewEntryDto)
        {
            var item = dbContext.LFManagment.FirstOrDefault(x => x.Id == id);
            if (item == null)
            {
                return NotFound(); // Or any appropriate response indicating ID not found
            }

            // Map Request Body to LFManagment Domain Model using AutoMapper
            _mapper.Map(addNewEntryDto, item);

            dbContext.SaveChanges();

            var updatedItem = _mapper.Map<LFMngmentDto>(item);

            return Ok(updatedItem);
        }
        
    }
}
