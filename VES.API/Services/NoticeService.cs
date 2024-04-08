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
        private readonly VESDbContext _noticeContext;
        private readonly IMapper _mapper;
        public NoticeService(VESDbContext noticeCotext, IMapper mapper) {
            _noticeContext = noticeCotext;
            _mapper = mapper;
        }
        public async Task<List<NoticeDto>> GetAllNotices(long? entryId, long? noticeId, long? accountNo)
        {
            List<NoticeDto> noticesDto=null;
            List<Notice> notices = await this._noticeContext.Notices.ToListAsync();

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
                noticesDto = _mapper.Map<List<NoticeDto>>(notices);
            }
            catch (Exception ex)
            {
                throw;
            }
            return noticesDto;
        }

        public bool UpdateNotice(int id, JsonPatchDocument noticeModel)
        {
            return true;
        }
    }
}
