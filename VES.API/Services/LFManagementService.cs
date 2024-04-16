using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.EntityFrameworkCore;
using VES.API.Data;
using VES.API.Models.Domain;
using VES.API.Models.DTO;
using VES.API.Types.Interfaces;

namespace VES.API.Services
{
    public class LFManagementService : ILFManagementService
    {
        private readonly VESDbContext _context;
        private readonly IMapper _mapper;

        public LFManagementService(VESDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }



        public async Task<List<LFManagementDto>> GetAllLF(long Id,long AccountNo)
        {
            List<LFManagementDto> lfDto = null;
            List<LFManagement> lf = await this._context.LFManagement.ToListAsync();

            try
            {
                if (Id != null)
                {
                    lf = lf.Where(notice => notice.Id.ToString().Contains(Id.ToString())).ToList();

                }

                if (AccountNo != null)
                {
                    lf = lf.Where(notice => notice.AccountNo.ToString().Contains(AccountNo.ToString())).ToList();

                }
                lfDto = _mapper.Map<List<LFManagementDto>>(lf);
            }
            catch (Exception ex)
            {
                throw;
            }
            return lfDto;
        }

        public async Task<bool> UpdateLF(int Id, JsonPatchDocument lfModel)
        {
            LFManagement lf = null;
            try
            {
                lf = await _context.LFManagement.Where(lf => lf.Id == Id).FirstAsync();
                if (lf != null)
                {
                    lfModel.ApplyTo(lf);
                    await this._context.SaveChangesAsync();

                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return lf == null ? false : true;
        }

    }
}
