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

        public PastDueController(VESDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult GetAll()
        {

            // Get Data From DataBase
            var list = dbContext.pastDues.ToList();

            // Map Domain Models to DTOs

            var listdto = new List<pastDueDto>();
            foreach (var item in list)
            {
                listdto.Add(new pastDueDto()
                {
                    EntryId = item.EntryId,
                    PMC = item.PMC,
                    InvoiceID = item.InvoiceID,
                    Type = item.Type,
                    SiteName = item.SiteName,
                    VendorName = item.VendorName,
                    AccountNo = item.AccountNo,
                    InvoiceDate = item.InvoiceDate,
                    HascontBFs = item.HascontBFs,
                    PostingDate = item.PostingDate,
                    PriorBalance = item.PriorBalance,
                    CurrentCharges = item.CurrentCharges,
                    LfAmount = item.LfAmount,
                    Priority = item.Priority,
                    TemplateAmount = item.TemplateAmount,
                    PrimaryRc = item.PrimaryRc,
                    Rc1 = item.Rc1,
                    Rc2 = item.Rc2, 
                    Notes = item.Notes

                });
            }
            return Ok(listdto);
        }


        [HttpGet("ids/{entryId}")]
        public IActionResult GetById([FromRoute] int entryId)
        {
            var item = dbContext.pastDues.FirstOrDefault(x => x.EntryId == entryId);

            if (item == null)
            {
                return NotFound();
            }

            var pastduedto = new pastDueDto
            {

                EntryId = item.EntryId,
                PMC = item.PMC,
                InvoiceID = item.InvoiceID,
                Type = item.Type,
                SiteName = item.SiteName,
                VendorName = item.VendorName,
                AccountNo = item.AccountNo,
                InvoiceDate = item.InvoiceDate,
                HascontBFs = item.HascontBFs,
                PostingDate = item.PostingDate,
                PriorBalance = item.PriorBalance,
                CurrentCharges = item.CurrentCharges,
                LfAmount = item.LfAmount,
                Priority = item.Priority,
                TemplateAmount = item.TemplateAmount,
                PrimaryRc = item.PrimaryRc,
                Rc1 = item.Rc1,
                Rc2 = item.Rc2,
                Notes = item.Notes

            };
            return Ok(item);
        }


        [HttpGet("invoices/{invoiceId}")]
        public IActionResult GetByInvoiceId([FromRoute] int invoiceId)
        {
            var items = dbContext.pastDues.FirstOrDefault(x => x.InvoiceID == invoiceId);
            if (items == null)
            {
                return NotFound();
            }

            var pastduedtos = new pastDueDto
            {

                EntryId = items.EntryId,
                PMC = items.PMC,
                InvoiceID = items.InvoiceID,
                Type = items.Type,
                SiteName = items.SiteName,
                VendorName = items.VendorName,
                AccountNo = items.AccountNo,
                InvoiceDate = items.InvoiceDate,
                HascontBFs = items.HascontBFs,
                PostingDate = items.PostingDate,
                PriorBalance = items.PriorBalance,
                CurrentCharges = items.CurrentCharges,
                LfAmount = items.LfAmount,
                Priority = items.Priority,
                TemplateAmount = items.TemplateAmount,
                PrimaryRc = items.PrimaryRc,
                Rc1 = items.Rc1,
                Rc2 = items.Rc2,
                Notes = items.Notes

            };
            return Ok(items);

        }

        [HttpGet("accounts/{accNo})")]
        public IActionResult GetByAccNo([FromRoute] string accNo)
        {
            var items = dbContext.pastDues.FirstOrDefault(x => x.AccountNo == accNo);
            if (items == null)
            {
                return NotFound();
            }

            var pastduedtos = new pastDueDto
            {

                EntryId = items.EntryId,
                PMC = items.PMC,
                InvoiceID = items.InvoiceID,
                Type = items.Type,
                SiteName = items.SiteName,
                VendorName = items.VendorName,
                AccountNo = items.AccountNo,
                InvoiceDate = items.InvoiceDate,
                HascontBFs = items.HascontBFs,
                PostingDate = items.PostingDate,
                PriorBalance = items.PriorBalance,
                CurrentCharges = items.CurrentCharges,
                LfAmount = items.LfAmount,
                Priority = items.Priority,
                TemplateAmount = items.TemplateAmount,
                PrimaryRc = items.PrimaryRc,
                Rc1 = items.Rc1,
                Rc2 = items.Rc2,
                Notes = items.Notes

            };
            return Ok(items);

        }


        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] UpdatePBDto updatedto)
        {
            var item = dbContext.pastDues.FirstOrDefault(x => x.EntryId == id);
            if(item == null)
            {
                return NotFound();
            }
            item.Rc1 = updatedto.Rc1;
            item.Rc2 = updatedto.Rc2;  
            item.Notes = updatedto.Notes;

            dbContext.SaveChanges();

            var updatedItems = new pastDueDto
            {
                EntryId = item.EntryId,
                PMC = item.PMC,
                InvoiceID = item.InvoiceID,
                Type = item.Type,
                SiteName = item.SiteName,
                VendorName = item.VendorName,
                AccountNo = item.AccountNo,
                InvoiceDate = item.InvoiceDate,
                HascontBFs = item.HascontBFs,
                PostingDate = item.PostingDate,
                PriorBalance = item.PriorBalance,
                CurrentCharges = item.CurrentCharges,
                LfAmount = item.LfAmount,
                Priority = item.Priority,
                TemplateAmount = item.TemplateAmount,
                PrimaryRc = item.PrimaryRc,
                Rc1 = item.Rc1,
                Rc2 = item.Rc2,
                Notes = item.Notes
            };
            return Ok(updatedItems);
        }
    }
}

