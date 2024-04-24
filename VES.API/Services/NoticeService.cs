using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.EntityFrameworkCore;
using VES.API.Data;
using VES.API.Models.Domain;
using VES.API.Models.DTO;
using VES.API.Types.Interfaces;

namespace VES.API.Services
{
    public class NoticeService : INoticeService
    {
        private readonly VESDbContext _context;
        private readonly IMapper _mapper;
        public NoticeService(VESDbContext context, IMapper mapper) {
            _context = context;
            _mapper = mapper;
        }
        public async Task<List<NoticeDTO>> GetAllNotices(long? entryId, long? noticeId, long? accountNo)
        {
            List<NoticeDTO> noticesDto=null;
            List<Notice> notices = await this._context.Notices.ToListAsync();

            try
            {
                if (entryId != null)
                {
                    notices = notices.Where(notice => notice.entryId.ToString().Contains(entryId.ToString())).ToList();
                   
                }
                if (noticeId != null)
                {
                    notices = notices.Where(notice => notice.noticeId.ToString().Contains(noticeId.ToString())).ToList();
                    
                }
                if(accountNo!=null)
                {
                    notices = notices.Where(notice => notice.accountNo.ToString().Contains(accountNo.ToString())).ToList();
                    
                }
                noticesDto = _mapper.Map<List<NoticeDTO>>(notices);
            }
            catch (Exception ex)
            {
                throw;
            }
            return noticesDto;
        }

        public async Task<bool> UpdateNotice(int id, JsonPatchDocument noticeModel)
        {
            Notice notice = null;
            try
            {
                notice = await _context.Notices.Where(notice => notice.entryId == id).FirstAsync();
                if (notice!=null)
                {
                    noticeModel.ApplyTo(notice);
                    await this._context.SaveChangesAsync();
                    
                }
            }
            catch(Exception ex)
            {
                throw new Exception("Notice not found with given ID");
            }
            return notice!=null;   
        }
    }
}
