﻿using AutoMapper;
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

        public async Task<List<PastDueDto>> GetPastDues(long? entryId, long? invoiceId, long? accountNo)
        {
            List<PastDueDto> pastDuesDto = null;
            List<PastDue> pastDues=await this._context.PastDues.ToListAsync();
            try
            {
                if(entryId!=null)
                {
                    pastDues = pastDues.Where(pastdue => pastdue.EntryId.ToString().Contains(entryId.ToString())).ToList();
                }
                if (invoiceId != null)
                {
                    pastDues = pastDues.Where(pastdue => pastdue.InvoiceID.ToString().Contains(invoiceId.ToString())).ToList();
                }
                if (entryId != null)
                {
                    pastDues = pastDues.Where(pastdue => pastdue.AccountNo.ToString().Contains(accountNo.ToString())).ToList();
                }
                pastDuesDto = _mapper.Map<List<PastDueDto>>(pastDues);
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
                pastDue = await _context.PastDues.Where(pastDue => pastDue.EntryId == id).FirstAsync();
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