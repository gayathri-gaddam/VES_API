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
                    LateFeeAmount   = item.LateFeeAmount,
                    ImpactAmount = item.ImpactAmount,
                    RequestedBy = item.RequestedBy,
                    RootCause1 = item.RootCause1,
                    RootCause2 = item.RootCause2,
                    Remarks = item.Remarks,
                    Creditmethod = item.Creditmethod,
                    ExpDatetoCredit = item.ExpDatetoCredit,
                    WaiverStatus = item.WaiverStatus,
                    RequestStatus = item.RequestStatus,
                    ApprovedAmount = item.ApprovedAmount,
                    DeclinedReason = item.DeclinedReason,
                    InvoiceSource = item.InvoiceSource
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
                LateFeeAmount = item.LateFeeAmount,
                ImpactAmount = item.ImpactAmount,
                RequestedBy = item.RequestedBy,
                RootCause1 = item.RootCause1,
                RootCause2 = item.RootCause2,
                Remarks = item.Remarks,
                Creditmethod = item.Creditmethod,
                ExpDatetoCredit = item.ExpDatetoCredit,
                WaiverStatus = item.WaiverStatus,
                RequestStatus = item.RequestStatus,
                ApprovedAmount= item.ApprovedAmount,
                DeclinedReason = item.DeclinedReason,
                InvoiceSource = item.InvoiceSource
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
                LateFeeAmount = item.LateFeeAmount,
                ImpactAmount = item.ImpactAmount,
                RequestedBy = item.RequestedBy,
                RootCause1 = item.RootCause1,
                RootCause2 = item.RootCause2,
                Remarks = item.Remarks,
                Creditmethod = item.Creditmethod,
                ExpDatetoCredit = item.ExpDatetoCredit,
                WaiverStatus = item.WaiverStatus,
                RequestStatus = item.RequestStatus,
                ApprovedAmount = item.ApprovedAmount,
                DeclinedReason = item.DeclinedReason,
                InvoiceSource = item.InvoiceSource
            };
            return Ok(item);
        }


        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] AddNewEntryDto addNewEntryDto)
        {
            var item = dbContext.LFMngment.FirstOrDefault(x => x.Id == id);
            if (item == null)
            {
                return NotFound(); // Or any appropriate response indicating ID not found
            }

            item.RootCause1 = addNewEntryDto.RootCause1;
            item.RootCause2 = addNewEntryDto.RootCause2;
            item.Remarks = addNewEntryDto.Remarks;
            item.Creditmethod = addNewEntryDto.Creditmethod;
            item.ExpDatetoCredit = addNewEntryDto.ExpDatetoCredit;
            item.WaiverStatus = addNewEntryDto.WaiverStatus;
            item.RequestStatus = addNewEntryDto.RequestStatus;
            item.ApprovedAmount = addNewEntryDto.ApprovedAmount;
            item.InvoiceSource = addNewEntryDto.InvoiceSource;
            item.DeclinedReason = addNewEntryDto.DeclinedReason;

            dbContext.SaveChanges();

            var updatedItem = new LFMngmentDto
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
                LateFeeAmount = item.LateFeeAmount,
                ImpactAmount = item.ImpactAmount,
                RequestedBy = item.RequestedBy,
                RootCause1 = item.RootCause1,
                RootCause2 = item.RootCause2,
                Remarks = item.Remarks,
                Creditmethod = item.Creditmethod,
                ExpDatetoCredit = item.ExpDatetoCredit,
                WaiverStatus = item.WaiverStatus,
                RequestStatus = item.RequestStatus,
                ApprovedAmount = item.ApprovedAmount,
                DeclinedReason = item.DeclinedReason,
                InvoiceSource = item.InvoiceSource
            };

            return Ok(updatedItem); 
        }

    }
}
