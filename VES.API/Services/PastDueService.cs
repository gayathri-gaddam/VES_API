using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.EntityFrameworkCore;
using VES.API.Data;
using VES.API.Models.Domain;
using VES.API.Models.DTO;
using VES.API.Types.Interfaces;

namespace VES.API.Services
{
   
    public class PastDueService : IPastDueService
    {
        private readonly VESDbContext _context;
        private readonly IMapper _mapper;

        public PastDueService(VESDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
            
        }

        public async Task<List<PastDueDTO>> GetPastDues(long? entryId, long? invoiceId, long? accountNo)
        {
            List<PastDueDTO> pastDuesDto = null;
            List<PastDue> pastDues = await this._context.PastDues.Take(25).ToListAsync();
            try
            {
                if(entryId!=null)
                {
                    pastDues = pastDues.Where(pastdue => pastdue.entryId.ToString().Contains(entryId.ToString())).ToList();
                }
                if (invoiceId != null)
                {
                    pastDues = pastDues.Where(pastdue => pastdue.invoiceId.ToString().Contains(invoiceId.ToString())).ToList();
                }
                if (entryId != null)
                {
                    pastDues = pastDues.Where(pastdue => pastdue.accountNo.ToString().Contains(accountNo.ToString())).ToList();
                }
                pastDuesDto = _mapper.Map<List<PastDueDTO>>(pastDues);
            }
            catch (Exception ex)
            {
                throw;
            }
            return pastDuesDto;

        }


        public async Task<bool> UpdatePastDue(int id, JsonPatchDocument pastDueModel)
        {
            PastDue pastDue= null;
            try
            {
                pastDue = await _context.PastDues.Where(pastDue => pastDue.entryId == id).FirstAsync();
                if( pastDue!=null)
                {
                    pastDueModel.ApplyTo(pastDue);
                    await this._context.SaveChangesAsync();
                }
            }
            catch(Exception ex)
            {
                throw;
            }
            return pastDue==null?false : true;
        }
    }
}
