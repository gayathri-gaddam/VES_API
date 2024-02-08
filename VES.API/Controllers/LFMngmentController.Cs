using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VES.API.Data;
using VES.API.Models.Domain;
using VES.API.Models.Domain;
using VES.API.Models.DTO;

namespace VES.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LFMngmentController : ControllerBase
    {
        /*
        [HttpGet]
        public IActionResult GetAll()
        {
            /*
            var tblLFMngment = new List<LFMngment>
            {
                new LFMngment
                {
                  Id=1,
                  Name="Arch Asset Management LLC",
                  SiteName="Austin Woods",
                  VendorName="Dominion Energy South Carolina",
                  AccountNo="3210136708471"
                },
                new LFMngment
                {
                  Id=2,
                  Name="Arch Asset Management LLC",
                  SiteName="Harbour Landing",
                  VendorName="Dominion Energy South Carolina",
                  AccountNo="3210135062851"
                },
                 new LFMngment
                {
                  Id=3,
                  Name="Arch Asset Management LLC",
                  SiteName="Austin Woods",
                  VendorName="Dominion Energy South Carolina",
                  AccountNo="3210135645207"
                },
                 new LFMngment
                {
                  Id=4,
                  Name="Arch Asset Management LLC",
                  SiteName="Austin Woods",
                  VendorName="Dominion Energy South Carolina",
                  AccountNo="3210131953456"
                }
            };
            return Ok(tblLFMngment);*/

            
            private readonly VESDbContext dbContext;
            public LFMngmentController(VESDbContext dbContext)
            {
                    this.dbContext = dbContext;
            }
            [HttpGet("/GetAll")]
            public IActionResult GetAll()
            {
            //Get Data From Database - Domain Models
                var tblLFMngment = dbContext.LFMngment.ToList();

            // Map Domain Models to DTOs
               var tblLFMngmentDto = new List<LFMngmentDto>();
               foreach(var item in tblLFMngment)
            {
                tblLFMngmentDto.Add(new LFMngmentDto()
                {
                    Id = item.Id,
                    Name = item.Name,
                    SiteName = item.SiteName,
                    VendorName = item.VendorName,
                    AccountNo = item.AccountNo,
                    InvoiceDate = item.InvoiceDate,
                    DueDate = item.DueDate,
                    PostingDate = item.PostingDate,
                    ReceivedDate = item.ReceivedDate,
                    TotalAmountDue = item.TotalAmountDue,
                    LateFeeAmount   = item.LateFeeAmount

                });
            }
               // Return DTO
                return Ok(tblLFMngmentDto);
            }


        [HttpGet("getById/{id}")]
       // [Route("{id:int}")]
            public IActionResult GetById([FromRoute]int id)
            {

            //var ids = dbContext.LFMngment.Find(id);
            // Get LFMngment Domain from Database
            var item = dbContext.LFMngment.FirstOrDefault(x =>  x.Id == id);

            if (item == null)
            {
                return NotFound();
            }

            //Map LFmngment Domain Model to LFmngment DTO
            var lfmngmentdto = new LFMngmentDto
            {

                Id = item.Id,
                Name = item.Name,
                SiteName = item.SiteName,
                VendorName = item.VendorName,
                AccountNo = item.AccountNo,
                InvoiceDate = item.InvoiceDate,
                DueDate = item.DueDate,
                PostingDate = item.PostingDate,
                ReceivedDate = item.ReceivedDate,
                TotalAmountDue = item.TotalAmountDue,
                LateFeeAmount = item.LateFeeAmount
            };
            return Ok(item);
          }
        
        [HttpGet ("getByName/{name}")]
        //[Route("{name}")]
        public IActionResult GetByName([FromRoute] string name)
        {

            // Get LFMngment Domain from Database
            var item = dbContext.LFMngment.FirstOrDefault(item => item.Name == name);

            if (item == null)
            {
                return NotFound();
            }
            //Map  //Map LFmngment Domain Model to LFmngment DTO
            var lfmngmentdto = new LFMngmentDto
            {

                Id = item.Id,
                Name = item.Name,
                SiteName = item.SiteName,
                VendorName = item.VendorName,
                AccountNo = item.AccountNo,
                InvoiceDate = item.InvoiceDate,
                DueDate = item.DueDate,
                PostingDate = item.PostingDate,
                ReceivedDate = item.ReceivedDate,
                TotalAmountDue = item.TotalAmountDue,
                LateFeeAmount = item.LateFeeAmount
            };
            return Ok(item);
        }









        //New Action Method to create new entry

        [HttpPost]
        public IActionResult Create([FromBody]AddNewEntryDto addNewEntryDto)
        {
            //Convert DTO to Domain Model
            var item = new LFMngment
            {
                Name = addNewEntryDto.Name,
                SiteName = addNewEntryDto.SiteName,
                VendorName = addNewEntryDto.VendorName,
                AccountNo = addNewEntryDto.AccountNo,
                InvoiceDate = addNewEntryDto.InvoiceDate,
                DueDate = addNewEntryDto.DueDate,
                PostingDate = addNewEntryDto.PostingDate,
                ReceivedDate = addNewEntryDto.ReceivedDate,
                TotalAmountDue = addNewEntryDto.TotalAmountDue,
                LateFeeAmount = addNewEntryDto.LateFeeAmount
            };
            // Use Domain Model to create a new entry in table
            dbContext.LFMngment.Add(item); 
            dbContext.SaveChanges();

            //Map Domain Model Back to DTO

            var newitem = new LFMngmentDto
            {
                Id = item.Id,
                Name = item.Name,
                SiteName = item.SiteName,
                VendorName = item.VendorName,
                AccountNo = item.AccountNo,
                InvoiceDate = item.InvoiceDate,
                DueDate = item.DueDate,
                PostingDate = item.PostingDate,
                ReceivedDate = item.ReceivedDate,
                TotalAmountDue = item.TotalAmountDue,
                LateFeeAmount = item.LateFeeAmount

            };
            return CreatedAtAction(nameof(GetById), new {id=item.Id},newitem);
        }

    }
}
