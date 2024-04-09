using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using VES.API.Data;
using VES.API.Models.Domain;
using VES.API.Models.DTO;

namespace VES.API.Types.Interfaces
{
    public interface INoticeService
    {
        public Task<List<NoticeDto>> GetAllNotices(long? entryId, long? noticeId, long? accountNo);
        public Task<bool> UpdateNotice(int id, JsonPatchDocument noticeModel);
    }
}
